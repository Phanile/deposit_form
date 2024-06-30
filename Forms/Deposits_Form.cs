using deposit_app.Const;
using deposit_app.DataBase;
using System.Windows.Forms;

namespace deposit_app.Forms
{
	public partial class Deposits_Form : Form
	{
		private AddDeposit_Form? _form;
		private AddClient_Form? _addClientForm;
		private AddMoneyToDeposit_Form? _addMoneyForm;
		private EditClient_Form? _editClientForm;
		public Deposits_Form()
		{
			InitializeComponent();
			ToolStripMenuItem showHistoryMenuItem = new ToolStripMenuItem("Показать историю транзакций вклада");
			ToolStripMenuItem showEditMenuItem = new ToolStripMenuItem("Редактирование");
			showHistoryMenuItem.Click += ShowDepositTransactionHistory;
			showEditMenuItem.Click += ShowEditClientsForm;
			contextMenuStrip2.Items.Add(showEditMenuItem);
			ToolStripMenuItem closeDepositMenuItem = new ToolStripMenuItem("Закрыть вклад");
			ToolStripMenuItem addMoneyToDepositMenuItem = new ToolStripMenuItem("Пополнить вклад");
			ToolStripMenuItem takeMoneyFromDepositMenuItem = new ToolStripMenuItem("Снять деньги со вклада");
			closeDepositMenuItem.Click += CloseDeposit_Click;
			addMoneyToDepositMenuItem.Click += AddMoneyToDeposit;
			contextMenuStrip1.Items.Add(showHistoryMenuItem);
			contextMenuStrip1.Items.Add(closeDepositMenuItem);
			contextMenuStrip1.Items.Add(addMoneyToDepositMenuItem);
			contextMenuStrip1.Items.Add(takeMoneyFromDepositMenuItem);
		}

		private void Deposits_Form_Load(object sender, System.EventArgs e)
		{
			clientDepositsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			clientsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			var clients = Db.GetClients();
			clientsDataGridView.DataSource = clients;
			clientsDataGridView.Columns["id"].Visible = false;
		}

		private void ViewDepositsButton_Click(object sender, System.EventArgs e)
		{
			if (clientsDataGridView.CurrentRow == null)
			{
				MessageBox.Show("Ошибка! Выберите любое поле клиента в таблице \"Клиенты\"");
				return;
			}

			var clientPassportData = clientsDataGridView.CurrentRow.Cells[7].Value.ToString();

			if (clientPassportData != null)
			{
				var clientDeposits = Db.GetDepositsByClientPassportData(clientPassportData);
				clientDepositsDataGridView.DataSource = clientDeposits;
				clientDepositsDataGridView.Columns["id"].Visible = false;
				clientDepositsDataGridView.Columns["client_id"].Visible = false;
			}
		}

		private void AddDepositButton_Click(object sender, System.EventArgs e)
		{
			if (_form == null || _form.IsDisposed)
			{
				_form = new AddDeposit_Form();
				_form.Show();
			}
			else
			{
				_form.Show();
				_form.Focus();
			}
		}

		private void DepositHistoryButton_Click(object sender, System.EventArgs e)
		{
			textBox1.Visible = false;
			panel2.Visible = true;
			var histories = Db.GetTransactionHistories();
			transactionHistoryGridView.DataSource = histories;
		}

		private void CloseDeposit_Click(object sender, System.EventArgs e)
		{
			if (clientDepositsDataGridView.CurrentRow == null)
			{
				MessageBox.Show("Ошибка! Выберите любое поле вклада в таблице \"Вклады клиента\"");
				return;
			}

			if (clientDepositsDataGridView.CurrentRow.Cells[4].Value.ToString() == DepositStatusConstants.DepositCloseStatus)
			{
				MessageBox.Show("Ошибка! Вклад уже закрыт");
				return;
			}

			var depositPersonalAccount = clientDepositsDataGridView.CurrentRow.Cells[5].Value.ToString();

			if (depositPersonalAccount != null)
			{
				Db.CloseDeposit(depositPersonalAccount);
				RedrawDeposits();
			}
		}

		private void button_back_from_transaction_history_Click(object sender, EventArgs e)
		{
			panel2.Visible = false;
		}

		private void RedrawDeposits()
		{
			if (clientsDataGridView.CurrentRow == null)
			{
				MessageBox.Show("Ошибка! Выберите любое поле клиента в таблице \"Клиенты\"");
				return;
			}

			var clientPassportData = clientsDataGridView.CurrentRow.Cells[7].Value.ToString();

			if (clientPassportData != null)
			{
				var clientDeposits = Db.GetDepositsByClientPassportData(clientPassportData);
				clientDepositsDataGridView.DataSource = clientDeposits;
				clientDepositsDataGridView.Columns["id"].Visible = false;
				clientDepositsDataGridView.Columns["client_id"].Visible = false;
			}
		}

