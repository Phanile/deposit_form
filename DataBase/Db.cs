using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using deposit_app.Entities;
using Npgsql;
using NpgsqlTypes;


namespace deposit_app.DataBase
{

    internal class Db
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["pgConnection"].ConnectionString;
      
        public static NpgsqlConnection Connect()
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка подключение к БД", ex);
            }
            return connection;
        }

        public static List<Client> GetClients()
        {
            var clients = new List<Client>();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                string query = "SELECT * FROM clients";
                NpgsqlCommand queryCommand = new NpgsqlCommand(query, connection);

                try
                {
                    connection.Open();
                    NpgsqlDataReader reader = queryCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        var client = new Client();
                        client.id = reader.GetGuid(0);
                        client.surname = reader.GetString(1);
                        client.first_name = reader.GetString(2);
                        client.patronymic = reader.GetString(3);
                        client.birth_date = reader.GetDateTime(4);
                        client.phone = reader.GetString(5);
                        client.email = reader.GetString(6);
                        client.passport_data = reader.GetString(7);
                        client.login = reader.GetString(8);
                        client.password = reader.GetString(9);
                        clients.Add(client);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
                return clients;
            }
        }
    }
}
