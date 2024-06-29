using deposit_app.DataBase;
using deposit_app.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace deposit_app.Forms
{

	public partial class EditClient_Form : Form
	{
		public event EventHandler ClientEdit;
		private void OnClientEdit()
		{
			ClientEdit?.Invoke(this, EventArgs.Empty);
		}
		public EditClient_Form()
		{
			InitializeComponent();
		}
		private void EditClient_Form_Load(object sender, System.EventArgs e)
		{

		}

		private void surname_textBox_KeyPress(object sender, KeyPressEventArgs e)
		{

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

		}
		private void phone_maskedTextBox_MouseClick(object sender, MouseEventArgs e)
		{
			
		}

		private void SaveChanged_btn_Click(object sender, EventArgs e)
		{
			string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
			Regex emailRegex = new Regex(emailPattern, RegexOptions.IgnoreCase);

			string surname = Surname_textBox.Text;
			if (string.IsNullOrWhiteSpace(surname))
			{
				MessageBox.Show("Введите фамилию клиента");
			}
			string first_name = firstname_textBox.Text;

			if (string.IsNullOrWhiteSpace(first_name))
			{
				MessageBox.Show("Введите имя клиента");
			}
			string patronymiс = patronymic_textBox.Text;

			if (string.IsNullOrWhiteSpace(patronymiс))
			{
				MessageBox.Show("Введите отчество клиента");
			}
			DateTime birthday = BirthDay_dateTimePicker.Value;

			string phone = $"+7{Regex.Replace(phone_maskedTextBox.Text, "[^0-9]", "")}";
			if (phone.Equals("+7") || phone.Length != 12)
			{
				MessageBox.Show("Слишком длинный номер");
			}

			if (string.IsNullOrWhiteSpace(phone))
			{
				MessageBox.Show("Введите номер телефона клиента");
			}
			string email = email_textBox.Text;

			if (string.IsNullOrWhiteSpace(email))
			{
				MessageBox.Show("Введите почту клиента");
			}
			else if (!emailRegex.IsMatch(email))
			{
				MessageBox.Show("Неправильно введена электронная почта");
				return;
			}
			string passportData = PassportData_textBox.Text;

			if (string.IsNullOrWhiteSpace(passportData))
			{
				MessageBox.Show("Введите паспортные даннеы клиента");
			}

			var client = new Client
			{
				surname = surname,
				first_name = first_name,
				patronymic = patronymiс,
				birth_date = birthday,
				phone = phone,
				email = email,
				passport_data = passportData
			};

			//Db.GetClientIdByEmail(email);
			bool check = Db.ClientExistsWithDetails(client.id, client.email, client.phone, client.passport_data);
			if (!check)
			{
				Db.EditClient(client);
				OnClientEdit();
				this.Close();
			}
			else
			{
				MessageBox.Show("Клиент с такой почтой, телефоном или паспортными данными уже существует");
			}

		}

		private void phone_maskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}
		private bool IsRussianLetter(char c)
		{
			return (c >= 'А' && c <= 'я') || c == 'Ё' || c == 'ё';
		}

		private void Surname_textBox_KeyPress_1(object sender, KeyPressEventArgs e)
		{
			if (!IsRussianLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
			{
				e.Handled = true;
			}
		}

		private void firstname_textBox_KeyPress_1(object sender, KeyPressEventArgs e)
		{
			if (!IsRussianLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
			{
				e.Handled = true;
			}
		}

		private void patronymic_textBox_KeyPress_1(object sender, KeyPressEventArgs e)
		{
			if (!IsRussianLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
			{
				e.Handled = true;
			}
		}

		private void phone_maskedTextBox_MouseClick_1(object sender, MouseEventArgs e)
		{
			phone_maskedTextBox.SelectionStart = 0;
		}
	}
}
