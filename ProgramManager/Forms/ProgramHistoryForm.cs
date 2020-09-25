
using ProgramManager.Managers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ProgramManager.Forms
{
    public partial class ProgramHistoryForm : Form
    {
        #region " Variables "

        public string _ProgramName = string.Empty;
        private string _FTPPath = string.Empty;
        private string _LocalPath = string.Empty;
        private string _DummyPath = string.Empty;

        #endregion " Variables End "

        #region " Create & Load & Shown "

        public ProgramHistoryForm()
        {
            InitializeComponent();

            this.Shown += ProgramHistoryForm_Shown;

            uiLv_Version.Click += UiLV_Version_Click;
            uiBtn_Restore.Click += UiBtn_Restore_Click;
        }

        private void ProgramHistoryForm_Shown(object sender, EventArgs e)
        {
            InitForm();

            InitVariables();

            GetVersionList();
        }

        #endregion " Create & Load Shown End "

        #region "  Methods "

        private void InitForm()
        {
            uiLab_ProgramName.Text = $" {_ProgramName} ";
        }

        private void InitVariables()
        {
            string ip = FileManager.GetValueString("FTP", "IP", "");
            string port = FileManager.GetValueString("FTP", "PORT", "");
            _FTPPath = FileManager.GetValueString("FTP", "PATH", "");
            _FTPPath = _FTPPath.Replace("{0}", ip);
            _FTPPath = _FTPPath.Replace("{1}", port);
            _FTPPath = Path.Combine(_FTPPath, $@"{_ProgramName}/");

            _LocalPath = FileManager.GetValueString("LOCAL", "DOWNLOAD_PATH", "");
            _LocalPath = Path.Combine(_LocalPath, $@"{_ProgramName}\");

            _DummyPath = Path.Combine(Application.StartupPath, @"dummy\");
        }

        private void GetVersionList()
        {
            List<string> versionList = FTPManager.Instance.GetFileList(_FTPPath);

            // ListView에 추가하기
            foreach (string version in versionList)
            {
                ListViewItem item = new ListViewItem(version);
                uiLv_Version.Items.Add(item);
            }
        }

        #endregion "  Methods End "

        #region " Events "

        void UiLV_Version_Click(object sender, EventArgs e)
        {
            if (uiLv_Version.SelectedItems.Count == 0)
                return;

            string version = uiLv_Version.SelectedItems[0].Text;
            string descFile = FileManager.GetValueString("ETC", "DESCRIPTION_FILE", "");

            string ftpFile = $@"{_FTPPath}{version}/{descFile}";
            string localFile = $@"{_DummyPath}{descFile}";

            if (FTPManager.Instance.DownLoad(localFile, ftpFile) == true)
            {
                if (File.Exists(localFile) == true)
                    uiRtb_Description.LoadFile(localFile, RichTextBoxStreamType.PlainText);
                else
                    uiRtb_Description.Clear();
            }
        }

        private void UiBtn_Restore_Click(object sender, EventArgs e)
        {
            if (uiLv_Version.SelectedItems.Count == 0)
            {
                MessageBox.Show("Pleaqse select one application verison.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                
            string version = uiLv_Version.SelectedItems[0].Text;
            string ftpPath = Path.Combine(_FTPPath, $@"{version}/");

            if (FTPManager.Instance.DownloadFolder(_LocalPath, ftpPath) == true)
            {
                MessageBox.Show("Restore complete.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        #endregion "Events End "
    }
}
