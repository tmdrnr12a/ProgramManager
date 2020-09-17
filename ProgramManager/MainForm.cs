using ProgramManager.Forms;
using ProgramManager.Managers;
using ProgramManager.Models;
using ProgramManager.Processor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ProgramManager
{
    public partial class MainForm : Form
    {
        #region " Variables "

        private List<ProgramData> pList = new List<ProgramData>();

        private BackgroundWorker mainWorker = new BackgroundWorker();

        private Point mCurrentPosition = new Point(0, 0);


        #endregion " Variables End "

        #region " Create & Load & Shown "

        public MainForm()
        {
            InitializeComponent();

            this.Shown += MainForm_Shown;

            this.mainWorker.DoWork += MainWorker_DoWork;
            this.mainWorker.RunWorkerCompleted += MainWorker_RunWorkerCompleted;

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

            this.mainWorker.RunWorkerAsync();
        }

        #endregion " Create & Load Shown End "

        #region "  Methods "

        private void InitForm()
        {
            SetVersion();
            SetUserInfo();
            SetButtonDesign();

            InitAppInfo();
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

        private void InitAppInfo()
        {
            uiLab_AppName.Text = string.Empty;
            uiLab_AppCurVersion.Text = string.Empty;
            uiLab_AppNewVersion.Text = string.Empty;

            uiRtb_Description.Text = string.Empty;

            uiBtn_History.Enabled = false;
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

        public void RefreshForm()
        {
            SetProgramDataList();

            SetListViewData();

            InitAppInfo();

            ClearListView();

            UpdateUI();
        }

        private void SetProgramDataList()
        {
            this.pList = DatabaseProcessor.Instance.GetProgramData();
        }

        private void SetListViewData()
        {
            SetInstallData();
            SetUpdateData();
            SetDownloadData();
        }

        private void SetInstallData()
        {

        }

        private void SetUpdateData()
        {

        }

        private void SetDownloadData()
        {

        }

        private void ClearListView()
        {
            uiLv_Installed.Clear();
            //imgList_Installed.Images.Clear();
            //l_InstalledAppInfo.Clear();

            uiLv_Update.Clear();
            //imgList_Update.Images.Clear();
            //l_UpdateAppInfo.Clear();

            uiLv_Download.Clear();
            //imgList_NotInstalled.Images.Clear();
            //l_NotInstalledAppInfo.Clear();
        }

        private void UpdateUI()
        {

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
            RefreshForm();
        }

        private void UiPnl_Title_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mCurrentPosition = new Point(-e.X, -e.Y);
        }

        private void UiPnl_Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point
                (
                    this.Location.X + (mCurrentPosition.X + e.X),
                    this.Location.Y + (mCurrentPosition.Y + e.Y)
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