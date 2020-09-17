using ProgramManager.Models;
using ProgramManager.Processor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramManager.Forms
{
    public partial class ChangePasswordForm : Form
    {
        #region " Variables "

        #endregion " Variables End "

        #region " Create & Load & Shown "

        public ChangePasswordForm()
        {
            InitializeComponent();

            this.Shown += ChangePasswordForm_Shown;

            uiBtn_Save.Click += UiBtn_Save_Click;
        }

        private void ChangePasswordForm_Shown(object sender, EventArgs e)
        {
            uiLab_UserID.Text = User.ID;
        }

        #endregion " Create & Load Shown End "

        #region "  Methods "

        #endregion "  Methods End "

        #region " Events "

        private void UiBtn_Save_Click(object sender, EventArgs e)
        {
            // 현재 PWD 와 변경할 PWD 의 값이 비어있는지 확인
            if (uiTxt_CurrentPassword.Text.Trim() == string.Empty || uiTxt_ChangePassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Current password or change password is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 현재 PWD 확인
            if (uiTxt_CurrentPassword.Text != User.PWD)
            {
                MessageBox.Show("Current password is wrong.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 현재 PWD 와 변경할 PWD 의 값이 같은지 확인
            if (uiTxt_CurrentPassword.Text == uiTxt_ChangePassword.Text)
            {
                MessageBox.Show("Password to change equals current password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DatabaseProcessor.Instance.UpdatePassword(uiTxt_ChangePassword.Text, uiLab_UserID.Text) == true)
                this.Close();
        }

        #endregion "Events End "
    }
}