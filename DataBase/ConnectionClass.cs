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

        private const string connStr = "server = 52.19.23.88; user = sql8597722; database = sql8597722; password = 1;";

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
