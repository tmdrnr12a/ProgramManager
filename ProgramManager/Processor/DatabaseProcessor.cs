using FarPoint.Win.Spread;
using ProgramManager.Etc;
using ProgramManager.Manager;
using ProgramManager.Managers;
using ProgramManager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ProgramManager.Processor
{
    class DatabaseProcessor : Singleton<DatabaseProcessor>
    {
        #region " Variables "

        #endregion " Variables End "

        #region " Create & Load & Shown "

        #endregion " Create & Load Shown End "

        #region "  Methods "

        public DataSet LoginInfo(string id, string pwd)
        {
            string query = @"
SELECT
    USER_SEQ,
    USER_ID, 
    USER_PWD, 
    USER_NAME, 
    USER_TYPE, 
    USER_PROGRAM
FROM PSK_DB.PM_USER_INFO
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

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {

                }
                else
                {
                    ds = null;
                    MessageBox.Show("Please Check ID and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ds = null;
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ds;
        }

        public List<ProgramData> GetExecutableProgramData(string userProgram)
        {
            List<ProgramData> _ProgramList = new List<ProgramData>();

            string query =
@"
SELECT PR_ID, PR_NAME, PR_ICON, PR_PATH, PR_FILE
FROM PSK_DB.PM_PROGRAM_INFO
WHERE 1=1
/*PR_ID AND PR_ID IN (#PR_ID) PR_ID*/
ORDER BY PR_NAME ASC
";
            if (userProgram != "ALL")
            {
                query = query.Replace("/*PR_ID ", "");
                query = query.Replace(" PR_ID*/", "");
                query = query.Replace("#PR_ID", $"'{userProgram.Replace(",", "','")}'");
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

        public string UpdatePassword(string curPwd, string changePwd, string id)
        {
            string password = curPwd;

            string query =
@"
UPDATE PSK_DB.PM_USER_INFO
SET
    USER_PWD = '#USER_PWD'
WHERE 1=1
AND USER_ID = '#USER_ID'
";
            query = query.Replace("#USER_PWD", changePwd);
            query = query.Replace("#USER_ID", id);

            try
            {
                int row = MysqlManager.Instance.ExecuteNonQuery(query);
                if (row == 1)
                {
                    password = changePwd;
                    MessageBox.Show("Change complete.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    password = curPwd;
                    MessageBox.Show("Failed to change password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return password;
        }

        public DataSet GetUserData()
        {
            string query =
@"
SELECT
    USER_SEQ,
    USER_ID, 
    USER_PWD, 
    USER_NAME, 
    USER_TYPE, 
    USER_PROGRAM
FROM PM_USER_INFO
ORDER BY USER_TYPE
";
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

            return ds;
        }

        public DataSet GetProgramData()
        {
            string query =
@"
SELECT 
    PR_ID, 
    PR_ICON,    
    PR_NAME
FROM PSK_DB.PM_PROGRAM_INFO
ORDER BY PR_NAME ASC
";
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

            return ds;
        }

        public void DeleteAllUser(string updateTime)
        {
            string query =
@"
DELETE FROM PSK_DB.PM_USER_INFO
WHERE UPDATE_TIME < '#UPDATE_TIME'
";
            query = query.Replace("#UPDATE_TIME", updateTime);

            try
            {
                int row = MysqlManager.Instance.ExecuteNonQuery(query);

                if (row > 0)
                    MessageBox.Show("Saved complete.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool DeleteTargetUser(string seq)
        {
            string query =
@"
DELETE FROM PSK_DB.PM_USER_INFO
WHERE USER_SEQ = '#USER_SEQ'
";
            query = query.Replace("#USER_SEQ", seq);

            int row = 0;

            try
            {
                row = MysqlManager.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (row >= 1);
        }

        public string GetCurrentTime()
        {
            string updateTime = DateTime.Now.ToString();

            string query =
@"
SELECT DATE_FORMAT(NOW(), '%Y-%m-%d %H:%i:%s')
";
            DataSet ds = new DataSet();

            try
            {
                MysqlManager.Instance.ExecuteDsQuery(ds, query);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    updateTime = ds.Tables[0].Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return updateTime;
        }

        public bool InsertUserData(List<User> users, string updateTime)
        {
            string headerQuery =
@"
INSERT INTO PSK_DB.PM_USER_INFO 
    (USER_ID, USER_PWD, USER_NAME, USER_TYPE, USER_PROGRAM, UPDATE_TIME)
VALUES 
";
            StringBuilder query = new StringBuilder();
            query.Clear();

            query.AppendFormat(headerQuery);

            for (int i = 0; i < users.Count; i++)
            {
                query.AppendFormat("\t");
                query.AppendFormat("(");
                query.AppendFormat("'{0}', ", users[i].ID);
                query.AppendFormat("'{0}', ", users[i].PWD);
                query.AppendFormat("'{0}', ", users[i].NAME);
                query.AppendFormat("'{0}', ", users[i].TYPE);
                query.AppendFormat("'{0}',", users[i].PROGRAM);
                query.AppendFormat("'{0}'", updateTime);
                query.AppendFormat(")");

                // 100개 단위로 입력
                if ((i % 100 == 99) || (i == users.Count - 1))
                {
                    query = query.Replace("*", "");

                    try
                    {
                        int r = MysqlManager.Instance.ExecuteNonQuery(query.ToString());
                        if (r <= 0)
                        {
                            MessageBox.Show("Failed to insert data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    query.Clear();
                    query.AppendFormat(headerQuery);
                }
                else
                {
                    query.AppendFormat(", \n");
                }
            }

            return true;
        }

        #endregion "  Methods End "

        #region " Events "

        #endregion "Events End "
    }
}
