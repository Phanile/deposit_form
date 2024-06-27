using System.Configuration;
using System.Data;
using deposit_app.Entities;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
                return clients;
            }
        }

        public static List<Deposit> GetDepositsByClientPassportData(string passportData)
        {
            var clientDeposits = new List<Deposit>();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                using (var command = new NpgsqlCommand("SELECT * FROM get_deposit_details(@passport_data)", connection))
                {
                    command.Parameters.AddWithValue("passport_data", passportData);
                    try
                    {
                        connection.Open();
                        NpgsqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            var deposit = new Deposit();
                            deposit.id = reader.GetGuid(0);
                            deposit.client_id = reader.GetGuid(1);
                            deposit.deposit_type = reader.GetString(2);
                            deposit.currency = reader.GetString(3);
                            deposit.status = reader.GetString(4);
                            deposit.personal_account = reader.GetString(5);
                            deposit.initial_balance = reader.GetDecimal(6);
                            deposit.curr_balance = reader.GetDecimal(7);
                            deposit.open_date = reader.GetDateTime(8);
                            deposit.timeframe = reader.GetInt16(10);
                            deposit.close_date = reader.IsDBNull(9) ? deposit.open_date.AddDays(deposit.timeframe) : reader.GetDateTime(9);
                            clientDeposits.Add(deposit);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}");
                    }
                    finally
                    {
                        connection.Close();
                    }
                    return clientDeposits;
                }

            }
        }
        public static List<TransactionHistory> GetTransactionHistories()
        {
            var transactionHistories = new List<TransactionHistory>();
			using (var connection = new NpgsqlConnection(connectionString))
            {
                using (var cmd = new NpgsqlCommand("select * from transaction_history", connection))
                {
                    connection.Open();
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        transactionHistories.Add(
                            new TransactionHistory
                            {
                                Id = (Guid)reader["Id"],
                                DepositId = (Guid)reader["deposit_id"],
                                TransactionType = (Guid)reader["type"],
                                DateTime = (DateTime)reader["datetime"],
                                Amount = (decimal)reader["amount"],
                                AmountBefore = (decimal)reader["amount_before"],
                                AmountAfter = (decimal)reader["amount_after"]
                            }
                        );

                    }
                }
			}
			return transactionHistories;
		}
        public static void AddDeposit(string email, string depositType, string currency, string status, string personalAccount, decimal initialBalance, decimal currBalance, DateTime openDate, DateTime closeDate, short timeframe)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                using (var command = new NpgsqlCommand("CALL insert_deposit(@mail::varchar, @deposit_type_name::varchar, @currency_name::varchar, @status_info::varchar, @_personal_account::varchar, @_initial_balance::decimal(9,2), @_curr_balance::decimal(9,2), @_open_date::date, @_close_date::date, @_timeframe::smallint)", connection))
                {
                    command.Parameters.AddWithValue("mail", email);
                    command.Parameters.AddWithValue("deposit_type_name", depositType);
                    command.Parameters.AddWithValue("currency_name", currency);
                    command.Parameters.AddWithValue("status_info", "Открыт"); 
                    command.Parameters.AddWithValue("_personal_account", personalAccount);
                    command.Parameters.AddWithValue("_initial_balance", initialBalance);
                    command.Parameters.AddWithValue("_curr_balance", currBalance);
                    command.Parameters.AddWithValue("_open_date", openDate);
                    command.Parameters.AddWithValue("_close_date", closeDate);
                    command.Parameters.AddWithValue("_timeframe", timeframe);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Депозит успешно добавлен");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

            }
        }
    }
}
