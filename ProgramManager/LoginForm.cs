using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ProgramManager.Manager;
using ProgramManager.Processor;

namespace ProgramManager
{
    public partial class LoginForm : Form
    {
        #region " Variables "

        private BackgroundWorker ConnectWorker = null;

        private readonly int second = 3;

        private Point _CurrentPosition = new Point(0, 0);

        #endregion " Variables End"

        #region " Create & Load & Shown "

        public LoginForm()
        {
            InitializeComponent();

            this.Shown += LoginForm_Shown;

            uiPnl_Main.MouseDown += UiPnl_Main_MouseDown;
            uiPnl_Main.MouseMove += UiPnl_Main_MouseMove;

            uiBtn_Login.Click += UiBtn_Login_Click;
            uiBtn_Login.MouseDown += UiBtn_Login_MouseDown;
            uiBtn_Login.MouseUp += UiBtn_Login_MouseUp;

            uiBtn_Enter.Click += UiBtn_Enter_Click;
            uiBtn_Close.Click += UiBtn_Close_Click;
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            InitLoginButtonImage();

            ConnectToDB();
        }

        #endregion " Create & Load & Shown End "

        #region " Methods "

        private void InitLoginButtonImage()
        {
            uiBtn_Login.BackgroundImage = Properties.Resources.LoginButtonDisable;
            uiBtn_Login.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void ConnectToDB()
        {
            if (this.ConnectWorker == null)
            {
                this.ConnectWorker = new BackgroundWorker();
                this.ConnectWorker.DoWork += ConnectWorker_DoWork;
                this.ConnectWorker.RunWorkerCompleted += ConnectWorker_RunWorkerCompleted;
            }

            ConnectWorker.RunWorkerAsync();
        }

        private void EnableLoginButton()
        {
            try
            {
                uiBtn_Login.BackgroundImage = Properties.Resources.LoginButtonEnable;
                uiBtn_Login.Tag = "OK";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetFocus()
        {
            uiTxt_ID.Focus();
            uiTxt_ID.Select();
        }

        private bool CheckUserInfo(string id, string pwd)
        {
            bool result = true;

            if (String.IsNullOrWhiteSpace(id) == true ||
                String.IsNullOrWhiteSpace(pwd) == true)
            {
                result = false;
                MessageBox.Show("Check Login Information.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return result;
        }

        #endregion " Methods End "

        #region " Events "

        void ConnectWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                try
                {
                    if (MysqlManager.Instance.GetConnection() == true)
                        break;

                    System.Threading.Thread.Sleep(1000 * second);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void ConnectWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            EnableLoginButton();

            SetFocus();
        }

        void UiBtn_Login_Click(object sender, EventArgs e)
        {
            Panel pnl = sender as Panel;
            if (pnl.Tag == null)
                return;

            string id = uiTxt_ID.Text;
            string pwd = uiTxt_PWD.Text;

            if (CheckUserInfo(id, pwd) == false)
                return;

            if (DatabaseProcessor.Instance.Login(id, pwd) == true)
                this.Close();
        }

        private void UiBtn_Enter_Click(object sender, EventArgs e)
        {
            UiBtn_Login_Click(uiBtn_Login, null);
        }

        private void UiBtn_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close?", "Inform", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (ConnectWorker != null)
                {
                    ConnectWorker.Dispose();
                    ConnectWorker = null;
                }

                Application.ExitThread();
                Environment.Exit(0);
            }
        }

        void UiBtn_Login_MouseUp(object sender, MouseEventArgs e)
        {
            Panel pnl = sender as Panel;
            if (pnl.Tag == null)
                return;

            uiBtn_Login.BackgroundImage = Properties.Resources.LoginButtonEnable;
        }

        void UiBtn_Login_MouseDown(object sender, MouseEventArgs e)
        {
            Panel pnl = sender as Panel;
            if (pnl.Tag == null)
                return;

            uiBtn_Login.BackgroundImage = Properties.Resources.LoginButtonClick;
        }

        private void UiPnl_Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point
                (
                    this.Location.X + (_CurrentPosition.X + e.X),
                    this.Location.Y + (_CurrentPosition.Y + e.Y)
                );
            }
        }

        private void UiPnl_Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _CurrentPosition = new Point(-e.X, -e.Y);
        }

        #endregion " Events End "
    }
}
