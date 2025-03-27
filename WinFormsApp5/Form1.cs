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
            Image obrazek = pictureBox1.Image;
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
    }
}
