namespace deposit_app
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			LogoLabel = new Label();
			AddBtn = new Button();
			DeleteBtn = new Button();
			LogBtn = new Button();
			dataGridView1 = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// LogoLabel
			// 
			LogoLabel.AutoSize = true;
			LogoLabel.Font = new Font("Snap ITC", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			LogoLabel.Location = new Point(175, 9);
			LogoLabel.Name = "LogoLabel";
			LogoLabel.Size = new Size(422, 45);
			LogoLabel.TabIndex = 0;
			LogoLabel.Text = "Deposits from Kolya";
			LogoLabel.Click += label1_Click;
			// 
			// AddBtn
			// 
			AddBtn.BackColor = Color.FromArgb(255, 192, 255);
			AddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			AddBtn.ForeColor = Color.FromArgb(64, 0, 64);
			AddBtn.Location = new Point(193, 74);
			AddBtn.Name = "AddBtn";
			AddBtn.Size = new Size(138, 44);
			AddBtn.TabIndex = 2;
			AddBtn.Text = "Добавить";
			AddBtn.UseVisualStyleBackColor = false;
			AddBtn.Click += AddBtn_Click;
			// 
			// DeleteBtn
			// 
			DeleteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			DeleteBtn.Location = new Point(390, 74);
			DeleteBtn.Name = "DeleteBtn";
			DeleteBtn.Size = new Size(138, 39);
			DeleteBtn.TabIndex = 3;
			DeleteBtn.Text = "Удалить";
			DeleteBtn.UseVisualStyleBackColor = true;
			// 
			// LogBtn
			// 
			LogBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			LogBtn.ImageAlign = ContentAlignment.BottomCenter;
			LogBtn.Location = new Point(585, 74);
			LogBtn.Name = "LogBtn";
			LogBtn.Size = new Size(138, 39);
			LogBtn.TabIndex = 4;
			LogBtn.Text = "История";
			LogBtn.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(135, 147);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(621, 273);
			dataGridView1.TabIndex = 5;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dataGridView1);
			Controls.Add(LogBtn);
			Controls.Add(DeleteBtn);
			Controls.Add(AddBtn);
			Controls.Add(LogoLabel);
			Name = "MainForm";
			Text = "Вклады.ру";
			Load += MainForm_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label LogoLabel;
		private Button button1;
		private Button AddBtn;
		private Button DeleteBtn;
		private Button LogBtn;
		private DataGridView dataGridView1;
	}
}
