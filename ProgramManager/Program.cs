using ProgramManager.Forms;
using ProgramManager.Managers;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ProgramManager
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string pName = "ProgramManager";
            string configFile = "Config.ini";

            Process[] arrProcess = Process.GetProcessesByName(pName);
            if (arrProcess.Length > 1)
            {
                MessageBox.Show($"{pName} Already executed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileManager.FileName = $"{Environment.CurrentDirectory}\\{configFile}";

            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.ThreadException += Application_ThreadException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm frm = new LoginForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm(frm._User));
            }
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
