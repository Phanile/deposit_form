namespace deposit_app.Forms
{
	partial class AddDeposit_Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDeposit_Form));
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			label10 = new Label();
			email_textBox = new TextBox();
			depositTypes_textbox = new ComboBox();
			curr_textbox = new ComboBox();
			startBalance_textbox = new TextBox();
			personalBalance_textbox = new TextBox();
			CurrBallance_textbox = new TextBox();
			start_dateTimePicker = new DateTimePicker();
			Finish_dateTimePicker = new DateTimePicker();
			label9 = new Label();
			duration_textBox = new TextBox();
			pictureBox1 = new PictureBox();
			SaveChange_btn = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
			label1.Location = new Point(98, 9);
			label1.Name = "label1";
			label1.Size = new Size(205, 32);
			label1.TabIndex = 0;
			label1.Text = "Добавить вклад";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 11.25F);
			label2.ImageAlign = ContentAlignment.BottomRight;
			label2.Location = new Point(22, 56);
			label2.Name = "label2";
			label2.Size = new Size(167, 20);
			label2.TabIndex = 1;
			label2.Text = "Введите почту клиента";
			label2.Click += label2_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 11.25F);
			label3.Location = new Point(24, 99);
			label3.Name = "label3";
			label3.Size = new Size(157, 20);
			label3.TabIndex = 2;
			label3.Text = "Выберите тип вклада";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 11.25F);
			label4.Location = new Point(27, 148);
			label4.Name = "label4";
			label4.Size = new Size(131, 20);
			label4.TabIndex = 3;
			label4.Text = "Выберите валюту";
			label4.Click += label4_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 11.25F);
			label5.Location = new Point(27, 248);
			label5.Name = "label5";
			label5.Size = new Size(156, 20);
			label5.TabIndex = 4;
			label5.Text = "Введите номер счёта";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 11.25F);
			label6.Location = new Point(27, 199);
			label6.Name = "label6";
			label6.Size = new Size(195, 20);
			label6.TabIndex = 5;
			label6.Text = "Введите стартовый баланс";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 11.25F);
			label7.Location = new Point(27, 298);
			label7.Name = "label7";
			label7.Size = new Size(193, 20);
			label7.TabIndex = 6;
			label7.Text = "Введите валютный баланс";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 11.25F);
			label8.Location = new Point(28, 347);
			label8.Name = "label8";
			label8.Size = new Size(110, 20);
			label8.TabIndex = 7;
			label8.Text = "Дата открытия";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI", 11.25F);
			label10.Location = new Point(31, 445);
			label10.Name = "label10";
			label10.Size = new Size(152, 20);
			label10.TabIndex = 9;
			label10.Text = "Продолжительность";
			// 
			// email_textBox
			// 
			email_textBox.Location = new Point(27, 78);
			email_textBox.Name = "email_textBox";
			email_textBox.Size = new Size(212, 23);
			email_textBox.TabIndex = 11;
			email_textBox.TextChanged += email_textBox_TextChanged;
			// 
			// depositTypes_textbox
			// 
			depositTypes_textbox.FormattingEnabled = true;
			depositTypes_textbox.Items.AddRange(new object[] { "Пенсионный фонд", "Премиальный сберегательный вклад", "Стандартный вклад", "Срочный депозит", "Студенческий сберегательный вклад", "Бизнес-вклад" });
			depositTypes_textbox.Location = new Point(27, 122);
			depositTypes_textbox.Name = "depositTypes_textbox";
			depositTypes_textbox.Size = new Size(212, 23);
			depositTypes_textbox.TabIndex = 12;
			depositTypes_textbox.SelectedIndexChanged += depositTypes_textbox_SelectedIndexChanged;
			// 
			// curr_textbox
			// 
			curr_textbox.FormattingEnabled = true;
			curr_textbox.Location = new Point(27, 173);
			curr_textbox.Name = "curr_textbox";
			curr_textbox.Size = new Size(212, 23);
			curr_textbox.TabIndex = 13;
			curr_textbox.SelectedIndexChanged += curr_textbox_SelectedIndexChanged;
			// 
			// startBalance_textbox
			// 
			startBalance_textbox.Location = new Point(27, 222);
			startBalance_textbox.Name = "startBalance_textbox";
			startBalance_textbox.Size = new Size(212, 23);
			startBalance_textbox.TabIndex = 14;
			startBalance_textbox.TextChanged += startBalance_textbox_TextChanged;
			// 
			// personalBalance_textbox
			// 
			personalBalance_textbox.Location = new Point(28, 272);
			personalBalance_textbox.Name = "personalBalance_textbox";
			personalBalance_textbox.Size = new Size(211, 23);
			personalBalance_textbox.TabIndex = 15;
			personalBalance_textbox.TextChanged += personalBalance_textbox_TextChanged;
			// 
			// CurrBallance_textbox
			// 
			CurrBallance_textbox.Location = new Point(28, 321);
			CurrBallance_textbox.Name = "CurrBallance_textbox";
			CurrBallance_textbox.Size = new Size(211, 23);
			CurrBallance_textbox.TabIndex = 16;
			CurrBallance_textbox.TextChanged += CurrBallance_textbox_TextChanged;
			// 
			// start_dateTimePicker
			// 
			start_dateTimePicker.Location = new Point(28, 370);
			start_dateTimePicker.Name = "start_dateTimePicker";
			start_dateTimePicker.Size = new Size(211, 23);
			start_dateTimePicker.TabIndex = 17;
			start_dateTimePicker.ValueChanged += start_dateTimePicker_ValueChanged;
			// 
			// Finish_dateTimePicker
			// 
			Finish_dateTimePicker.Location = new Point(28, 419);
			Finish_dateTimePicker.Name = "Finish_dateTimePicker";
			Finish_dateTimePicker.Size = new Size(211, 23);
			Finish_dateTimePicker.TabIndex = 18;
			Finish_dateTimePicker.ValueChanged += Finish_dateTimePicker_ValueChanged;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 11.25F);
			label9.Location = new Point(28, 396);
			label9.Name = "label9";
			label9.Size = new Size(110, 20);
			label9.TabIndex = 8;
			label9.Text = "Дата закрытия";
			// 
			// duration_textBox
			// 
			duration_textBox.Location = new Point(27, 468);
			duration_textBox.Name = "duration_textBox";
			duration_textBox.Size = new Size(212, 23);
			duration_textBox.TabIndex = 19;
			duration_textBox.TextChanged += duration_textBox_TextChanged;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(245, 78);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(463, 413);
			pictureBox1.TabIndex = 20;
			pictureBox1.TabStop = false;
			// 
			// SaveChange_btn
			// 
			SaveChange_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			SaveChange_btn.Location = new Point(139, 527);
			SaveChange_btn.Name = "SaveChange_btn";
			SaveChange_btn.Size = new Size(135, 39);
			SaveChange_btn.TabIndex = 21;
			SaveChange_btn.Text = "Сохранить";
			SaveChange_btn.UseVisualStyleBackColor = true;
			SaveChange_btn.Click += SaveChange_btn_Click;
			// 
			// AddDeposit_Form
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(424, 578);
			Controls.Add(SaveChange_btn);
			Controls.Add(pictureBox1);
			Controls.Add(duration_textBox);
			Controls.Add(Finish_dateTimePicker);
			Controls.Add(start_dateTimePicker);
			Controls.Add(CurrBallance_textbox);
			Controls.Add(personalBalance_textbox);
			Controls.Add(startBalance_textbox);
			Controls.Add(curr_textbox);
			Controls.Add(depositTypes_textbox);
			Controls.Add(email_textBox);
			Controls.Add(label10);
			Controls.Add(label9);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "AddDeposit_Form";
			Text = "AddDeposit_Form";
			Load += AddDeposit_Form_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
		private Label label8;
		private Label label10;
		private TextBox email_textBox;
		private ComboBox depositTypes_textbox;
		private ComboBox curr_textbox;
		private TextBox startBalance_textbox;
		private TextBox personalBalance_textbox;
		private TextBox CurrBallance_textbox;
		private DateTimePicker start_dateTimePicker;
		private DateTimePicker Finish_dateTimePicker;
		private Label label9;
		private TextBox duration_textBox;
		private PictureBox pictureBox1;
		private Button SaveChange_btn;
	}
}