using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateButton
{
    public partial class Form_task3 : Form
    {
        public Form_task3()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            //timer1.Tick += timer1_Tick;

        }
        DateTime dateNewYer = new DateTime(2023, 12, 31, 23, 55, 0);
        DateTime dateNow = DateTime.Now;
        private void timer1_Tick(object sender, EventArgs e)
        {
            dateNow = DateTime.Now;
            var time = dateNewYer - dateNow;
            richTextBox1.Text = $"{time.Days}:{time.Hours}:{time.Minutes}:{time.Seconds}";
            richTextBox1.Show();
        }

        private void Form_task3_Load(object sender, EventArgs e)
        {

        }
    }
}
