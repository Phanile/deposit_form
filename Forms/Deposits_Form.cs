using deposit_app.Const;
using deposit_app.DataBase;
using System.Windows.Forms;

namespace deposit_app.Forms
{
    public partial class Deposits_Form : Form
    {
        private AddDeposit_Form? _form;
        private AddClient_Form? _addClientForm;

        public Deposits_Form()
        {
            InitializeComponent();
            ToolStripMenuItem showHistoryMenuItem = new ToolStripMenuItem("Показать историю транзакций вклада");
            showHistoryMenuItem.Click += ShowDepositTransactionHistory;
            contextMenuStrip1.Items.Add(showHistoryMenuItem);
        }

        private void Deposits_Form_Load(object sender, System.EventArgs e)
        {
            clientDepositsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clientsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            RedrawClients();
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

        private void clientDepositsDataGridView_MouseDown(object sender, MouseEventArgs e)
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

        private void ShowDepositTransactionHistory(object sender, EventArgs e)
        {
            var depositId = clientDepositsDataGridView.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void addClientButton_Click(object sender, EventArgs e)
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
    }
}
