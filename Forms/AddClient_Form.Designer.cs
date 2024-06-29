namespace deposit_app.Forms
{
    partial class AddClient_Form
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
			surname_textBox = new TextBox();
			label2 = new Label();
			firstname_textBox = new TextBox();
			label3 = new Label();
			patronymic_textBox = new TextBox();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			email_textBox = new TextBox();
			label7 = new Label();
			label8 = new Label();
			SaveChange_button = new Button();
			phone_maskedTextBox = new MaskedTextBox();
			birthDate_maskedTextBox = new MaskedTextBox();
			passportNumber_maskedTextBox = new MaskedTextBox();
			passportSeries_maskedTextBox = new MaskedTextBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
			label1.Location = new Point(84, 7);
			label1.Name = "label1";
			label1.Size = new Size(230, 32);
			label1.TabIndex = 1;
			label1.Text = "Добавить клиента";
			// 
			// surname_textBox
			// 
			surname_textBox.Location = new Point(28, 80);
			surname_textBox.MaxLength = 50;
			surname_textBox.Name = "surname_textBox";
			surname_textBox.Size = new Size(212, 23);
			surname_textBox.TabIndex = 13;
			surname_textBox.KeyPress += surname_textBox_KeyPress;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 11.25F);
			label2.ImageAlign = ContentAlignment.BottomRight;
			label2.Location = new Point(23, 58);
			label2.Name = "label2";
			label2.Size = new Size(73, 20);
			label2.TabIndex = 12;
			label2.Text = "Фамилия";
			// 
			// firstname_textBox
			// 
			firstname_textBox.Location = new Point(28, 124);
			firstname_textBox.MaxLength = 50;
			firstname_textBox.Name = "firstname_textBox";
			firstname_textBox.Size = new Size(212, 23);
			firstname_textBox.TabIndex = 15;
			firstname_textBox.KeyPress += firstname_textBox_KeyPress;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 11.25F);
			label3.ImageAlign = ContentAlignment.BottomRight;
			label3.Location = new Point(23, 103);
			label3.Name = "label3";
			label3.Size = new Size(39, 20);
			label3.TabIndex = 14;
			label3.Text = "Имя";
			// 
			// patronymic_textBox
			// 
			patronymic_textBox.Location = new Point(28, 170);
			patronymic_textBox.MaxLength = 50;
			patronymic_textBox.Name = "patronymic_textBox";
			patronymic_textBox.Size = new Size(212, 23);
			patronymic_textBox.TabIndex = 17;
			patronymic_textBox.KeyPress += patronymic_textBox_KeyPress;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 11.25F);
			label4.ImageAlign = ContentAlignment.BottomRight;
			label4.Location = new Point(23, 148);
			label4.Name = "label4";
			label4.Size = new Size(72, 20);
			label4.TabIndex = 16;
			label4.Text = "Отчество";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 11.25F);
			label5.ImageAlign = ContentAlignment.BottomRight;
			label5.Location = new Point(23, 193);
			label5.Name = "label5";
			label5.Size = new Size(116, 20);
			label5.TabIndex = 18;
			label5.Text = "Дата рождения";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 11.25F);
			label6.ImageAlign = ContentAlignment.BottomRight;
			label6.Location = new Point(23, 238);
			label6.Name = "label6";
			label6.Size = new Size(129, 20);
			label6.TabIndex = 20;
			label6.Text = "Телефон (без +7)";
			// 
			// email_textBox
			// 
			email_textBox.Location = new Point(28, 304);
			email_textBox.Name = "email_textBox";
			email_textBox.PlaceholderText = "example@mail.com";
			email_textBox.Size = new Size(212, 23);
			email_textBox.TabIndex = 23;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 11.25F);
			label7.ImageAlign = ContentAlignment.BottomRight;
			label7.Location = new Point(23, 283);
			label7.Name = "label7";
			label7.Size = new Size(143, 20);
			label7.TabIndex = 22;
			label7.Text = "Электронная почта";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 11.25F);
			label8.ImageAlign = ContentAlignment.BottomRight;
			label8.Location = new Point(23, 328);
			label8.Name = "label8";
			label8.Size = new Size(173, 20);
			label8.TabIndex = 24;
			label8.Text = "Паспорт (серия номер)";
			// 
			// SaveChange_button
			// 
			SaveChange_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			SaveChange_button.Location = new Point(138, 389);
			SaveChange_button.Name = "SaveChange_button";
			SaveChange_button.Size = new Size(135, 39);
			SaveChange_button.TabIndex = 27;
			SaveChange_button.Text = "Сохранить";
			SaveChange_button.UseVisualStyleBackColor = true;
			SaveChange_button.Click += SaveChange_button_Click;
			// 
			// phone_maskedTextBox
			// 
			phone_maskedTextBox.Location = new Point(28, 259);
			phone_maskedTextBox.Margin = new Padding(3, 2, 3, 2);
			phone_maskedTextBox.Mask = "(999) 000-0000";
			phone_maskedTextBox.Name = "phone_maskedTextBox";
			phone_maskedTextBox.Size = new Size(212, 23);
			phone_maskedTextBox.TabIndex = 29;
			phone_maskedTextBox.MouseClick += phone_maskedTextBox_MouseClick;
			// 
			// birthDate_maskedTextBox
			// 
			birthDate_maskedTextBox.Location = new Point(28, 214);
			birthDate_maskedTextBox.Margin = new Padding(3, 2, 3, 2);
			birthDate_maskedTextBox.Mask = "00/00/0000";
			birthDate_maskedTextBox.Name = "birthDate_maskedTextBox";
			birthDate_maskedTextBox.Size = new Size(212, 23);
			birthDate_maskedTextBox.TabIndex = 30;
			birthDate_maskedTextBox.ValidatingType = typeof(DateTime);
			birthDate_maskedTextBox.MouseClick += birthDate_maskedTextBox_MouseClick;
			// 
			// passportNumber_maskedTextBox
			// 
			passportNumber_maskedTextBox.Location = new Point(122, 349);
			passportNumber_maskedTextBox.Margin = new Padding(3, 2, 3, 2);
			passportNumber_maskedTextBox.Mask = "000000";
			passportNumber_maskedTextBox.Name = "passportNumber_maskedTextBox";
			passportNumber_maskedTextBox.Size = new Size(119, 23);
			passportNumber_maskedTextBox.TabIndex = 31;
			passportNumber_maskedTextBox.MouseClick += passportNumber_maskedTextBox_MouseClick;
			// 
			// passportSeries_maskedTextBox
			// 
			passportSeries_maskedTextBox.Location = new Point(28, 349);
			passportSeries_maskedTextBox.Margin = new Padding(3, 2, 3, 2);
			passportSeries_maskedTextBox.Mask = "0000";
			passportSeries_maskedTextBox.Name = "passportSeries_maskedTextBox";
			passportSeries_maskedTextBox.Size = new Size(57, 23);
			passportSeries_maskedTextBox.TabIndex = 32;
			passportSeries_maskedTextBox.ValidatingType = typeof(int);
			passportSeries_maskedTextBox.MouseClick += passportSeries_maskedTextBox_MouseClick;
			// 
			// AddClient_Form
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(424, 438);
			Controls.Add(passportSeries_maskedTextBox);
			Controls.Add(passportNumber_maskedTextBox);
			Controls.Add(birthDate_maskedTextBox);
			Controls.Add(phone_maskedTextBox);
			Controls.Add(SaveChange_button);
			Controls.Add(label8);
			Controls.Add(email_textBox);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(patronymic_textBox);
			Controls.Add(label4);
			Controls.Add(firstname_textBox);
			Controls.Add(label3);
			Controls.Add(surname_textBox);
			Controls.Add(label2);
			Controls.Add(label1);
			Margin = new Padding(3, 2, 3, 2);
			Name = "AddClient_Form";
			Text = "AddClient_Form";
			Load += AddClient_Form_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private TextBox surname_textBox;
        private Label label2;
        private TextBox firstname_textBox;
        private Label label3;
        private TextBox patronymic_textBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox email_textBox;
        private Label label7;
        private TextBox passportData_textBox;
        private Label label8;
        private Button SaveChange_button;
        private MaskedTextBox phone_maskedTextBox;
        private MaskedTextBox birthDate_maskedTextBox;
        private MaskedTextBox passportNumber_maskedTextBox;
        private MaskedTextBox passportSeries_maskedTextBox;
    }
}