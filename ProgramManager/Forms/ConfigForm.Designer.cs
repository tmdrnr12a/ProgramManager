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
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiBtn_Save = new System.Windows.Forms.Button();
            this.uiBtn_Close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.uiTxt_FTP_Port = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.uiTxt_FTP_PWD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uiTxt_FTP_User = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiTxt_FTP_Path = new System.Windows.Forms.TextBox();
            this.uiTxt_FTP_IP = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uiNum_Etc_RefreshTime = new System.Windows.Forms.NumericUpDown();
            this.uiTxt_Local_Path = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uiTxt_Etc_Description = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiNum_Etc_RefreshTime)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.uiBtn_Save);
            this.panel1.Controls.Add(this.uiBtn_Close);
            this.panel1.Location = new System.Drawing.Point(9, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 46);
            this.panel1.TabIndex = 73;
            // 
            // uiBtn_Save
            // 
            this.uiBtn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBtn_Save.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiBtn_Save.ForeColor = System.Drawing.Color.Blue;
            this.uiBtn_Save.Location = new System.Drawing.Point(479, 5);
            this.uiBtn_Save.Name = "uiBtn_Save";
            this.uiBtn_Save.Size = new System.Drawing.Size(90, 35);
            this.uiBtn_Save.TabIndex = 72;
            this.uiBtn_Save.Text = "Save";
            this.uiBtn_Save.UseVisualStyleBackColor = true;
            // 
            // uiBtn_Close
            // 
            this.uiBtn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBtn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uiBtn_Close.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiBtn_Close.ForeColor = System.Drawing.Color.Black;
            this.uiBtn_Close.Location = new System.Drawing.Point(573, 5);
            this.uiBtn_Close.Name = "uiBtn_Close";
            this.uiBtn_Close.Size = new System.Drawing.Size(90, 35);
            this.uiBtn_Close.TabIndex = 71;
            this.uiBtn_Close.Text = "Close";
            this.uiBtn_Close.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(10, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 180);
            this.panel2.TabIndex = 74;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.uiTxt_DB_Name);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.uiTxt_DB_PWD);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.uiTxt_DB_User);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.uiTxt_DB_Port);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.uiTxt_DB_IP);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 167);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Database ";
            // 
            // uiTxt_DB_Name
            // 
            this.uiTxt_DB_Name.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_DB_Name.Location = new System.Drawing.Point(145, 133);
            this.uiTxt_DB_Name.Name = "uiTxt_DB_Name";
            this.uiTxt_DB_Name.Size = new System.Drawing.Size(163, 23);
            this.uiTxt_DB_Name.TabIndex = 77;
            this.uiTxt_DB_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(8, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 24);
            this.label13.TabIndex = 76;
            this.label13.Text = "DB Name";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTxt_DB_PWD
            // 
            this.uiTxt_DB_PWD.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_DB_PWD.Location = new System.Drawing.Point(145, 105);
            this.uiTxt_DB_PWD.Name = "uiTxt_DB_PWD";
            this.uiTxt_DB_PWD.Size = new System.Drawing.Size(163, 23);
            this.uiTxt_DB_PWD.TabIndex = 75;
            this.uiTxt_DB_PWD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(8, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 24);
            this.label12.TabIndex = 74;
            this.label12.Text = "Password";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTxt_DB_User
            // 
            this.uiTxt_DB_User.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_DB_User.Location = new System.Drawing.Point(145, 77);
            this.uiTxt_DB_User.Name = "uiTxt_DB_User";
            this.uiTxt_DB_User.Size = new System.Drawing.Size(163, 23);
            this.uiTxt_DB_User.TabIndex = 73;
            this.uiTxt_DB_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(8, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 24);
            this.label11.TabIndex = 72;
            this.label11.Text = "User";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTxt_DB_Port
            // 
            this.uiTxt_DB_Port.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_DB_Port.Location = new System.Drawing.Point(145, 49);
            this.uiTxt_DB_Port.Name = "uiTxt_DB_Port";
            this.uiTxt_DB_Port.Size = new System.Drawing.Size(163, 23);
            this.uiTxt_DB_Port.TabIndex = 71;
            this.uiTxt_DB_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(8, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 24);
            this.label10.TabIndex = 70;
            this.label10.Text = "Port";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTxt_DB_IP
            // 
            this.uiTxt_DB_IP.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_DB_IP.Location = new System.Drawing.Point(145, 21);
            this.uiTxt_DB_IP.Name = "uiTxt_DB_IP";
            this.uiTxt_DB_IP.Size = new System.Drawing.Size(163, 23);
            this.uiTxt_DB_IP.TabIndex = 69;
            this.uiTxt_DB_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(8, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 24);
            this.label9.TabIndex = 59;
            this.label9.Text = "IP";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.groupBox3);
            this.panel5.Location = new System.Drawing.Point(10, 194);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(330, 180);
            this.panel5.TabIndex = 77;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.uiTxt_Local_Path);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 166);
            this.groupBox3.TabIndex = 72;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Local";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 24);
            this.label7.TabIndex = 59;
            this.label7.Text = "Download Path";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.groupBox5);
            this.panel6.Location = new System.Drawing.Point(346, 8);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(330, 180);
            this.panel6.TabIndex = 78;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Controls.Add(this.uiTxt_FTP_IP);
            this.groupBox5.Controls.Add(this.uiTxt_FTP_Path);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.uiTxt_FTP_Port);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.uiTxt_FTP_PWD);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.uiTxt_FTP_User);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox5.Location = new System.Drawing.Point(9, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(314, 168);
            this.groupBox5.TabIndex = 72;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "FTP";
            // 
            // uiTxt_FTP_Port
            // 
            this.uiTxt_FTP_Port.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_FTP_Port.Location = new System.Drawing.Point(144, 49);
            this.uiTxt_FTP_Port.Name = "uiTxt_FTP_Port";
            this.uiTxt_FTP_Port.Size = new System.Drawing.Size(163, 23);
            this.uiTxt_FTP_Port.TabIndex = 77;
            this.uiTxt_FTP_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Black;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(8, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(131, 24);
            this.label18.TabIndex = 76;
            this.label18.Text = "Port";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTxt_FTP_PWD
            // 
            this.uiTxt_FTP_PWD.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_FTP_PWD.Location = new System.Drawing.Point(145, 105);
            this.uiTxt_FTP_PWD.Name = "uiTxt_FTP_PWD";
            this.uiTxt_FTP_PWD.Size = new System.Drawing.Size(163, 23);
            this.uiTxt_FTP_PWD.TabIndex = 75;
            this.uiTxt_FTP_PWD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 74;
            this.label1.Text = "Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTxt_FTP_User
            // 
            this.uiTxt_FTP_User.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_FTP_User.Location = new System.Drawing.Point(145, 77);
            this.uiTxt_FTP_User.Name = "uiTxt_FTP_User";
            this.uiTxt_FTP_User.Size = new System.Drawing.Size(163, 23);
            this.uiTxt_FTP_User.TabIndex = 73;
            this.uiTxt_FTP_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Black;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(8, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 24);
            this.label15.TabIndex = 72;
            this.label15.Text = "User";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Black;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(8, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(131, 24);
            this.label17.TabIndex = 59;
            this.label17.Text = "IP";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 79;
            this.label2.Text = "Path";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTxt_FTP_Path
            // 
            this.uiTxt_FTP_Path.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_FTP_Path.Location = new System.Drawing.Point(145, 133);
            this.uiTxt_FTP_Path.Name = "uiTxt_FTP_Path";
            this.uiTxt_FTP_Path.Size = new System.Drawing.Size(163, 23);
            this.uiTxt_FTP_Path.TabIndex = 80;
            this.uiTxt_FTP_Path.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uiTxt_FTP_IP
            // 
            this.uiTxt_FTP_IP.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_FTP_IP.Location = new System.Drawing.Point(144, 21);
            this.uiTxt_FTP_IP.Name = "uiTxt_FTP_IP";
            this.uiTxt_FTP_IP.Size = new System.Drawing.Size(163, 23);
            this.uiTxt_FTP_IP.TabIndex = 81;
            this.uiTxt_FTP_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(346, 194);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 180);
            this.panel3.TabIndex = 78;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.uiTxt_Etc_Description);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.uiNum_Etc_RefreshTime);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 166);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Etc";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 59;
            this.label3.Text = "Refresh Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiNum_Etc_RefreshTime
            // 
            this.uiNum_Etc_RefreshTime.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiNum_Etc_RefreshTime.Location = new System.Drawing.Point(144, 21);
            this.uiNum_Etc_RefreshTime.Name = "uiNum_Etc_RefreshTime";
            this.uiNum_Etc_RefreshTime.Size = new System.Drawing.Size(164, 25);
            this.uiNum_Etc_RefreshTime.TabIndex = 73;
            this.uiNum_Etc_RefreshTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uiNum_Etc_RefreshTime.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // uiTxt_Local_Path
            // 
            this.uiTxt_Local_Path.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_Local_Path.Location = new System.Drawing.Point(145, 21);
            this.uiTxt_Local_Path.Name = "uiTxt_Local_Path";
            this.uiTxt_Local_Path.Size = new System.Drawing.Size(163, 23);
            this.uiTxt_Local_Path.TabIndex = 78;
            this.uiTxt_Local_Path.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 74;
            this.label4.Text = "Description File";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTxt_Etc_Description
            // 
            this.uiTxt_Etc_Description.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTxt_Etc_Description.Location = new System.Drawing.Point(144, 52);
            this.uiTxt_Etc_Description.Name = "uiTxt_Etc_Description";
            this.uiTxt_Etc_Description.Size = new System.Drawing.Size(163, 23);
            this.uiTxt_Etc_Description.TabIndex = 82;
            this.uiTxt_Etc_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConfigForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.CancelButton = this.uiBtn_Close;
            this.ClientSize = new System.Drawing.Size(684, 432);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfigForm";
            this.Text = "설정";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiNum_Etc_RefreshTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button uiBtn_Save;
        private System.Windows.Forms.Button uiBtn_Close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox uiTxt_FTP_Port;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox uiTxt_FTP_PWD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uiTxt_FTP_User;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox uiTxt_FTP_IP;
        private System.Windows.Forms.TextBox uiTxt_FTP_Path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown uiNum_Etc_RefreshTime;
        private System.Windows.Forms.TextBox uiTxt_Local_Path;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uiTxt_Etc_Description;
    }
}