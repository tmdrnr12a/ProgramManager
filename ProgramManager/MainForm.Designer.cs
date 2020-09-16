namespace ProgramManager
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiTlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.uiPnl_Top = new System.Windows.Forms.Panel();
            this.uiPnl_Mid = new System.Windows.Forms.Panel();
            this.uiTlp_Sub = new System.Windows.Forms.TableLayoutPanel();
            this.uiLab_Title = new System.Windows.Forms.Label();
            this.uiLab_Version = new System.Windows.Forms.Label();
            this.uiLab_Authority = new System.Windows.Forms.Label();
            this.uiLab_Name = new System.Windows.Forms.Label();
            this.uiLab_ID = new System.Windows.Forms.Label();
            this.uiLab_UserAuthority = new System.Windows.Forms.Label();
            this.uiLab_UserName = new System.Windows.Forms.Label();
            this.uiLab_UserID = new System.Windows.Forms.Label();
            this.uiLab_Dept = new System.Windows.Forms.Label();
            this.uiLab_UserDept = new System.Windows.Forms.Label();
            this.uiPnl_Installed = new System.Windows.Forms.Panel();
            this.uiPnl_Update = new System.Windows.Forms.Panel();
            this.uiPnl_Download = new System.Windows.Forms.Panel();
            this.uiLab_Installed = new System.Windows.Forms.Label();
            this.uiLab_Update = new System.Windows.Forms.Label();
            this.uiLab_Download = new System.Windows.Forms.Label();
            this.uiBtn_Program = new System.Windows.Forms.Panel();
            this.uiBtn_UserManagement = new System.Windows.Forms.Panel();
            this.uiPic_Minimization = new System.Windows.Forms.PictureBox();
            this.uiPic_Close = new System.Windows.Forms.PictureBox();
            this.uiTlp_Main.SuspendLayout();
            this.uiPnl_Top.SuspendLayout();
            this.uiPnl_Mid.SuspendLayout();
            this.uiTlp_Sub.SuspendLayout();
            this.uiPnl_Installed.SuspendLayout();
            this.uiPnl_Update.SuspendLayout();
            this.uiPnl_Download.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPic_Minimization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPic_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // uiTlp_Main
            // 
            this.uiTlp_Main.ColumnCount = 1;
            this.uiTlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTlp_Main.Controls.Add(this.uiPnl_Top, 0, 0);
            this.uiTlp_Main.Controls.Add(this.uiPnl_Mid, 0, 1);
            this.uiTlp_Main.Controls.Add(this.uiTlp_Sub, 0, 2);
            this.uiTlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTlp_Main.Location = new System.Drawing.Point(0, 0);
            this.uiTlp_Main.Name = "uiTlp_Main";
            this.uiTlp_Main.RowCount = 3;
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uiTlp_Main.Size = new System.Drawing.Size(977, 663);
            this.uiTlp_Main.TabIndex = 0;
            // 
            // uiPnl_Top
            // 
            this.uiPnl_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uiPnl_Top.Controls.Add(this.uiLab_Title);
            this.uiPnl_Top.Controls.Add(this.uiPic_Minimization);
            this.uiPnl_Top.Controls.Add(this.uiPic_Close);
            this.uiPnl_Top.Controls.Add(this.uiLab_Version);
            this.uiPnl_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPnl_Top.Location = new System.Drawing.Point(1, 1);
            this.uiPnl_Top.Margin = new System.Windows.Forms.Padding(1);
            this.uiPnl_Top.Name = "uiPnl_Top";
            this.uiPnl_Top.Size = new System.Drawing.Size(975, 38);
            this.uiPnl_Top.TabIndex = 0;
            // 
            // uiPnl_Mid
            // 
            this.uiPnl_Mid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uiPnl_Mid.Controls.Add(this.uiBtn_UserManagement);
            this.uiPnl_Mid.Controls.Add(this.uiBtn_Program);
            this.uiPnl_Mid.Controls.Add(this.uiLab_Dept);
            this.uiPnl_Mid.Controls.Add(this.uiLab_UserDept);
            this.uiPnl_Mid.Controls.Add(this.uiLab_Authority);
            this.uiPnl_Mid.Controls.Add(this.uiLab_Name);
            this.uiPnl_Mid.Controls.Add(this.uiLab_ID);
            this.uiPnl_Mid.Controls.Add(this.uiLab_UserAuthority);
            this.uiPnl_Mid.Controls.Add(this.uiLab_UserName);
            this.uiPnl_Mid.Controls.Add(this.uiLab_UserID);
            this.uiPnl_Mid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPnl_Mid.Location = new System.Drawing.Point(1, 41);
            this.uiPnl_Mid.Margin = new System.Windows.Forms.Padding(1);
            this.uiPnl_Mid.Name = "uiPnl_Mid";
            this.uiPnl_Mid.Size = new System.Drawing.Size(975, 48);
            this.uiPnl_Mid.TabIndex = 1;
            // 
            // uiTlp_Sub
            // 
            this.uiTlp_Sub.ColumnCount = 3;
            this.uiTlp_Sub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.uiTlp_Sub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.uiTlp_Sub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.uiTlp_Sub.Controls.Add(this.uiPnl_Installed, 0, 0);
            this.uiTlp_Sub.Controls.Add(this.uiPnl_Update, 1, 0);
            this.uiTlp_Sub.Controls.Add(this.uiPnl_Download, 2, 0);
            this.uiTlp_Sub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTlp_Sub.Location = new System.Drawing.Point(1, 91);
            this.uiTlp_Sub.Margin = new System.Windows.Forms.Padding(1);
            this.uiTlp_Sub.Name = "uiTlp_Sub";
            this.uiTlp_Sub.RowCount = 2;
            this.uiTlp_Sub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTlp_Sub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTlp_Sub.Size = new System.Drawing.Size(975, 571);
            this.uiTlp_Sub.TabIndex = 2;
            // 
            // uiLab_Title
            // 
            this.uiLab_Title.AutoSize = true;
            this.uiLab_Title.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.uiLab_Title.ForeColor = System.Drawing.Color.White;
            this.uiLab_Title.Location = new System.Drawing.Point(8, 12);
            this.uiLab_Title.Name = "uiLab_Title";
            this.uiLab_Title.Size = new System.Drawing.Size(179, 16);
            this.uiLab_Title.TabIndex = 10;
            this.uiLab_Title.Text = "PROGRAM MANAGER";
            // 
            // uiLab_Version
            // 
            this.uiLab_Version.AutoSize = true;
            this.uiLab_Version.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_Version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.uiLab_Version.Location = new System.Drawing.Point(192, 18);
            this.uiLab_Version.Name = "uiLab_Version";
            this.uiLab_Version.Size = new System.Drawing.Size(32, 12);
            this.uiLab_Version.TabIndex = 7;
            this.uiLab_Version.Text = "VER";
            // 
            // uiLab_Authority
            // 
            this.uiLab_Authority.AutoSize = true;
            this.uiLab_Authority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uiLab_Authority.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_Authority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.uiLab_Authority.Location = new System.Drawing.Point(427, 19);
            this.uiLab_Authority.Name = "uiLab_Authority";
            this.uiLab_Authority.Size = new System.Drawing.Size(73, 12);
            this.uiLab_Authority.TabIndex = 16;
            this.uiLab_Authority.Text = "Authority :";
            // 
            // uiLab_Name
            // 
            this.uiLab_Name.AutoSize = true;
            this.uiLab_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uiLab_Name.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.uiLab_Name.Location = new System.Drawing.Point(119, 19);
            this.uiLab_Name.Name = "uiLab_Name";
            this.uiLab_Name.Size = new System.Drawing.Size(61, 12);
            this.uiLab_Name.TabIndex = 14;
            this.uiLab_Name.Text = "Name ：";
            // 
            // uiLab_ID
            // 
            this.uiLab_ID.AutoSize = true;
            this.uiLab_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uiLab_ID.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.uiLab_ID.Location = new System.Drawing.Point(12, 19);
            this.uiLab_ID.Name = "uiLab_ID";
            this.uiLab_ID.Size = new System.Drawing.Size(36, 12);
            this.uiLab_ID.TabIndex = 13;
            this.uiLab_ID.Text = "ID ：";
            // 
            // uiLab_UserAuthority
            // 
            this.uiLab_UserAuthority.AutoSize = true;
            this.uiLab_UserAuthority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uiLab_UserAuthority.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_UserAuthority.ForeColor = System.Drawing.Color.White;
            this.uiLab_UserAuthority.Location = new System.Drawing.Point(502, 19);
            this.uiLab_UserAuthority.Name = "uiLab_UserAuthority";
            this.uiLab_UserAuthority.Size = new System.Drawing.Size(82, 12);
            this.uiLab_UserAuthority.TabIndex = 12;
            this.uiLab_UserAuthority.Text = "AUTHORITY";
            // 
            // uiLab_UserName
            // 
            this.uiLab_UserName.AutoSize = true;
            this.uiLab_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uiLab_UserName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_UserName.ForeColor = System.Drawing.Color.White;
            this.uiLab_UserName.Location = new System.Drawing.Point(181, 19);
            this.uiLab_UserName.Name = "uiLab_UserName";
            this.uiLab_UserName.Size = new System.Drawing.Size(45, 12);
            this.uiLab_UserName.TabIndex = 11;
            this.uiLab_UserName.Text = "NAME";
            // 
            // uiLab_UserID
            // 
            this.uiLab_UserID.AutoSize = true;
            this.uiLab_UserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uiLab_UserID.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_UserID.ForeColor = System.Drawing.Color.White;
            this.uiLab_UserID.Location = new System.Drawing.Point(49, 19);
            this.uiLab_UserID.Name = "uiLab_UserID";
            this.uiLab_UserID.Size = new System.Drawing.Size(18, 12);
            this.uiLab_UserID.TabIndex = 10;
            this.uiLab_UserID.Text = "ID";
            // 
            // uiLab_Dept
            // 
            this.uiLab_Dept.AutoSize = true;
            this.uiLab_Dept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uiLab_Dept.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_Dept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.uiLab_Dept.Location = new System.Drawing.Point(281, 19);
            this.uiLab_Dept.Name = "uiLab_Dept";
            this.uiLab_Dept.Size = new System.Drawing.Size(44, 12);
            this.uiLab_Dept.TabIndex = 18;
            this.uiLab_Dept.Text = "Dept :";
            // 
            // uiLab_UserDept
            // 
            this.uiLab_UserDept.AutoSize = true;
            this.uiLab_UserDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uiLab_UserDept.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_UserDept.ForeColor = System.Drawing.Color.White;
            this.uiLab_UserDept.Location = new System.Drawing.Point(328, 19);
            this.uiLab_UserDept.Name = "uiLab_UserDept";
            this.uiLab_UserDept.Size = new System.Drawing.Size(41, 12);
            this.uiLab_UserDept.TabIndex = 17;
            this.uiLab_UserDept.Text = "DEPT";
            // 
            // uiPnl_Installed
            // 
            this.uiPnl_Installed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.uiPnl_Installed.Controls.Add(this.uiLab_Installed);
            this.uiPnl_Installed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPnl_Installed.Location = new System.Drawing.Point(1, 1);
            this.uiPnl_Installed.Margin = new System.Windows.Forms.Padding(1);
            this.uiPnl_Installed.Name = "uiPnl_Installed";
            this.uiPnl_Installed.Size = new System.Drawing.Size(322, 283);
            this.uiPnl_Installed.TabIndex = 0;
            // 
            // uiPnl_Update
            // 
            this.uiPnl_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uiPnl_Update.Controls.Add(this.uiLab_Update);
            this.uiPnl_Update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPnl_Update.Location = new System.Drawing.Point(325, 1);
            this.uiPnl_Update.Margin = new System.Windows.Forms.Padding(1);
            this.uiPnl_Update.Name = "uiPnl_Update";
            this.uiPnl_Update.Size = new System.Drawing.Size(322, 283);
            this.uiPnl_Update.TabIndex = 1;
            // 
            // uiPnl_Download
            // 
            this.uiPnl_Download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.uiPnl_Download.Controls.Add(this.uiLab_Download);
            this.uiPnl_Download.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPnl_Download.Location = new System.Drawing.Point(649, 1);
            this.uiPnl_Download.Margin = new System.Windows.Forms.Padding(1);
            this.uiPnl_Download.Name = "uiPnl_Download";
            this.uiPnl_Download.Size = new System.Drawing.Size(325, 283);
            this.uiPnl_Download.TabIndex = 2;
            // 
            // uiLab_Installed
            // 
            this.uiLab_Installed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uiLab_Installed.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLab_Installed.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_Installed.Location = new System.Drawing.Point(0, 0);
            this.uiLab_Installed.Name = "uiLab_Installed";
            this.uiLab_Installed.Size = new System.Drawing.Size(322, 37);
            this.uiLab_Installed.TabIndex = 0;
            this.uiLab_Installed.Text = "Installed App";
            this.uiLab_Installed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLab_Update
            // 
            this.uiLab_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uiLab_Update.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLab_Update.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_Update.Location = new System.Drawing.Point(0, 0);
            this.uiLab_Update.Name = "uiLab_Update";
            this.uiLab_Update.Size = new System.Drawing.Size(322, 37);
            this.uiLab_Update.TabIndex = 1;
            this.uiLab_Update.Text = "App To Update";
            this.uiLab_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLab_Download
            // 
            this.uiLab_Download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiLab_Download.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLab_Download.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_Download.Location = new System.Drawing.Point(0, 0);
            this.uiLab_Download.Name = "uiLab_Download";
            this.uiLab_Download.Size = new System.Drawing.Size(325, 37);
            this.uiLab_Download.TabIndex = 2;
            this.uiLab_Download.Text = "Not Installed App";
            this.uiLab_Download.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiBtn_Program
            // 
            this.uiBtn_Program.Location = new System.Drawing.Point(624, 1);
            this.uiBtn_Program.Margin = new System.Windows.Forms.Padding(1);
            this.uiBtn_Program.Name = "uiBtn_Program";
            this.uiBtn_Program.Size = new System.Drawing.Size(60, 46);
            this.uiBtn_Program.TabIndex = 19;
            // 
            // uiBtn_UserManagement
            // 
            this.uiBtn_UserManagement.Location = new System.Drawing.Point(684, 1);
            this.uiBtn_UserManagement.Margin = new System.Windows.Forms.Padding(1);
            this.uiBtn_UserManagement.Name = "uiBtn_UserManagement";
            this.uiBtn_UserManagement.Size = new System.Drawing.Size(60, 46);
            this.uiBtn_UserManagement.TabIndex = 20;
            // 
            // uiPic_Minimization
            // 
            this.uiPic_Minimization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPic_Minimization.BackgroundImage = global::ProgramManager.Properties.Resources.MinimizationButtonDefault;
            this.uiPic_Minimization.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiPic_Minimization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiPic_Minimization.Location = new System.Drawing.Point(874, 1);
            this.uiPic_Minimization.Margin = new System.Windows.Forms.Padding(1);
            this.uiPic_Minimization.Name = "uiPic_Minimization";
            this.uiPic_Minimization.Size = new System.Drawing.Size(50, 36);
            this.uiPic_Minimization.TabIndex = 9;
            this.uiPic_Minimization.TabStop = false;
            // 
            // uiPic_Close
            // 
            this.uiPic_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPic_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uiPic_Close.BackgroundImage = global::ProgramManager.Properties.Resources.CloseButtonDefault;
            this.uiPic_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiPic_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiPic_Close.Location = new System.Drawing.Point(924, 1);
            this.uiPic_Close.Margin = new System.Windows.Forms.Padding(1);
            this.uiPic_Close.Name = "uiPic_Close";
            this.uiPic_Close.Size = new System.Drawing.Size(50, 36);
            this.uiPic_Close.TabIndex = 8;
            this.uiPic_Close.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(977, 663);
            this.Controls.Add(this.uiTlp_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.uiTlp_Main.ResumeLayout(false);
            this.uiPnl_Top.ResumeLayout(false);
            this.uiPnl_Top.PerformLayout();
            this.uiPnl_Mid.ResumeLayout(false);
            this.uiPnl_Mid.PerformLayout();
            this.uiTlp_Sub.ResumeLayout(false);
            this.uiPnl_Installed.ResumeLayout(false);
            this.uiPnl_Update.ResumeLayout(false);
            this.uiPnl_Download.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiPic_Minimization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPic_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel uiTlp_Main;
        private System.Windows.Forms.Panel uiPnl_Top;
        private System.Windows.Forms.Panel uiPnl_Mid;
        private System.Windows.Forms.TableLayoutPanel uiTlp_Sub;
        private System.Windows.Forms.Label uiLab_Title;
        private System.Windows.Forms.PictureBox uiPic_Minimization;
        private System.Windows.Forms.PictureBox uiPic_Close;
        private System.Windows.Forms.Label uiLab_Version;
        private System.Windows.Forms.Label uiLab_Authority;
        private System.Windows.Forms.Label uiLab_Name;
        private System.Windows.Forms.Label uiLab_ID;
        private System.Windows.Forms.Label uiLab_UserAuthority;
        private System.Windows.Forms.Label uiLab_UserName;
        private System.Windows.Forms.Label uiLab_UserID;
        private System.Windows.Forms.Label uiLab_Dept;
        private System.Windows.Forms.Label uiLab_UserDept;
        private System.Windows.Forms.Panel uiPnl_Installed;
        private System.Windows.Forms.Label uiLab_Installed;
        private System.Windows.Forms.Panel uiPnl_Update;
        private System.Windows.Forms.Label uiLab_Update;
        private System.Windows.Forms.Panel uiPnl_Download;
        private System.Windows.Forms.Label uiLab_Download;
        private System.Windows.Forms.Panel uiBtn_UserManagement;
        private System.Windows.Forms.Panel uiBtn_Program;
    }
}


