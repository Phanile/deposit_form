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
    }
}
