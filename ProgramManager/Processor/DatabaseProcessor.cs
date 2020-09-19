using ProgramManager.Etc;
using ProgramManager.Manager;
using ProgramManager.Managers;
using ProgramManager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProgramManager.Processor
{
    class DatabaseProcessor : Singleton<DatabaseProcessor>
    {
        public bool Login(string id, string pwd)
        {
            bool result = true;

            // 유저 정보 조회
            string query = @"
SELECT
    USER_SEQ,
    USER_ID, 
    USER_PWD, 
    USER_NAME, 
    USER_TYPE, 
    USER_DEPT, 
    USER_PROGRAM
FROM PM_USER_INFO
WHERE 1=1
AND USER_ID = '#USER_ID'
AND USER_PWD = '#USER_PWD'
";

            query = query.Replace("#USER_ID", id);
            query = query.Replace("#USER_PWD", pwd);

            DataSet ds = new DataSet();

            try
            {
                MysqlManager.Instance.ExecuteDsQuery(ds, query);
            }
            catch (Exception ex)
            {
                ds = null;
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                User.SEQ = ds.Tables[0].Rows[0]["USER_SEQ"].ToString();
                User.ID = ds.Tables[0].Rows[0]["USER_ID"].ToString();
                User.PWD = ds.Tables[0].Rows[0]["USER_PWD"].ToString();
                User.TYPE = ds.Tables[0].Rows[0]["USER_TYPE"].ToString();
                User.NAME = ds.Tables[0].Rows[0]["USER_NAME"].ToString();
                User.DEPT = ds.Tables[0].Rows[0]["USER_DEPT"].ToString();
                User.PROGRAM = ds.Tables[0].Rows[0]["USER_PROGRAM"].ToString();
            }
            else
            {
                result = false;
                MessageBox.Show("Please Check ID and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        public List<ProgramData> GetProgramData()
        {
            List<ProgramData> _ProgramList = new List<ProgramData>();

            string query =
@"
SELECT PR_ID, PR_NAME, PR_ICON, PR_PATH, PR_FILE
FROM PSK_DB.PM_PROGRAM_INFO
WHERE 1=1
/*PRID AND PR_ID IN (#PRID) PPID*/
ORDER BY PR_NAME ASC
";
            if (User.PROGRAM != "ALL")
            {
                query = query.Replace("/*PRID ", "");
                query = query.Replace(" PRID*/", "");
                query = query.Replace("#PRID", $"'{User.PROGRAM.Replace(",", "','")}'");
            }

            DataSet ds = new DataSet();

            try
            {
                MysqlManager.Instance.ExecuteDsQuery(ds, query);
            }
            catch (Exception ex)
            {
                ds = null;
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ProgramData pd = new ProgramData
                    {
                        PR_ID = ds.Tables[0].Rows[i]["PR_ID"].ToString(),
                        PR_NAME = ds.Tables[0].Rows[i]["PR_NAME"].ToString(),
                        PR_PATH = ds.Tables[0].Rows[i]["PR_PATH"].ToString(),
                        PR_FILE = ds.Tables[0].Rows[i]["PR_FILE"].ToString(),
                        
                    };

                    try
                    {
                        pd.PR_ICON = Image.FromStream(new MemoryStream((byte[])ds.Tables[0].Rows[i]["PR_ICON"]));
                    }
                    catch
                    {
                        pd.PR_ICON = Properties.Resources.NotFoundImage;
                    }

                    _ProgramList.Add(pd);
                }

                if (_ProgramList.Count > 0)
                    ReplaceFTPPath(_ProgramList);
            }

            return _ProgramList;
        }

        private List<ProgramData> ReplaceFTPPath(List<ProgramData> _ProgramList)
        {
            string ip = FileManager.GetValueString("FTP", "IP", "");
            string port = FileManager.GetValueString("FTP", "PORT", "");

            foreach (ProgramData pd in _ProgramList)
            {
                pd.PR_PATH = pd.PR_PATH.Replace("{0}", ip);
                pd.PR_PATH = pd.PR_PATH.Replace("{1}", port);
            }

            return _ProgramList;
        }

        public bool UpdatePassword(string pwd, string id)
        {
            bool result = false;

            string query =
@"
UPDATE PSK_DB.PM_USER_INFO
SET
    USER_PWD = '#USER_PWD'
WHERE 1=1
AND USER_ID = '#USER_ID'
";
            query = query.Replace("#USER_PWD", pwd);
            query = query.Replace("#USER_ID", id);

            try
            {
                int row = MysqlManager.Instance.ExecuteNonQuery(query);
                if (row == 1)
                {
                    result = true;

                    User.PWD = pwd;
                    MessageBox.Show("Change complete.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    result = false;
                    MessageBox.Show("Failed to change password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }
    }
}
