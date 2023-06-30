using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoForms
{
    public partial class Child : Form
    {
        Parent parent = null;
        private static Bitmap img = new Bitmap(Properties.Resources.child);
        public Child()
        {
            InitializeComponent();
        }
        public Child(Parent parent)
        {
            InitializeComponent();
            this.parent = parent;
            BackgroundImage = img;
            Size = new System.Drawing.Size(img.Width, img.Height);
        }

        private void Child_Load(object sender, EventArgs e)
        {

        }

        private void textBoxChild_TextChanged(object sender, EventArgs e)
        {

            parent.somet = textBoxChild.Text;
            parent.textBox1.Text = parent.somet;
        }


    }
}
