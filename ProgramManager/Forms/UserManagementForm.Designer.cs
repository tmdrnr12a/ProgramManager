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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uiBtn_Delete = new ProgramManager.Controls.ImageButton();
            this.uiBtn_Add = new ProgramManager.Controls.ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.uiBtn_Save = new ProgramManager.Controls.ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.uiDGV_User = new System.Windows.Forms.DataGridView();
            this.uiDGV_Program = new System.Windows.Forms.DataGridView();
            this.uiTlp_Main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDGV_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiDGV_Program)).BeginInit();
            this.SuspendLayout();
            // 
            // uiTlp_Main
            // 
            this.uiTlp_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uiTlp_Main.ColumnCount = 2;
            this.uiTlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.125F));
            this.uiTlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.875F));
            this.uiTlp_Main.Controls.Add(this.panel1, 0, 0);
            this.uiTlp_Main.Controls.Add(this.panel2, 1, 0);
            this.uiTlp_Main.Controls.Add(this.uiDGV_User, 0, 1);
            this.uiTlp_Main.Controls.Add(this.uiDGV_Program, 1, 1);
            this.uiTlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTlp_Main.Location = new System.Drawing.Point(0, 0);
            this.uiTlp_Main.Name = "uiTlp_Main";
            this.uiTlp_Main.RowCount = 2;
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTlp_Main.Size = new System.Drawing.Size(800, 450);
            this.uiTlp_Main.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.uiBtn_Add);
            this.panel1.Controls.Add(this.uiBtn_Delete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 50);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.uiBtn_Save);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(457, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 50);
            this.panel2.TabIndex = 1;
            // 
            // uiBtn_Delete
            // 
            this.uiBtn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.uiBtn_Delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiBtn_Delete.Location = new System.Drawing.Point(401, 0);
            this.uiBtn_Delete.Margin = new System.Windows.Forms.Padding(0);
            this.uiBtn_Delete.Name = "uiBtn_Delete";
            this.uiBtn_Delete.Size = new System.Drawing.Size(56, 50);
            this.uiBtn_Delete.TabIndex = 0;
            // 
            // uiBtn_Add
            // 
            this.uiBtn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.uiBtn_Add.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiBtn_Add.Location = new System.Drawing.Point(345, 0);
            this.uiBtn_Add.Margin = new System.Windows.Forms.Padding(0);
            this.uiBtn_Add.Name = "uiBtn_Add";
            this.uiBtn_Add.Size = new System.Drawing.Size(56, 50);
            this.uiBtn_Add.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiBtn_Save
            // 
            this.uiBtn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.uiBtn_Save.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiBtn_Save.Location = new System.Drawing.Point(287, 0);
            this.uiBtn_Save.Margin = new System.Windows.Forms.Padding(0);
            this.uiBtn_Save.Name = "uiBtn_Save";
            this.uiBtn_Save.Size = new System.Drawing.Size(56, 50);
            this.uiBtn_Save.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "Available Program";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiDGV_User
            // 
            this.uiDGV_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiDGV_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiDGV_User.Location = new System.Drawing.Point(0, 50);
            this.uiDGV_User.Margin = new System.Windows.Forms.Padding(0);
            this.uiDGV_User.Name = "uiDGV_User";
            this.uiDGV_User.RowTemplate.Height = 23;
            this.uiDGV_User.Size = new System.Drawing.Size(457, 400);
            this.uiDGV_User.TabIndex = 2;
            // 
            // uiDGV_Program
            // 
            this.uiDGV_Program.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiDGV_Program.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiDGV_Program.Location = new System.Drawing.Point(457, 50);
            this.uiDGV_Program.Margin = new System.Windows.Forms.Padding(0);
            this.uiDGV_Program.Name = "uiDGV_Program";
            this.uiDGV_Program.RowTemplate.Height = 23;
            this.uiDGV_Program.Size = new System.Drawing.Size(343, 400);
            this.uiDGV_Program.TabIndex = 3;
            // 
            // UserManagementForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiTlp_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserManagementForm";
            this.Text = "UserManagementForm";
            this.uiTlp_Main.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDGV_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiDGV_Program)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel uiTlp_Main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Controls.ImageButton uiBtn_Add;
        private Controls.ImageButton uiBtn_Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Controls.ImageButton uiBtn_Save;
        private System.Windows.Forms.DataGridView uiDGV_User;
        private System.Windows.Forms.DataGridView uiDGV_Program;
    }
}