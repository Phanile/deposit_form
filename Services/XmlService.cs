using deposit_app.DataBase;
using deposit_app.Entities;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace deposit_app.Services
{
    internal class XmlService
    {
        static string xsdFile = ConfigurationManager.AppSettings.Get("xsdSchemaPath");

		public static void AddClientFromXml(string path) 
        {
            var isValid = ValidateXml(path);
            if (isValid)
            {
                var clients = DeserializeFromXml(path);
                foreach (var client in clients)
                {
                    if (IsClientValid(client, out List<string> errors))
                    {
                        Db.AddClient(client);
                    }
                    else
                    {
                        MessageBox.Show($"Errors (#{clients.IndexOf(client) + 1}) {string.Join("\n\n", errors)}");
                        return;
                    }
                }
            }
        }

        public static bool ValidateXml(string xmlFilePath)
        {
            string errorMessage = string.Empty;
            var errors = new List<string>();

            try
            {
                XmlSchemaSet schema = new XmlSchemaSet();
                schema.Add("", xsdFile);

                XmlReaderSettings settings = new XmlReaderSettings();
                settings.ValidationType = ValidationType.Schema;
                settings.Schemas = schema;
                settings.ValidationEventHandler += (sender, e) =>
                {
                    errors.Add(e.Message);
                };

                using (XmlReader reader = XmlReader.Create(xmlFilePath, settings))
                {
                    while (reader.Read()) ;
                }

                if (errors.Count != 0)
                {
                    MessageBox.Show(string.Join("\n\n", errors));
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        private static List<Client> DeserializeFromXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Client>), new XmlRootAttribute("Clients"));
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                return (List<Client>)serializer.Deserialize(fileStream);
            }
        }

        private static bool IsClientValid(Client client, out List<string> errors)
        {
            errors = new List<string>();

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex emailRegex = new Regex(emailPattern, RegexOptions.IgnoreCase);

            if (string.IsNullOrWhiteSpace(client.Surname))
            {
                errors.Add("Введите фамилию");
            }

            if (string.IsNullOrWhiteSpace(client.FirstName))
            {
                errors.Add("Введите Имя");
            }

            if (string.IsNullOrWhiteSpace(client.Patronymic))
            {
                errors.Add("Введите Отчество");
            }

            DateTime birthDate = DateTime.Now;
            DateOnly date = DateOnly.FromDateTime(client.BirthDate);
            var birthDateString = date.ToString().Split('.');
            string day = birthDateString[0];
            string month = birthDateString[1];
            string year = birthDateString[2];
            if (string.IsNullOrWhiteSpace(day) || string.IsNullOrWhiteSpace(month) || string.IsNullOrWhiteSpace(year))
            {
                errors.Add("Введите дату рождения");
            }
            else
            {
                DateTime.TryParse(client.BirthDate.ToString(), out birthDate);
                int _day = int.Parse(day);
                int _month = int.Parse(month);
                int _year = int.Parse(year);
                if (_month > 12)
                {
                    errors.Add("Месяц не может быль больше 12");
                }
                else if (_day > DateTime.DaysInMonth(_year, _month))
                {
                    errors.Add($"Дней в этом месяце не может быть больше {DateTime.DaysInMonth(_year, _month)}");
                }
                else if (birthDate > DateTime.Now)
                {
                    errors.Add("Дата рождения не может быть в будущем");
                }
            }

            if (string.IsNullOrWhiteSpace(client.Phone) || !client.Phone.Contains("+7") || client.Phone.Length != 12)
            {
                errors.Add("Введите телефонный номер");
            }

            string email = client.Email;
            if (string.IsNullOrWhiteSpace(email))
            {
                errors.Add("Введите электронную почту");
            }
            else if (!emailRegex.IsMatch(email))
            {
                errors.Add("Неправильно введена электронная почта");
            }

            string passportData = client.PassportData;
            if (string.IsNullOrWhiteSpace(passportData))
            {
                errors.Add("Введите паспортные данные");
            }
            else if (passportData.Length != 10)
            {
                errors.Add("Неправильно введены паспортные данные(10 символов)");
            }

            if (errors.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
