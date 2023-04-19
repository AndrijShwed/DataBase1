using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace DataBase
{
    class ConnectionClass
    {

        private const string connStr = "server = localhost; user = User; database = berezhnytsya; password = User;";

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
