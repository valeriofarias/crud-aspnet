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
        public static MySqlConnection ReturnConnection()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=crud;port=3306;password=;");
            return connection;
        }
    }
}
