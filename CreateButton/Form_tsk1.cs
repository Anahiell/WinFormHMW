using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateButton
{
    public partial class Form_tsk1 : Form
    {
        public Form_tsk1()
        {
            InitializeComponent();
        }
        private Button button = new Button();
        private int wButton;
        private int hButton;
        private int count = 0;
        private int x1;
        private int y1;
        private int x;
        private int y;
        private int x_mouse_clik;//support
        private int y_mouse_clik;
        private void Form_tsk1_MouseUp(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
            wButton = x1 - x_mouse_clik;
            hButton = y1 - y_mouse_clik;
            if (wButton <= 0 || hButton <= 0)
            {
                if (wButton > 0 && hButton < 0)
                {
                    y = y1;
                    hButton = Math.Abs(hButton);
                }
                else if (wButton < 0 && hButton > 0)
                {
                    x = x1;
                    wButton = Math.Abs(wButton);
                }
                else if (wButton < 0 && hButton < 0)
                {
                    x = x1;
                    y = y1;
                    hButton = Math.Abs(hButton);
                    wButton = Math.Abs(wButton);
                }
            }

            button = new Button();
            button.Name = $"button{count}";
            button.Text = $"button{count}";
            button.TabIndex = 0;
            button.BackColor = Color.Brown;
            button.Location = new Point(x, y);
            button.Size = new Size(wButton, hButton);
            button.Visible = true;
            Controls.Add(button);
            count++;

            if (wButton < 35 || hButton < 35)
            {
                MessageBox.Show("Small Button", "Error");
                button.Dispose();
            }

        }

        private void Form_tsk1_MouseDown(object sender, MouseEventArgs e)
        {
            x_mouse_clik = e.X;
            y_mouse_clik = e.Y;
            x = e.X; y = e.Y;
        }
    }
}
