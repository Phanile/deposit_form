using System.Configuration;
using System.Windows.Forms;
using deposit_app.DataBase;
using Npgsql;

namespace deposit_app.Forms
{
    public partial class Deposits_Form : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["pgConnection"].ConnectionString;

        public Deposits_Form()
        {
            InitializeComponent();
        }

        private void Deposits_Form_Load(object sender, System.EventArgs e)
        {
            var clients = Db.GetClients();
            clientsDataGridView.DataSource = clients;
            clientsDataGridView.Columns["id"].Visible = false;
            clientsDataGridView.Columns["password"].Visible = false;
        }

        private void ViewDepositsButton_Click(object sender, System.EventArgs e)
        {
            var clientPassportData = clientsDataGridView.CurrentRow.Cells[7].Value.ToString();
            var clientDeposits = Db.GetDepositsByClientPassportData(clientPassportData);
            clientDepositsDataGridView.DataSource = clientDeposits;
            clientDepositsDataGridView.Columns["id"].Visible = false;
            clientDepositsDataGridView.Columns["client_id"].Visible = false;
        }

        private void AddDepositButton_Click(object sender, System.EventArgs e)
        {

        }

        private void DepositHistoryButton_Click(object sender, System.EventArgs e)
        {

        }

        private void DeleteDeposit_Click(object sender, System.EventArgs e)
        {

        }

        private void clientsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

        }
    }
}
