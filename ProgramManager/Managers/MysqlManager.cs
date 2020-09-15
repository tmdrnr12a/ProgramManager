using MySql.Data.MySqlClient;
using ProgramManager.Managers;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProgramManager.Manager
{
    public sealed class MysqlManager
    {
        public string ConnectionString { get; set; }
        public string InitFileName { get; set; }

        public string Address { get; private set; }
        public string Port { get; private set; }
        public string LastException { get; private set; }

        public bool IsRunning { get { return Connection.State == ConnectionState.Open; } }

        public MySqlConnection Connection { get; private set; }

        public bool IsConnected = false;

        private static MysqlManager instance;

        public static MysqlManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new MysqlManager();

                return instance;
            }
        }

        /// <summary>
        /// DB 커넥션 객체를 얻는 메서드 
        /// </summary>
        /// <returns></returns>
        public bool GetConnection()
        {
            try
            {
                SetConnectionString();

                Connection = new MySqlConnection(ConnectionString);

                Connection.Open();

                this.IsConnected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //LogManager.Instance.WriteLog(LogType.Error, msg);

                LastException = ex.Message;
                this.IsConnected = false;
                return false;
            }

            if (Connection.State == ConnectionState.Open)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Execute_NonQuery() 메서드를 호출하는 메서드 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string query)
        {
            lock (this)
            {
                int result = Execute_NonQuery(query);

                return result;
            }
        }

        /// <summary>
        /// ExecuteReader() 메서드를 호출하는 메서드
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public MySqlDataReader ExecuteReaderQuery(string query)
        {
            lock (this)
            {
                MySqlDataReader result = ExecuteReader(query);

                return result;
            }
        }

        /// <summary>
        /// ExecuteDataAdt() 메서드를 호출하는 메서드
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataSet ExecuteDsQuery(DataSet ds, string query)
        {
            ds.Reset();

            lock (this)
            {
                return ExecuteDataAdt(ds, query);
            }
        }

        /// <summary>
        /// 연결된 커넥션을 종료하는 메서드 
        /// </summary>
        public void Close()
        {
            Connection.Close();
        }

        #region private..........................................................

        /// <summary>
        /// 커넥션 연결을 위한 문자열을 세팅하는 메서드
        /// </summary>
        private void SetConnectionString()
        {
            string ip = FileManager.GetValueString("DATABASE", "IP", "");
            string port = FileManager.GetValueString("DATABASE", "PORT", "");
            string user = FileManager.GetValueString("DATABASE", "USER", "");
            string pwd = FileManager.GetValueString("DATABASE", "PWD", "");
            string dbName = FileManager.GetValueString("DATABASE", "DB_NAME", "");

            this.Address = ip;
            this.Port = port;
            this.ConnectionString = "Server=" + ip + ";Port=" + port + ";DataBase=" + dbName + ";UId=" + user + ";pwd=" + pwd;
            this.ConnectionString += ";charset=utf8";
        }

        /// <summary>
        /// 쿼리 실행 후 영향받은 Row 수를 반환하는 메서드
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        private int Execute_NonQuery(string query)
        {
            int result = 0;

            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = this.Connection,
                    CommandText = query
                };
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //LogManager.Instance.WriteLog(LogType.Error, msg);

                LastException = ex.Message;
            }

            return result;
        }

        /// <summary>
        /// 쿼리 실행결과를 MySqlDataReader 객체에 저장하는 메서드
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        private MySqlDataReader ExecuteReader(string query)
        {
            MySqlDataReader result = null;

            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = this.Connection,
                    CommandText = query
                };
                result = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                LastException = ex.Message;
                return null;
            }

            return result;
        }

        /// <summary>
        /// 쿼리 실행결과를 DataSet 에 저장하는 메서드
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        private DataSet ExecuteDataAdt(DataSet ds, string query)
        {
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter
                {
                    SelectCommand = new MySqlCommand()
                };
                cmd.SelectCommand.Connection = this.Connection;
                cmd.SelectCommand.CommandText = query;

                cmd.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //LogManager.Instance.WriteLog(LogType.Error, msg);

                LastException = ex.Message;
                return null;
            }

            return ds;
        }

        #endregion private..................................................................
    }
}