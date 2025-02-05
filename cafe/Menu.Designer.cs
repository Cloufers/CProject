namespace cafe
{
    partial class Menu
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
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            button4 = new Button();
            buttonAdmin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Mistral", 36F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(192, 255, 255);
            label1.Location = new Point(79, 26);
            label1.Name = "label1";
            label1.Size = new Size(367, 76);
            label1.TabIndex = 0;
            label1.Text = "Кафешка Клод Моне";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.Font = new Font("Sitka Display", 12.7499981F);
            button2.Location = new Point(154, 153);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(200, 48);
            button2.TabIndex = 3;
            button2.Text = "Забронировать столик";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 255);
            button3.Font = new Font("Sitka Display", 12.7499981F);
            button3.Location = new Point(154, 229);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(200, 45);
            button3.TabIndex = 4;
            button3.Text = "Связаться с нами";
            button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(192, 255, 255);
            label2.Location = new Point(192, 102);
            label2.Name = "label2";
            label2.Size = new Size(116, 28);
            label2.TabIndex = 5;
            label2.Text = "Ваш Аккаунт";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 255, 255);
            button4.Font = new Font("Sitka Display", 12.7499981F);
            button4.Location = new Point(154, 298);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(200, 45);
            button4.TabIndex = 6;
            button4.Text = "Оставить отзыв";
            button4.UseVisualStyleBackColor = false;
            // 
            // buttonAdmin
            // 
            buttonAdmin.BackColor = Color.FromArgb(192, 255, 255);
            buttonAdmin.Font = new Font("Sitka Display", 11F);
            buttonAdmin.Location = new Point(154, 363);
            buttonAdmin.Margin = new Padding(3, 2, 3, 2);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(200, 45);
            buttonAdmin.TabIndex = 7;
            buttonAdmin.Text = "Панель администрататора";
            buttonAdmin.UseVisualStyleBackColor = false;
            buttonAdmin.Click += adminButton_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(524, 478);
            Controls.Add(buttonAdmin);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Menu";
            Text = "KlodMone";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Button button4;
        private Button buttonAdmin;
    }
}
