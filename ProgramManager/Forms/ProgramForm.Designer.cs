namespace ProgramManager.Forms
{
    partial class ProgramForm
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
            this.uiBtn_Save = new System.Windows.Forms.Button();
            this.uiBtn_Add = new System.Windows.Forms.Button();
            this.uiBtn_Delete = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.uiSpread_Program = new FarPoint.Win.Spread.FpSpread();
            this.uiSheet_Program = new FarPoint.Win.Spread.SheetView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiSpread_Program)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiSheet_Program)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.panel1.Location = new System.Drawing.Point(20, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 1);
            this.panel1.TabIndex = 13;
            // 
            // uiLab_UserID
            // 
            this.uiLab_UserID.AutoSize = true;
            this.uiLab_UserID.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.uiLab_UserID.ForeColor = System.Drawing.Color.Black;
            this.uiLab_UserID.Location = new System.Drawing.Point(38, 18);
            this.uiLab_UserID.Name = "uiLab_UserID";
            this.uiLab_UserID.Size = new System.Drawing.Size(156, 14);
            this.uiLab_UserID.TabIndex = 14;
            this.uiLab_UserID.Text = "Program Information";
            // 
            // uiBtn_Save
            // 
            this.uiBtn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBtn_Save.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiBtn_Save.ForeColor = System.Drawing.Color.Green;
            this.uiBtn_Save.Location = new System.Drawing.Point(646, 331);
            this.uiBtn_Save.Name = "uiBtn_Save";
            this.uiBtn_Save.Size = new System.Drawing.Size(86, 38);
            this.uiBtn_Save.TabIndex = 21;
            this.uiBtn_Save.Text = "Save";
            this.uiBtn_Save.UseVisualStyleBackColor = true;
            // 
            // uiBtn_Add
            // 
            this.uiBtn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiBtn_Add.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiBtn_Add.ForeColor = System.Drawing.Color.Blue;
            this.uiBtn_Add.Location = new System.Drawing.Point(22, 331);
            this.uiBtn_Add.Name = "uiBtn_Add";
            this.uiBtn_Add.Size = new System.Drawing.Size(86, 38);
            this.uiBtn_Add.TabIndex = 23;
            this.uiBtn_Add.Text = "Add";
            this.uiBtn_Add.UseVisualStyleBackColor = true;
            // 
            // uiBtn_Delete
            // 
            this.uiBtn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiBtn_Delete.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiBtn_Delete.ForeColor = System.Drawing.Color.Red;
            this.uiBtn_Delete.Location = new System.Drawing.Point(110, 331);
            this.uiBtn_Delete.Name = "uiBtn_Delete";
            this.uiBtn_Delete.Size = new System.Drawing.Size(86, 38);
            this.uiBtn_Delete.TabIndex = 24;
            this.uiBtn_Delete.Text = "Delete";
            this.uiBtn_Delete.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ProgramManager.Properties.Resources.RedPoint;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(23, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 12);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // uiSpread_Program
            // 
            this.uiSpread_Program.AccessibleDescription = "";
            this.uiSpread_Program.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiSpread_Program.Location = new System.Drawing.Point(23, 43);
            this.uiSpread_Program.Name = "uiSpread_Program";
            this.uiSpread_Program.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.uiSheet_Program});
            this.uiSpread_Program.Size = new System.Drawing.Size(709, 282);
            this.uiSpread_Program.TabIndex = 25;
            // 
            // uiSheet_Program
            // 
            this.uiSheet_Program.Reset();
            uiSheet_Program.SheetName = "Sheet1";
            // 
            // ProgramForm2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(754, 375);
            this.Controls.Add(this.uiSpread_Program);
            this.Controls.Add(this.uiBtn_Delete);
            this.Controls.Add(this.uiBtn_Add);
            this.Controls.Add(this.uiBtn_Save);
            this.Controls.Add(this.uiLab_UserID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgramForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Program Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiSpread_Program)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiSheet_Program)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label uiLab_UserID;
        private System.Windows.Forms.Button uiBtn_Save;
        private System.Windows.Forms.Button uiBtn_Add;
        private System.Windows.Forms.Button uiBtn_Delete;
        private FarPoint.Win.Spread.FpSpread uiSpread_Program;
        private FarPoint.Win.Spread.SheetView uiSheet_Program;
    }
}