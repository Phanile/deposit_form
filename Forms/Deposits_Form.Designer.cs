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
			label1 = new Label();
			ViewDepositsButton = new Button();
			AddDepositButton = new Button();
			DepositHistoryButton = new Button();
			DeleteDeposit = new Button();
			clientsDataGridView = new DataGridView();
			clientDepositsDataGridView = new DataGridView();
			panel1 = new Panel();
			panel2 = new Panel();
			button_back_from_transaction_history = new Button();
			transactionHistoryGridView = new DataGridView();
			label2 = new Label();
			label3 = new Label();
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
			ViewDepositsButton.Location = new Point(10, 69);
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
			AddDepositButton.Location = new Point(232, 69);
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
			DepositHistoryButton.Location = new Point(463, 69);
			DepositHistoryButton.Name = "DepositHistoryButton";
			DepositHistoryButton.Size = new Size(165, 67);
			DepositHistoryButton.TabIndex = 3;
			DepositHistoryButton.Text = "История по всем вкладам";
			DepositHistoryButton.UseVisualStyleBackColor = true;
			DepositHistoryButton.Click += DepositHistoryButton_Click;
			// 
			// DeleteDeposit
			// 
			DeleteDeposit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			DeleteDeposit.Location = new Point(683, 69);
			DeleteDeposit.Name = "DeleteDeposit";
			DeleteDeposit.Size = new Size(165, 67);
			DeleteDeposit.TabIndex = 4;
			DeleteDeposit.Text = "Удалить вклад";
			DeleteDeposit.UseVisualStyleBackColor = true;
			DeleteDeposit.Click += DeleteDeposit_Click;
			// 
			// clientsDataGridView
			// 
			clientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			clientsDataGridView.Location = new Point(232, 173);
			clientsDataGridView.Name = "clientsDataGridView";
			clientsDataGridView.RowHeadersWidth = 51;
			clientsDataGridView.RowTemplate.Height = 24;
			clientsDataGridView.Size = new Size(617, 334);
			clientsDataGridView.TabIndex = 5;
			// 
			// clientDepositsDataGridView
			// 
			clientDepositsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			clientDepositsDataGridView.Location = new Point(10, 173);
			clientDepositsDataGridView.Name = "clientDepositsDataGridView";
			clientDepositsDataGridView.RowHeadersWidth = 51;
			clientDepositsDataGridView.RowTemplate.Height = 24;
			clientDepositsDataGridView.Size = new Size(205, 334);
			clientDepositsDataGridView.TabIndex = 6;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ActiveCaption;
			panel1.Controls.Add(label1);
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(859, 50);
			panel1.TabIndex = 7;
			// 
			// panel2
			// 
			panel2.Controls.Add(button_back_from_transaction_history);
			panel2.Controls.Add(transactionHistoryGridView);
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(859, 520);
			panel2.TabIndex = 20;
			panel2.Visible = false;
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
			transactionHistoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			transactionHistoryGridView.Location = new Point(378, 108);
			transactionHistoryGridView.Name = "transactionHistoryGridView";
			transactionHistoryGridView.Size = new Size(428, 244);
			transactionHistoryGridView.TabIndex = 0;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label2.Location = new Point(228, 147);
			label2.Name = "label2";
			label2.Size = new Size(76, 20);
			label2.TabIndex = 8;
			label2.Text = "Клиенты";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label3.Location = new Point(6, 147);
			label3.Name = "label3";
			label3.Size = new Size(136, 20);
			label3.TabIndex = 9;
			label3.Text = "Вклады клиента";
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
			Controls.Add(DeleteDeposit);
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
	}
}