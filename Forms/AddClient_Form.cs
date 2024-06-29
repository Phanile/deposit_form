using deposit_app.DataBase;
using deposit_app.Entities;
using System.Text.RegularExpressions;

namespace deposit_app.Forms
{
    public partial class AddClient_Form : Form
    {
        public event EventHandler ClientAdded;
        

        public AddClient_Form()
        {
            InitializeComponent();
        }
        private void OnClientAdded()
        {
            ClientAdded?.Invoke(this, EventArgs.Empty);
        }
		


		private void SaveChange_button_Click(object sender, EventArgs e)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex emailRegex = new Regex(emailPattern, RegexOptions.IgnoreCase);

            var errors = new List<string>();

            string surname = surname_textBox.Text;
            if (string.IsNullOrWhiteSpace(surname))
            {
                errors.Add("Введите фамилию");
            }

            string firstname = firstname_textBox.Text;
            if (string.IsNullOrWhiteSpace(firstname))
            {
                errors.Add("Введите Имя");
            }

            string patronymic = patronymic_textBox.Text;
            if (string.IsNullOrWhiteSpace(patronymic))
            {
                errors.Add("Введите Отчество");
            }

            DateTime birthDate = birthDate_dateTimePicker.Value;
            if (birthDate > DateTime.Now)
            {
                errors.Add("Дата рождения не может быть в будущем");
            }

            string phone = phone_textBox.Text;
            if (string.IsNullOrWhiteSpace(phone))
            {
                errors.Add("Введите телефонный номер");
            }

            string email = email_textBox.Text;
            if (string.IsNullOrWhiteSpace(email))
            {
                errors.Add("Введите электронную почту");
            }
            else if (!emailRegex.IsMatch(email))
            {
                errors.Add("Неправильно введена электронная почта");
            }

            string passportData = passportSeries_textBox.Text + passportNumber_textBox.Text;
            if (string.IsNullOrWhiteSpace(passportData))
            {
                errors.Add("Введите паспортные данные");
            }
            else if (passportData.Length != 10)
            {
                errors.Add("Неправильно введены паспортные данные(10 символов)");
            }
            
            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join('\n',errors));
                return;
            }

            var client = new Client
            {
                surname = surname,
                first_name = firstname,
                patronymic = patronymic,
                birth_date = birthDate,
                phone = phone,
                email = email,
                passport_data = passportData
            };
            
            Db.AddClient(client);
            OnClientAdded();
            this.Close();
        }
    }
}
