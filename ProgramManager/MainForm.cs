using ProgramManager.Models;
using System;
using System.Windows.Forms;

namespace ProgramManager
{
    public partial class MainForm : Form
    {
        #region " Variables "

        #endregion " Variables End "

        #region " Create & Load & Shown "

        public MainForm()
        {
            InitializeComponent();

            this.Shown += MainForm_Shown;

            uiBtn_Program.Click += UiBtn_Program_Click;
            uiBtn_UserManagement.Click += UiBtn_UserManagement_Click;
            uiBtn_Config.Click += UiBtn_Config_Click;
            
            
            uiPic_Minimization.Click += UiPic_Minimization_Click;



            uiPic_Close.Click += UiPic_Close_Click;
        }             

        private void MainForm_Shown(object sender, EventArgs e)
        {
            InitForm();
        }

        #endregion " Create & Load Shown End "

        #region "  Methods "

        private void InitForm()
        {
            SetVersion();
            SetUserInfo();
        }

        private void SetVersion()
        {
            uiLab_Version.Text = ProgramManager.Etc.Version.BuildDate;
        }

        private void SetUserInfo()
        {
            uiLab_UserID.Text = User.ID;
            uiLab_UserName.Text = User.NAME;
            uiLab_UserDept.Text = User.DEPT;
            uiLab_UserType.Text = User.TYPE;
        }

        #endregion "  Methods End "

        #region " Events "

        private void UiBtn_Program_Click(object sender, EventArgs e)
        {

        }
        private void UiBtn_UserManagement_Click(object sender, EventArgs e)
        {

        }

        private void UiBtn_Config_Click(object sender, EventArgs e)
        {

        }

        private void UiPic_Minimization_Click(object sender, EventArgs e)
        {

        }

        private void UiPic_Close_Click(object sender, EventArgs e)
        {

        }

        #endregion "Events End "


    }
}



