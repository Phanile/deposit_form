namespace deposit_app.Forms
{
	partial class AddMoneyToDeposit_Form
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
			button1 = new Button();
			label1 = new Label();
			textBox1 = new TextBox();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(145, 186);
			button1.Name = "button1";
			button1.Size = new Size(169, 60);
			button1.TabIndex = 0;
			button1.Text = "Пополнить";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(34, 91);
			label1.Name = "label1";
			label1.Size = new Size(99, 15);
			label1.TabIndex = 1;
			label1.Text = "Введите депозит:";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(139, 88);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(100, 23);
			textBox1.TabIndex = 2;
			// 
			// AddMoneyToDeposit_Form
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(469, 258);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Controls.Add(button1);
			Name = "AddMoneyToDeposit_Form";
			Text = "AddMoneyToDeposit_Form";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Label label1;
		private TextBox textBox1;
	}
}