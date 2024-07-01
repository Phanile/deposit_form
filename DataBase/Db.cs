using System.Configuration;
using deposit_app.Entities;
using Npgsql;

namespace deposit_app.DataBase
{
	internal class Db
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["pgConnection"].ConnectionString;
        private static readonly log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static List<Client> GetClients()
        {
			var clients = new List<Client>();
            using (var connection = new NpgsqlConnection(_connectionString))
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
            using (var connection = new NpgsqlConnection(_connectionString))
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
			using (var connection = new NpgsqlConnection(_connectionString))
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

		public static List<TransactionHistory> GetTransactionHistoriesByDepositId(string depositId)
		{
			var transactionHistories = new List<TransactionHistory>();
            string command = $"select * from transaction_history where deposit_id = '{depositId}'";
			using (var connection = new NpgsqlConnection(_connectionString))
			{
				using (var cmd = new NpgsqlCommand(command, connection))
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

		public static void CloseDeposit(string personal_account)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                using (var command = new NpgsqlCommand("CALL close_deposit(@_personal_account::varchar)", connection))
                {
                    command.Parameters.AddWithValue("_personal_account", personal_account);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Вклад успешно закрыт");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}");
                    }
                    finally
                    {
                        connection.Close();
						_logger.Info($"Вклад с лицевым счетом {personal_account} успешно закрыт");
					}
                }
            }
        }
        
		public static void AddDeposit(string email, string depositType, string currency, string status, string personalAccount, decimal initialBalance, decimal currBalance, DateTime openDate, DBNull closeDate, short timeframe)
		{
			using (var connection = new NpgsqlConnection(_connectionString))
			{
				try
				{
					connection.Open();

					// Проверка наличия пользователя с таким email
					using (var checkUserCommand = new NpgsqlCommand("SELECT COUNT(*) FROM clients WHERE email = @mail", connection))
					{
						checkUserCommand.Parameters.AddWithValue("mail", email);
						var userCount = (long)checkUserCommand.ExecuteScalar();

						if (userCount == 0)
						{
							MessageBox.Show("Пользователь с таким email не найден");
							return;
						}
					}

					// Если пользователь найден, добавляем депозит
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

						command.ExecuteNonQuery();
						MessageBox.Show("Вклад успешно добавлен");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Ошибка: {ex.Message}");
				}
				finally
				{
					connection.Close();
					_logger.Info($"Открыт вклад пользователю {email}");
				}
			}
		}

        public static void AddClient(Client client)
        {

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (var checkClientExistsCommand = new NpgsqlCommand("SELECT * FROM check_client_exists(@passport_data, @email, @phone)", connection))
                    {
                        checkClientExistsCommand.Parameters.AddWithValue("passport_data", client.passport_data);
                        checkClientExistsCommand.Parameters.AddWithValue("email", client.email);
                        checkClientExistsCommand.Parameters.AddWithValue("phone", client.phone);

                        var userCount = (bool)checkClientExistsCommand.ExecuteScalar();

                        if (userCount)
                        {
                            MessageBox.Show("Пользователь с такими данными(паспорт, телефон или почта) существует");
                            return;
                        }
                    }

                    using (var command = new NpgsqlCommand("CALL add_client(@surname::varchar, " +
                                                                          "@firstname::varchar, " +
                                                                          "@patronymic::varchar, " +
                                                                          "@birth_date::date, " +
                                                                          "@phone::varchar, " +
                                                                          "@email::varchar, " +
                                                                          "@passport_data::varchar)", connection))
                    {
                        command.Parameters.AddWithValue("surname", client.surname);
                        command.Parameters.AddWithValue("firstname", client.first_name);
                        command.Parameters.AddWithValue("patronymic", client.patronymic);
                        command.Parameters.AddWithValue("birth_date", $"{client.birth_date.Year}-{client.birth_date.Month}-{client.birth_date.Day}");
                        command.Parameters.AddWithValue("phone", client.phone);
                        command.Parameters.AddWithValue("email", client.email);
                        command.Parameters.AddWithValue("passport_data", client.passport_data);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Клиент успешно добавлен");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
				finally
				{
                    connection.Close();
					_logger.Info($"Добавлен новый клиент {client.first_name}, {client.email}");
				}
            }
        }

        public static void AddMoneyToDeposit(string depositId, decimal value)
        {
			using (var connection = new NpgsqlConnection(_connectionString))
			{
				try
				{
					connection.Open();

					using (var checkDepositExsist = new NpgsqlCommand("SELECT COUNT(*) FROM deposits WHERE id = @id::uuid", connection))
					{
						checkDepositExsist.Parameters.AddWithValue("id", depositId);
						var count = (long)checkDepositExsist.ExecuteScalar();

						if (count == 0)
						{
							MessageBox.Show("Вклад не найден!");
							return;
						}
					}

					using (var command = new NpgsqlCommand("call add_money_to_deposit(@value::decimal, @depositId::uuid);", connection))
					{
						command.Parameters.AddWithValue("value", value);
						command.Parameters.AddWithValue("depositId", depositId);

						command.ExecuteNonQuery();
						MessageBox.Show($"Вклад успешно пополнен на {value}");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Ошибка: {ex.Message}");
				}
				finally
				{
					connection.Close();
					_logger.Info($"На вклад {depositId} внесена сумма {value}");
				}
			}
            
		}

		public static void TakeMoneyFromDeposit(string depositId, decimal value)
		{
			using (var connection = new NpgsqlConnection(_connectionString))
			{
				try
				{
					connection.Open();

					using (var checkDepositExsist = new NpgsqlCommand("SELECT COUNT(*) FROM deposits WHERE id = @id::uuid", connection))
					{
						checkDepositExsist.Parameters.AddWithValue("id", depositId);
						var count = (long)checkDepositExsist.ExecuteScalar();

						if (count == 0)
						{
							MessageBox.Show("Вклад не найден!");
							return;
						}
					}

					using (var command = new NpgsqlCommand("call take_money_from_deposit(@value::decimal, @depositId::uuid);", connection))
					{
						command.Parameters.AddWithValue("value", value);
						command.Parameters.AddWithValue("depositId", depositId);

						command.ExecuteNonQuery();
						MessageBox.Show($"Со вклада успешно сняли {value}");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Ошибка: {ex.Message}");
				}
				finally
				{
					connection.Close();
					_logger.Info($"Со вклада {depositId} успешно сняли {value}");
				}
			}

		}

		public static Guid? GetClientIdByEmail(string email)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                using (var command = new NpgsqlCommand("SELECT get_client_id_by_email(@mail)", connection))
                {
                    command.Parameters.AddWithValue("mail", email);
                    try
                    {
                        connection.Open();
                        var result = command.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            return (Guid)result;
                        }
                        else
                        {
                            return null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}");
                        return null;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
		public static void EditClient(Client client)
		{
            using var connection = new NpgsqlConnection(_connectionString);
            {
				try
				{
					connection.Open();
					using (var command = new NpgsqlCommand("CALL update_client(" +
                                                                          "@client_id,"+
                                                                          "@surname::varchar, " +
																		  "@firstname::varchar, " +
																		  "@patronymic::varchar, " +
																		  "@birth_date::date, " +
																		  "@phone::varchar, " +
																		  "@email::varchar, " +
																		  "@passport_data::varchar)", connection))
					{
						command.Parameters.AddWithValue("client_id", client.id);
						command.Parameters.AddWithValue("surname", client.surname);
						command.Parameters.AddWithValue("firstname", client.first_name);
						command.Parameters.AddWithValue("patronymic", client.patronymic);
						command.Parameters.AddWithValue("birth_date", $"{client.birth_date.Year}-{client.birth_date.Month}-{client.birth_date.Day}");
						command.Parameters.AddWithValue("phone", client.phone);
						command.Parameters.AddWithValue("email", client.email);
						command.Parameters.AddWithValue("passport_data", client.passport_data);

						command.ExecuteNonQuery();
						MessageBox.Show("Клиент успешно изменён");
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
			}
		}
		public static bool ClientExistsWithDetails(Guid id,string email,string phone,string passportData)
		{
			using (var connection = new NpgsqlConnection(_connectionString))
			{
				using (var command = new NpgsqlCommand("SELECT client_exists_with_details(@id,@email,@phone,@passportData)", connection))
				{
					command.Parameters.AddWithValue("id", id);
					command.Parameters.AddWithValue("email", email);
					command.Parameters.AddWithValue("phone", phone);
					command.Parameters.AddWithValue("passportData", passportData);
					try
					{
						connection.Open();
						var result = command.ExecuteScalar();

						return (bool)result;
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Ошибка: {ex.Message}");
					}
					finally
					{
						connection.Close();
					}
                    return false;
				}
			}
		}

		public static DepositType? GetDepositTypeByDepositId(string depositId)
		{
			using (var connection = new NpgsqlConnection(_connectionString))
			{
				connection.Open();

				using (var checkDepositExsist = new NpgsqlCommand("select count(*) from deposits where id = @id::uuid", connection))
				{
					checkDepositExsist.Parameters.AddWithValue("id", depositId);
					var count = (long)checkDepositExsist.ExecuteScalar();

					if (count == 0)
					{
						MessageBox.Show("Вклад не найден!");
						return null;
					}
				}

				var depositTypeId = Guid.Empty;

				using (var getDepositTypeCommand = new NpgsqlCommand("select deposit_type from deposits where id = @id::uuid", connection))
				{
					getDepositTypeCommand.Parameters.AddWithValue("id", depositId);
					depositTypeId = (Guid)getDepositTypeCommand.ExecuteScalar();

					if (depositTypeId == Guid.Empty || depositTypeId == null)
					{
						MessageBox.Show("Тип вклада не определен!");
						return null;
					}
				}

				DepositType? depositType = null;

				using (var cmd = new NpgsqlCommand("select * from deposit_types where id = @id::uuid", connection))
				{
					cmd.Parameters.AddWithValue("id", depositTypeId);
					NpgsqlDataReader reader = cmd.ExecuteReader();
					while (reader.Read())
					{

						depositType = new DepositType
						{
							Id = (Guid)reader["Id"],
							Name = (string)reader["name"],
							Description = (string)reader["description"],
							Rate = (decimal)reader["rate"],
							Removable = (bool)reader["removable"],
							Addable = (bool)reader["addable"],
							MinBalance = (decimal)reader["min_balance"],
							MaxBalance = (decimal)reader["max_balance"],
							TimeFrame = (short)reader["timeframe"],
							NonDeductibleBalance = (decimal)reader["non_deductible_balance"]
						};
					}
				}

				return depositType;
			}
		}
	}
}
