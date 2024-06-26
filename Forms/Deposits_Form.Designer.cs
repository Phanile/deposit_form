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
            this.label1 = new System.Windows.Forms.Label();
            this.ViewDepositsButton = new System.Windows.Forms.Button();
            this.AddDepositButton = new System.Windows.Forms.Button();
            this.DepositHistoryButton = new System.Windows.Forms.Button();
            this.DeleteDeposit = new System.Windows.Forms.Button();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.clientDepositsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDepositsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "АИС \"Учет вкладов в банке\"";
            // 
            // ViewDepositsButton
            // 
            this.ViewDepositsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewDepositsButton.Location = new System.Drawing.Point(12, 74);
            this.ViewDepositsButton.Name = "ViewDepositsButton";
            this.ViewDepositsButton.Size = new System.Drawing.Size(189, 71);
            this.ViewDepositsButton.TabIndex = 1;
            this.ViewDepositsButton.Text = "Показать вклады";
            this.ViewDepositsButton.UseVisualStyleBackColor = true;
            this.ViewDepositsButton.Click += new System.EventHandler(this.ViewDepositsButton_Click);
            // 
            // AddDepositButton
            // 
            this.AddDepositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDepositButton.Location = new System.Drawing.Point(265, 74);
            this.AddDepositButton.Name = "AddDepositButton";
            this.AddDepositButton.Size = new System.Drawing.Size(189, 71);
            this.AddDepositButton.TabIndex = 2;
            this.AddDepositButton.Text = "Добавить вклад";
            this.AddDepositButton.UseVisualStyleBackColor = true;
            this.AddDepositButton.Click += new System.EventHandler(this.AddDepositButton_Click);
            // 
            // DepositHistoryButton
            // 
            this.DepositHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepositHistoryButton.Location = new System.Drawing.Point(529, 74);
            this.DepositHistoryButton.Name = "DepositHistoryButton";
            this.DepositHistoryButton.Size = new System.Drawing.Size(189, 71);
            this.DepositHistoryButton.TabIndex = 3;
            this.DepositHistoryButton.Text = "История вклада";
            this.DepositHistoryButton.UseVisualStyleBackColor = true;
            this.DepositHistoryButton.Click += new System.EventHandler(this.DepositHistoryButton_Click);
            // 
            // DeleteDeposit
            // 
            this.DeleteDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteDeposit.Location = new System.Drawing.Point(781, 74);
            this.DeleteDeposit.Name = "DeleteDeposit";
            this.DeleteDeposit.Size = new System.Drawing.Size(189, 71);
            this.DeleteDeposit.TabIndex = 4;
            this.DeleteDeposit.Text = "Удалить вклад";
            this.DeleteDeposit.UseVisualStyleBackColor = true;
            this.DeleteDeposit.Click += new System.EventHandler(this.DeleteDeposit_Click);
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Location = new System.Drawing.Point(265, 185);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.RowHeadersWidth = 51;
            this.clientsDataGridView.RowTemplate.Height = 24;
            this.clientsDataGridView.Size = new System.Drawing.Size(705, 356);
            this.clientsDataGridView.TabIndex = 5;
            // 
            // clientDepositsDataGridView
            // 
            this.clientDepositsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDepositsDataGridView.Location = new System.Drawing.Point(12, 185);
            this.clientDepositsDataGridView.Name = "clientDepositsDataGridView";
            this.clientDepositsDataGridView.RowHeadersWidth = 51;
            this.clientDepositsDataGridView.RowTemplate.Height = 24;
            this.clientDepositsDataGridView.Size = new System.Drawing.Size(234, 356);
            this.clientDepositsDataGridView.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 53);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(260, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Клиенты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Вклады клиента";
            // 
            // Deposits_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clientDepositsDataGridView);
            this.Controls.Add(this.clientsDataGridView);
            this.Controls.Add(this.DeleteDeposit);
            this.Controls.Add(this.DepositHistoryButton);
            this.Controls.Add(this.AddDepositButton);
            this.Controls.Add(this.ViewDepositsButton);
            this.Name = "Deposits_Form";
            this.Text = "Deposits_Form";
            this.Load += new System.EventHandler(this.Deposits_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDepositsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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