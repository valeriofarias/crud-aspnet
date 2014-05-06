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
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public void Save()
        {
            MySqlConnection connection = Behaviors.ConnectionMysql.ReturnConnection();

            try
            {
                connection.Open();

                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO groups (name, type) VALUES (@name, @type)";
                cmd.Parameters.AddWithValue("@name", this.Name);
                cmd.Parameters.AddWithValue("@type", this.Type);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw new ApplicationException(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void Update()
        {
            MySqlConnection connection = Behaviors.ConnectionMysql.ReturnConnection();

            try
            {
                connection.Open();

                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE groups SET name = @name, type = @type WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", this.Id);
                cmd.Parameters.AddWithValue("@name", this.Name);
                cmd.Parameters.AddWithValue("@type", this.Type);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw new ApplicationException(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
