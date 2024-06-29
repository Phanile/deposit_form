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
        private void Surname_textBox_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void FirstName_textBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void patronymik_textBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void BirthDay_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
        private void Phone_textBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Email_textBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void PassportData_textBox_TextChanged(object sender, EventArgs e)
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
			string first_name = FirstName_textBox.Text;

			if (string.IsNullOrWhiteSpace(first_name))
			{
				MessageBox.Show("Введите имя клиента");
			}
			string patronymiс = patronymik_textBox.Text;

			if (string.IsNullOrWhiteSpace(patronymiс))
			{
				MessageBox.Show("Введите отчество клиента");
			}
			DateTime birthday = BirthDay_dateTimePicker.Value;

            string phone = Phone_textBox.Text;

			if (string.IsNullOrWhiteSpace(phone))
			{
				MessageBox.Show("Введите номер телефона клиента");
			}
			string email = Email_textBox.Text;

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
    }
}
