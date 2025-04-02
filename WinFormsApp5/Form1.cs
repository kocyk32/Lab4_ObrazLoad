namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Wybierz plik graficzny | *.jpg;* *.jpeg;* *.png;* *.gif;* ";
                openFileDialog.Title = "wybierz obrazek";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);

                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Image obrazek = pictureBox1.Image;
            obrazek.RotateFlip(RotateFlipType.Rotate90FlipX);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Image obrazek = pictureBox1.Image;
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                Image obrazek = pictureBox1.Image;
                if (radioButton1.Checked)
                {
                    obrazek.RotateFlip(RotateFlipType.Rotate90FlipX);

                }
                if (radioButton2.Checked)
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);

                }
                if (radioButton3.Checked)
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipX);

                }
                pictureBox1.Refresh();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Image obrazek = pictureBox1.Image;
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap original = new Bitmap(pictureBox1.Image);
                Bitmap inverted = new Bitmap(original.Width, original.Height);

                for (int y = 0; y < original.Height; y++)
                {
                    for (int x = 0; x < original.Width; x++)
                    {
                        Color pixelColor = original.GetPixel(x, y);
                        Color invertedColor = Color.FromArgb(
                            pixelColor.A,
                            255 - pixelColor.R,
                            255 - pixelColor.G,
                            255 - pixelColor.B
                        );
                        inverted.SetPixel(x, y, invertedColor);
                    }
                }

                pictureBox1.Image = inverted;
            }
            else
            {
                MessageBox.Show("Najpierw za³aduj obraz!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap original = new Bitmap(pictureBox1.Image);
                original.RotateFlip(RotateFlipType.Rotate180FlipNone); // obrót o 180 stopni (wystarczy by by³ upside down)
                pictureBox1.Image = original;
            }
            else
            {
                MessageBox.Show("Najpierw za³aduj obraz!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

