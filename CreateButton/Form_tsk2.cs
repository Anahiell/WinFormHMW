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
    public partial class Form_tsk2 : Form
    {
        public Form_tsk2()
        {
            InitializeComponent();
        }

        private void Form_tsk2_Load(object sender, EventArgs e)
        {

        }

        private void Form_tsk2_Enter(object sender, EventArgs e)
        {
        }

        private void button_catch_MouseEnter(object sender, EventArgs e)
        {

            Random rnd1 = new Random();
            Random rnd2 = new Random();
            button_catch.Location = new Point(rnd1.Next(this.Size.Width - 150), rnd2.Next(this.Size.Height - 80));

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