		private void RedrawClients()
		{
			var clients = Db.GetClients();
			clientsDataGridView.DataSource = clients;
			clientsDataGridView.Columns["id"].Visible = false;

			clientsDataGridView.Columns["surname"].HeaderText = "Фамилия";
			clientsDataGridView.Columns["first_name"].HeaderText = "Имя";
			clientsDataGridView.Columns["patronymic"].HeaderText = "Отчество";
			clientsDataGridView.Columns["birth_date"].HeaderText = "Дата рожд.";
			clientsDataGridView.Columns["phone"].HeaderText = "Телефон";
			clientsDataGridView.Columns["email"].HeaderText = "Почта";
			clientsDataGridView.Columns["passport_data"].HeaderText = "Паспорт";
		}

		private void AddClientButton_Click(object sender, EventArgs e)
		{
			if (_addClientForm == null || _addClientForm.IsDisposed)
			{
				_addClientForm = new AddClient_Form();
				_addClientForm.ClientAdded += FormAddClient_ClientAdded;
				_addClientForm.Show();
			}
			else
			{
				_addClientForm.ClientAdded += FormAddClient_ClientAdded;
				_addClientForm.Show();
				_addClientForm.Focus();
			}

		}

		private void FormAddClient_ClientAdded(object sender, EventArgs e)
		{
			RedrawClients();
		}
		private void FormEditClient_ClientEdit(object sender, EventArgs e)
		{
			RedrawClients();
		}

		private void ClientDepositsDataGridView_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				var hit = clientDepositsDataGridView.HitTest(e.X, e.Y);
				if (hit.RowIndex >= 0)
				{
					clientDepositsDataGridView.ClearSelection();
					clientDepositsDataGridView.Rows[hit.RowIndex].Selected = true;
					contextMenuStrip1.Show(clientDepositsDataGridView, e.Location);
				}
			}
		}

		private void ClientsDataGridView_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				var hit = clientsDataGridView.HitTest(e.X, e.Y);
				if (hit.RowIndex >= 0)
				{
					clientsDataGridView.ClearSelection();
					clientsDataGridView.Rows[hit.RowIndex].Selected = true;
					contextMenuStrip2.Show(clientsDataGridView, e.Location);
				}
			}
		}

		private void ShowDepositTransactionHistory(object sender, EventArgs e)
		{
			var depositId = clientDepositsDataGridView.SelectedRows[0]?.Cells[0]?.Value?.ToString();

			if (depositId == null)
			{
				MessageBox.Show("Не найден ID вклада");
			}
			else
			{
				panel2.Visible = true;
				var histories = Db.GetTransactionHistoriesByDepositId(depositId);

				if (histories.Count > 0)
				{
					textBox1.Visible = false;
					transactionHistoryGridView.Visible = true;
					transactionHistoryGridView.DataSource = histories;
				}
				else
				{
					transactionHistoryGridView.Visible = false;
					textBox1.Visible = true;
				}
			}
		}

		private void ShowEditClientsForm(object sender, EventArgs e)
		{
			var clientId = clientsDataGridView.SelectedRows[0]?.Cells[0]?.Value?.ToString();
			if (clientId == null)
			{
				MessageBox.Show("Не найден ID клиента");
			}
			else
			{
				
				if (_editClientForm == null || _editClientForm.IsDisposed)
				{
					
					_editClientForm = new EditClient_Form();
					DataGridViewRow selectRow = clientsDataGridView.SelectedRows[0];
					_editClientForm.Surname_textBox.Text = selectRow.Cells["surname"].Value.ToString();
					_editClientForm.firstname_textBox.Text = selectRow.Cells["first_name"].Value.ToString();
					_editClientForm.patronymic_textBox.Text = selectRow.Cells["patronymic"].Value.ToString();
					_editClientForm.BirthDay_dateTimePicker.Text = selectRow.Cells["birth_date"].Value.ToString();
					_editClientForm.phone_maskedTextBox.Text = selectRow.Cells["phone"].Value.ToString();
					_editClientForm.email_textBox.Text = selectRow.Cells["email"].Value.ToString();
					_editClientForm._passportData_textBox.Text = selectRow.Cells["passport_data"].Value.ToString();
					_editClientForm.ClientEdit += FormEditClient_ClientEdit;
					_editClientForm.Show();
				}
				else
				{
					_editClientForm.ClientEdit += FormEditClient_ClientEdit;
					_editClientForm.Show();
					_editClientForm.Focus();
				}
			}
		}

		private void AddMoneyToDeposit(object sender, EventArgs e)
		{
			var depositId = clientDepositsDataGridView.SelectedRows[0]?.Cells[0]?.Value?.ToString();

			if (depositId == null)
			{
				MessageBox.Show("Не найден ID вклада");
				return;
			}

			if (clientDepositsDataGridView.SelectedRows[0]?.Cells[4].Value.ToString() == DepositStatusConstants.DepositCloseStatus)
			{
				MessageBox.Show("Ошибка! Вклад уже закрыт");
				return;
			}

			if (clientDepositsDataGridView.SelectedRows[0]?.Cells[4].Value.ToString() == DepositStatusConstants.DepositFreezeStatus)
			{
				MessageBox.Show("Ошибка! Вклад заморожен");
				return;
			}

			if (_addMoneyForm == null || _addMoneyForm.IsDisposed)
			{
				_addMoneyForm = new AddMoneyToDeposit_Form(depositId);
				_addMoneyForm.Show();
			}
			else
			{
				_addMoneyForm.Show();
				_addMoneyForm.Focus();
			}
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		
	}
}
