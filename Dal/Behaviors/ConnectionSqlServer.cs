using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Behaviors
{
    public class ConnectionSqlServer
    {
        public static SqlConnection ReturnConnection()
        {
            SqlConnection sqlConnetion = new SqlConnection("Data Source=UPANEMA;Initial Catalog=dbCrud;Persist Security Info=True;User ID=sa;Password=123456");
            return sqlConnetion;
        }
    }
}
