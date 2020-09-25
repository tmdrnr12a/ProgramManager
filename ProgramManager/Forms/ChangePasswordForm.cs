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

        public User _User = null;

        #endregion " Variables End "

        #region " Create & Load & Shown "

        public ChangePasswordForm(User user)
        {
            InitializeComponent();

            this.Shown += ChangePasswordForm_Shown;

            uiBtn_Save.Click += UiBtn_Save_Click;

            _User = user;
        }

        private void ChangePasswordForm_Shown(object sender, EventArgs e)
        {
            uiLab_UserID.Text = _User.ID;
        }

        #endregion " Create & Load Shown End "

        #region "  Methods "

        #endregion "  Methods End "

        #region " Events "

        private void UiBtn_Save_Click(object sender, EventArgs e)
        {
            string curPwd = uiTxt_CurrentPassword.Text;
            string changePwd = uiTxt_ChangePassword.Text;
            string userId = uiLab_UserID.Text;

            // 현재 PWD 와 변경할 PWD 의 값이 비어있는지 확인
            if (curPwd.Trim() == string.Empty || changePwd.Trim() == string.Empty)
            {
                MessageBox.Show("Current password or change password is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 현재 PWD 확인
            if (curPwd != _User.PWD)
            {
                MessageBox.Show("Current password is wrong.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 현재 PWD 와 변경할 PWD 의 값이 같은지 확인
            if (curPwd == changePwd)
            {
                MessageBox.Show("Password to change equals current password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DatabaseProcessor.Instance.UpdatePassword(curPwd, changePwd, userId) == changePwd)
            {
                _User.PWD = changePwd;
                this.Close();
            }
        }

        #endregion "Events End "
    }
}