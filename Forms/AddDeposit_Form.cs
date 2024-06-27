using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using deposit_app.DataBase;

namespace deposit_app.Forms
{
	public partial class AddDeposit_Form : Form
	{
		public AddDeposit_Form()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void AddDeposit_Form_Load(object sender, EventArgs e)
		{

		}

		private void SaveChange_btn_Click(object sender, EventArgs e)
		{
			string email = email_textBox.Text;
			string depositType = depositTypes_textbox.Text;
			string currency = curr_textbox.Text;
			string status = "Открыт"; // Not used in the procedure, hardcoded to 'Открыт'
			string personalAccount = personalBalance_textbox.Text;
			decimal initialBalance = decimal.Parse(startBalance_textbox.Text);
			decimal currBalance = decimal.Parse(CurrBallance_textbox.Text);
			DateTime openDate = DateTime.Parse(start_dateTimePicker.Text);
			DateTime closeDate = DateTime.Parse(Finish_dateTimePicker.Text);
			short timeframe = short.Parse(duration_textBox.Text);
			Db.AddDeposit(email, depositType, currency, status, personalAccount, initialBalance, currBalance, openDate, closeDate, timeframe);
			this.Close();
		}

		private void email_textBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void depositTypes_textbox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void curr_textbox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void startBalance_textbox_TextChanged(object sender, EventArgs e)
		{

		}

		private void personalBalance_textbox_TextChanged(object sender, EventArgs e)
		{

		}

		private void CurrBallance_textbox_TextChanged(object sender, EventArgs e)
		{

		}

		private void start_dateTimePicker_ValueChanged(object sender, EventArgs e)
		{

		}

		private void Finish_dateTimePicker_ValueChanged(object sender, EventArgs e)
		{

		}

		private void duration_textBox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
