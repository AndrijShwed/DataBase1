using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
using MySqlConnector;

namespace DataBase
{
    class ConnectionClass
    {
<<<<<<< HEAD
        private const string connStr = "server = localhost; user = User; database = berezhnytsya; password = User;";
=======
<<<<<<< HEAD
       
        private const string connStr = "server=52.19.23.88;user=sql8597722;database=sql8597722;password=1;";
=======
        private const string connStr = "server = localhost; user = User; database =  berezhnytsya; password = User;";
>>>>>>> a83e5dd766a121b1f278eb157d83e2ab717a76c7
>>>>>>> 4f1372880473d857913919a0080e68c5e5900fcc

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
