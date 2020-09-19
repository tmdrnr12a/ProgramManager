using ProgramManager.Forms;
using ProgramManager.Managers;
using ProgramManager.Models;
using ProgramManager.Processor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ProgramManager
{
    public partial class MainForm : Form
    {
        #region " Variables "

        private List<ProgramData> _ProgramList = null;

        private BackgroundWorker _MainWorker = null;

        private BackgroundWorker _RefreshWorker = null;

        private Point _CurrentPosition = new Point(0, 0);


        #endregion " Variables End "

        #region " Create & Load & Shown "

        public MainForm()
        {
            InitializeComponent();

            InitVariables();

            this.Shown += MainForm_Shown;

            _MainWorker.DoWork += MainWorker_DoWork;
            _MainWorker.RunWorkerCompleted += MainWorker_RunWorkerCompleted;

            _RefreshWorker.DoWork += RefreshWorker_DoWork;

            uiPnl_Title.MouseDown += UiPnl_Title_MouseDown;
            uiPnl_Title.MouseMove += UiPnl_Title_MouseMove;

            uiBtn_Minimization.Click += UiBtn_Minimization_Click;
            uiBtn_Close.Click += UiBtn_Close_Click;

            uiBtn_Program.Click += UiBtn_Program_Click;
            uiBtn_UserManagement.Click += UiBtn_UserManagement_Click;
            uiBtn_Config.Click += UiBtn_Config_Click;

            uiLv_Install.MouseClick += UiLv_Install_MouseClick;

            uiLv_Install.DoubleClick += UiLv_Install_DoubleClick;
            uiLv_Update.DoubleClick += UiLv_Update_DoubleClick;
            uiLv_Download.DoubleClick += UiLv_Download_DoubleClick;

            uiBtn_History.Click += UiBtn_History_Click;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            InitForm();

            _MainWorker.RunWorkerAsync();
        }

        #endregion " Create & Load Shown End "

        #region "  Methods "

        private void InitVariables()
        {
            _ProgramList = new List<ProgramData>();
            _MainWorker = new BackgroundWorker();
            _RefreshWorker = new BackgroundWorker();
        }

        private void InitForm()
        {
            SetVersion();
            SetUserInfo();
            SetButtonDesign();
        }

        private void SetVersion()
        {
            uiLab_Version.Text = Etc.Version.BuildDate;
        }

        private void SetUserInfo()
        {
            uiLab_UserID.Text = User.ID;
            uiLab_UserName.Text = User.NAME;
            uiLab_UserDept.Text = User.DEPT;
            uiLab_UserType.Text = User.TYPE;
        }

        private void SetButtonDesign()
        {
            // Minimization Button
            uiBtn_Minimization.IMAGE_DEFAULT = Properties.Resources.MinimizationButtonDefault;
            uiBtn_Minimization.IMAGE_FOCUS = Properties.Resources.MinimizationButtonFocus;
            uiBtn_Minimization.IMAGE_CLICK = Properties.Resources.MinimizationButtonClick;

            // Close Button
            uiBtn_Close.IMAGE_DEFAULT = Properties.Resources.CloseButtonDefault;
            uiBtn_Close.IMAGE_FOCUS = Properties.Resources.CloseButtonFocus;
            uiBtn_Close.IMAGE_CLICK = Properties.Resources.CloseButtonClick2;

            // Program Button
            //uiBtn_Program.IMAGE_DEFAULT = Properties.Resources;
            //uiBtn_Program.IMAGE_FOCUS = Properties.Resources;
            //uiBtn_Program.IMAGE_CLICK = Properties.Resources;

            // UserManagement or Password Button
            //uiBtn_UserManagement.IMAGE_DEFAULT = Properties.Resources;
            //uiBtn_UserManagement.IMAGE_FOCUS = Properties.Resources;
            //uiBtn_UserManagement.IMAGE_CLICK = Properties.Resources;

            // Config Button
            //uiBtn_Config.IMAGE_DEFAULT = Properties.Resources;
            //uiBtn_Config.IMAGE_FOCUS = Properties.Resources;
            //uiBtn_Config.IMAGE_CLICK = Properties.Resources;
        }

        private bool ConnectToFTP()
        {
            string ip = FileManager.GetValueString("FTP", "IP", "");
            string port = FileManager.GetValueString("FTP", "PORT", "");
            string user = FileManager.GetValueString("FTP", "USER", "");
            string pwd = FileManager.GetValueString("FTP", "PWD", "");

            bool result = FTPManager.Instance.ConnectToServer(ip, port, user, pwd);

            if (result == false)
            {
                Exception ex = FTPManager.Instance.LastException;

                string msg = $"Can not connect FTP Server. \n{ex.Message}";
                MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return result;
        }

        private void RefreshForm()
        {
            InitAppInfo();

            ClearListView();

            GetProgramDataList();

            SetProgramDataList();

            ShowListViewData();

            UpdateUI();
        }

        private void InitAppInfo()
        {
            uiTlp_App.Invoke(new MethodInvoker(delegate ()
            {
                uiLab_AppName.Text = string.Empty;
                uiLab_AppCurVersion.Text = string.Empty;
                uiLab_AppNewVersion.Text = string.Empty;

                uiBtn_History.Enabled = false;

                uiRtb_Description.Text = string.Empty;
            }));
        }
        private void ClearListView()
        {
            uiTlp_App.Invoke(new MethodInvoker(delegate ()
            {
                uiLv_Install.Clear();
                uiLv_Update.Clear();
                uiLv_Download.Clear();

                uiImageList_Install.Images.Clear();
                uiImageList_Update.Images.Clear();
                uiImageList_Download.Images.Clear();
            }));
        }

        private void GetProgramDataList()
        {
            _ProgramList = DatabaseProcessor.Instance.GetProgramData();
        }

        private void SetProgramDataList()
        {
            string localPath = FileManager.GetValueString("LOCAL", "DOWNLOAD_PATH", "");
            string ftpPath = GetFTPPath();

            SetInstallData(localPath);
            SetNewVersionData(ftpPath);
        }

        private string GetFTPPath()
        {
            string ftpPath = FileManager.GetValueString("FTP", "PATH", "");
            string ip = FileManager.GetValueString("FTP", "IP", "");
            string port = FileManager.GetValueString("FTP", "PORT", "");
            ftpPath = ftpPath.Replace("{0}", ip);
            ftpPath = ftpPath.Replace("{1}", port);

            return ftpPath;
        }

        private void SetInstallData(string localPath)
        {
            if (localPath == string.Empty)
            {
                MessageBox.Show("LocalPath does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Directory.Exists(localPath) == false)
            {
                Directory.CreateDirectory(localPath);
                return;
            }

            string[] installPrograms = Directory.GetDirectories(localPath);

            if (installPrograms.Length == 0)
                return;

            for (int i = 0; i < installPrograms.Length; i++)
            {
                for (int k = 0; k < _ProgramList.Count; k++)
                {
                    string program = installPrograms[i].Substring(installPrograms[i].LastIndexOf(@"\") + 1);

                    // 설치되어 있는 목록 확인
                    if (program != _ProgramList[k].PR_NAME)
                        continue;

                    _ProgramList[k].INSTALLED = true;
                    _ProgramList[k].CUR_VER = GetLocalFileVersion($"{installPrograms[i]}\\{_ProgramList[k].PR_FILE}");

                    break;
                }
            }
        }

        private string GetLocalFileVersion(string fileName)
        {
            string version = string.Empty;

            if (File.Exists(fileName) == true)
            {
                FileVersionInfo fv = FileVersionInfo.GetVersionInfo(fileName);
                version = fv.FileVersion;
            }
            return version;
        }

        private void SetNewVersionData(string ftpPath)
        {
            List<string> updatePrograms = FTPManager.Instance.GetFileList(ftpPath);

            for (int i = 0; i < updatePrograms.Count; i++)
            {
                for (int k = 0; k < _ProgramList.Count; k++)
                {
                    if (_ProgramList[k].INSTALLED == false)
                        continue;

                    if (updatePrograms[i] != _ProgramList[k].PR_NAME)
                        continue;

                    _ProgramList[k].NEW_VER = GetNewFileVersion(_ProgramList[k].PR_PATH);

                    break;
                }
            }
        }

        private string GetNewFileVersion(string ftpFilePath)
        {
            string newVersion = string.Empty;

            List<string> list = FTPManager.Instance.GetFileList(ftpFilePath);

            if (list.Count > 0)
                newVersion = list[list.Count - 1];

            return newVersion;
        }

        private void ShowListViewData()
        {
            foreach (ProgramData pd in _ProgramList)
            {
                if (pd.INSTALLED == true)
                {
                    AddListViewImage(uiImageList_Install, pd.PR_ICON);
                    AddListViewItem(uiLv_Install, pd.PR_NAME, uiImageList_Install.Images.Count - 1);
                    SetImageList(uiLv_Install, uiImageList_Install);
                }

                if (pd.INSTALLED == true && pd.CUR_VER != pd.NEW_VER)
                {
                    AddListViewImage(uiImageList_Update, pd.PR_ICON);
                    AddListViewItem(uiLv_Update, pd.PR_NAME, uiImageList_Update.Images.Count - 1);
                    SetImageList(uiLv_Update, uiImageList_Update);
                }

                if (pd.INSTALLED == false)
                {
                    AddListViewImage(uiImageList_Download, pd.PR_ICON);
                    AddListViewItem(uiLv_Download, pd.PR_NAME, uiImageList_Download.Images.Count - 1);
                    SetImageList(uiLv_Download, uiImageList_Download);
                }
            }
        }

        private void AddListViewImage(ImageList imgList, Image img)
        {
            imgList.Images.Add(img);
        }

        private void AddListViewItem(ListView listView, string programName, int idx)
        {
            ListViewItem item = new ListViewItem(programName, idx);
            listView.Invoke(new MethodInvoker(delegate ()
            {
                listView.Items.Add(item);
            }));
        }

        private void SetImageList(ListView listView, ImageList imgList)
        {
            listView.Invoke(new MethodInvoker(delegate ()
            {
                listView.LargeImageList = imgList;
            }));
        }

        private void UpdateUI()
        {
            uiTlp_App.Invoke(new MethodInvoker(delegate ()
            {
                uiTlp_App.Refresh();
            }));
        }

        private bool CheckExecuting(string programName)
        {
            bool result = false;

            var exeFiles = _ProgramList.Where(r => r.PR_NAME == programName).Select(x => x.PR_FILE).ToList();
            string exeFile = (exeFiles.Count() > 0) ? exeFiles[0] : string.Empty;

            if (exeFile == string.Empty)
            {
                MessageBox.Show("EXE file is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result;
            }

            Process[] arrProcess = Process.GetProcesses();
            var executingProcess = arrProcess.Where(r => r.ProcessName == exeFile).Select(x => x.ProcessName).ToList();

            if (executingProcess.Count() > 0)
            {
                result = true;

                string msgTxt = $"'{programName}' is already executing. \nPlease close '{programName}' and retry.";
                MessageBox.Show(msgTxt, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        private void DeleteProgram(string programName)
        {
            string localPath = FileManager.GetValueString("LOCAL", "DOWNLOAD_PATH", "");
            string deletePath = Path.Combine(localPath, programName);

            if (Directory.Exists(deletePath) == true)
            {
                Directory.Delete(deletePath, true);
                MessageBox.Show("Delete complete.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            RefreshForm();
        }

        private ProgramData GetProgramData(string programName)
        {
            ProgramData pd = new ProgramData();

            var list = _ProgramList.Where(r => r.PR_NAME == programName).Select(x => x).ToList();

            if (list.Count() > 0)
                pd = (ProgramData)list[0];

            return pd;
        }

        #endregion "  Methods End "

        #region " Events "

        private void MainWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                // FTP 연결 시도
                if (ConnectToFTP() == true)
                    break;

                Thread.Sleep(1000);
            }
        }

        private void MainWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _RefreshWorker.RunWorkerAsync();
        }

        private void RefreshWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            RefreshForm();
        }

        private void UiPnl_Title_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _CurrentPosition = new Point(-e.X, -e.Y);
        }

        private void UiPnl_Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point
                (
                    this.Location.X + (_CurrentPosition.X + e.X),
                    this.Location.Y + (_CurrentPosition.Y + e.Y)
                );
            }
        }

        private void UiBtn_Minimization_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UiBtn_Close_Click(object sender, EventArgs e)
        {
            string msg = "Do you want to close program?";
            if (MessageBox.Show(msg, "Inform", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                // 스레드들 종료해야 함!!

                this.Close();
            }
        }
        private void UiBtn_Program_Click(object sender, EventArgs e)
        {
            ProgramForm frm = new ProgramForm();
            frm.ShowDialog();
        }

        private void UiBtn_UserManagement_Click(object sender, EventArgs e)
        {
            UserManagementForm frm = new UserManagementForm();
            frm.ShowDialog();
        }

        private void UiBtn_Config_Click(object sender, EventArgs e)
        {
            ConfigForm frm = new ConfigForm();
            frm.ShowDialog();
        }

        private void UiBtn_History_Click(object sender, EventArgs e)
        {
            ProgramHistoryForm frm = new ProgramHistoryForm();
            frm.ShowDialog();
        }

        private void UiLv_Install_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Right))
            {
                ContextMenuStrip menu = new ContextMenuStrip();

                ToolStripMenuItem item01 = new ToolStripMenuItem("Delete Program");
                item01.Click -= Delete_Click;
                item01.Click += Delete_Click;

                ToolStripMenuItem item02 = new ToolStripMenuItem("Installed Path");
                //item02.Click -= SelectedPath_Click;
                //item02.Click += SelectedPath_Click;

                menu.Items.Add(item01);

                if (User.TYPE == "Administrator")
                    menu.Items.Add(item02);

                menu.Show(MousePosition);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (uiLv_Install.SelectedItems.Count == 0)
                return;

            string programName = uiLv_Install.SelectedItems[0].Text;

            if (CheckExecuting(programName) == true)
                return;

            DeleteProgram(programName);
        }

        private void UiLv_Install_DoubleClick(object sender, EventArgs e)
        {
            ListView listView = sender as ListView;

            if (listView.SelectedItems.Count == 0)
                return;

            string programName = listView.SelectedItems[0].Text;
            ProgramData pd = GetProgramData(programName);

            if (pd.CUR_VER != pd.NEW_VER)
            {
                string msg = $"Do you want to update new version program?\n[{programName}] {pd.CUR_VER} -> {pd.NEW_VER}";
                if (MessageBox.Show(msg, "Inform", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    UiLv_Update_DoubleClick(listView, null);
                    return;
                }
            }

            this.Cursor = Cursors.WaitCursor;

            //string exeName = "";
            //for (int i = 0; i < l_PD.Count; i++)
            //{
            //    if (l_PD[i].PR_NAME == selectedItemName)
            //    {
            //        exeName = l_PD[i].PR_FULL_PATH.Substring(l_PD[i].PR_FULL_PATH.LastIndexOf(@"\") + 1).Replace(".exe", "");
            //        break;
            //    }
            //}
            //string fileName = localPath + @"\" + selectedItemName + @"\" + exeName;

            //string exeFile = "";

            //// 링크파일 생성
            //string excutableFile = GetLinkFile(fileName);

            //// 링크경로로 프로그램 실행
            //StartProgram(excutableFile);

            this.Cursor = Cursors.Default;

        }

        private void UiLv_Update_DoubleClick(object sender, EventArgs e)
        {

        }

        private void UiLv_Download_DoubleClick(object sender, EventArgs e)
        {

        }

        #endregion "Events End "
    }
}