using System.Globalization;

namespace Localut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//UA
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("uk-UA");
            Controls.Clear();
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)//pl
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("pl-PL");
            Controls.Clear();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//EN
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            Controls.Clear();
            InitializeComponent();
        }
    }
}