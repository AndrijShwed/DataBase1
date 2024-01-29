using MySqlConnector;

namespace DataBase
{
    class ConnectionClass
    {
        private const string server_1 = "18.185.46.18";
        private const string user = "userb";
        private const string database = "berezhnytsya";
        private const string password = "1";
      
        private const string connStr = "server = " + server_1 + "; user = " + user + "; database = " + database + "; password = " + password + ";";

        MySqlConnection sqlConn = new MySqlConnection(connStr);

        public void openConnection()
        {
            if(sqlConn.State == System.Data.ConnectionState.Closed)
            {
                sqlConn.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConn.State == System.Data.ConnectionState.Open)
            {
                sqlConn.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return sqlConn;
        }
    }
}
