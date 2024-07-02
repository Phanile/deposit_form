using deposit_app.DataBase;

namespace deposit_app.Forms
{
	public partial class AddMoneyToDeposit_Form : Form
	{
		private string _depositId;
		private decimal _maxBalance;
		private DataGridViewCell _cellToUpdate;

		public AddMoneyToDeposit_Form(string depositId, decimal maxBalance, DataGridViewCell cellToUpdate)
		{
			InitializeComponent();
			_depositId = depositId;
			_maxBalance = maxBalance;
			_cellToUpdate = cellToUpdate;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (decimal.TryParse(textBox1.Text, out decimal result))
			{
				if (result > _maxBalance)
				{
					MessageBox.Show("Сумма депозита не может превышать лимит для вклада данного типа");
					return;
				}

				if (result == 0)
				{
					MessageBox.Show("Сумма депозита не может быть 0");
					return;
				}

				if (result < 0)
				{
					MessageBox.Show("Сумма депозита не может быть отрицательной");
					return;
				}

				if (result > 0)
				{
					Db.AddMoneyToDeposit(_depositId, result);
					_cellToUpdate.Value = decimal.Parse(_cellToUpdate.Value.ToString()) + result;
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
