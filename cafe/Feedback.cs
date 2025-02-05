using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe
{
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
            InitializeStarPictureBox();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        { }




        private void pbStars_Click(object sender, EventArgs e)
        { }
        private const int StarCount = 5;
        private int selectedStars = 0;

        private void InitializeStarPictureBox()
        {
            pbStars.Image = CreateStarImage(0);
            pbStars.SizeMode = PictureBoxSizeMode.StretchImage;
            pbStars.Click += PbStars_Click;
        }

        private void PbStars_Click(object sender, EventArgs e)
        {
            // Определяем, сколько звезд выбрано
            Point mousePosition = pbStars.PointToClient(Cursor.Position);
            int starWidth = pbStars.Width / StarCount;

            selectedStars = mousePosition.X / starWidth + 1;
            if (selectedStars > StarCount) selectedStars = StarCount;

            pbStars.Image = CreateStarImage(selectedStars);
        }

        private Image CreateStarImage(int filledStars)
        {
            Bitmap bitmap = new Bitmap(pbStars.Width, pbStars.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                for (int i = 0; i < StarCount; i++)
                {
                    Image starImage = (i < filledStars) ? Properties.Resources.StarFilled : Properties.Resources.StarEmpty;
                    g.DrawImage(starImage, i * (bitmap.Width / StarCount), 0, bitmap.Width / StarCount, bitmap.Height);
                }
            }
            return bitmap;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string review = textBox1.Text;
            MessageBox.Show($"Отзыв: {review}\nОценка: {selectedStars} ", "Отправлено");
        }
    }
}

    

