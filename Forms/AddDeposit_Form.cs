using deposit_app.DataBase;
using System.Text.RegularExpressions;

namespace deposit_app.Forms
{
	public partial class AddDeposit_Form : Form
	{
		private string? _email;
		public AddDeposit_Form(string? email)
		{
			InitializeComponent();
			_email = email;
			email_textBox.Text = _email;
		}

		private void SaveChange_btn_Click(object sender, EventArgs e)
		{
			string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
			Regex emailRegex = new Regex(emailPattern, RegexOptions.IgnoreCase);

			string email = email_textBox.Text;
			if (email == null || email.Length == 0)
			{
				MessageBox.Show("Заполните поле email");
				return;
			}
			else if (!emailRegex.IsMatch(email))
			{
				MessageBox.Show("Неправильно введена электронная почта");
				return;
			}

			string depositType = depositTypes_textbox.Text;
			if (string.IsNullOrWhiteSpace(depositType))
			{
				MessageBox.Show("Выберите тип вклада");
				return;
			}

			string currency = curr_textbox.Text;
			if (string.IsNullOrWhiteSpace(currency))
			{
				MessageBox.Show("Выберите тип валюты");
				return;
			}

			string status = "Открыт";
			if (string.IsNullOrEmpty(personalAccount_maskedTextBox1.Text))
			{
				MessageBox.Show("Введите лицевой счёт");
				return;
			}

			string personalAccount = personalAccount_maskedTextBox1.Text;

			decimal initialBalance;
			if (!decimal.TryParse(startBalance_textbox.Text, out initialBalance))
			{
				MessageBox.Show("Неправильно введён начальный баланс");
				return;
			}
			else if (initialBalance == null)
			{
				MessageBox.Show("Введите начальный баланс");
				return;
			}
			decimal currBalance = initialBalance;
			DateTime openDate = DateTime.Today;//DateTime.Parse(start_dateTimePicker.Text);

			//DateTime? closeDate = DBNull.Value;
			short timeframe;
			if (string.IsNullOrEmpty(duration_textBox.Text))
			{
				MessageBox.Show("Введите продолжительность вклада");
				return;
			}
			else if(!short.TryParse(duration_textBox.Text, out timeframe))
			{
				MessageBox.Show("Неправильно введена продолжительность");
				return;
			}

			Db.AddDeposit(email, depositType, currency, status, personalAccount, initialBalance, currBalance, openDate, DBNull.Value, timeframe);
			this.Close();
		}

		private void email_textBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void startBalance_textbox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
