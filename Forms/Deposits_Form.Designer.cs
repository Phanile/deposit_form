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
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientDepositsDataGridView).BeginInit();
            panel1.SuspendLayout();
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
            ViewDepositsButton.Location = new Point(12, 75);
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
            AddDepositButton.Location = new Point(265, 75);
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
            DepositHistoryButton.Location = new Point(529, 75);
            DepositHistoryButton.Margin = new Padding(3, 4, 3, 4);
            DepositHistoryButton.Name = "DepositHistoryButton";
            DepositHistoryButton.Size = new Size(189, 89);
            DepositHistoryButton.TabIndex = 3;
            DepositHistoryButton.Text = "История вклада";
            DepositHistoryButton.UseVisualStyleBackColor = true;
            DepositHistoryButton.Click += DepositHistoryButton_Click;
            // 
            // DeleteDeposit
            // 
            DeleteDeposit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteDeposit.Location = new Point(781, 75);
            DeleteDeposit.Margin = new Padding(3, 4, 3, 4);
            DeleteDeposit.Name = "DeleteDeposit";
            DeleteDeposit.Size = new Size(189, 89);
            DeleteDeposit.TabIndex = 4;
            DeleteDeposit.Text = "Удалить вклад";
            DeleteDeposit.UseVisualStyleBackColor = true;
            DeleteDeposit.Click += DeleteDeposit_Click;
            // 
            // clientsDataGridView
            // 
            clientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsDataGridView.Location = new Point(265, 212);
            clientsDataGridView.Margin = new Padding(3, 4, 3, 4);
            clientsDataGridView.Name = "clientsDataGridView";
            clientsDataGridView.RowHeadersWidth = 51;
            clientsDataGridView.RowTemplate.Height = 24;
            clientsDataGridView.Size = new Size(705, 466);
            clientsDataGridView.TabIndex = 5;
            clientsDataGridView.CellMouseClick += clientsDataGridView_CellMouseClick;
            // 
            // clientDepositsDataGridView
            // 
            clientDepositsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientDepositsDataGridView.Location = new Point(12, 212);
            clientDepositsDataGridView.Margin = new Padding(3, 4, 3, 4);
            clientDepositsDataGridView.Name = "clientDepositsDataGridView";
            clientDepositsDataGridView.RowHeadersWidth = 51;
            clientDepositsDataGridView.RowTemplate.Height = 24;
            clientDepositsDataGridView.Size = new Size(234, 464);
            clientDepositsDataGridView.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 57);
            panel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(265, 183);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 8;
            label2.Text = "Клиенты";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 183);
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
            Controls.Add(DeleteDeposit);
            Controls.Add(DepositHistoryButton);
            Controls.Add(AddDepositButton);
            Controls.Add(ViewDepositsButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Deposits_Form";
            Text = "Deposits_Form";
            Load += Deposits_Form_Load;
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientDepositsDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}