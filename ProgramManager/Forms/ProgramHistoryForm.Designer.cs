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
            this.pnl_Restore = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Version = new System.Windows.Forms.Label();
            this.pnl_ListView = new System.Windows.Forms.Panel();
            this.rtb_Description = new System.Windows.Forms.RichTextBox();
            this.lv_Version = new System.Windows.Forms.ListView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_ProgramName = new System.Windows.Forms.Label();
            this.pnl_ListView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Restore
            // 
            this.pnl_Restore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Restore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_Restore.Location = new System.Drawing.Point(394, 39);
            this.pnl_Restore.Name = "pnl_Restore";
            this.pnl_Restore.Size = new System.Drawing.Size(86, 27);
            this.pnl_Restore.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(103, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "Detail Description";
            // 
            // lb_Version
            // 
            this.lb_Version.AutoSize = true;
            this.lb_Version.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.lb_Version.Location = new System.Drawing.Point(22, 51);
            this.lb_Version.Name = "lb_Version";
            this.lb_Version.Size = new System.Drawing.Size(55, 12);
            this.lb_Version.TabIndex = 10;
            this.lb_Version.Text = "Version";
            // 
            // pnl_ListView
            // 
            this.pnl_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_ListView.Controls.Add(this.rtb_Description);
            this.pnl_ListView.Controls.Add(this.lv_Version);
            this.pnl_ListView.Location = new System.Drawing.Point(20, 68);
            this.pnl_ListView.Name = "pnl_ListView";
            this.pnl_ListView.Size = new System.Drawing.Size(461, 248);
            this.pnl_ListView.TabIndex = 9;
            // 
            // rtb_Description
            // 
            this.rtb_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Description.Location = new System.Drawing.Point(80, 0);
            this.rtb_Description.Name = "rtb_Description";
            this.rtb_Description.Size = new System.Drawing.Size(380, 249);
            this.rtb_Description.TabIndex = 7;
            this.rtb_Description.Text = "";
            // 
            // lv_Version
            // 
            this.lv_Version.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lv_Version.Font = new System.Drawing.Font("굴림", 10F);
            this.lv_Version.GridLines = true;
            this.lv_Version.HideSelection = false;
            this.lv_Version.Location = new System.Drawing.Point(0, 0);
            this.lv_Version.Name = "lv_Version";
            this.lv_Version.Size = new System.Drawing.Size(78, 248);
            this.lv_Version.TabIndex = 2;
            this.lv_Version.UseCompatibleStateImageBehavior = false;
            this.lv_Version.View = System.Windows.Forms.View.List;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.panel1.Location = new System.Drawing.Point(20, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 1);
            this.panel1.TabIndex = 13;
            // 
            // lbl_ProgramName
            // 
            this.lbl_ProgramName.AutoSize = true;
            this.lbl_ProgramName.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_ProgramName.Location = new System.Drawing.Point(38, 12);
            this.lbl_ProgramName.Name = "lbl_ProgramName";
            this.lbl_ProgramName.Size = new System.Drawing.Size(32, 14);
            this.lbl_ProgramName.TabIndex = 14;
            this.lbl_ProgramName.Text = "{0}";
            // 
            // ProgramHistoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(501, 327);
            this.Controls.Add(this.lbl_ProgramName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pnl_Restore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Version);
            this.Controls.Add(this.pnl_ListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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

        private System.Windows.Forms.Panel pnl_Restore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Version;
        private System.Windows.Forms.Panel pnl_ListView;
        private System.Windows.Forms.RichTextBox rtb_Description;
        private System.Windows.Forms.ListView lv_Version;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_ProgramName;


    }
}