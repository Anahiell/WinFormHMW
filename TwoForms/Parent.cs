namespace TwoForms
{
    public partial class Parent : Form
    {
        private static Bitmap img = new Bitmap(Properties.Resources.perent);
        public Parent()
        {
            InitializeComponent();
            BackgroundImage = img;
            Size = new System.Drawing.Size(img.Width, img.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            child = new Child(this);
            this.Location = new Point(100, 100);
            child.StartPosition = FormStartPosition.CenterScreen;
            child.Show();
            child.Location = new Point(800, 100);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            child.textBoxChild.Text = this.textBox1.Text;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            child.textBoxChild.Text = this.textBox1.Text;
        }
    }
}