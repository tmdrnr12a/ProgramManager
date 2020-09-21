using ProgramManager.Etc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Managers
{
    public class FTPManager : Singleton<FTPManager>
    {
        #region " Variables "

        public event ExceptionEventHandler ExceptionEvent;
        public Exception LastException = null;

        public bool IsConnected { get; set; }

        private string ip = string.Empty;
        private string port = string.Empty;
        private string user = string.Empty;
        private string pwd = string.Empty;

        #endregion " Variables End "

        #region " Create & Load & Shown "

        #endregion " Create & Load Shown End "

        #region "  Methods "

        public bool ConnectToServer(string ip, string port, string user, string pwd)
        {
            this.IsConnected = false;

            this.ip = ip;
            this.port = port;
            this.user = user;
            this.pwd = pwd;

            string url = string.Format(@"FTP://{0}:{1}/", this.ip, this.port);

            try
            {
                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(url);
                ftpRequest.Credentials = new NetworkCredential(user, pwd);
                ftpRequest.KeepAlive = false;
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                ftpRequest.UsePassive = false;

                using (ftpRequest.GetResponse())
                {

                }

                this.IsConnected = true;
            }
            catch (Exception ex)
            {
                this.LastException = ex;

                System.Reflection.MemberInfo info = System.Reflection.MethodInfo.GetCurrentMethod();
                string id = string.Format("{0}.{1}", info.ReflectedType.Name, info.Name);

                this.ExceptionEvent?.Invoke(id, ex);

                return false;
            }

            return true;
        }

        public bool DownloadFolder(string localFolder, string serverFolder)
        {
            bool result = true;

            StreamReader reader = null;
            Stream responseStream = null;
            FtpWebResponse response = null;

            try
            {
                string url = serverFolder;
                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(url);
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                ftpRequest.Credentials = new NetworkCredential(user, pwd);
                response = (FtpWebResponse)ftpRequest.GetResponse();
                responseStream = response.GetResponseStream();
                reader = new StreamReader(responseStream);
                string tmp = reader.ReadToEnd();
                string[] items = tmp.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < items.Length; i++)
                {
                    // 디렉토리
                    if (items[i].Contains("<DIR>") == true)
                    {
                        string folderName = items[i].Split('>')[1].Trim();
                        string subLocalPath = $@"{localFolder}{folderName}";
                        string subServerPath = $@"{serverFolder}{folderName}";

                        // 재귀호출
                        bool result2 = DownloadFolder(subLocalPath, subServerPath);

                        // 서브 디렉토리 복사도 실패했을 경우
                        if (result2 == false)
                        {
                            result = false;
                            break;
                        }
                    }
                    // 파일
                    else
                    {
                        string fileName = GetFileName(items[i]);
                        string subLocalFile = $@"{localFolder}\{fileName}";
                        string subServerFile = $@"{serverFolder}/{fileName}";


                        int tryCnt = 0;
                        while (true)
                        {
                            if (FTPManager.Instance.DownLoad(subLocalFile, subServerFile) == true)
                                break;
                            else
                            {
                                System.Threading.Thread.Sleep(10);
                                tryCnt++;

                                // 10번 다운로드 재시도
                                if (tryCnt == 10)
                                {
                                    result = false;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                result = false;
            }
            finally
            {
                if (reader != null) reader.Close();
                if (responseStream != null) responseStream.Close();
                if (response != null) response.Close();
            }

            return result;
        }

        private string GetFileName(string item)
        {
            string[] tmps = item.Split(' ');
            string tmpFile = "";

            // 시간정보 제외하고 나머지 Merge
            int indexLastTime = 2;
            for (int i = indexLastTime + 1; i < tmps.Length; i++)
            {
                if (i == tmps.Length - 1)
                    tmpFile += tmps[i];
                else
                    tmpFile += tmps[i] + " ";
            }

            tmpFile = tmpFile.Trim();
            tmps = tmpFile.Split(' ');

            string fileName = "";

            // 파일 사이즈 제외하고 나머지 Merge
            int indexFileSize = 0;
            for (int i = indexFileSize + 1; i < tmps.Length; i++)
            {
                if (i == tmps.Length - 1)
                    fileName += tmps[i];
                else
                    fileName += tmps[i] + " ";
            }

            return fileName;
        }

        public bool DownLoad(string localFullPathFile, string serverFullPathFile)
        {
            return Download(localFullPathFile, serverFullPathFile);
        }

        public bool UpLoad(string folder, string filename)
        {
            return Upload(folder, filename);
        }

        public List<string> GetFileList(string serverFolder)
        {
            List<string> resultList = new List<string>();
            StringBuilder result = new StringBuilder();

            try
            {
                string url = serverFolder;
                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(url);
                ftpRequest.Credentials = new NetworkCredential(user, pwd);
                ftpRequest.KeepAlive = false;
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;

                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;

                using (WebResponse response = ftpRequest.GetResponse())
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());

                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        result.Append(line);
                        result.Append("\n");
                        line = reader.ReadLine();
                    }
                    result.Remove(result.ToString().LastIndexOf('\n'), 1);

                    if (reader != null) reader.Close();

                    foreach (string file in result.ToString().Split('\n'))
                    {
                        resultList.Add(file);
                    }
                }

                return resultList;
            }
            catch (Exception ex)
            {
                this.LastException = ex;

                System.Reflection.MemberInfo info = System.Reflection.MethodInfo.GetCurrentMethod();
                string id = string.Format("{0}.{1}", info.ReflectedType.Name, info.Name);

                this.ExceptionEvent?.Invoke(id, ex);

                return resultList;
            }
        }

        private bool Download(string localFullPathFile, string serverFullPathFile)
        {
            try
            {
                CheckDir(localFullPathFile);

                string url = serverFullPathFile;
                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(url);

                ftpRequest.Credentials = new NetworkCredential(user, pwd);
                ftpRequest.KeepAlive = false;
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;

                using (FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse())
                {
                    FileStream outputStream = new FileStream(localFullPathFile, FileMode.Create, FileAccess.Write);
                    Stream ftpStream = response.GetResponseStream();

                    int bufferSize = 2048;
                    int readCount;
                    byte[] buffer = new byte[bufferSize];

                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                    while (readCount > 0)
                    {
                        outputStream.Write(buffer, 0, readCount);
                        readCount = ftpStream.Read(buffer, 0, bufferSize);
                    }

                    ftpStream.Close();
                    outputStream.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                this.LastException = ex;

                if (serverFullPathFile.Contains(@"\ZOOM\") == true)
                    return false;

                System.Reflection.MemberInfo info = System.Reflection.MethodInfo.GetCurrentMethod();
                string id = string.Format("{0}.{1}", info.ReflectedType.Name, info.Name);

                this.ExceptionEvent?.Invoke(id, ex);

                return false;
            }
        }

        private bool Upload(string folder, string filename)
        {
            try
            {
                MakeDir(folder);

                FileInfo fileInf = new FileInfo(filename);

                folder = folder.Replace('\\', '/');
                filename = filename.Replace('\\', '/');

                string url = string.Format(@"FTP://{0}:{1}/{2}{3}", this.ip, this.port, folder, fileInf.Name);
                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(url);
                ftpRequest.Credentials = new NetworkCredential(user, pwd);
                ftpRequest.KeepAlive = false;
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;

                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
                ftpRequest.ContentLength = fileInf.Length;

                int buffLength = 2048;
                byte[] buff = new byte[buffLength];
                int contentLen;

                FileStream fs = fileInf.OpenRead();

                using (Stream strm = ftpRequest.GetRequestStream())
                {
                    contentLen = fs.Read(buff, 0, buffLength);

                    while (contentLen != 0)
                    {
                        strm.Write(buff, 0, contentLen);
                        contentLen = fs.Read(buff, 0, buffLength);
                    }
                }

                fs.Flush();
                fs.Close();
            }
            catch (Exception ex)
            {
                this.LastException = ex;

                System.Reflection.MemberInfo info = System.Reflection.MethodInfo.GetCurrentMethod();
                string id = string.Format("{0}.{1}", info.ReflectedType.Name, info.Name);

                this.ExceptionEvent?.Invoke(id, ex);

                return false;
            }

            return true;
        }

        private void MakeDir(string dirName)
        {
            string[] arrDir = dirName.Split('\\');
            string currentDir = string.Empty;

            try
            {
                foreach (string tmpFoler in arrDir)
                {
                    try
                    {
                        if (tmpFoler == string.Empty) continue;

                        currentDir += @"\" + tmpFoler;

                        string url = string.Format(@"FTP://{0}:{1}/{2}", this.ip, this.port, currentDir);
                        FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(url);
                        ftpRequest.Credentials = new NetworkCredential(user, pwd);

                        ftpRequest.Method = WebRequestMethods.Ftp.MakeDirectory;
                        ftpRequest.KeepAlive = false;
                        ftpRequest.UsePassive = true;

                        FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse();
                        response.Close();
                    }
                    catch { }
                }
            }
            catch (Exception ex)
            {
                this.LastException = ex;

                System.Reflection.MemberInfo info = System.Reflection.MethodInfo.GetCurrentMethod();
                string id = string.Format("{0}.{1}", info.ReflectedType.Name, info.Name);

                this.ExceptionEvent?.Invoke(id, ex);
            }
        }

        private void CheckDir(string localFullPathFile)
        {
            FileInfo fInfo = new FileInfo(localFullPathFile);

            if (!fInfo.Exists)
            {
                DirectoryInfo dInfo = new DirectoryInfo(fInfo.DirectoryName);
                if (!dInfo.Exists)
                {
                    dInfo.Create();
                }
            }
        }

        #endregion "  Methods End "

        #region " Events "

        #endregion "Events End "
    }
}
