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
            this.components = new System.ComponentModel.Container();
            this.uiTlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.uiPnl_AppInfo = new System.Windows.Forms.Panel();
            this.uiPnl_Description = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiRtb_Description = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.uiPnl_AppName = new System.Windows.Forms.Panel();
            this.uiLab_AppNewVersion = new System.Windows.Forms.Label();
            this.uiLab_AppCurVersion = new System.Windows.Forms.Label();
            this.uiLab_AppName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.uiPnl_Title = new System.Windows.Forms.Panel();
            this.uiLab_Title = new System.Windows.Forms.Label();
            this.uiLab_Version = new System.Windows.Forms.Label();
            this.uiPnl_Option = new System.Windows.Forms.Panel();
            this.uiLab_Dept = new System.Windows.Forms.Label();
            this.uiLab_UserDept = new System.Windows.Forms.Label();
            this.uiLab_Type = new System.Windows.Forms.Label();
            this.uiLab_Name = new System.Windows.Forms.Label();
            this.uiLab_ID = new System.Windows.Forms.Label();
            this.uiLab_UserType = new System.Windows.Forms.Label();
            this.uiLab_UserName = new System.Windows.Forms.Label();
            this.uiLab_UserID = new System.Windows.Forms.Label();
            this.uiTlp_App = new System.Windows.Forms.TableLayoutPanel();
            this.uiPnl_Installed = new System.Windows.Forms.Panel();
            this.uiLv_Install = new System.Windows.Forms.ListView();
            this.uiLab_Install = new System.Windows.Forms.Label();
            this.uiPnl_Update = new System.Windows.Forms.Panel();
            this.uiLv_Update = new System.Windows.Forms.ListView();
            this.uiLab_Update = new System.Windows.Forms.Label();
            this.uiPnl_Download = new System.Windows.Forms.Panel();
            this.uiLv_Download = new System.Windows.Forms.ListView();
            this.uiLab_Download = new System.Windows.Forms.Label();
            this.uiImageList_Install = new System.Windows.Forms.ImageList(this.components);
            this.uiImageList_Update = new System.Windows.Forms.ImageList(this.components);
            this.uiImageList_Download = new System.Windows.Forms.ImageList(this.components);
            this.uiBtn_History = new ProgramManager.Controls.ImageButton();
            this.uiBtn_Close = new ProgramManager.Controls.ImageButton();
            this.uiBtn_Minimization = new ProgramManager.Controls.ImageButton();
            this.uiBtn_Config = new ProgramManager.Controls.ImageButton();
            this.uiBtn_UserManagement = new ProgramManager.Controls.ImageButton();
            this.uiBtn_Program = new ProgramManager.Controls.ImageButton();
            this.uiTlp_Main.SuspendLayout();
            this.uiPnl_AppInfo.SuspendLayout();
            this.uiPnl_Description.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.uiPnl_AppName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.uiPnl_Title.SuspendLayout();
            this.uiPnl_Option.SuspendLayout();
            this.uiTlp_App.SuspendLayout();
            this.uiPnl_Installed.SuspendLayout();
            this.uiPnl_Update.SuspendLayout();
            this.uiPnl_Download.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTlp_Main
            // 
            this.uiTlp_Main.ColumnCount = 1;
            this.uiTlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTlp_Main.Controls.Add(this.uiPnl_AppInfo, 0, 3);
            this.uiTlp_Main.Controls.Add(this.uiPnl_Title, 0, 0);
            this.uiTlp_Main.Controls.Add(this.uiPnl_Option, 0, 1);
            this.uiTlp_Main.Controls.Add(this.uiTlp_App, 0, 2);
            this.uiTlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTlp_Main.Location = new System.Drawing.Point(0, 0);
            this.uiTlp_Main.Name = "uiTlp_Main";
            this.uiTlp_Main.RowCount = 4;
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uiTlp_Main.Size = new System.Drawing.Size(977, 663);
            this.uiTlp_Main.TabIndex = 0;
            // 
            // uiPnl_AppInfo
            // 
            this.uiPnl_AppInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPnl_AppInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiPnl_AppInfo.Controls.Add(this.uiPnl_Description);
            this.uiPnl_AppInfo.Controls.Add(this.uiPnl_AppName);
            this.uiPnl_AppInfo.Location = new System.Drawing.Point(3, 379);
            this.uiPnl_AppInfo.Name = "uiPnl_AppInfo";
            this.uiPnl_AppInfo.Size = new System.Drawing.Size(971, 281);
            this.uiPnl_AppInfo.TabIndex = 3;
            // 
            // uiPnl_Description
            // 
            this.uiPnl_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPnl_Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.uiPnl_Description.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiPnl_Description.Controls.Add(this.panel1);
            this.uiPnl_Description.Controls.Add(this.label13);
            this.uiPnl_Description.Controls.Add(this.pictureBox5);
            this.uiPnl_Description.Location = new System.Drawing.Point(-1, 57);
            this.uiPnl_Description.Name = "uiPnl_Description";
            this.uiPnl_Description.Size = new System.Drawing.Size(973, 224);
            this.uiPnl_Description.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.uiRtb_Description);
            this.panel1.Location = new System.Drawing.Point(1, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 184);
            this.panel1.TabIndex = 10;
            // 
            // uiRtb_Description
            // 
            this.uiRtb_Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.uiRtb_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiRtb_Description.Location = new System.Drawing.Point(19, 19);
            this.uiRtb_Description.Name = "uiRtb_Description";
            this.uiRtb_Description.ReadOnly = true;
            this.uiRtb_Description.Size = new System.Drawing.Size(935, 162);
            this.uiRtb_Description.TabIndex = 11;
            this.uiRtb_Description.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label13.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(35, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 12);
            this.label13.TabIndex = 9;
            this.label13.Text = "Detail Description";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::ProgramManager.Properties.Resources.RedPoint;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Location = new System.Drawing.Point(20, 14);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 12);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // uiPnl_AppName
            // 
            this.uiPnl_AppName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPnl_AppName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.uiPnl_AppName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiPnl_AppName.Controls.Add(this.uiBtn_History);
            this.uiPnl_AppName.Controls.Add(this.uiLab_AppNewVersion);
            this.uiPnl_AppName.Controls.Add(this.uiLab_AppCurVersion);
            this.uiPnl_AppName.Controls.Add(this.uiLab_AppName);
            this.uiPnl_AppName.Controls.Add(this.label9);
            this.uiPnl_AppName.Controls.Add(this.pictureBox4);
            this.uiPnl_AppName.Controls.Add(this.label8);
            this.uiPnl_AppName.Controls.Add(this.pictureBox3);
            this.uiPnl_AppName.Location = new System.Drawing.Point(-1, -1);
            this.uiPnl_AppName.Name = "uiPnl_AppName";
            this.uiPnl_AppName.Size = new System.Drawing.Size(973, 58);
            this.uiPnl_AppName.TabIndex = 0;
            // 
            // uiLab_AppNewVersion
            // 
            this.uiLab_AppNewVersion.AutoSize = true;
            this.uiLab_AppNewVersion.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_AppNewVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.uiLab_AppNewVersion.Location = new System.Drawing.Point(184, 41);
            this.uiLab_AppNewVersion.Name = "uiLab_AppNewVersion";
            this.uiLab_AppNewVersion.Size = new System.Drawing.Size(101, 12);
            this.uiLab_AppNewVersion.TabIndex = 7;
            this.uiLab_AppNewVersion.Text = "(New Version)";
            // 
            // uiLab_AppCurVersion
            // 
            this.uiLab_AppCurVersion.AutoSize = true;
            this.uiLab_AppCurVersion.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_AppCurVersion.Location = new System.Drawing.Point(99, 41);
            this.uiLab_AppCurVersion.Name = "uiLab_AppCurVersion";
            this.uiLab_AppCurVersion.Size = new System.Drawing.Size(55, 12);
            this.uiLab_AppCurVersion.TabIndex = 5;
            this.uiLab_AppCurVersion.Text = "Version";
            // 
            // uiLab_AppName
            // 
            this.uiLab_AppName.AutoSize = true;
            this.uiLab_AppName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_AppName.Location = new System.Drawing.Point(99, 14);
            this.uiLab_AppName.Name = "uiLab_AppName";
            this.uiLab_AppName.Size = new System.Drawing.Size(43, 12);
            this.uiLab_AppName.TabIndex = 4;
            this.uiLab_AppName.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(35, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "Version ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::ProgramManager.Properties.Resources.RedPoint;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(20, 40);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 12);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(35, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "Name   ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ProgramManager.Properties.Resources.RedPoint;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(20, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 12);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // uiPnl_Title
            // 
            this.uiPnl_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uiPnl_Title.Controls.Add(this.uiBtn_Close);
            this.uiPnl_Title.Controls.Add(this.uiBtn_Minimization);
            this.uiPnl_Title.Controls.Add(this.uiLab_Title);
            this.uiPnl_Title.Controls.Add(this.uiLab_Version);
            this.uiPnl_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPnl_Title.Location = new System.Drawing.Point(1, 1);
            this.uiPnl_Title.Margin = new System.Windows.Forms.Padding(1);
            this.uiPnl_Title.Name = "uiPnl_Title";
            this.uiPnl_Title.Size = new System.Drawing.Size(975, 38);
            this.uiPnl_Title.TabIndex = 0;
            // 
            // uiLab_Title
            // 
            this.uiLab_Title.AutoSize = true;
            this.uiLab_Title.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.uiLab_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
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
            // uiPnl_Option
            // 
            this.uiPnl_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uiPnl_Option.Controls.Add(this.uiBtn_Config);
            this.uiPnl_Option.Controls.Add(this.uiBtn_UserManagement);
            this.uiPnl_Option.Controls.Add(this.uiBtn_Program);
            this.uiPnl_Option.Controls.Add(this.uiLab_Dept);
            this.uiPnl_Option.Controls.Add(this.uiLab_UserDept);
            this.uiPnl_Option.Controls.Add(this.uiLab_Type);
            this.uiPnl_Option.Controls.Add(this.uiLab_Name);
            this.uiPnl_Option.Controls.Add(this.uiLab_ID);
            this.uiPnl_Option.Controls.Add(this.uiLab_UserType);
            this.uiPnl_Option.Controls.Add(this.uiLab_UserName);
            this.uiPnl_Option.Controls.Add(this.uiLab_UserID);
            this.uiPnl_Option.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPnl_Option.Location = new System.Drawing.Point(1, 41);
            this.uiPnl_Option.Margin = new System.Windows.Forms.Padding(1);
            this.uiPnl_Option.Name = "uiPnl_Option";
            this.uiPnl_Option.Size = new System.Drawing.Size(975, 48);
            this.uiPnl_Option.TabIndex = 1;
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
            this.uiLab_UserDept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.uiLab_UserDept.Location = new System.Drawing.Point(328, 19);
            this.uiLab_UserDept.Name = "uiLab_UserDept";
            this.uiLab_UserDept.Size = new System.Drawing.Size(41, 12);
            this.uiLab_UserDept.TabIndex = 17;
            this.uiLab_UserDept.Text = "DEPT";
            // 
            // uiLab_Type
            // 
            this.uiLab_Type.AutoSize = true;
            this.uiLab_Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uiLab_Type.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.uiLab_Type.Location = new System.Drawing.Point(427, 19);
            this.uiLab_Type.Name = "uiLab_Type";
            this.uiLab_Type.Size = new System.Drawing.Size(48, 12);
            this.uiLab_Type.TabIndex = 16;
            this.uiLab_Type.Text = "Type :";
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
            // uiLab_UserType
            // 
            this.uiLab_UserType.AutoSize = true;
            this.uiLab_UserType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uiLab_UserType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_UserType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.uiLab_UserType.Location = new System.Drawing.Point(479, 19);
            this.uiLab_UserType.Name = "uiLab_UserType";
            this.uiLab_UserType.Size = new System.Drawing.Size(38, 12);
            this.uiLab_UserType.TabIndex = 12;
            this.uiLab_UserType.Text = "Type";
            // 
            // uiLab_UserName
            // 
            this.uiLab_UserName.AutoSize = true;
            this.uiLab_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uiLab_UserName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
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
            this.uiLab_UserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.uiLab_UserID.Location = new System.Drawing.Point(49, 19);
            this.uiLab_UserID.Name = "uiLab_UserID";
            this.uiLab_UserID.Size = new System.Drawing.Size(18, 12);
            this.uiLab_UserID.TabIndex = 10;
            this.uiLab_UserID.Text = "ID";
            // 
            // uiTlp_App
            // 
            this.uiTlp_App.ColumnCount = 3;
            this.uiTlp_App.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.uiTlp_App.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.uiTlp_App.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.uiTlp_App.Controls.Add(this.uiPnl_Installed, 0, 0);
            this.uiTlp_App.Controls.Add(this.uiPnl_Update, 1, 0);
            this.uiTlp_App.Controls.Add(this.uiPnl_Download, 2, 0);
            this.uiTlp_App.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTlp_App.Location = new System.Drawing.Point(1, 91);
            this.uiTlp_App.Margin = new System.Windows.Forms.Padding(1);
            this.uiTlp_App.Name = "uiTlp_App";
            this.uiTlp_App.RowCount = 1;
            this.uiTlp_App.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTlp_App.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uiTlp_App.Size = new System.Drawing.Size(975, 284);
            this.uiTlp_App.TabIndex = 2;
            // 
            // uiPnl_Installed
            // 
            this.uiPnl_Installed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.uiPnl_Installed.Controls.Add(this.uiLv_Install);
            this.uiPnl_Installed.Controls.Add(this.uiLab_Install);
            this.uiPnl_Installed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPnl_Installed.Location = new System.Drawing.Point(1, 1);
            this.uiPnl_Installed.Margin = new System.Windows.Forms.Padding(1);
            this.uiPnl_Installed.Name = "uiPnl_Installed";
            this.uiPnl_Installed.Size = new System.Drawing.Size(323, 282);
            this.uiPnl_Installed.TabIndex = 0;
            // 
            // uiLv_Install
            // 
            this.uiLv_Install.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.uiLv_Install.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiLv_Install.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLv_Install.HideSelection = false;
            this.uiLv_Install.Location = new System.Drawing.Point(0, 37);
            this.uiLv_Install.Name = "uiLv_Install";
            this.uiLv_Install.Size = new System.Drawing.Size(323, 245);
            this.uiLv_Install.TabIndex = 1;
            this.uiLv_Install.UseCompatibleStateImageBehavior = false;
            // 
            // uiLab_Install
            // 
            this.uiLab_Install.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uiLab_Install.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLab_Install.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_Install.Location = new System.Drawing.Point(0, 0);
            this.uiLab_Install.Name = "uiLab_Install";
            this.uiLab_Install.Size = new System.Drawing.Size(323, 37);
            this.uiLab_Install.TabIndex = 0;
            this.uiLab_Install.Text = "Installed App";
            this.uiLab_Install.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPnl_Update
            // 
            this.uiPnl_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uiPnl_Update.Controls.Add(this.uiLv_Update);
            this.uiPnl_Update.Controls.Add(this.uiLab_Update);
            this.uiPnl_Update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPnl_Update.Location = new System.Drawing.Point(326, 1);
            this.uiPnl_Update.Margin = new System.Windows.Forms.Padding(1);
            this.uiPnl_Update.Name = "uiPnl_Update";
            this.uiPnl_Update.Size = new System.Drawing.Size(323, 282);
            this.uiPnl_Update.TabIndex = 1;
            // 
            // uiLv_Update
            // 
            this.uiLv_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uiLv_Update.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiLv_Update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLv_Update.HideSelection = false;
            this.uiLv_Update.Location = new System.Drawing.Point(0, 37);
            this.uiLv_Update.Name = "uiLv_Update";
            this.uiLv_Update.Size = new System.Drawing.Size(323, 245);
            this.uiLv_Update.TabIndex = 2;
            this.uiLv_Update.UseCompatibleStateImageBehavior = false;
            // 
            // uiLab_Update
            // 
            this.uiLab_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uiLab_Update.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLab_Update.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_Update.Location = new System.Drawing.Point(0, 0);
            this.uiLab_Update.Name = "uiLab_Update";
            this.uiLab_Update.Size = new System.Drawing.Size(323, 37);
            this.uiLab_Update.TabIndex = 1;
            this.uiLab_Update.Text = "App To Update";
            this.uiLab_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPnl_Download
            // 
            this.uiPnl_Download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.uiPnl_Download.Controls.Add(this.uiLv_Download);
            this.uiPnl_Download.Controls.Add(this.uiLab_Download);
            this.uiPnl_Download.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPnl_Download.Location = new System.Drawing.Point(651, 1);
            this.uiPnl_Download.Margin = new System.Windows.Forms.Padding(1);
            this.uiPnl_Download.Name = "uiPnl_Download";
            this.uiPnl_Download.Size = new System.Drawing.Size(323, 282);
            this.uiPnl_Download.TabIndex = 2;
            // 
            // uiLv_Download
            // 
            this.uiLv_Download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.uiLv_Download.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiLv_Download.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLv_Download.HideSelection = false;
            this.uiLv_Download.Location = new System.Drawing.Point(0, 37);
            this.uiLv_Download.Name = "uiLv_Download";
            this.uiLv_Download.Size = new System.Drawing.Size(323, 245);
            this.uiLv_Download.TabIndex = 3;
            this.uiLv_Download.UseCompatibleStateImageBehavior = false;
            // 
            // uiLab_Download
            // 
            this.uiLab_Download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiLab_Download.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLab_Download.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_Download.Location = new System.Drawing.Point(0, 0);
            this.uiLab_Download.Name = "uiLab_Download";
            this.uiLab_Download.Size = new System.Drawing.Size(323, 37);
            this.uiLab_Download.TabIndex = 2;
            this.uiLab_Download.Text = "Not Installed App";
            this.uiLab_Download.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiImageList_Install
            // 
            this.uiImageList_Install.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.uiImageList_Install.ImageSize = new System.Drawing.Size(48, 48);
            this.uiImageList_Install.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // uiImageList_Update
            // 
            this.uiImageList_Update.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.uiImageList_Update.ImageSize = new System.Drawing.Size(48, 48);
            this.uiImageList_Update.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // uiImageList_Download
            // 
            this.uiImageList_Download.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.uiImageList_Download.ImageSize = new System.Drawing.Size(48, 48);
            this.uiImageList_Download.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // uiBtn_History
            // 
            this.uiBtn_History.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.uiBtn_History.Location = new System.Drawing.Point(874, 0);
            this.uiBtn_History.Name = "uiBtn_History";
            this.uiBtn_History.Size = new System.Drawing.Size(100, 60);
            this.uiBtn_History.TabIndex = 9;
            // 
            // uiBtn_Close
            // 
            this.uiBtn_Close.BackgroundImage = global::ProgramManager.Properties.Resources.CloseButtonDefault;
            this.uiBtn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uiBtn_Close.Location = new System.Drawing.Point(925, 0);
            this.uiBtn_Close.Name = "uiBtn_Close";
            this.uiBtn_Close.Size = new System.Drawing.Size(50, 38);
            this.uiBtn_Close.TabIndex = 12;
            // 
            // uiBtn_Minimization
            // 
            this.uiBtn_Minimization.BackgroundImage = global::ProgramManager.Properties.Resources.MinimizationButtonDefault;
            this.uiBtn_Minimization.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uiBtn_Minimization.Location = new System.Drawing.Point(875, 0);
            this.uiBtn_Minimization.Name = "uiBtn_Minimization";
            this.uiBtn_Minimization.Size = new System.Drawing.Size(50, 38);
            this.uiBtn_Minimization.TabIndex = 11;
            // 
            // uiBtn_Config
            // 
            this.uiBtn_Config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uiBtn_Config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uiBtn_Config.Location = new System.Drawing.Point(915, 1);
            this.uiBtn_Config.Name = "uiBtn_Config";
            this.uiBtn_Config.Size = new System.Drawing.Size(60, 46);
            this.uiBtn_Config.TabIndex = 24;
            // 
            // uiBtn_UserManagement
            // 
            this.uiBtn_UserManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uiBtn_UserManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uiBtn_UserManagement.Location = new System.Drawing.Point(855, 1);
            this.uiBtn_UserManagement.Name = "uiBtn_UserManagement";
            this.uiBtn_UserManagement.Size = new System.Drawing.Size(60, 46);
            this.uiBtn_UserManagement.TabIndex = 23;
            // 
            // uiBtn_Program
            // 
            this.uiBtn_Program.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uiBtn_Program.Location = new System.Drawing.Point(795, 1);
            this.uiBtn_Program.Name = "uiBtn_Program";
            this.uiBtn_Program.Size = new System.Drawing.Size(60, 46);
            this.uiBtn_Program.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(977, 663);
            this.Controls.Add(this.uiTlp_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.uiTlp_Main.ResumeLayout(false);
            this.uiPnl_AppInfo.ResumeLayout(false);
            this.uiPnl_Description.ResumeLayout(false);
            this.uiPnl_Description.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.uiPnl_AppName.ResumeLayout(false);
            this.uiPnl_AppName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.uiPnl_Title.ResumeLayout(false);
            this.uiPnl_Title.PerformLayout();
            this.uiPnl_Option.ResumeLayout(false);
            this.uiPnl_Option.PerformLayout();
            this.uiTlp_App.ResumeLayout(false);
            this.uiPnl_Installed.ResumeLayout(false);
            this.uiPnl_Update.ResumeLayout(false);
            this.uiPnl_Download.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel uiTlp_Main;
        private System.Windows.Forms.Panel uiPnl_Title;
        private System.Windows.Forms.Panel uiPnl_Option;
        private System.Windows.Forms.Label uiLab_Title;
        private System.Windows.Forms.Label uiLab_Version;
        private System.Windows.Forms.Label uiLab_Type;
        private System.Windows.Forms.Label uiLab_Name;
        private System.Windows.Forms.Label uiLab_ID;
        private System.Windows.Forms.Label uiLab_UserType;
        private System.Windows.Forms.Label uiLab_UserName;
        private System.Windows.Forms.Label uiLab_UserID;
        private System.Windows.Forms.Label uiLab_Dept;
        private System.Windows.Forms.Label uiLab_UserDept;
        private System.Windows.Forms.TableLayoutPanel uiTlp_App;
        private System.Windows.Forms.Panel uiPnl_Installed;
        private System.Windows.Forms.Label uiLab_Install;
        private System.Windows.Forms.Panel uiPnl_Update;
        private System.Windows.Forms.Label uiLab_Update;
        private System.Windows.Forms.Panel uiPnl_Download;
        private System.Windows.Forms.Label uiLab_Download;
        private System.Windows.Forms.Panel uiPnl_AppInfo;
        private System.Windows.Forms.Panel uiPnl_AppName;
        private System.Windows.Forms.Label uiLab_AppNewVersion;
        private System.Windows.Forms.Label uiLab_AppCurVersion;
        private System.Windows.Forms.Label uiLab_AppName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Controls.ImageButton uiBtn_UserManagement;
        private Controls.ImageButton uiBtn_Program;
        private Controls.ImageButton uiBtn_Config;
        private Controls.ImageButton uiBtn_Minimization;
        private Controls.ImageButton uiBtn_Close;
        private System.Windows.Forms.ListView uiLv_Install;
        private System.Windows.Forms.ListView uiLv_Update;
        private System.Windows.Forms.ListView uiLv_Download;
        private System.Windows.Forms.Panel uiPnl_Description;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Controls.ImageButton uiBtn_History;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox uiRtb_Description;
        private System.Windows.Forms.ImageList uiImageList_Install;
        private System.Windows.Forms.ImageList uiImageList_Update;
        private System.Windows.Forms.ImageList uiImageList_Download;
    }
}


