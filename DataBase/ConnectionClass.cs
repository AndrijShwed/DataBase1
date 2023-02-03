using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataBase
{
    class ConnectionClass
    {
<<<<<<< HEAD
<<<<<<< HEAD
        private const string connStr = "server = localhost; user = User; database = berezhnytsya; password = User;";
=======
        private const string connStr = "server = localhost; user = User ; database = berezhnytsya; password = User;";
>>>>>>> 6a8cf10201205534c12e85b83940ebece9ad43c5
=======
        private const string connStr = "server = localhost; user = User; database = berezhnytsya; password = User;";
>>>>>>> Робоча версія на робочому ПК
        
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
