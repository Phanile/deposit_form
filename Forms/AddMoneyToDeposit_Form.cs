using deposit_app.DataBase;

namespace deposit_app.Forms
{
	public partial class AddMoneyToDeposit_Form : Form
	{
		private string _depositId;
		public AddMoneyToDeposit_Form(string depositId)
		{
			InitializeComponent();
			_depositId = depositId;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (decimal.TryParse(textBox1.Text, out decimal result))
			{
				if (result == 0)
				{
					MessageBox.Show("Сумма депозита не может быть 0");
				}

				if (result < 0)
				{
					MessageBox.Show("Сумма депозита не может быть отрицательной");
				}

				if (result > 0)
				{
					Db.AddMoneyToDeposit(_depositId, result);
					Close();
				}
			}
			else
			{
				MessageBox.Show("Введите корректную сумму депозита");
			}
		}
	}
}
