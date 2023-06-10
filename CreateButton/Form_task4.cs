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
    public partial class Form_task4 : Form
    {
        public Form_task4()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
        }
        private int timeOut;
        private Button btnEnd;
        private int mouseClick;
        private void buttonStart_Click(object sender, EventArgs e)
        {
            mouseClick = 0;
            timeOut = 20;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            buttonStart.Visible = false;
            richTextBox1.Visible = false;
            buttonStart.Enabled = false;
            richTextBox1.Enabled = false;
            richTextFinish2.Visible = false;
            richTextFinish2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeOut == 0)
            {
                buttonStart.Enabled = true;
                richTextBox1.Enabled = true;
                richTextFinish2.Enabled=true;
                buttonStart.Visible = true;
                richTextBox1.Visible = true;
                richTextFinish2.Visible = true;
                richTextFinish2.Text = $"You make mouse click: {mouseClick}";
            }
            else
                timeOut--;
        }

        private void Form_task4_MouseClick(object sender, MouseEventArgs e)
        {
            if (timeOut != 0)
            {
                mouseClick++;
            }
            else
                return;
        }
    }
}
