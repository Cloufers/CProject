namespace cafe
{
    partial class Feedback
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
            pbStars = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            cyberButtonFeedback = new ReaLTaiizor.Controls.CyberButton();
            cyberTextBoxFeedback = new ReaLTaiizor.Controls.CyberTextBox();
            ((System.ComponentModel.ISupportInitialize)pbStars).BeginInit();
            SuspendLayout();
            // 
            // pbStars
            // 
            pbStars.BackgroundImageLayout = ImageLayout.Zoom;
            pbStars.Image = Properties.Resources.StarEmpty;
            pbStars.Location = new Point(44, 86);
            pbStars.Margin = new Padding(3, 2, 3, 2);
            pbStars.Name = "pbStars";
            pbStars.Size = new Size(468, 85);
            pbStars.SizeMode = PictureBoxSizeMode.Zoom;
            pbStars.TabIndex = 1;
            pbStars.TabStop = false;
            pbStars.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(192, 255, 255);
            label1.Location = new Point(27, 28);
            label1.Name = "label1";
            label1.Size = new Size(279, 35);
            label1.TabIndex = 2;
            label1.Text = "Поставьте нам оценку";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(192, 255, 255);
            label2.Location = new Point(27, 281);
            label2.Name = "label2";
            label2.Size = new Size(275, 35);
            label2.TabIndex = 3;
            label2.Text = "Напишите свой отзыв";
            // 
            // cyberButtonFeedback
            // 
            cyberButtonFeedback.Alpha = 20;
            cyberButtonFeedback.BackColor = Color.Transparent;
            cyberButtonFeedback.Background = true;
            cyberButtonFeedback.Background_WidthPen = 4F;
            cyberButtonFeedback.BackgroundPen = true;
            cyberButtonFeedback.ColorBackground = Color.Teal;
            cyberButtonFeedback.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButtonFeedback.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButtonFeedback.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberButtonFeedback.ColorLighting = Color.FromArgb(192, 255, 255);
            cyberButtonFeedback.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButtonFeedback.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButtonFeedback.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButtonFeedback.Effect_1 = true;
            cyberButtonFeedback.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButtonFeedback.Effect_1_Transparency = 25;
            cyberButtonFeedback.Effect_2 = true;
            cyberButtonFeedback.Effect_2_ColorBackground = Color.White;
            cyberButtonFeedback.Effect_2_Transparency = 20;
            cyberButtonFeedback.Font = new Font("Arial", 11F);
            cyberButtonFeedback.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButtonFeedback.Lighting = false;
            cyberButtonFeedback.LinearGradient_Background = false;
            cyberButtonFeedback.LinearGradientPen = false;
            cyberButtonFeedback.Location = new Point(382, 281);
            cyberButtonFeedback.Name = "cyberButtonFeedback";
            cyberButtonFeedback.PenWidth = 15;
            cyberButtonFeedback.Rounding = true;
            cyberButtonFeedback.RoundingInt = 70;
            cyberButtonFeedback.Size = new Size(130, 41);
            cyberButtonFeedback.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButtonFeedback.TabIndex = 5;
            cyberButtonFeedback.Tag = "Cyber";
            cyberButtonFeedback.TextButton = "Отправить";
            cyberButtonFeedback.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButtonFeedback.Timer_Effect_1 = 5;
            cyberButtonFeedback.Timer_RGB = 300;
            cyberButtonFeedback.Click += cyberButtonFeedback_Click;
            // 
            // cyberTextBoxFeedback
            // 
            cyberTextBoxFeedback.Alpha = 20;
            cyberTextBoxFeedback.BackColor = Color.Transparent;
            cyberTextBoxFeedback.Background_WidthPen = 3F;
            cyberTextBoxFeedback.BackgroundPen = true;
            cyberTextBoxFeedback.ColorBackground = Color.FromArgb(0, 64, 64);
            cyberTextBoxFeedback.ColorBackground_Pen = Color.FromArgb(192, 255, 255);
            cyberTextBoxFeedback.ColorLighting = Color.FromArgb(192, 255, 255);
            cyberTextBoxFeedback.ColorPen_1 = Color.FromArgb(29, 200, 238);
            cyberTextBoxFeedback.ColorPen_2 = Color.FromArgb(37, 52, 68);
            cyberTextBoxFeedback.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBoxFeedback.Font = new Font("Arial", 16F);
            cyberTextBoxFeedback.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBoxFeedback.Lighting = false;
            cyberTextBoxFeedback.LinearGradientPen = false;
            cyberTextBoxFeedback.Location = new Point(44, 361);
            cyberTextBoxFeedback.Name = "cyberTextBoxFeedback";
            cyberTextBoxFeedback.PenWidth = 15;
            cyberTextBoxFeedback.RGB = false;
            cyberTextBoxFeedback.Rounding = true;
            cyberTextBoxFeedback.RoundingInt = 60;
            cyberTextBoxFeedback.Size = new Size(473, 67);
            cyberTextBoxFeedback.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBoxFeedback.TabIndex = 6;
            cyberTextBoxFeedback.Tag = "Cyber";
            cyberTextBoxFeedback.TextButton = "";
            cyberTextBoxFeedback.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBoxFeedback.Timer_RGB = 300;
            // 
            // Feedback
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(554, 551);
            Controls.Add(cyberTextBoxFeedback);
            Controls.Add(cyberButtonFeedback);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbStars);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(570, 590);
            MinimumSize = new Size(570, 590);
            Name = "Feedback";
            Text = "Feedback1";
            ((System.ComponentModel.ISupportInitialize)pbStars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbStars;
        private Label label1;
        private Label label2;
        private ReaLTaiizor.Controls.CyberButton cyberButtonFeedback;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBoxFeedback;
    }
}