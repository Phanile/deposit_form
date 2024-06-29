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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label10 = new Label();
			email_textBox = new TextBox();
			depositTypes_textbox = new ComboBox();
			curr_textbox = new ComboBox();
			startBalance_textbox = new TextBox();
			personalBalance_textbox = new TextBox();
			duration_textBox = new TextBox();
			SaveChange_btn = new Button();
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
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI", 11.25F);
			label10.Location = new Point(27, 310);
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
			// 
			// curr_textbox
			// 
			curr_textbox.FormattingEnabled = true;
			curr_textbox.Items.AddRange(new object[] { "Российский рубль ", "Доллар США", "Евро", "Британский фунт", "Японская иена" });
			curr_textbox.Location = new Point(27, 173);
			curr_textbox.Name = "curr_textbox";
			curr_textbox.Size = new Size(212, 23);
			curr_textbox.TabIndex = 13;
			// 
			// startBalance_textbox
			// 
			startBalance_textbox.Location = new Point(27, 222);
			startBalance_textbox.Name = "startBalance_textbox";
			startBalance_textbox.Size = new Size(212, 23);
			startBalance_textbox.TabIndex = 14;
			// 
			// personalBalance_textbox
			// 
			personalBalance_textbox.Location = new Point(28, 272);
			personalBalance_textbox.Name = "personalBalance_textbox";
			personalBalance_textbox.Size = new Size(211, 23);
			personalBalance_textbox.TabIndex = 15;
			// 
			// duration_textBox
			// 
			duration_textBox.Location = new Point(28, 333);
			duration_textBox.Name = "duration_textBox";
			duration_textBox.Size = new Size(212, 23);
			duration_textBox.TabIndex = 19;
			// 
			// SaveChange_btn
			// 
			SaveChange_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			SaveChange_btn.Location = new Point(140, 378);
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
			ClientSize = new Size(424, 438);
			Controls.Add(SaveChange_btn);
			Controls.Add(duration_textBox);
			Controls.Add(personalBalance_textbox);
			Controls.Add(startBalance_textbox);
			Controls.Add(curr_textbox);
			Controls.Add(depositTypes_textbox);
			Controls.Add(email_textBox);
			Controls.Add(label10);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "AddDeposit_Form";
			Text = "AddDeposit_Form";
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
		private Label label10;
		private TextBox email_textBox;
		private ComboBox depositTypes_textbox;
		private ComboBox curr_textbox;
		private TextBox startBalance_textbox;
		private TextBox personalBalance_textbox;
		private TextBox duration_textBox;
		private Button SaveChange_btn;
	}
}