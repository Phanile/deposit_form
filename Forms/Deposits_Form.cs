using deposit_app.DataBase;

namespace deposit_app.Forms
{
    public partial class Deposits_Form : Form
    {
        public Deposits_Form()
        {
            InitializeComponent();
        }

        private void Deposits_Form_Load(object sender, System.EventArgs e)
        {
            clientDepositsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clientsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var clients = Db.GetClients();
            clientsDataGridView.DataSource = clients;
            clientsDataGridView.Columns["id"].Visible = false;
            clientsDataGridView.Columns["password"].Visible = false;
        }

        private void ViewDepositsButton_Click(object sender, System.EventArgs e)
        {
            if (clientsDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Ошибка! Выберите любое поле клиента в таблице \"Клиенты\"");
                return;
            }

            var clientPassportData = clientsDataGridView.CurrentRow.Cells[7].Value.ToString();
            var clientDeposits = Db.GetDepositsByClientPassportData(clientPassportData);
            clientDepositsDataGridView.DataSource = clientDeposits;
            clientDepositsDataGridView.Columns["id"].Visible = false;
            clientDepositsDataGridView.Columns["client_id"].Visible = false;
        }

        private void AddDepositButton_Click(object sender, System.EventArgs e)
        {
            AddDeposit_Form form = new AddDeposit_Form();
            form.Show();
        }

        private void DepositHistoryButton_Click(object sender, System.EventArgs e)
        {
            panel2.Visible = true;
            var histories = Db.GetTransactionHistories();
            transactionHistoryGridView.DataSource = histories;
        }

        private void CloseDeposit_Click(object sender, System.EventArgs e)
        {
            if (clientsDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Ошибка! Выберите любое поле вклада в таблице \"Вклады клиента\"");
                return;
            }
            if (clientDepositsDataGridView.CurrentRow.Cells[5].Value.ToString() == "Закрыт")
            {
                MessageBox.Show("Ошибка! Вклад уже закрыт");
                return;
            }
            var depositPersonalAccount = clientDepositsDataGridView.CurrentRow.Cells[5].Value.ToString();
            Db.CloseDeposit(depositPersonalAccount);
            RedrawDeposits();
        }

        private void clientsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


        }

        private void button_back_from_transaction_history_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clientDepositsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void RedrawDeposits()
        {
            if (clientsDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Ошибка! Выберите любое поле клиента в таблице \"Клиенты\"");
                return;
            }

            var clientPassportData = clientsDataGridView.CurrentRow.Cells[7].Value.ToString();
            var clientDeposits = Db.GetDepositsByClientPassportData(clientPassportData);
            clientDepositsDataGridView.DataSource = clientDeposits;
            clientDepositsDataGridView.Columns["id"].Visible = false;
            clientDepositsDataGridView.Columns["client_id"].Visible = false;
        }
    }
}
