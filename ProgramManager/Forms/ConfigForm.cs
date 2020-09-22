using ProgramManager.Managers;
using System;
using System.Windows.Forms;

namespace ProgramManager.Forms
{
    public partial class ConfigForm : Form
    {
        #region Variable

        #endregion Variable End

        #region Create & Load & Shown

        public ConfigForm()
        {
            InitializeComponent();

            this.Shown += ConfigForm_Shown;

            uiBtn_Save.Click += UiBtn_Save_Click;
            uiBtn_Close.Click += UiBtn_Close_Click;
        }

        /// <summary>
        /// Shown 화면이 처음 표시될 때 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>+
        private void ConfigForm_Shown(object sender, EventArgs e)
        {
            LoadValue();
        }

        #endregion Create & Load & Shown End

        #region Method

        /// <summary>
        /// 화면의 정보를 파일에 업데이트하는 메서드
        /// </summary>
        private void UpdateValue()
        {
            FileManager.SetValue("DATABASE", "IP", uiTxt_DB_IP.Text);
            FileManager.SetValue("DATABASE", "PORT", uiTxt_DB_Port.Text);
            FileManager.SetValue("DATABASE", "USER", uiTxt_DB_User.Text);
            FileManager.SetValue("DATABASE", "PWD", uiTxt_DB_PWD.Text);
            FileManager.SetValue("DATABASE", "DB_NAME", uiTxt_DB_Name.Text);

            FileManager.SetValue("FTP", "IP", uiTxt_FTP_IP.Text);
            FileManager.SetValue("FTP", "PORT", uiTxt_FTP_Port.Text);
            FileManager.SetValue("FTP", "USER", uiTxt_FTP_User.Text);
            FileManager.SetValue("FTP", "PWD", uiTxt_FTP_PWD.Text);
            FileManager.SetValue("FTP", "PATH", uiTxt_FTP_Path.Text);

            FileManager.SetValue("LOCAL", "DOWNLOAD_PATH", uiTxt_Local_Path.Text);

            FileManager.SetValue("ETC", "REFRESH_TIME", uiNum_Etc_RefreshTime.Text);
            FileManager.SetValue("ETC", "DESCRIPTION_FILE", uiTxt_Etc_Description.Text);
        }

        /// <summary>
        /// 파일의 값들을 읽어서 화면에 보여주는 메서드
        /// </summary>
        private void LoadValue()
        {
            uiTxt_DB_IP.Text = FileManager.GetValueString("DATABASE", "IP", "");
            uiTxt_DB_Port.Text = FileManager.GetValueString("DATABASE", "PORT", "");
            uiTxt_DB_User.Text = FileManager.GetValueString("DATABASE", "USER", "");
            uiTxt_DB_PWD.Text = FileManager.GetValueString("DATABASE", "PWD", "");
            uiTxt_DB_Name.Text = FileManager.GetValueString("DATABASE", "DB_NAME", "");

            uiTxt_FTP_IP.Text = FileManager.GetValueString("FTP", "IP", "");
            uiTxt_FTP_Port.Text = FileManager.GetValueString("FTP", "PORT", "");
            uiTxt_FTP_User.Text = FileManager.GetValueString("FTP", "USER", "");
            uiTxt_FTP_PWD.Text = FileManager.GetValueString("FTP", "PWD", "");
            uiTxt_FTP_Path.Text = FileManager.GetValueString("FTP", "PATH", "");

            uiTxt_Local_Path.Text = FileManager.GetValueString("LOCAL", "DOWNLOAD_PATH", "");

            uiNum_Etc_RefreshTime.Text = FileManager.GetValueString("ETC", "REFRESH_TIME", "");
            uiTxt_Etc_Description.Text = FileManager.GetValueString("ETC", "DESCRIPTION_FILE", "");
        }

        #endregion Method End

        #region Event

        /// <summary>
        /// Save 버튼 클릭시, 실행되는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiBtn_Save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("저장하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                UpdateValue();
                LoadValue();

                MessageBox.Show("저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        /// <summary>
        /// Close 버튼 클릭시, 실행되는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UiBtn_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("설정화면을 종료하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                this.Close();
        }

        #endregion Event End
    }
}
