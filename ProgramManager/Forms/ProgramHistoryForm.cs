
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProgramManager.Forms
{
    public partial class ProgramHistoryForm : Form
    {
        #region " Variables "

        MainForm frm = null;

        private string backupPath = @"TMS_APP/{0}/{1}/backup";
        private string PR_NAME = "";
        private string dummyPath = @"C:\Winforsys\dummy\PROGRAM\FILE";

        #endregion " Variables End "

        #region " Create & Load & Shown "

        public ProgramHistoryForm(MainForm frm, string PR_NAME)
        {
            InitializeComponent();

            this.frm = frm;
            this.PR_NAME = PR_NAME;
            lbl_ProgramName.Text = String.Format(" {0} ", PR_NAME);

            backupPath = backupPath.Replace("{0}", Function.DEPT.ToString());
            backupPath = backupPath.Replace("{1}", PR_NAME);

            this.Load += UpdateHistory_Load;
            lv_Version.Click += lv_Version_Click;

            pnl_Restore.MouseDown += pnl_Restore_MouseDown;
            pnl_Restore.MouseUp += pnl_Restore_MouseUp;
            pnl_Restore.Click += btn_Restore_Click;
        }

        void UpdateHistory_Load(object sender, EventArgs e)
        {
            GetVersionList(backupPath);
        }


        #endregion " Create & Load Shown End "

        #region "  Methods "

        private void GetVersionList(string backupPath)
        {
            // 해당 FTP 경로로 들어가서 Version List 읽어오기 
            string ftpUser = XmlManager.GetValue("FTP_APP", "USER");
            string ftpPWD = XmlManager.GetValue("FTP_APP", "PWD");

            List<string> versionList = Function.GetVersionList(backupPath);

            // ListView에 추가하기
            foreach (string version in versionList)
            {
                ListViewItem item = new ListViewItem(version);
                lv_Version.Items.Add(item);
            }
        }

        private void SetDescription(string version)
        {
            string rtfPath = GetFTPDescription(PR_NAME + @"\backup\" + version + @"\" + frm.descFile, version);

            if (System.IO.File.Exists(rtfPath) == true)
                rtb_Description.LoadFile(rtfPath, RichTextBoxStreamType.PlainText);
            else
                rtb_Description.Clear();
        }

        private string GetFTPDescription(string fileName, string version)
        {
            string path = "";

            try
            {
                string program = fileName.Substring(0, fileName.LastIndexOf('\\'));
                string file = fileName.Substring(fileName.LastIndexOf('\\') + 1);

                string tmpPath = dummyPath;
                tmpPath = tmpPath.Replace("PROGRAM", program);
                tmpPath = tmpPath.Replace("FILE", file);

                bool same = Function.CompareModifyTime(tmpPath, fileName);

                // 다르면 로컬에 다운받기
                if (same == false)
                {
                    if (FTPManager.Instance.DownLoad(tmpPath, fileName) == true)
                    {
                        if (System.IO.File.Exists(tmpPath) == true)
                            path = tmpPath;
                    }
                }
                // 같으면 로컬 파일의 정보 읽기
                else
                    path = tmpPath;
            }
            catch { }

            return path;
        }

        #endregion "  Methods End "

        #region " Events "

        void lv_Version_Click(object sender, EventArgs e)
        {
            if (lv_Version.SelectedItems.Count == 0)
                return;

            string selectedVersion = lv_Version.SelectedItems[0].Text;
            SetDescription(selectedVersion);
        }

        void btn_Restore_Click(object sender, EventArgs e)
        {
            if (lv_Version.SelectedIndices.Count != 0)
            {
                if (frm.CheckExecuting(PR_NAME) == true)
                    return;

                this.Cursor = Cursors.WaitCursor;

                LoadingProcessor.Start(this);
                LoadingProcessor.SetDescription("Program restore is in progress...");

                string selectedVersion = lv_Version.SelectedItems[0].Text;
                string localFolder = frm.localPath + @"\" + PR_NAME;

                bool result = Function.Download(localFolder, backupPath + @"\" + selectedVersion);

                LoadingProcessor.End();

                if (result == true)
                {
                    frm.FormRefreshThread();

                    MessageBox.Show("Restore Completed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to restore.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.Cursor = Cursors.Default;
            }
            else
            {
                MessageBox.Show("Please Select One Application Verison.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void pnl_Restore_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                pnl_Restore.BackgroundImage = TMS_Manager.Properties.Resources.btnRestoreDefault;
            }
            catch { }
        }

        void pnl_Restore_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                pnl_Restore.BackgroundImage = TMS_Manager.Properties.Resources.btnRestoreSelected;
            }
            catch { }
        }

        #endregion "Events End "
    }
}
