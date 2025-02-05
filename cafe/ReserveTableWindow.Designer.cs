namespace cafe
{
    partial class ReserveTableWindow
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
            comboBoxTime = new ComboBox();
            NumericUpDownPeople = new NumericUpDown();
            TextBoxName = new TextBox();
            reserveButton = new Button();
            headerLabel = new Label();
            nameLabel = new Label();
            timeLabel = new Label();
            dateLabel = new Label();
            peopleAmountLabel = new Label();
            phoneNumberBox = new TextBox();
            phoneLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownPeople).BeginInit();
            SuspendLayout();
            // 
            // comboBoxTime
            // 
            comboBoxTime.Font = new Font("Sitka Small", 9F);
            comboBoxTime.FormattingEnabled = true;
            comboBoxTime.Location = new Point(46, 178);
            comboBoxTime.Margin = new Padding(3, 2, 3, 2);
            comboBoxTime.Name = "comboBoxTime";
            comboBoxTime.Size = new Size(273, 26);
            comboBoxTime.TabIndex = 0;
            // 
            // NumericUpDownPeople
            // 
            NumericUpDownPeople.Font = new Font("Sitka Small", 9F);
            NumericUpDownPeople.Location = new Point(45, 303);
            NumericUpDownPeople.Margin = new Padding(3, 2, 3, 2);
            NumericUpDownPeople.Name = "NumericUpDownPeople";
            NumericUpDownPeople.Size = new Size(272, 23);
            NumericUpDownPeople.TabIndex = 2;
            // 
            // TextBoxName
            // 
            TextBoxName.Font = new Font("Sitka Small", 9F);
            TextBoxName.Location = new Point(46, 111);
            TextBoxName.Margin = new Padding(3, 2, 3, 2);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(273, 23);
            TextBoxName.TabIndex = 3;
            // 
            // reserveButton
            // 
            reserveButton.BackColor = Color.FromArgb(0, 64, 64);
            reserveButton.Font = new Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            reserveButton.ForeColor = Color.PaleTurquoise;
            reserveButton.Location = new Point(46, 419);
            reserveButton.Margin = new Padding(3, 2, 3, 2);
            reserveButton.Name = "reserveButton";
            reserveButton.Size = new Size(172, 44);
            reserveButton.TabIndex = 4;
            reserveButton.Text = "Забронировать";
            reserveButton.UseVisualStyleBackColor = false;
            reserveButton.Click += reserveButton_Click;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Sitka Heading", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            headerLabel.ForeColor = Color.FromArgb(0, 64, 64);
            headerLabel.Location = new Point(44, 32);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(265, 29);
            headerLabel.TabIndex = 5;
            headerLabel.Text = "БРОНИРОВАНИЕ СТОЛИКА";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Sitka Subheading", 12F, FontStyle.Bold);
            nameLabel.ForeColor = Color.FromArgb(0, 64, 64);
            nameLabel.Location = new Point(46, 82);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(110, 23);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Введите Имя";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Sitka Subheading", 12F, FontStyle.Bold);
            timeLabel.ForeColor = Color.FromArgb(0, 64, 64);
            timeLabel.Location = new Point(46, 150);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(136, 23);
            timeLabel.TabIndex = 7;
            timeLabel.Text = "Выберите время";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Sitka Subheading", 12F, FontStyle.Bold);
            dateLabel.ForeColor = Color.FromArgb(0, 64, 64);
            dateLabel.Location = new Point(46, 218);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(125, 23);
            dateLabel.TabIndex = 8;
            dateLabel.Text = "Выберите дату";
            // 
            // peopleAmountLabel
            // 
            peopleAmountLabel.AutoSize = true;
            peopleAmountLabel.Font = new Font("Sitka Subheading", 12F, FontStyle.Bold);
            peopleAmountLabel.ForeColor = Color.FromArgb(0, 64, 64);
            peopleAmountLabel.Location = new Point(45, 275);
            peopleAmountLabel.Name = "peopleAmountLabel";
            peopleAmountLabel.Size = new Size(197, 23);
            peopleAmountLabel.TabIndex = 9;
            peopleAmountLabel.Text = "Выберите кол-во персон";
            // 
            // phoneNumberBox
            // 
            phoneNumberBox.Font = new Font("Sitka Small", 9F);
            phoneNumberBox.Location = new Point(44, 360);
            phoneNumberBox.Margin = new Padding(3, 2, 3, 2);
            phoneNumberBox.Name = "phoneNumberBox";
            phoneNumberBox.Size = new Size(273, 23);
            phoneNumberBox.TabIndex = 10;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Sitka Subheading", 12F, FontStyle.Bold);
            phoneLabel.ForeColor = Color.FromArgb(0, 64, 64);
            phoneLabel.Location = new Point(45, 332);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(202, 23);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "Введите номер телефона";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(47, 249);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(272, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // ReserveTableWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(578, 500);
            Controls.Add(dateTimePicker1);
            Controls.Add(phoneLabel);
            Controls.Add(phoneNumberBox);
            Controls.Add(peopleAmountLabel);
            Controls.Add(dateLabel);
            Controls.Add(timeLabel);
            Controls.Add(nameLabel);
            Controls.Add(headerLabel);
            Controls.Add(reserveButton);
            Controls.Add(TextBoxName);
            Controls.Add(NumericUpDownPeople);
            Controls.Add(comboBoxTime);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReserveTableWindow";
            Text = "KlodMone";
            ((System.ComponentModel.ISupportInitialize)NumericUpDownPeople).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxTime;
        private NumericUpDown NumericUpDownPeople;
        private TextBox TextBoxName;
        private Button reserveButton;
        private Label headerLabel;
        private Label nameLabel;
        private Label timeLabel;
        private Label dateLabel;
        private Label peopleAmountLabel;
        private TextBox phoneNumberBox;
        private Label phoneLabel;
        private DateTimePicker dateTimePicker1;
    }
}