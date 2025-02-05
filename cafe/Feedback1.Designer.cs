namespace cafe
{
    partial class Feedback1
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
            textBox1 = new TextBox();
            pbStars = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbStars).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 381);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(517, 239);
            textBox1.TabIndex = 0;
            // 
            // pbStars
            // 
            pbStars.Image = Properties.Resources.StarEmpty;
            pbStars.Location = new Point(36, 111);
            pbStars.Name = "pbStars";
            pbStars.Size = new Size(663, 157);
            pbStars.SizeMode = PictureBoxSizeMode.Zoom;
            pbStars.TabIndex = 1;
            pbStars.TabStop = false;
            pbStars.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 70);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 2;
            label1.Text = "Поставьте нам оценку";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 358);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 3;
            label2.Text = "Напишите свой отзыв";
            // 
            // button1
            // 
            button1.Location = new Point(293, 626);
            button1.Name = "button1";
            button1.Size = new Size(160, 30);
            button1.TabIndex = 4;
            button1.Text = "Отправить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Feedback1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 736);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbStars);
            Controls.Add(textBox1);
            Name = "Feedback1";
            Text = "Feedback1";
            ((System.ComponentModel.ISupportInitialize)pbStars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private PictureBox pbStars;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}