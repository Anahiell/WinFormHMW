using System.Drawing.Imaging;
using System.Globalization;
using System.Windows.Forms;

namespace Screnshot_Localz
{
    public partial class Form1 : Form
    {
        private static Bitmap bmpScreenshot;
        private static Graphics gfxScreenshot;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dlg.ShowDialog() == DialogResult.OK)//указывем путь куда наскриншотим
            {
                this.Hide();
                bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
                gfxScreenshot = Graphics.FromImage(bmpScreenshot);
                count = 0;//обнуляем счетчик
                timer1.Start();//стартуем
            }

            if (this.count == 5)
            {
                timer1.Stop();
                this.Show();//предохранитель
            }
            else
                timer1.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count != 5)
            {
                str = $"/{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}_{DateTime.Now.Second}_{DateTime.Now.Microsecond}.png";
                // Take the screenshot from the upper left corner to the right bottom corner
                gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
                // Save the screenshot to the specified path that the user has chosen
                bmpScreenshot.Save(dlg.SelectedPath + str);
                count++;
            }
            else
                this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            Controls.Clear();
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("uk-UA");
            Controls.Clear();
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("pl-PL");
            Controls.Clear();
            InitializeComponent();
        }
    }
}