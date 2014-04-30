using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Behaviors
{
    public class ConnectionMysql
    {
        public static string connectionString;
        
        public static MySqlConnection returnConnection()
        {
            connectionString = "server=localhost;user=root;database=crud;port=3306;password=;"; ;
            MySqlConnection connection = new MySqlConnection(connectionString);
            
            return connection;
        }

        public static void openConnection()
        {
            ConnectionMysql.returnConnection().Open();
        }

        public static void closeConnection()
        {
            ConnectionMysql.returnConnection().Close();
        }
    }
}
