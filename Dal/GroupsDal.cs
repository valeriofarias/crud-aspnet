using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Core;

namespace Dal
{
    public class GroupsDal
    {
        public static void Save(Groups groups)
        {
            MySqlConnection connection = Behaviors.ConnectionMysql.ReturnConnection();

            try
            {
                connection.Open();

                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO groups (name, type) VALUES (@name, @type)";
                cmd.Parameters.AddWithValue("@name", groups.Name);
                cmd.Parameters.AddWithValue("@type", groups.Type);
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

        public static void Update(Groups groups)
        {
            MySqlConnection connection = Behaviors.ConnectionMysql.ReturnConnection();

            try
            {
                connection.Open();

                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE groups SET name = @name, type = @type WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", groups.Id);
                cmd.Parameters.AddWithValue("@name", groups.Name);
                cmd.Parameters.AddWithValue("@type", groups.Type);
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

        public static Groups FindById(int id)
        {
            MySqlConnection connection = Behaviors.ConnectionMysql.ReturnConnection();
            Groups groups = new Groups();

            try
            {
                connection.Open();

                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM groups WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader data = cmd.ExecuteReader();

                while (data.Read())
                {
                    groups.Id = Convert.ToInt32(data["id"]);
                    groups.Name = data["name"].ToString();
                    groups.Type = Convert.ToInt32(data["type"]);
                }
            }
            catch (MySqlException e)
            {
                throw new ApplicationException(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return groups;
        }
    }
}
