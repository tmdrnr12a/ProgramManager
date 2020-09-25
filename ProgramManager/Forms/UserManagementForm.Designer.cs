namespace ProgramManager.Forms
{
    partial class UserManagementForm
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
            this.uiTlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.uiPnl_Program = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.uiBtn_Save = new ProgramManager.Controls.ImageButton();
            this.uiPnl_User = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.uiBtn_Delete = new ProgramManager.Controls.ImageButton();
            this.uiBtn_Add = new ProgramManager.Controls.ImageButton();
            this.uiSpread_User = new FarPoint.Win.Spread.FpSpread();
            this.uiSheet_User = new FarPoint.Win.Spread.SheetView();
            this.uiSpread_Program = new FarPoint.Win.Spread.FpSpread();
            this.uiSheet_Program = new FarPoint.Win.Spread.SheetView();
            this.uiTlp_Main.SuspendLayout();
            this.uiPnl_Program.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uiPnl_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiSpread_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiSheet_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiSpread_Program)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiSheet_Program)).BeginInit();
            this.SuspendLayout();
            // 
            // uiTlp_Main
            // 
            this.uiTlp_Main.ColumnCount = 2;
            this.uiTlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.54978F));
            this.uiTlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.45022F));
            this.uiTlp_Main.Controls.Add(this.uiPnl_Program, 1, 0);
            this.uiTlp_Main.Controls.Add(this.uiPnl_User, 0, 0);
            this.uiTlp_Main.Controls.Add(this.uiSpread_User, 0, 1);
            this.uiTlp_Main.Controls.Add(this.uiSpread_Program, 1, 1);
            this.uiTlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTlp_Main.Location = new System.Drawing.Point(0, 0);
            this.uiTlp_Main.Name = "uiTlp_Main";
            this.uiTlp_Main.RowCount = 2;
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.960938F));
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.03906F));
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uiTlp_Main.Size = new System.Drawing.Size(924, 511);
            this.uiTlp_Main.TabIndex = 0;
            // 
            // uiPnl_Program
            // 
            this.uiPnl_Program.Controls.Add(this.pictureBox1);
            this.uiPnl_Program.Controls.Add(this.panel1);
            this.uiPnl_Program.Controls.Add(this.label1);
            this.uiPnl_Program.Controls.Add(this.uiBtn_Save);
            this.uiPnl_Program.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPnl_Program.Location = new System.Drawing.Point(540, 0);
            this.uiPnl_Program.Margin = new System.Windows.Forms.Padding(0);
            this.uiPnl_Program.Name = "uiPnl_Program";
            this.uiPnl_Program.Size = new System.Drawing.Size(384, 50);
            this.uiPnl_Program.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProgramManager.Properties.Resources.RedPoint;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(22, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 12);
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.panel1.Location = new System.Drawing.Point(19, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 1);
            this.panel1.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 94;
            this.label1.Text = "Available Program";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiBtn_Save
            // 
            this.uiBtn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBtn_Save.BackgroundImage = global::ProgramManager.Properties.Resources.SaveDefault;
            this.uiBtn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.uiBtn_Save.Location = new System.Drawing.Point(279, 1);
            this.uiBtn_Save.Name = "uiBtn_Save";
            this.uiBtn_Save.Size = new System.Drawing.Size(105, 49);
            this.uiBtn_Save.TabIndex = 0;
            // 
            // uiPnl_User
            // 
            this.uiPnl_User.Controls.Add(this.pictureBox3);
            this.uiPnl_User.Controls.Add(this.panel2);
            this.uiPnl_User.Controls.Add(this.label5);
            this.uiPnl_User.Controls.Add(this.uiBtn_Delete);
            this.uiPnl_User.Controls.Add(this.uiBtn_Add);
            this.uiPnl_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPnl_User.Location = new System.Drawing.Point(0, 0);
            this.uiPnl_User.Margin = new System.Windows.Forms.Padding(0);
            this.uiPnl_User.Name = "uiPnl_User";
            this.uiPnl_User.Size = new System.Drawing.Size(540, 50);
            this.uiPnl_User.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ProgramManager.Properties.Resources.RedPoint;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(22, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 12);
            this.pictureBox3.TabIndex = 93;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.panel2.Location = new System.Drawing.Point(19, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 1);
            this.panel2.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(37, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 91;
            this.label5.Text = "User Information";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiBtn_Delete
            // 
            this.uiBtn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBtn_Delete.BackgroundImage = global::ProgramManager.Properties.Resources.DeleteDefault;
            this.uiBtn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.uiBtn_Delete.Location = new System.Drawing.Point(436, 1);
            this.uiBtn_Delete.Name = "uiBtn_Delete";
            this.uiBtn_Delete.Size = new System.Drawing.Size(104, 49);
            this.uiBtn_Delete.TabIndex = 1;
            // 
            // uiBtn_Add
            // 
            this.uiBtn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBtn_Add.BackgroundImage = global::ProgramManager.Properties.Resources.AddDefault;
            this.uiBtn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.uiBtn_Add.Location = new System.Drawing.Point(340, 1);
            this.uiBtn_Add.Name = "uiBtn_Add";
            this.uiBtn_Add.Size = new System.Drawing.Size(96, 49);
            this.uiBtn_Add.TabIndex = 0;
            // 
            // uiSpread_User
            // 
            this.uiSpread_User.AccessibleDescription = "";
            this.uiSpread_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSpread_User.Location = new System.Drawing.Point(1, 51);
            this.uiSpread_User.Margin = new System.Windows.Forms.Padding(1);
            this.uiSpread_User.Name = "uiSpread_User";
            this.uiSpread_User.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.uiSheet_User});
            this.uiSpread_User.Size = new System.Drawing.Size(538, 459);
            this.uiSpread_User.TabIndex = 2;
            // 
            // uiSheet_User
            // 
            this.uiSheet_User.Reset();
            uiSheet_User.SheetName = "Sheet1";
            // 
            // uiSpread_Program
            // 
            this.uiSpread_Program.AccessibleDescription = "";
            this.uiSpread_Program.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSpread_Program.Location = new System.Drawing.Point(541, 51);
            this.uiSpread_Program.Margin = new System.Windows.Forms.Padding(1);
            this.uiSpread_Program.Name = "uiSpread_Program";
            this.uiSpread_Program.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.uiSheet_Program});
            this.uiSpread_Program.Size = new System.Drawing.Size(382, 459);
            this.uiSpread_Program.TabIndex = 3;
            // 
            // uiSheet_Program
            // 
            this.uiSheet_Program.Reset();
            uiSheet_Program.SheetName = "Sheet1";
            // 
            // UserManagementForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(924, 511);
            this.Controls.Add(this.uiTlp_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserManagementForm";
            this.Text = "UserManagementForm";
            this.uiTlp_Main.ResumeLayout(false);
            this.uiPnl_Program.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uiPnl_User.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiSpread_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiSheet_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiSpread_Program)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiSheet_Program)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel uiTlp_Main;
        private System.Windows.Forms.Panel uiPnl_Program;
        private System.Windows.Forms.Panel uiPnl_User;
        private Controls.ImageButton uiBtn_Save;
        private Controls.ImageButton uiBtn_Delete;
        private Controls.ImageButton uiBtn_Add;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private FarPoint.Win.Spread.FpSpread uiSpread_User;
        private FarPoint.Win.Spread.SheetView uiSheet_User;
        private FarPoint.Win.Spread.FpSpread uiSpread_Program;
        private FarPoint.Win.Spread.SheetView uiSheet_Program;
    }
}