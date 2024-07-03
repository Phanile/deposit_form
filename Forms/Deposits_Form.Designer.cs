namespace deposit_app.Forms
{
    partial class Deposits_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			label1 = new Label();
			ViewDepositsButton = new Button();
			AddDepositButton = new Button();
			DepositHistoryButton = new Button();
			AddClient = new Button();
			clientsDataGridView = new DataGridView();
			clientDepositsDataGridView = new DataGridView();
			contextMenuStrip1 = new ContextMenuStrip(components);
			panel1 = new Panel();
			panel2 = new Panel();
			textBox1 = new TextBox();
			button_back_from_transaction_history = new Button();
			transactionHistoryGridView = new DataGridView();
			label2 = new Label();
			label3 = new Label();
			contextMenuStrip2 = new ContextMenuStrip(components);
			((System.ComponentModel.ISupportInitialize)clientsDataGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)clientDepositsDataGridView).BeginInit();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)transactionHistoryGridView).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
			label1.Location = new Point(256, 8);
			label1.Name = "label1";
			label1.Size = new Size(330, 26);
			label1.TabIndex = 0;
			label1.Text = "АИС \"Учет вкладов в банке\"";
			// 
			// ViewDepositsButton
			// 
			ViewDepositsButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			ViewDepositsButton.Location = new Point(9, 56);
			ViewDepositsButton.Name = "ViewDepositsButton";
			ViewDepositsButton.Size = new Size(165, 67);
			ViewDepositsButton.TabIndex = 1;
			ViewDepositsButton.Text = "Показать вклады";
			ViewDepositsButton.UseVisualStyleBackColor = true;
			ViewDepositsButton.Click += ViewDepositsButton_Click;
			// 
			// AddDepositButton
			// 
			AddDepositButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			AddDepositButton.Location = new Point(231, 56);
			AddDepositButton.Name = "AddDepositButton";
			AddDepositButton.Size = new Size(165, 67);
			AddDepositButton.TabIndex = 2;
			AddDepositButton.Text = "Добавить вклад";
			AddDepositButton.UseVisualStyleBackColor = true;
			AddDepositButton.Click += AddDepositButton_Click;
			// 
			// DepositHistoryButton
			// 
			DepositHistoryButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			DepositHistoryButton.Location = new Point(462, 56);
			DepositHistoryButton.Name = "DepositHistoryButton";
			DepositHistoryButton.Size = new Size(165, 67);
			DepositHistoryButton.TabIndex = 3;
			DepositHistoryButton.Text = "История по всем вкладам";
			DepositHistoryButton.UseVisualStyleBackColor = true;
			DepositHistoryButton.Click += DepositHistoryButton_Click;
			// 
			// AddClient
			// 
			AddClient.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			AddClient.Location = new Point(682, 56);
			AddClient.Name = "AddClient";
			AddClient.Size = new Size(165, 67);
			AddClient.TabIndex = 4;
			AddClient.Text = "Добавить клиента";
			AddClient.UseVisualStyleBackColor = true;
			AddClient.Click += AddClientButton_Click;
			// 
			// clientsDataGridView
			// 
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.ActiveBorder;
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			clientsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			clientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			clientsDataGridView.EnableHeadersVisualStyles = false;
			clientsDataGridView.Location = new Point(10, 150);
			clientsDataGridView.Name = "clientsDataGridView";
			clientsDataGridView.ReadOnly = true;
			clientsDataGridView.RowHeadersWidth = 51;
			clientsDataGridView.RowTemplate.Height = 24;
			clientsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			clientsDataGridView.Size = new Size(838, 194);
			clientsDataGridView.TabIndex = 5;
			clientsDataGridView.MouseDown += ClientsDataGridView_MouseDown;
			// 
			// clientDepositsDataGridView
			// 
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = SystemColors.ActiveBorder;
			dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			clientDepositsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			clientDepositsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			clientDepositsDataGridView.EnableHeadersVisualStyles = false;
			clientDepositsDataGridView.Location = new Point(10, 374);
			clientDepositsDataGridView.Name = "clientDepositsDataGridView";
			clientDepositsDataGridView.ReadOnly = true;
			clientDepositsDataGridView.RowHeadersWidth = 51;
			clientDepositsDataGridView.RowTemplate.Height = 24;
			clientDepositsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			clientDepositsDataGridView.Size = new Size(839, 133);
			clientDepositsDataGridView.TabIndex = 6;
			clientDepositsDataGridView.MouseDown += ClientDepositsDataGridView_MouseDown;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.ImageScalingSize = new Size(20, 20);
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(61, 4);
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ActiveCaption;
			panel1.Controls.Add(label1);
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(859, 40);
			panel1.TabIndex = 7;
			// 
			// panel2
			// 
			panel2.Controls.Add(textBox1);
			panel2.Controls.Add(button_back_from_transaction_history);
			panel2.Controls.Add(transactionHistoryGridView);
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(859, 526);
			panel2.TabIndex = 0;
			panel2.Visible = false;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(402, 105);
			textBox1.Name = "textBox1";
			textBox1.ReadOnly = true;
			textBox1.Size = new Size(237, 23);
			textBox1.TabIndex = 2;
			textBox1.Text = "У данного вклада нет истории транзакций";
			textBox1.Visible = false;
			// 
			// button_back_from_transaction_history
			// 
			button_back_from_transaction_history.Location = new Point(51, 64);
			button_back_from_transaction_history.Name = "button_back_from_transaction_history";
			button_back_from_transaction_history.Size = new Size(197, 103);
			button_back_from_transaction_history.TabIndex = 1;
			button_back_from_transaction_history.Text = "Назад в меню";
			button_back_from_transaction_history.UseVisualStyleBackColor = true;
			button_back_from_transaction_history.Click += button_back_from_transaction_history_Click;
			// 
			// transactionHistoryGridView
			// 
			transactionHistoryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			transactionHistoryGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedHeaders;
			transactionHistoryGridView.Location = new Point(51, 210);
			transactionHistoryGridView.Name = "transactionHistoryGridView";
			transactionHistoryGridView.ReadOnly = true;
			transactionHistoryGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			transactionHistoryGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			transactionHistoryGridView.Size = new Size(737, 244);
			transactionHistoryGridView.TabIndex = 0;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label2.Location = new Point(10, 128);
			label2.Name = "label2";
			label2.Size = new Size(76, 20);
			label2.TabIndex = 8;
			label2.Text = "Клиенты";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label3.Location = new Point(10, 352);
			label3.Name = "label3";
			label3.Size = new Size(136, 20);
			label3.TabIndex = 9;
			label3.Text = "Вклады клиента";
			// 
			// contextMenuStrip2
			// 
			contextMenuStrip2.ImageScalingSize = new Size(20, 20);
			contextMenuStrip2.Name = "contextMenuStrip2";
			contextMenuStrip2.Size = new Size(61, 4);
			// 
			// Deposits_Form
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(859, 518);
			Controls.Add(panel2);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(panel1);
			Controls.Add(clientDepositsDataGridView);
			Controls.Add(clientsDataGridView);
			Controls.Add(AddClient);
			Controls.Add(DepositHistoryButton);
			Controls.Add(AddDepositButton);
			Controls.Add(ViewDepositsButton);
			Name = "Deposits_Form";
			Text = "Deposits_Form";
			Load += Deposits_Form_Load;
			((System.ComponentModel.ISupportInitialize)clientsDataGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)clientDepositsDataGridView).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)transactionHistoryGridView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewDepositsButton;
        private System.Windows.Forms.Button AddDepositButton;
        private System.Windows.Forms.Button DepositHistoryButton;
        private System.Windows.Forms.Button DeleteDeposit;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.DataGridView clientDepositsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
		private Panel panel2;
		private DataGridView transactionHistoryGridView;
		private Button button_back_from_transaction_history;
        private Button AddClient;
		private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox1;
		private ContextMenuStrip contextMenuStrip2;
	}
}