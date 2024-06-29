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
            phone_textBox = new TextBox();
            label6 = new Label();
            email_textBox = new TextBox();
            label7 = new Label();
            passportSeries_textBox = new TextBox();
            label8 = new Label();
            birthDate_dateTimePicker = new DateTimePicker();
            SaveChange_button = new Button();
            passportNumber_textBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(96, 9);
            label1.Name = "label1";
            label1.Size = new Size(286, 41);
            label1.TabIndex = 1;
            label1.Text = "Добавить клиента";
            // 
            // surname_textBox
            // 
            surname_textBox.Location = new Point(32, 106);
            surname_textBox.Margin = new Padding(3, 4, 3, 4);
            surname_textBox.Name = "surname_textBox";
            surname_textBox.Size = new Size(242, 27);
            surname_textBox.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.ImageAlign = ContentAlignment.BottomRight;
            label2.Location = new Point(26, 77);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 12;
            label2.Text = "Фамилия";
            // 
            // firstname_textBox
            // 
            firstname_textBox.Location = new Point(32, 166);
            firstname_textBox.Margin = new Padding(3, 4, 3, 4);
            firstname_textBox.Name = "firstname_textBox";
            firstname_textBox.Size = new Size(242, 27);
            firstname_textBox.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.ImageAlign = ContentAlignment.BottomRight;
            label3.Location = new Point(26, 137);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 14;
            label3.Text = "Имя";
            // 
            // patronymic_textBox
            // 
            patronymic_textBox.Location = new Point(32, 226);
            patronymic_textBox.Margin = new Padding(3, 4, 3, 4);
            patronymic_textBox.Name = "patronymic_textBox";
            patronymic_textBox.Size = new Size(242, 27);
            patronymic_textBox.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.ImageAlign = ContentAlignment.BottomRight;
            label4.Location = new Point(26, 197);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 16;
            label4.Text = "Отчество";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.ImageAlign = ContentAlignment.BottomRight;
            label5.Location = new Point(26, 257);
            label5.Name = "label5";
            label5.Size = new Size(146, 25);
            label5.TabIndex = 18;
            label5.Text = "Дата рождения";
            // 
            // phone_textBox
            // 
            phone_textBox.Location = new Point(32, 346);
            phone_textBox.Margin = new Padding(3, 4, 3, 4);
            phone_textBox.Name = "phone_textBox";
            phone_textBox.PlaceholderText = "88005553535";
            phone_textBox.Size = new Size(242, 27);
            phone_textBox.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.ImageAlign = ContentAlignment.BottomRight;
            label6.Location = new Point(26, 317);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 20;
            label6.Text = "Телефон";
            // 
            // email_textBox
            // 
            email_textBox.Location = new Point(32, 406);
            email_textBox.Margin = new Padding(3, 4, 3, 4);
            email_textBox.Name = "email_textBox";
            email_textBox.PlaceholderText = "example@mail.com";
            email_textBox.Size = new Size(242, 27);
            email_textBox.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.ImageAlign = ContentAlignment.BottomRight;
            label7.Location = new Point(26, 377);
            label7.Name = "label7";
            label7.Size = new Size(181, 25);
            label7.TabIndex = 22;
            label7.Text = "Электронная почта";
            // 
            // passportSeries_textBox
            // 
            passportSeries_textBox.Location = new Point(32, 466);
            passportSeries_textBox.Margin = new Padding(3, 4, 3, 4);
            passportSeries_textBox.Name = "passportSeries_textBox";
            passportSeries_textBox.PlaceholderText = "1234";
            passportSeries_textBox.Size = new Size(81, 27);
            passportSeries_textBox.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.ImageAlign = ContentAlignment.BottomRight;
            label8.Location = new Point(26, 437);
            label8.Name = "label8";
            label8.Size = new Size(215, 25);
            label8.TabIndex = 24;
            label8.Text = "Паспорт (серия номер)";
            // 
            // birthDate_dateTimePicker
            // 
            birthDate_dateTimePicker.Location = new Point(32, 287);
            birthDate_dateTimePicker.Name = "birthDate_dateTimePicker";
            birthDate_dateTimePicker.Size = new Size(242, 27);
            birthDate_dateTimePicker.TabIndex = 26;
            // 
            // SaveChange_button
            // 
            SaveChange_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SaveChange_button.Location = new Point(158, 519);
            SaveChange_button.Margin = new Padding(3, 4, 3, 4);
            SaveChange_button.Name = "SaveChange_button";
            SaveChange_button.Size = new Size(154, 52);
            SaveChange_button.TabIndex = 27;
            SaveChange_button.Text = "Сохранить";
            SaveChange_button.UseVisualStyleBackColor = true;
            SaveChange_button.Click += SaveChange_button_Click;
            // 
            // passportNumber_textBox
            // 
            passportNumber_textBox.Location = new Point(135, 466);
            passportNumber_textBox.Margin = new Padding(3, 4, 3, 4);
            passportNumber_textBox.Name = "passportNumber_textBox";
            passportNumber_textBox.PlaceholderText = "123456";
            passportNumber_textBox.Size = new Size(139, 27);
            passportNumber_textBox.TabIndex = 28;
            // 
            // AddClient_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 584);
            Controls.Add(passportNumber_textBox);
            Controls.Add(SaveChange_button);
            Controls.Add(birthDate_dateTimePicker);
            Controls.Add(passportSeries_textBox);
            Controls.Add(label8);
            Controls.Add(email_textBox);
            Controls.Add(label7);
            Controls.Add(phone_textBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(patronymic_textBox);
            Controls.Add(label4);
            Controls.Add(firstname_textBox);
            Controls.Add(label3);
            Controls.Add(surname_textBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddClient_Form";
            Text = "AddClient_Form";
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
        private TextBox phone_textBox;
        private Label label6;
        private TextBox email_textBox;
        private Label label7;
        private TextBox passportData_textBox;
        private Label label8;
        private DateTimePicker birthDate_dateTimePicker;
        private Button SaveChange_button;
        private TextBox passportSeries_textBox;
        private TextBox passportNumber_textBox;
    }
}