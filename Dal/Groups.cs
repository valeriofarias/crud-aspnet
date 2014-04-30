using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Dal
{
    public class Groups
    {
        public string Nome { get; set; }
        public string Type { get; set; }

        public string Save()
        {
            try
            {
                Behaviors.ConnectionMysql.openConnection();

                //string query = "INSERT INTO groups (name) VALUES('" + this.Nome + "')";

                //MySqlCommand cmd = new MySqlCommand(query, Behaviors.ConnectionMysql.returnConnection());
                //cmd.ExecuteNonQuery();

                MySqlCommand cmd = Behaviors.ConnectionMysql.returnConnection().CreateCommand();
                cmd.CommandText = "INSERT INTO groups (name) VALUES(@name)";
                cmd.Parameters.AddWithValue("@name", this.Nome);
                cmd.ExecuteNonQuery();

                return "Salvo com sucesso!";

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                return "Não pode ser salvo!";
            }
            finally
            {
                Behaviors.ConnectionMysql.closeConnection();
            }
        }
    }
}
