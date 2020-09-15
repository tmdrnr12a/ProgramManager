namespace ProgramManager
{
    partial class LoginForm
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
            this.uiPnl_Main = new System.Windows.Forms.Panel();
            this.uiTxt_PWD = new System.Windows.Forms.TextBox();
            this.uiTxt_ID = new System.Windows.Forms.TextBox();
            this.uiBtn_Close = new System.Windows.Forms.Button();
            this.uiBtn_Login = new System.Windows.Forms.Panel();
            this.uiPnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPnl_Main
            // 
            this.uiPnl_Main.BackgroundImage = global::ProgramManager.Properties.Resources.LoginForm;
            this.uiPnl_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiPnl_Main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uiPnl_Main.Controls.Add(this.uiTxt_PWD);
            this.uiPnl_Main.Controls.Add(this.uiTxt_ID);
            this.uiPnl_Main.Controls.Add(this.uiBtn_Close);
            this.uiPnl_Main.Controls.Add(this.uiBtn_Login);
            this.uiPnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPnl_Main.Location = new System.Drawing.Point(0, 0);
            this.uiPnl_Main.Name = "uiPnl_Main";
            this.uiPnl_Main.Size = new System.Drawing.Size(415, 331);
            this.uiPnl_Main.TabIndex = 6;
            // 
            // uiTxt_PWD
            // 
            this.uiTxt_PWD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiTxt_PWD.Font = new System.Drawing.Font("굴림", 12F);
            this.uiTxt_PWD.Location = new System.Drawing.Point(39, 226);
            this.uiTxt_PWD.Name = "uiTxt_PWD";
            this.uiTxt_PWD.PasswordChar = '*';
            this.uiTxt_PWD.Size = new System.Drawing.Size(331, 19);
            this.uiTxt_PWD.TabIndex = 7;
            // 
            // uiTxt_ID
            // 
            this.uiTxt_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiTxt_ID.Font = new System.Drawing.Font("굴림", 12F);
            this.uiTxt_ID.Location = new System.Drawing.Point(39, 153);
            this.uiTxt_ID.Name = "uiTxt_ID";
            this.uiTxt_ID.Size = new System.Drawing.Size(331, 19);
            this.uiTxt_ID.TabIndex = 6;
            // 
            // uiBtn_Close
            // 
            this.uiBtn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uiBtn_Close.Location = new System.Drawing.Point(429, 35);
            this.uiBtn_Close.Name = "uiBtn_Close";
            this.uiBtn_Close.Size = new System.Drawing.Size(75, 23);
            this.uiBtn_Close.TabIndex = 9;
            this.uiBtn_Close.Text = "Close";
            this.uiBtn_Close.UseVisualStyleBackColor = true;
            // 
            // uiBtn_Login
            // 
            this.uiBtn_Login.BackgroundImage = global::ProgramManager.Properties.Resources.LoginButtonDisable;
            this.uiBtn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiBtn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiBtn_Login.Location = new System.Drawing.Point(25, 271);
            this.uiBtn_Login.Name = "uiBtn_Login";
            this.uiBtn_Login.Size = new System.Drawing.Size(364, 48);
            this.uiBtn_Login.TabIndex = 8;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(415, 331);
            this.Controls.Add(this.uiPnl_Main);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.uiPnl_Main.ResumeLayout(false);
            this.uiPnl_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel uiPnl_Main;
        private System.Windows.Forms.TextBox uiTxt_PWD;
        private System.Windows.Forms.TextBox uiTxt_ID;
        private System.Windows.Forms.Button uiBtn_Close;
        private System.Windows.Forms.Panel uiBtn_Login;
    }
}