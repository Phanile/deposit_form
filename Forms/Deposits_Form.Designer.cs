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
            CloseDeposit = new Button();
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
            label1.Location = new Point(293, 11);
            label1.Name = "label1";
            label1.Size = new Size(410, 32);
            label1.TabIndex = 0;
            label1.Text = "АИС \"Учет вкладов в банке\"";
            // 
            // ViewDepositsButton
            // 
            ViewDepositsButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ViewDepositsButton.Location = new Point(10, 75);
            ViewDepositsButton.Margin = new Padding(3, 4, 3, 4);
            ViewDepositsButton.Name = "ViewDepositsButton";
            ViewDepositsButton.Size = new Size(189, 89);
            ViewDepositsButton.TabIndex = 1;
            ViewDepositsButton.Text = "Показать вклады";
            ViewDepositsButton.UseVisualStyleBackColor = true;
            ViewDepositsButton.Click += ViewDepositsButton_Click;
            // 
            // AddDepositButton
            // 
            AddDepositButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddDepositButton.Location = new Point(264, 75);
            AddDepositButton.Margin = new Padding(3, 4, 3, 4);
            AddDepositButton.Name = "AddDepositButton";
            AddDepositButton.Size = new Size(189, 89);
            AddDepositButton.TabIndex = 2;
            AddDepositButton.Text = "Добавить вклад";
            AddDepositButton.UseVisualStyleBackColor = true;
            AddDepositButton.Click += AddDepositButton_Click;
            // 
            // DepositHistoryButton
            // 
            DepositHistoryButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DepositHistoryButton.Location = new Point(528, 75);
            DepositHistoryButton.Margin = new Padding(3, 4, 3, 4);
            DepositHistoryButton.Name = "DepositHistoryButton";
            DepositHistoryButton.Size = new Size(189, 89);
            DepositHistoryButton.TabIndex = 3;
            DepositHistoryButton.Text = "История по всем вкладам";
            DepositHistoryButton.UseVisualStyleBackColor = true;
            DepositHistoryButton.Click += DepositHistoryButton_Click;
            // 
            // CloseDeposit
            // 
            CloseDeposit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CloseDeposit.Location = new Point(780, 75);
            CloseDeposit.Margin = new Padding(3, 4, 3, 4);
            CloseDeposit.Name = "CloseDeposit";
            CloseDeposit.Size = new Size(189, 89);
            CloseDeposit.TabIndex = 4;
            CloseDeposit.Text = "Закрыть вклад";
            CloseDeposit.UseVisualStyleBackColor = true;
            CloseDeposit.Click += CloseDeposit_Click;
            // 
            // clientsDataGridView
            // 
            clientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsDataGridView.Location = new Point(11, 200);
            clientsDataGridView.Margin = new Padding(3, 4, 3, 4);
            clientsDataGridView.Name = "clientsDataGridView";
            clientsDataGridView.RowHeadersWidth = 51;
            clientsDataGridView.RowTemplate.Height = 24;
            clientsDataGridView.Size = new Size(958, 258);
            clientsDataGridView.TabIndex = 5;
            // 
            // clientDepositsDataGridView
            // 
            clientDepositsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientDepositsDataGridView.Location = new Point(11, 499);
            clientDepositsDataGridView.Margin = new Padding(3, 4, 3, 4);
            clientDepositsDataGridView.Name = "clientDepositsDataGridView";
            clientDepositsDataGridView.RowHeadersWidth = 51;
            clientDepositsDataGridView.RowTemplate.Height = 24;
            clientDepositsDataGridView.Size = new Size(959, 177);
            clientDepositsDataGridView.TabIndex = 6;
            clientDepositsDataGridView.CellMouseClick += clientDepositsDataGridView_CellMouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 53);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(button_back_from_transaction_history);
            panel2.Controls.Add(transactionHistoryGridView);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(978, 629);
            panel2.TabIndex = 20;
            panel2.Visible = false;
            // 
            // button_back_from_transaction_history
            // 
            button_back_from_transaction_history.Location = new Point(58, 85);
            button_back_from_transaction_history.Margin = new Padding(3, 4, 3, 4);
            button_back_from_transaction_history.Name = "button_back_from_transaction_history";
            button_back_from_transaction_history.Size = new Size(225, 137);
            button_back_from_transaction_history.TabIndex = 1;
            button_back_from_transaction_history.Text = "Назад в меню";
            button_back_from_transaction_history.UseVisualStyleBackColor = true;
            button_back_from_transaction_history.Click += button_back_from_transaction_history_Click;
            // 
            // transactionHistoryGridView
            // 
            transactionHistoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionHistoryGridView.Location = new Point(432, 144);
            transactionHistoryGridView.Margin = new Padding(3, 4, 3, 4);
            transactionHistoryGridView.Name = "transactionHistoryGridView";
            transactionHistoryGridView.RowHeadersWidth = 51;
            transactionHistoryGridView.Size = new Size(489, 325);
            transactionHistoryGridView.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(11, 171);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 8;
            label2.Text = "Клиенты";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(11, 470);
            label3.Name = "label3";
            label3.Size = new Size(164, 25);
            label3.TabIndex = 9;
            label3.Text = "Вклады клиента";
            // 
            // Deposits_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 691);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(clientDepositsDataGridView);
            Controls.Add(clientsDataGridView);
            Controls.Add(CloseDeposit);
            Controls.Add(DepositHistoryButton);
            Controls.Add(AddDepositButton);
            Controls.Add(ViewDepositsButton);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button CloseDeposit;
    }
}