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

			DateTime birthDate = DateTime.Now;
			var birthDateString = birthDate_maskedTextBox.Text.Split('.');
			string day = birthDateString[0];
			string month = birthDateString[1];
			string year = birthDateString[2];
			if (string.IsNullOrWhiteSpace(day) || string.IsNullOrWhiteSpace(month) || string.IsNullOrWhiteSpace(year))
			{
				errors.Add("Введите дату рождения");
			}
			else
			{
                DateTime.TryParse(birthDate_maskedTextBox.Text, out birthDate);
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

			string phone = $"+7{Regex.Replace(phone_maskedTextBox.Text, "[^0-9]", "")}";
			if (phone.Equals("+7") || phone.Length != 12)
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

			string passportData = passportSeries_maskedTextBox.Text + passportNumber_maskedTextBox.Text;
			if (string.IsNullOrWhiteSpace(passportData))
			{
				errors.Add("Введите паспортные данные");
			}
			else if (passportSeries_maskedTextBox.Text.Length != 4 || passportNumber_maskedTextBox.Text.Length != 6)
			{
				errors.Add("Неправильно введены паспортные данные(10 символов)");
			}

			if (errors.Count == 0)
			{
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
				return;
			}
            MessageBox.Show(string.Join('\n', errors));
            return;
        }

		private void passportSeries_maskedTextBox_MouseClick(object sender, MouseEventArgs e)
		{
			passportSeries_maskedTextBox.SelectionStart = 0;
		}

		private void passportNumber_maskedTextBox_MouseClick(object sender, MouseEventArgs e)
		{
			passportNumber_maskedTextBox.SelectionStart = 0;
		}

		private void birthDate_maskedTextBox_MouseClick(object sender, MouseEventArgs e)
		{
			birthDate_maskedTextBox.SelectionStart = 0;
		}

		private void phone_maskedTextBox_MouseClick(object sender, MouseEventArgs e)
		{
			phone_maskedTextBox.SelectionStart = 0;
		}

		private void surname_textBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!IsRussianLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
			{
				e.Handled = true;
			}
		}

		private void firstname_textBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!IsRussianLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
			{
				e.Handled = true;
			}
		}

		private void patronymic_textBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!IsRussianLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
			{
				e.Handled = true;
			}
		}

		private bool IsRussianLetter(char c)
		{
			return (c >= 'А' && c <= 'я') || c == 'Ё' || c == 'ё';
		}

		private void AddClient_Form_Load(object sender, EventArgs e)
		{

		}
	}
}
