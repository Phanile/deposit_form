using deposit_app.DataBase;

namespace deposit_app.Forms
{
	public partial class TakeMoneyForm : Form
	{
		private string _depositId;
		private DataGridViewCell _cellToUpdate;

		public TakeMoneyForm(string depositId, DataGridViewCell cellToUpdate)
		{
			InitializeComponent();
			_depositId = depositId;
			_cellToUpdate = cellToUpdate;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (decimal.TryParse(textBox1.Text, out decimal result))
			{
				if (result == 0)
				{
					MessageBox.Show("Сумма снятия не может быть 0");
					return;
				}

				if (result < 0)
				{
					MessageBox.Show("Сумма снятия не может быть отрицательной");
					return;
				}

				if (result > 0)
				{
					Db.TakeMoneyFromDeposit(_depositId, result);
					_cellToUpdate.Value = decimal.Parse(_cellToUpdate.Value.ToString()) - result;
					Close();
				}
			}
			else
			{
				MessageBox.Show("Введите корректный депозит");
			}
		}
	}
}
