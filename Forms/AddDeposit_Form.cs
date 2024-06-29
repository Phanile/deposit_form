using deposit_app.DataBase;

namespace deposit_app.Forms
{
	public partial class AddDeposit_Form : Form
	{
		public AddDeposit_Form()
		{
			InitializeComponent();
		}

		private void SaveChange_btn_Click(object sender, EventArgs e)
		{

			string email = email_textBox.Text;
			if (email == null || email.Length == 0)
			{
				MessageBox.Show("Заполните поле email");
				return;
			}
			string depositType = depositTypes_textbox.Text;
			if (depositType == null || depositType.Length == 0)
			{
				MessageBox.Show("Выберите тип вклада");
				return;
			}
			string currency = curr_textbox.Text;
			if (currency == null)
			{
				MessageBox.Show("Выберите тип валюты");
				return;
			}
			string status = "Открыт";
			if (string.IsNullOrEmpty(personalBalance_textbox.Text))
			{
				MessageBox.Show("Введите лицевой счёт");
				return;
			}
			string personalAccount = personalBalance_textbox.Text;

			decimal initialBalance = decimal.Parse(startBalance_textbox.Text);

			if (initialBalance == null)
			{
				MessageBox.Show("Введите начальный баланс");
				return;
			}
			decimal currBalance = initialBalance;
			DateTime openDate = DateTime.Today;//DateTime.Parse(start_dateTimePicker.Text);

			//DateTime? closeDate = DBNull.Value;
			if (string.IsNullOrEmpty(duration_textBox.Text))
			{
				MessageBox.Show("Введите продолжительность вклада");
				return;
			}
			short timeframe = short.Parse(duration_textBox.Text);

			Db.AddDeposit(email, depositType, currency, status, personalAccount, initialBalance, currBalance, openDate, DBNull.Value, timeframe);
			this.Close();
		}

		private void email_textBox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
