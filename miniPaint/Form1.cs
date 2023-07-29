using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                using (Pen pen = new Pen(Color.DarkGreen, 5.0f))
                {

                    SolidBrush brush = new SolidBrush(Color.LimeGreen);
                    g.FillEllipse(brush, new Rectangle(80, 80, 110, 150));//bode
                    g.DrawEllipse(pen, new Rectangle(80, 80, 110, 150));//bones bode
                    g.FillEllipse(brush, new Rectangle(105, 60, 60, 45));//head down
                    g.FillEllipse(brush, new Rectangle(114, 45, 40, 40));//head
                    g.FillEllipse(brush, new Rectangle(60, 110, 30, 30));//left arm
                    g.FillEllipse(brush, new Rectangle(180, 160, 30, 30));//right arm
                    g.FillRectangle(brush, new Rectangle(150, 200, 16, 55));//right leg
                    g.FillRectangle(brush, new Rectangle(110, 200, 16, 55));//left leg
                    brush.Color = Color.Brown;
                    g.FillRectangle(brush, new Rectangle(192, 53, 12, 200));//weapon1
                    brush.Color = Color.LightGray;
                    g.FillRectangle(brush, new Rectangle(192, 150, 12, 50));//weapon2
                    brush.Color = Color.DarkViolet;
                    g.FillRectangle(brush, new Rectangle(109, 240, 18, 7));//stripleg left
                    g.FillRectangle(brush, new Rectangle(149, 240, 18, 7));//stripleg right
                    g.FillRectangle(brush, new Rectangle(114, 55, 40, 10));//strip heaad
                    brush.Color = Color.GreenYellow;
                    g.FillRectangle(brush, new Rectangle(110, 110, 50, 80));//stom
                    g.FillEllipse(brush, new Rectangle(109, 160, 51, 51));//stom
                    brush.Dispose();
                }
            }
        }
    }
}
