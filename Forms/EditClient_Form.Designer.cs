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
			label6 = new Label();
			label7 = new Label();
			Surname_textBox = new TextBox();
			FirstName_textBox = new TextBox();
			patronymik_textBox = new TextBox();
			BirthDay_dateTimePicker = new DateTimePicker();
			Phone_textBox = new TextBox();
			Email_textBox = new TextBox();
			PassportData_textBox = new TextBox();
			SaveChanged_btn = new Button();
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
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 12F);
			label6.Location = new Point(26, 279);
			label6.Name = "label6";
			label6.Size = new Size(54, 21);
			label6.TabIndex = 5;
			label6.Text = "Почта";
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
			// Surname_textBox
			// 
			Surname_textBox.Location = new Point(30, 54);
			Surname_textBox.Name = "Surname_textBox";
			Surname_textBox.Size = new Size(233, 23);
			Surname_textBox.TabIndex = 9;
			Surname_textBox.TextChanged += Surname_textBox_TextChanged_1;
			// 
			// FirstName_textBox
			// 
			FirstName_textBox.Location = new Point(30, 103);
			FirstName_textBox.Name = "FirstName_textBox";
			FirstName_textBox.Size = new Size(233, 23);
			FirstName_textBox.TabIndex = 10;
			FirstName_textBox.TextChanged += FirstName_textBox_TextChanged;
			// 
			// patronymik_textBox
			// 
			patronymik_textBox.Location = new Point(31, 152);
			patronymik_textBox.Name = "patronymik_textBox";
			patronymik_textBox.Size = new Size(232, 23);
			patronymik_textBox.TabIndex = 11;
			patronymik_textBox.TextChanged += patronymik_textBox_TextChanged;
			// 
			// BirthDay_dateTimePicker
			// 
			BirthDay_dateTimePicker.Location = new Point(31, 203);
			BirthDay_dateTimePicker.Name = "BirthDay_dateTimePicker";
			BirthDay_dateTimePicker.Size = new Size(232, 23);
			BirthDay_dateTimePicker.TabIndex = 12;
			BirthDay_dateTimePicker.ValueChanged += BirthDay_dateTimePicker_ValueChanged;
			// 
			// Phone_textBox
			// 
			Phone_textBox.Location = new Point(30, 253);
			Phone_textBox.Name = "Phone_textBox";
			Phone_textBox.Size = new Size(233, 23);
			Phone_textBox.TabIndex = 13;
			Phone_textBox.TextChanged += Phone_textBox_TextChanged;
			// 
			// Email_textBox
			// 
			Email_textBox.Location = new Point(26, 303);
			Email_textBox.Name = "Email_textBox";
			Email_textBox.Size = new Size(237, 23);
			Email_textBox.TabIndex = 14;
			Email_textBox.TextChanged += Email_textBox_TextChanged;
			// 
			// PassportData_textBox
			// 
			PassportData_textBox.Location = new Point(25, 349);
			PassportData_textBox.Name = "PassportData_textBox";
			PassportData_textBox.Size = new Size(238, 23);
			PassportData_textBox.TabIndex = 15;
			PassportData_textBox.TextChanged += PassportData_textBox_TextChanged;
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
			SaveChanged_btn.Click += this.SaveChanged_btn_Click;
			// 
			// EditClient_Form
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(289, 465);
			Controls.Add(SaveChanged_btn);
			Controls.Add(PassportData_textBox);
			Controls.Add(Email_textBox);
			Controls.Add(Phone_textBox);
			Controls.Add(BirthDay_dateTimePicker);
			Controls.Add(patronymik_textBox);
			Controls.Add(FirstName_textBox);
			Controls.Add(Surname_textBox);
			Controls.Add(label7);
			Controls.Add(label6);
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
		private Label label6;
		private Label label7;
		public TextBox Surname_textBox;
		public TextBox FirstName_textBox;
		public TextBox patronymik_textBox;
		public DateTimePicker BirthDay_dateTimePicker;
		public TextBox Phone_textBox;
		public TextBox Email_textBox;
		public TextBox PassportData_textBox;
		private Button SaveChanged_btn;
	}
}