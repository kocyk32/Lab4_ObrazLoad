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
    }
}
