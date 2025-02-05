namespace cafe
{
    partial class AdminPanel
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
            dataGridViewReservations = new DataGridView();
            buttonViewReservationForToday = new Button();
            dateTimePicker = new DateTimePicker();
            buttonViewSelectedDateReservations = new Button();
            buttonCompleteReservation = new Button();
            buttonCancelReservation = new Button();
            labelStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservations).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewReservations
            // 
            dataGridViewReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservations.Location = new Point(398, 50);
            dataGridViewReservations.Name = "dataGridViewReservations";
            dataGridViewReservations.Size = new Size(378, 281);
            dataGridViewReservations.TabIndex = 0;
            // 
            // buttonViewReservationForToday
            // 
            buttonViewReservationForToday.Location = new Point(22, 50);
            buttonViewReservationForToday.Name = "buttonViewReservationForToday";
            buttonViewReservationForToday.Size = new Size(217, 38);
            buttonViewReservationForToday.TabIndex = 1;
            buttonViewReservationForToday.Text = "Посмотреть резеврацию на сегодня";
            buttonViewReservationForToday.UseVisualStyleBackColor = true;
            buttonViewReservationForToday.Click += buttonViewReservationForToday_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(22, 159);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(217, 23);
            dateTimePicker.TabIndex = 2;
            // 
            // buttonViewSelectedDateReservations
            // 
            buttonViewSelectedDateReservations.Location = new Point(22, 115);
            buttonViewSelectedDateReservations.Name = "buttonViewSelectedDateReservations";
            buttonViewSelectedDateReservations.Size = new Size(217, 38);
            buttonViewSelectedDateReservations.TabIndex = 3;
            buttonViewSelectedDateReservations.Text = "Посмотреть резеврацию (дата)";
            buttonViewSelectedDateReservations.UseVisualStyleBackColor = true;
            buttonViewSelectedDateReservations.Click += buttonViewSelectedDateReservations_Click;
            // 
            // buttonCompleteReservation
            // 
            buttonCompleteReservation.BackColor = Color.LightGreen;
            buttonCompleteReservation.Location = new Point(413, 359);
            buttonCompleteReservation.Name = "buttonCompleteReservation";
            buttonCompleteReservation.Size = new Size(131, 23);
            buttonCompleteReservation.TabIndex = 4;
            buttonCompleteReservation.Text = "Завершить бронь";
            buttonCompleteReservation.UseVisualStyleBackColor = false;
            buttonCompleteReservation.Click += buttonCompleteReservation_Click;
            // 
            // buttonCancelReservation
            // 
            buttonCancelReservation.BackColor = Color.Red;
            buttonCancelReservation.Location = new Point(629, 359);
            buttonCancelReservation.Name = "buttonCancelReservation";
            buttonCancelReservation.Size = new Size(131, 23);
            buttonCancelReservation.TabIndex = 5;
            buttonCancelReservation.Text = "Отменить бронь";
            buttonCancelReservation.UseVisualStyleBackColor = false;
            buttonCancelReservation.Click += buttonCancelReservation_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(413, 438);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(0, 15);
            labelStatus.TabIndex = 6;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 622);
            Controls.Add(labelStatus);
            Controls.Add(buttonCancelReservation);
            Controls.Add(buttonCompleteReservation);
            Controls.Add(buttonViewSelectedDateReservations);
            Controls.Add(dateTimePicker);
            Controls.Add(buttonViewReservationForToday);
            Controls.Add(dataGridViewReservations);
            Name = "AdminPanel";
            Text = "AdminWindow";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewReservations;
        private Button buttonViewReservationForToday;
        private DateTimePicker dateTimePicker;
        private Button buttonViewSelectedDateReservations;
        private Button buttonCompleteReservation;
        private Button buttonCancelReservation;
        private Label labelStatus;
    }
}