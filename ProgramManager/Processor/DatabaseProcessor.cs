using ProgramManager.Etc;
using ProgramManager.Manager;
using ProgramManager.Models;
using System.Data;
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
            MysqlManager.Instance.ExecuteDsQuery(ds, query);

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
    }
}
