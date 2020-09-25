namespace ProgramManager.Forms
{
    partial class ChangePasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiLab_UserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiTxt_CurrentPassword = new System.Windows.Forms.TextBox();
            this.uiTxt_ChangePassword = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.uiBtn_Save = new ProgramManager.Controls.ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.panel1.Location = new System.Drawing.Point(20, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 1);
            this.panel1.TabIndex = 13;
            // 
            // uiLab_UserID
            // 
            this.uiLab_UserID.AutoSize = true;
            this.uiLab_UserID.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.uiLab_UserID.ForeColor = System.Drawing.Color.Black;
            this.uiLab_UserID.Location = new System.Drawing.Point(38, 16);
            this.uiLab_UserID.Name = "uiLab_UserID";
            this.uiLab_UserID.Size = new System.Drawing.Size(32, 14);
            this.uiLab_UserID.TabIndex = 14;
            this.uiLab_UserID.Text = "{0}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "Current Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "Change Password";
            // 
            // uiTxt_CurrentPassword
            // 
            this.uiTxt_CurrentPassword.Location = new System.Drawing.Point(141, 45);
            this.uiTxt_CurrentPassword.Name = "uiTxt_CurrentPassword";
            this.uiTxt_CurrentPassword.PasswordChar = '*';
            this.uiTxt_CurrentPassword.Size = new System.Drawing.Size(100, 21);
            this.uiTxt_CurrentPassword.TabIndex = 17;
            // 
            // uiTxt_ChangePassword
            // 
            this.uiTxt_ChangePassword.Location = new System.Drawing.Point(141, 77);
            this.uiTxt_ChangePassword.MaxLength = 16;
            this.uiTxt_ChangePassword.Name = "uiTxt_ChangePassword";
            this.uiTxt_ChangePassword.PasswordChar = '*';
            this.uiTxt_ChangePassword.Size = new System.Drawing.Size(100, 21);
            this.uiTxt_ChangePassword.TabIndex = 18;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ProgramManager.Properties.Resources.RedPoint;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(23, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 12);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // uiBtn_Save
            // 
            this.uiBtn_Save.BackgroundImage = global::ProgramManager.Properties.Resources.SaveDefault;
            this.uiBtn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uiBtn_Save.Location = new System.Drawing.Point(246, 45);
            this.uiBtn_Save.Name = "uiBtn_Save";
            this.uiBtn_Save.Size = new System.Drawing.Size(106, 55);
            this.uiBtn_Save.TabIndex = 19;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(380, 117);
            this.Controls.Add(this.uiBtn_Save);
            this.Controls.Add(this.uiTxt_ChangePassword);
            this.Controls.Add(this.uiTxt_CurrentPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiLab_UserID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Password Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label uiLab_UserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiTxt_CurrentPassword;
        private System.Windows.Forms.TextBox uiTxt_ChangePassword;
        private Controls.ImageButton uiBtn_Save;
    }
}