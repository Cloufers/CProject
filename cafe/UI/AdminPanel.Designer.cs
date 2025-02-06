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
            buttonCompleteReservation = new Button();
            buttonCancelReservation = new Button();
            labelStatus = new Label();
            nightbuttonViewReservationForToday = new ReaLTaiizor.Controls.NightButton();
            nightbuttonViewSelectedDateReservations = new ReaLTaiizor.Controls.NightButton();
            parrotPictureBox1 = new ReaLTaiizor.Controls.ParrotPictureBox();
            poisondateTimePicker = new ReaLTaiizor.Controls.PoisonDateTime();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservations).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewReservations
            // 
            dataGridViewReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservations.Location = new Point(0, 1);
            dataGridViewReservations.Name = "dataGridViewReservations";
            dataGridViewReservations.Size = new Size(832, 215);
            dataGridViewReservations.TabIndex = 0;
            // 
            // buttonCompleteReservation
            // 
            buttonCompleteReservation.BackColor = Color.LightGreen;
            buttonCompleteReservation.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            buttonCompleteReservation.ForeColor = SystemColors.ControlText;
            buttonCompleteReservation.Location = new Point(444, 256);
            buttonCompleteReservation.Name = "buttonCompleteReservation";
            buttonCompleteReservation.Size = new Size(162, 37);
            buttonCompleteReservation.TabIndex = 4;
            buttonCompleteReservation.Text = "Завершить бронь";
            buttonCompleteReservation.UseVisualStyleBackColor = false;
            buttonCompleteReservation.Click += buttonCompleteReservation_Click;
            // 
            // buttonCancelReservation
            // 
            buttonCancelReservation.BackColor = Color.Brown;
            buttonCancelReservation.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            buttonCancelReservation.ForeColor = SystemColors.ControlText;
            buttonCancelReservation.Location = new Point(661, 256);
            buttonCancelReservation.Name = "buttonCancelReservation";
            buttonCancelReservation.Size = new Size(161, 37);
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
            // nightbuttonViewReservationForToday
            // 
            nightbuttonViewReservationForToday.BackColor = Color.Transparent;
            nightbuttonViewReservationForToday.DialogResult = DialogResult.None;
            nightbuttonViewReservationForToday.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold);
            nightbuttonViewReservationForToday.ForeColor = Color.FromArgb(192, 255, 255);
            nightbuttonViewReservationForToday.HoverBackColor = Color.DarkSlateGray;
            nightbuttonViewReservationForToday.HoverForeColor = Color.White;
            nightbuttonViewReservationForToday.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            nightbuttonViewReservationForToday.Location = new Point(0, 314);
            nightbuttonViewReservationForToday.MinimumSize = new Size(144, 47);
            nightbuttonViewReservationForToday.Name = "nightbuttonViewReservationForToday";
            nightbuttonViewReservationForToday.NormalBackColor = Color.FromArgb(192, 255, 255);
            nightbuttonViewReservationForToday.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            nightbuttonViewReservationForToday.PressedBackColor = Color.Teal;
            nightbuttonViewReservationForToday.PressedForeColor = Color.White;
            nightbuttonViewReservationForToday.Radius = 20;
            nightbuttonViewReservationForToday.Size = new Size(266, 64);
            nightbuttonViewReservationForToday.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            nightbuttonViewReservationForToday.TabIndex = 7;
            nightbuttonViewReservationForToday.Text = "Посмотреть резервацию на сегодня";
            nightbuttonViewReservationForToday.Click += nightbuttonViewReservationForToday_Click;
            // 
            // nightbuttonViewSelectedDateReservations
            // 
            nightbuttonViewSelectedDateReservations.BackColor = Color.Transparent;
            nightbuttonViewSelectedDateReservations.DialogResult = DialogResult.None;
            nightbuttonViewSelectedDateReservations.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold);
            nightbuttonViewSelectedDateReservations.ForeColor = Color.FromArgb(192, 255, 255);
            nightbuttonViewSelectedDateReservations.HoverBackColor = Color.DarkSlateGray;
            nightbuttonViewSelectedDateReservations.HoverForeColor = Color.White;
            nightbuttonViewSelectedDateReservations.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            nightbuttonViewSelectedDateReservations.Location = new Point(0, 232);
            nightbuttonViewSelectedDateReservations.MinimumSize = new Size(144, 47);
            nightbuttonViewSelectedDateReservations.Name = "nightbuttonViewSelectedDateReservations";
            nightbuttonViewSelectedDateReservations.NormalBackColor = Color.FromArgb(192, 255, 255);
            nightbuttonViewSelectedDateReservations.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            nightbuttonViewSelectedDateReservations.PressedBackColor = Color.Teal;
            nightbuttonViewSelectedDateReservations.PressedForeColor = Color.White;
            nightbuttonViewSelectedDateReservations.Radius = 20;
            nightbuttonViewSelectedDateReservations.Size = new Size(266, 61);
            nightbuttonViewSelectedDateReservations.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            nightbuttonViewSelectedDateReservations.TabIndex = 8;
            nightbuttonViewSelectedDateReservations.Text = "Резервация столов (Дата)";
            nightbuttonViewSelectedDateReservations.Click += nightbuttonViewSelectedDateReservations_Click;
            // 
            // parrotPictureBox1
            // 
            parrotPictureBox1.BackgroundImage = Properties.Resources.Fox;
            parrotPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            parrotPictureBox1.ColorLeft = Color.DodgerBlue;
            parrotPictureBox1.ColorRight = Color.DodgerBlue;
            parrotPictureBox1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox1.FilterAlpha = 200;
            parrotPictureBox1.FilterEnabled = true;
            parrotPictureBox1.Image = null;
            parrotPictureBox1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox1.IsElipse = false;
            parrotPictureBox1.IsParallax = false;
            parrotPictureBox1.Location = new Point(737, 355);
            parrotPictureBox1.Name = "parrotPictureBox1";
            parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox1.Size = new Size(85, 81);
            parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox1.TabIndex = 9;
            parrotPictureBox1.Text = "parrotPictureBox1";
            parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // poisondateTimePicker
            // 
            poisondateTimePicker.Location = new Point(0, 398);
            poisondateTimePicker.MinimumSize = new Size(0, 29);
            poisondateTimePicker.Name = "poisondateTimePicker";
            poisondateTimePicker.Size = new Size(266, 29);
            poisondateTimePicker.TabIndex = 10;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(834, 461);
            Controls.Add(poisondateTimePicker);
            Controls.Add(parrotPictureBox1);
            Controls.Add(nightbuttonViewSelectedDateReservations);
            Controls.Add(nightbuttonViewReservationForToday);
            Controls.Add(labelStatus);
            Controls.Add(buttonCancelReservation);
            Controls.Add(buttonCompleteReservation);
            Controls.Add(dataGridViewReservations);
            MaximumSize = new Size(850, 500);
            MinimumSize = new Size(820, 500);
            Name = "AdminPanel";
            Text = "AdminWindow";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewReservations;
        private Button buttonCompleteReservation;
        private Button buttonCancelReservation;
        private Label labelStatus;
        private ReaLTaiizor.Controls.NightButton nightbuttonViewReservationForToday;
        private ReaLTaiizor.Controls.NightButton nightbuttonViewSelectedDateReservations;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox1;
        private ReaLTaiizor.Controls.PoisonDateTime poisondateTimePicker;
    }
}