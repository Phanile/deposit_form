namespace deposit_app.Forms
{
	partial class EditClient_Form
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
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			Surname_textBox = new TextBox();
			firstname_textBox = new TextBox();
			patronymic_textBox = new TextBox();
			BirthDay_dateTimePicker = new DateTimePicker();
			SaveChanged_btn = new Button();
			phone_maskedTextBox = new MaskedTextBox();
			label7 = new Label();
			PassportData_textBox = new TextBox();
			email_textBox = new TextBox();
			label6 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(26, 30);
			label1.Name = "label1";
			label1.Size = new Size(75, 21);
			label1.TabIndex = 0;
			label1.Text = "Фамилия";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(26, 79);
			label2.Name = "label2";
			label2.Size = new Size(41, 21);
			label2.TabIndex = 1;
			label2.Text = "Имя";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F);
			label3.Location = new Point(26, 129);
			label3.Name = "label3";
			label3.Size = new Size(77, 21);
			label3.TabIndex = 2;
			label3.Text = "Отчество";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F);
			label4.Location = new Point(26, 178);
			label4.Name = "label4";
			label4.Size = new Size(121, 21);
			label4.TabIndex = 3;
			label4.Text = "Дата рождения";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 12F);
			label5.Location = new Point(26, 229);
			label5.Name = "label5";
			label5.Size = new Size(71, 21);
			label5.TabIndex = 4;
			label5.Text = "Телефон";
			// 
			// Surname_textBox
			// 
			Surname_textBox.Location = new Point(30, 54);
			Surname_textBox.Name = "Surname_textBox";
			Surname_textBox.Size = new Size(233, 23);
			Surname_textBox.TabIndex = 9;
			Surname_textBox.KeyPress += Surname_textBox_KeyPress_1;
			// 
			// firstname_textBox
			// 
			firstname_textBox.Location = new Point(30, 103);
			firstname_textBox.Name = "firstname_textBox";
			firstname_textBox.Size = new Size(233, 23);
			firstname_textBox.TabIndex = 10;
			firstname_textBox.KeyPress += firstname_textBox_KeyPress_1;
			// 
			// patronymic_textBox
			// 
			patronymic_textBox.Location = new Point(31, 152);
			patronymic_textBox.Name = "patronymic_textBox";
			patronymic_textBox.Size = new Size(232, 23);
			patronymic_textBox.TabIndex = 11;
			patronymic_textBox.KeyPress += patronymic_textBox_KeyPress_1;
			// 
			// BirthDay_dateTimePicker
			// 
			BirthDay_dateTimePicker.Location = new Point(31, 203);
			BirthDay_dateTimePicker.Name = "BirthDay_dateTimePicker";
			BirthDay_dateTimePicker.Size = new Size(232, 23);
			BirthDay_dateTimePicker.TabIndex = 12;
			// 
			// SaveChanged_btn
			// 
			SaveChanged_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			SaveChanged_btn.Location = new Point(58, 389);
			SaveChanged_btn.Name = "SaveChanged_btn";
			SaveChanged_btn.Size = new Size(154, 55);
			SaveChanged_btn.TabIndex = 16;
			SaveChanged_btn.Text = "Сохранить изменения";
			SaveChanged_btn.UseVisualStyleBackColor = true;
			SaveChanged_btn.Click += SaveChanged_btn_Click;
			// 
			// phone_maskedTextBox
			// 
			phone_maskedTextBox.Location = new Point(31, 252);
			phone_maskedTextBox.Margin = new Padding(3, 2, 3, 2);
			phone_maskedTextBox.Mask = "(999) 000-0000";
			phone_maskedTextBox.Name = "phone_maskedTextBox";
			phone_maskedTextBox.Size = new Size(232, 23);
			phone_maskedTextBox.TabIndex = 30;
			phone_maskedTextBox.MaskInputRejected += phone_maskedTextBox_MaskInputRejected;
			phone_maskedTextBox.MouseClick += phone_maskedTextBox_MouseClick_1;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 12F);
			label7.Location = new Point(26, 324);
			label7.Name = "label7";
			label7.Size = new Size(156, 21);
			label7.TabIndex = 6;
			label7.Text = "Паспортные данные";
			// 
			// PassportData_textBox
			// 
			PassportData_textBox.Location = new Point(25, 349);
			PassportData_textBox.Name = "PassportData_textBox";
			PassportData_textBox.Size = new Size(238, 23);
			PassportData_textBox.TabIndex = 15;
			// 
			// email_textBox
			// 
			email_textBox.Location = new Point(30, 298);
			email_textBox.Name = "email_textBox";
			email_textBox.PlaceholderText = "example@mail.com";
			email_textBox.Size = new Size(233, 23);
			email_textBox.TabIndex = 32;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 11.25F);
			label6.ImageAlign = ContentAlignment.BottomRight;
			label6.Location = new Point(25, 277);
			label6.Name = "label6";
			label6.Size = new Size(143, 20);
			label6.TabIndex = 31;
			label6.Text = "Электронная почта";
			// 
			// EditClient_Form
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(289, 465);
			Controls.Add(email_textBox);
			Controls.Add(label6);
			Controls.Add(phone_maskedTextBox);
			Controls.Add(SaveChanged_btn);
			Controls.Add(PassportData_textBox);
			Controls.Add(BirthDay_dateTimePicker);
			Controls.Add(patronymic_textBox);
			Controls.Add(firstname_textBox);
			Controls.Add(Surname_textBox);
			Controls.Add(label7);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "EditClient_Form";
			Text = "Редактор клиента";
			Load += EditClient_Form_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		public TextBox Surname_textBox;
		public TextBox firstname_textBox;
		public TextBox patronymic_textBox;
		public DateTimePicker BirthDay_dateTimePicker;
		private Button SaveChanged_btn;
		public MaskedTextBox phone_maskedTextBox;
		private Label label7;
		public TextBox PassportData_textBox;
		public TextBox email_textBox;
		private Label label6;
	}
}