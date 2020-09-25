namespace ProgramManager.Forms
{
    partial class ProgramHistoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Version = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiLab_ProgramName = new System.Windows.Forms.Label();
            this.uiLv_Version = new System.Windows.Forms.ListView();
            this.uiRtb_Description = new System.Windows.Forms.RichTextBox();
            this.pnl_ListView = new System.Windows.Forms.Panel();
            this.uiBtn_Restore = new ProgramManager.Controls.ImageButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnl_ListView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(135, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "Detail Description";
            // 
            // lb_Version
            // 
            this.lb_Version.AutoSize = true;
            this.lb_Version.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.lb_Version.ForeColor = System.Drawing.Color.Black;
            this.lb_Version.Location = new System.Drawing.Point(34, 55);
            this.lb_Version.Name = "lb_Version";
            this.lb_Version.Size = new System.Drawing.Size(55, 12);
            this.lb_Version.TabIndex = 10;
            this.lb_Version.Text = "Version";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.panel1.Location = new System.Drawing.Point(20, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 1);
            this.panel1.TabIndex = 13;
            // 
            // uiLab_ProgramName
            // 
            this.uiLab_ProgramName.AutoSize = true;
            this.uiLab_ProgramName.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.uiLab_ProgramName.ForeColor = System.Drawing.Color.Black;
            this.uiLab_ProgramName.Location = new System.Drawing.Point(38, 12);
            this.uiLab_ProgramName.Name = "uiLab_ProgramName";
            this.uiLab_ProgramName.Size = new System.Drawing.Size(32, 14);
            this.uiLab_ProgramName.TabIndex = 14;
            this.uiLab_ProgramName.Text = "{0}";
            // 
            // uiLv_Version
            // 
            this.uiLv_Version.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uiLv_Version.Font = new System.Drawing.Font("굴림", 10F);
            this.uiLv_Version.GridLines = true;
            this.uiLv_Version.HideSelection = false;
            this.uiLv_Version.Location = new System.Drawing.Point(0, 0);
            this.uiLv_Version.Name = "uiLv_Version";
            this.uiLv_Version.Size = new System.Drawing.Size(101, 239);
            this.uiLv_Version.TabIndex = 2;
            this.uiLv_Version.UseCompatibleStateImageBehavior = false;
            this.uiLv_Version.View = System.Windows.Forms.View.List;
            // 
            // uiRtb_Description
            // 
            this.uiRtb_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiRtb_Description.Location = new System.Drawing.Point(98, 0);
            this.uiRtb_Description.Name = "uiRtb_Description";
            this.uiRtb_Description.Size = new System.Drawing.Size(344, 240);
            this.uiRtb_Description.TabIndex = 7;
            this.uiRtb_Description.Text = "";
            // 
            // pnl_ListView
            // 
            this.pnl_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_ListView.Controls.Add(this.uiRtb_Description);
            this.pnl_ListView.Controls.Add(this.uiLv_Version);
            this.pnl_ListView.Location = new System.Drawing.Point(31, 77);
            this.pnl_ListView.Name = "pnl_ListView";
            this.pnl_ListView.Size = new System.Drawing.Size(443, 239);
            this.pnl_ListView.TabIndex = 9;
            // 
            // uiBtn_Restore
            // 
            this.uiBtn_Restore.BackgroundImage = global::ProgramManager.Properties.Resources.RestoreDefault;
            this.uiBtn_Restore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.uiBtn_Restore.Location = new System.Drawing.Point(382, 41);
            this.uiBtn_Restore.Name = "uiBtn_Restore";
            this.uiBtn_Restore.Size = new System.Drawing.Size(93, 36);
            this.uiBtn_Restore.TabIndex = 15;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ProgramManager.Properties.Resources.RedPoint;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(23, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 12);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // ProgramHistoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(501, 327);
            this.Controls.Add(this.uiBtn_Restore);
            this.Controls.Add(this.uiLab_ProgramName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Version);
            this.Controls.Add(this.pnl_ListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(517, 366);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(517, 366);
            this.Name = "ProgramHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Program History";
            this.pnl_ListView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Version;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label uiLab_ProgramName;
        private Controls.ImageButton uiBtn_Restore;
        private System.Windows.Forms.ListView uiLv_Version;
        private System.Windows.Forms.RichTextBox uiRtb_Description;
        private System.Windows.Forms.Panel pnl_ListView;
    }
}