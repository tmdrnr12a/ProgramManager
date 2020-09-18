using ProgramManager.Forms;
using ProgramManager.Managers;
using ProgramManager.Models;
using ProgramManager.Processor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ProgramManager
{
    public partial class MainForm : Form
    {
        #region " Variables "

        private List<ProgramData> _ProgramList = null;

        private BackgroundWorker _MainWorker = null;

        private Thread _MainThread = null;

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

            uiPnl_Title.MouseDown += UiPnl_Title_MouseDown;
            uiPnl_Title.MouseMove += UiPnl_Title_MouseMove;

            uiBtn_Minimization.Click += UiBtn_Minimization_Click;
            uiBtn_Close.Click += UiBtn_Close_Click;

            uiBtn_Program.Click += UiBtn_Program_Click;
            uiBtn_UserManagement.Click += UiBtn_UserManagement_Click;
            uiBtn_Config.Click += UiBtn_Config_Click;

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
            _MainThread = new Thread(new ThreadStart(RefreshForm));
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

            SetProgramDataList();

            SetListViewData();

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
            uiLv_Install.Clear();
            uiLv_Update.Clear();
            uiLv_Download.Clear();

            uiImageList_Install.Images.Clear();
            uiImageList_Update.Images.Clear();
            uiImageList_Download.Images.Clear();
        }

        private void SetProgramDataList()
        {
            _ProgramList = DatabaseProcessor.Instance.GetProgramData();
        }

        private void SetListViewData()
        {
            string localPath = FileManager.GetValueString("LOCAL", "DOWNLOAD_PATH", "");
            
            string ip = FileManager.GetValueString("FTP", "IP", "");
            string port = FileManager.GetValueString("FTP", "PORT", "");
            string tmpPath = FileManager.GetValueString("FTP", "PATH", "");
            tmpPath = tmpPath.Replace("{0}", ip);
            tmpPath = tmpPath.Replace("{1}", port);
            string ftpPath = tmpPath;

            SetInstallData(localPath);
            SetUpdateData(localPath, ftpPath);
            SetDownloadData();
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

                    uiImageList_Install.Images.Add(_ProgramList[k].PR_ICON);

                    ListViewItem item = new ListViewItem(_ProgramList[k].PR_NAME, uiImageList_Install.Images.Count - 1);
                    uiLv_Install.Items.Add(item);
                }
            }

            uiLv_Install.LargeImageList = uiImageList_Install;
        }

        private void SetUpdateData(string localPath, string ftpPath)
        {
            List<string> installPrograms = new List<string>(Directory.GetDirectories(localPath));
            List<string> updatePrograms = FTPManager.Instance.GetFileList(ftpPath);

            for (int i = 0; i < _ProgramList.Count; i++)
            {
                for (int k = 0; k < installPrograms.Count; k++)
                {
                    if (_ProgramList[i].PR_NAME == installPrograms[k])
                    {

                    }
                }

                for (int k = 0; k < updatePrograms.Count; k++)
                {
                    if (_ProgramList[i].PR_NAME == updatePrograms[k])
                    {

                    }
                }
            }
        }

        private void SetDownloadData()
        {

        }

        private string GetLocalFileVersion(string fileName)
        {
            string version = "";

            if (System.IO.File.Exists(fileName) == true)
            {
                System.Diagnostics.FileVersionInfo fv = System.Diagnostics.FileVersionInfo.GetVersionInfo(fileName);
                version = fv.FileVersion;
            }
            return version;
        }

        private void UpdateUI()
        {
            //this.Refresh();
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
            _MainThread.Start();
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

        #endregion "Events End "
    }
}