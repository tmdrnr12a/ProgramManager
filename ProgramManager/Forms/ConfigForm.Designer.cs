namespace ProgramManager.Forms
{
    partial class ConfigForm
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uiPnl_DB = new System.Windows.Forms.Panel();
            this.uiTxt_DB_Name = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.uiTxt_DB_PWD = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.uiTxt_DB_User = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.uiTxt_DB_Port = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.uiTxt_DB_IP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uiTxt_FTP_IP = new System.Windows.Forms.TextBox();
            this.uiTxt_FTP_Path = new System.Windows.Forms.TextBox();
            this.uiTxt_FTP_Port = new System.Windows.Forms.TextBox();
            this.uiTxt_FTP_PWD = new System.Windows.Forms.TextBox();
            this.uiTxt_FTP_User = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.uiNum_Etc_RefreshTime = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.uiTxt_Local_Path = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.uiTxt_Etc_Description = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiBtn_Save = new System.Windows.Forms.Button();
            this.uiTlp_Main.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.uiPnl_DB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiNum_Etc_RefreshTime)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTlp_Main
            // 
            this.uiTlp_Main.BackColor = System.Drawing.SystemColors.Control;
            this.uiTlp_Main.ColumnCount = 2;
            this.uiTlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTlp_Main.Controls.Add(this.uiPnl_DB, 0, 0);
            this.uiTlp_Main.Controls.Add(this.panel3, 1, 1);
            this.uiTlp_Main.Controls.Add(this.panel5, 0, 1);
            this.uiTlp_Main.Controls.Add(this.panel6, 1, 0);
            this.uiTlp_Main.Controls.Add(this.panel1, 1, 2);
            this.uiTlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTlp_Main.Location = new System.Drawing.Point(0, 0);
            this.uiTlp_Main.Name = "uiTlp_Main";
            this.uiTlp_Main.RowCount = 3;
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.uiTlp_Main.Size = new System.Drawing.Size(684, 432);
            this.uiTlp_Main.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.uiTxt_FTP_IP);
            this.panel6.Controls.Add(this.uiTxt_FTP_Path);
            this.panel6.Controls.Add(this.uiTxt_FTP_Port);
            this.panel6.Controls.Add(this.uiTxt_FTP_PWD);
            this.panel6.Controls.Add(this.uiTxt_FTP_User);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(343, 1);
            this.panel6.Margin = new System.Windows.Forms.Padding(1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(340, 189);
            this.panel6.TabIndex = 84;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.uiTxt_Local_Path);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(1, 192);
            this.panel5.Margin = new System.Windows.Forms.Padding(1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(340, 189);
            this.panel5.TabIndex = 85;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.uiTxt_Etc_Description);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.uiNum_Etc_RefreshTime);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(343, 192);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 189);
            this.panel3.TabIndex = 86;
            // 
            // uiPnl_DB
            // 
            this.uiPnl_DB.BackColor = System.Drawing.SystemColors.Control;
            this.uiPnl_DB.Controls.Add(this.label5);
            this.uiPnl_DB.Controls.Add(this.uiTxt_DB_Name);
            this.uiPnl_DB.Controls.Add(this.label13);
            this.uiPnl_DB.Controls.Add(this.uiTxt_DB_PWD);
            this.uiPnl_DB.Controls.Add(this.label12);
            this.uiPnl_DB.Controls.Add(this.uiTxt_DB_User);
            this.uiPnl_DB.Controls.Add(this.label11);
            this.uiPnl_DB.Controls.Add(this.uiTxt_DB_Port);
            this.uiPnl_DB.Controls.Add(this.label10);
            this.uiPnl_DB.Controls.Add(this.uiTxt_DB_IP);
            this.uiPnl_DB.Controls.Add(this.label9);
            this.uiPnl_DB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPnl_DB.Location = new System.Drawing.Point(1, 1);
            this.uiPnl_DB.Margin = new System.Windows.Forms.Padding(1);
            this.uiPnl_DB.Name = "uiPnl_DB";
            this.uiPnl_DB.Size = new System.Drawing.Size(340, 189);
            this.uiPnl_DB.TabIndex = 87;
            // 
            // uiTxt_DB_Name
            // 
            this.uiTxt_DB_Name.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_DB_Name.Location = new System.Drawing.Point(125, 150);
            this.uiTxt_DB_Name.Name = "uiTxt_DB_Name";
            this.uiTxt_DB_Name.Size = new System.Drawing.Size(192, 23);
            this.uiTxt_DB_Name.TabIndex = 87;
            this.uiTxt_DB_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(19, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 24);
            this.label13.TabIndex = 86;
            this.label13.Text = "DB Name";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTxt_DB_PWD
            // 
            this.uiTxt_DB_PWD.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_DB_PWD.Location = new System.Drawing.Point(125, 122);
            this.uiTxt_DB_PWD.Name = "uiTxt_DB_PWD";
            this.uiTxt_DB_PWD.Size = new System.Drawing.Size(192, 23);
            this.uiTxt_DB_PWD.TabIndex = 85;
            this.uiTxt_DB_PWD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(19, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 24);
            this.label12.TabIndex = 84;
            this.label12.Text = "Password";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTxt_DB_User
            // 
            this.uiTxt_DB_User.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_DB_User.Location = new System.Drawing.Point(125, 94);
            this.uiTxt_DB_User.Name = "uiTxt_DB_User";
            this.uiTxt_DB_User.Size = new System.Drawing.Size(192, 23);
            this.uiTxt_DB_User.TabIndex = 83;
            this.uiTxt_DB_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(19, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 24);
            this.label11.TabIndex = 82;
            this.label11.Text = "User";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTxt_DB_Port
            // 
            this.uiTxt_DB_Port.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_DB_Port.Location = new System.Drawing.Point(125, 66);
            this.uiTxt_DB_Port.Name = "uiTxt_DB_Port";
            this.uiTxt_DB_Port.Size = new System.Drawing.Size(192, 23);
            this.uiTxt_DB_Port.TabIndex = 81;
            this.uiTxt_DB_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(19, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 24);
            this.label10.TabIndex = 80;
            this.label10.Text = "Port";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTxt_DB_IP
            // 
            this.uiTxt_DB_IP.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_DB_IP.Location = new System.Drawing.Point(125, 38);
            this.uiTxt_DB_IP.Name = "uiTxt_DB_IP";
            this.uiTxt_DB_IP.Size = new System.Drawing.Size(192, 23);
            this.uiTxt_DB_IP.TabIndex = 79;
            this.uiTxt_DB_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(19, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 24);
            this.label9.TabIndex = 78;
            this.label9.Text = "IP";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 29);
            this.label5.TabIndex = 88;
            this.label5.Text = "Database";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "FTP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTxt_FTP_IP
            // 
            this.uiTxt_FTP_IP.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_FTP_IP.Location = new System.Drawing.Point(124, 38);
            this.uiTxt_FTP_IP.Name = "uiTxt_FTP_IP";
            this.uiTxt_FTP_IP.Size = new System.Drawing.Size(192, 23);
            this.uiTxt_FTP_IP.TabIndex = 91;
            this.uiTxt_FTP_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uiTxt_FTP_Path
            // 
            this.uiTxt_FTP_Path.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_FTP_Path.Location = new System.Drawing.Point(124, 150);
            this.uiTxt_FTP_Path.Name = "uiTxt_FTP_Path";
            this.uiTxt_FTP_Path.Size = new System.Drawing.Size(192, 23);
            this.uiTxt_FTP_Path.TabIndex = 90;
            this.uiTxt_FTP_Path.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uiTxt_FTP_Port
            // 
            this.uiTxt_FTP_Port.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_FTP_Port.Location = new System.Drawing.Point(124, 66);
            this.uiTxt_FTP_Port.Name = "uiTxt_FTP_Port";
            this.uiTxt_FTP_Port.Size = new System.Drawing.Size(192, 23);
            this.uiTxt_FTP_Port.TabIndex = 88;
            this.uiTxt_FTP_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uiTxt_FTP_PWD
            // 
            this.uiTxt_FTP_PWD.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_FTP_PWD.Location = new System.Drawing.Point(124, 122);
            this.uiTxt_FTP_PWD.Name = "uiTxt_FTP_PWD";
            this.uiTxt_FTP_PWD.Size = new System.Drawing.Size(192, 23);
            this.uiTxt_FTP_PWD.TabIndex = 86;
            this.uiTxt_FTP_PWD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uiTxt_FTP_User
            // 
            this.uiTxt_FTP_User.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_FTP_User.Location = new System.Drawing.Point(124, 94);
            this.uiTxt_FTP_User.Name = "uiTxt_FTP_User";
            this.uiTxt_FTP_User.Size = new System.Drawing.Size(192, 23);
            this.uiTxt_FTP_User.TabIndex = 84;
            this.uiTxt_FTP_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 96;
            this.label2.Text = "Path";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 95;
            this.label6.Text = "Password";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 24);
            this.label8.TabIndex = 94;
            this.label8.Text = "User";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(13, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 24);
            this.label14.TabIndex = 93;
            this.label14.Text = "Port";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(13, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 24);
            this.label15.TabIndex = 92;
            this.label15.Text = "IP";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(340, 29);
            this.label16.TabIndex = 89;
            this.label16.Text = "Local";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiNum_Etc_RefreshTime
            // 
            this.uiNum_Etc_RefreshTime.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiNum_Etc_RefreshTime.Location = new System.Drawing.Point(124, 38);
            this.uiNum_Etc_RefreshTime.Name = "uiNum_Etc_RefreshTime";
            this.uiNum_Etc_RefreshTime.Size = new System.Drawing.Size(195, 25);
            this.uiNum_Etc_RefreshTime.TabIndex = 84;
            this.uiNum_Etc_RefreshTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uiNum_Etc_RefreshTime.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Black;
            this.label17.Dock = System.Windows.Forms.DockStyle.Top;
            this.label17.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(340, 29);
            this.label17.TabIndex = 90;
            this.label17.Text = "Etc";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTxt_Local_Path
            // 
            this.uiTxt_Local_Path.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_Local_Path.Location = new System.Drawing.Point(125, 40);
            this.uiTxt_Local_Path.Name = "uiTxt_Local_Path";
            this.uiTxt_Local_Path.Size = new System.Drawing.Size(194, 23);
            this.uiTxt_Local_Path.TabIndex = 91;
            this.uiTxt_Local_Path.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(16, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 24);
            this.label18.TabIndex = 90;
            this.label18.Text = "Download Path";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(16, 41);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 24);
            this.label19.TabIndex = 92;
            this.label19.Text = "Refresh Time";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTxt_Etc_Description
            // 
            this.uiTxt_Etc_Description.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_Etc_Description.Location = new System.Drawing.Point(124, 69);
            this.uiTxt_Etc_Description.Name = "uiTxt_Etc_Description";
            this.uiTxt_Etc_Description.Size = new System.Drawing.Size(195, 23);
            this.uiTxt_Etc_Description.TabIndex = 95;
            this.uiTxt_Etc_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(16, 69);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 24);
            this.label20.TabIndex = 94;
            this.label20.Text = "Description File";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uiBtn_Save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(342, 382);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 50);
            this.panel1.TabIndex = 88;
            // 
            // uiBtn_Save
            // 
            this.uiBtn_Save.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiBtn_Save.ForeColor = System.Drawing.Color.Green;
            this.uiBtn_Save.Location = new System.Drawing.Point(268, 0);
            this.uiBtn_Save.Name = "uiBtn_Save";
            this.uiBtn_Save.Size = new System.Drawing.Size(74, 50);
            this.uiBtn_Save.TabIndex = 89;
            this.uiBtn_Save.Text = "Save";
            this.uiBtn_Save.UseVisualStyleBackColor = true;
            // 
            // ConfigForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(684, 432);
            this.Controls.Add(this.uiTlp_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfigForm";
            this.Text = "Config";
            this.uiTlp_Main.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.uiPnl_DB.ResumeLayout(false);
            this.uiPnl_DB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiNum_Etc_RefreshTime)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel uiTlp_Main;
        private System.Windows.Forms.Panel uiPnl_DB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox uiTxt_DB_Name;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox uiTxt_DB_PWD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox uiTxt_DB_User;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox uiTxt_DB_Port;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox uiTxt_DB_IP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uiTxt_FTP_IP;
        private System.Windows.Forms.TextBox uiTxt_FTP_Path;
        private System.Windows.Forms.TextBox uiTxt_FTP_Port;
        private System.Windows.Forms.TextBox uiTxt_FTP_PWD;
        private System.Windows.Forms.TextBox uiTxt_FTP_User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox uiTxt_Etc_Description;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown uiNum_Etc_RefreshTime;
        private System.Windows.Forms.TextBox uiTxt_Local_Path;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button uiBtn_Save;
    }
}