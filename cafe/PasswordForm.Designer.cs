namespace cafe
{
    partial class PasswordForm
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
            passwordTextBox = new TextBox();
            label1 = new Label();
            userTextBox = new TextBox();
            label2 = new Label();
            foxBigLabel1 = new ReaLTaiizor.Controls.FoxBigLabel();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            cyberButton2 = new ReaLTaiizor.Controls.CyberButton();
            parrotPictureBox2 = new ReaLTaiizor.Controls.ParrotPictureBox();
            SuspendLayout();
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.SeaShell;
            passwordTextBox.Location = new Point(93, 234);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(170, 23);
            passwordTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 14.25F);
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(99, 111);
            label1.Name = "label1";
            label1.Size = new Size(164, 33);
            label1.TabIndex = 1;
            label1.Text = "Введите логин";
            // 
            // userTextBox
            // 
            userTextBox.BackColor = Color.SeaShell;
            userTextBox.Location = new Point(93, 147);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(164, 23);
            userTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 14.25F);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(93, 183);
            label2.Name = "label2";
            label2.Size = new Size(178, 33);
            label2.TabIndex = 5;
            label2.Text = "Введите пароль";
            label2.Click += label2_Click;
            // 
            // foxBigLabel1
            // 
            foxBigLabel1.BackColor = Color.FromArgb(0, 64, 64);
            foxBigLabel1.Dock = DockStyle.Top;
            foxBigLabel1.Font = new Font("Segoe Print", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            foxBigLabel1.ForeColor = Color.FromArgb(192, 255, 255);
            foxBigLabel1.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            foxBigLabel1.LineColor = Color.FromArgb(200, 200, 200);
            foxBigLabel1.Location = new Point(0, 0);
            foxBigLabel1.Name = "foxBigLabel1";
            foxBigLabel1.Size = new Size(354, 91);
            foxBigLabel1.TabIndex = 6;
            foxBigLabel1.Text = "Войти";
            // 
            // cyberButton1
            // 
            cyberButton1.Alpha = 20;
            cyberButton1.BackColor = Color.Transparent;
            cyberButton1.Background = true;
            cyberButton1.Background_WidthPen = 4F;
            cyberButton1.BackgroundPen = true;
            cyberButton1.ColorBackground = Color.FromArgb(0, 64, 64);
            cyberButton1.ColorBackground_1 = Color.FromArgb(0, 64, 64);
            cyberButton1.ColorBackground_2 = Color.FromArgb(0, 64, 64);
            cyberButton1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorPen_1 = Color.FromArgb(128, 128, 255);
            cyberButton1.ColorPen_2 = Color.FromArgb(128, 128, 255);
            cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton1.Effect_1 = true;
            cyberButton1.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton1.Effect_1_Transparency = 25;
            cyberButton1.Effect_2 = true;
            cyberButton1.Effect_2_ColorBackground = Color.White;
            cyberButton1.Effect_2_Transparency = 20;
            cyberButton1.Font = new Font("Segoe Print", 14.25F);
            cyberButton1.ForeColor = Color.FromArgb(192, 255, 255);
            cyberButton1.Lighting = false;
            cyberButton1.LinearGradient_Background = false;
            cyberButton1.LinearGradientPen = false;
            cyberButton1.Location = new Point(93, 282);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(172, 50);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 7;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "Войти";
            cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton1.Timer_Effect_1 = 5;
            cyberButton1.Timer_RGB = 300;
            cyberButton1.Click += cyberButton1_Click;
            // 
            // cyberButton2
            // 
            cyberButton2.Alpha = 20;
            cyberButton2.BackColor = Color.Transparent;
            cyberButton2.Background = true;
            cyberButton2.Background_WidthPen = 4F;
            cyberButton2.BackgroundPen = true;
            cyberButton2.ColorBackground = Color.FromArgb(0, 64, 64);
            cyberButton2.ColorBackground_1 = Color.FromArgb(0, 64, 64);
            cyberButton2.ColorBackground_2 = Color.FromArgb(0, 64, 64);
            cyberButton2.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberButton2.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton2.ColorPen_1 = Color.FromArgb(128, 128, 255);
            cyberButton2.ColorPen_2 = Color.FromArgb(128, 128, 255);
            cyberButton2.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton2.Effect_1 = true;
            cyberButton2.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton2.Effect_1_Transparency = 25;
            cyberButton2.Effect_2 = true;
            cyberButton2.Effect_2_ColorBackground = Color.White;
            cyberButton2.Effect_2_Transparency = 20;
            cyberButton2.Font = new Font("Segoe Print", 14.25F);
            cyberButton2.ForeColor = Color.FromArgb(192, 255, 255);
            cyberButton2.Lighting = false;
            cyberButton2.LinearGradient_Background = false;
            cyberButton2.LinearGradientPen = false;
            cyberButton2.Location = new Point(93, 349);
            cyberButton2.Name = "cyberButton2";
            cyberButton2.PenWidth = 15;
            cyberButton2.Rounding = true;
            cyberButton2.RoundingInt = 70;
            cyberButton2.Size = new Size(172, 50);
            cyberButton2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton2.TabIndex = 8;
            cyberButton2.Tag = "Cyber";
            cyberButton2.TextButton = "Закрыть";
            cyberButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton2.Timer_Effect_1 = 5;
            cyberButton2.Timer_RGB = 300;
            cyberButton2.Click += cyberButton2_Click;
            // 
            // parrotPictureBox2
            // 
            parrotPictureBox2.BackColor = Color.FromArgb(0, 64, 64);
            parrotPictureBox2.BackgroundImage = Properties.Resources.Fox;
            parrotPictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            parrotPictureBox2.ColorLeft = Color.DodgerBlue;
            parrotPictureBox2.ColorRight = Color.DodgerBlue;
            parrotPictureBox2.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox2.FilterAlpha = 200;
            parrotPictureBox2.FilterEnabled = true;
            parrotPictureBox2.Image = null;
            parrotPictureBox2.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox2.IsElipse = false;
            parrotPictureBox2.IsParallax = false;
            parrotPictureBox2.Location = new Point(269, 0);
            parrotPictureBox2.Name = "parrotPictureBox2";
            parrotPictureBox2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox2.Size = new Size(88, 91);
            parrotPictureBox2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox2.TabIndex = 20;
            parrotPictureBox2.Text = "parrotPictureBox2";
            parrotPictureBox2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // PasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(354, 431);
            Controls.Add(parrotPictureBox2);
            Controls.Add(cyberButton2);
            Controls.Add(cyberButton1);
            Controls.Add(foxBigLabel1);
            Controls.Add(label2);
            Controls.Add(userTextBox);
            Controls.Add(label1);
            Controls.Add(passwordTextBox);
            MaximumSize = new Size(370, 470);
            MinimumSize = new Size(370, 470);
            Name = "PasswordForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwordTextBox;
        private Label label1;
        private TextBox userTextBox;
        private Label label2;
        private ReaLTaiizor.Controls.FoxBigLabel foxBigLabel1;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private ReaLTaiizor.Controls.CyberButton cyberButton2;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox2;
    }
}