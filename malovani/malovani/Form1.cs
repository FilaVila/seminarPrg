using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace malovani
{
    public partial class Form1 : Form
    {
        bool MouseACtive;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 35);
            SolidBrush brush = new SolidBrush(Color.Black);
            if (MouseACtive == true)
            {
                int a = MousePosition.X;
                int b = MousePosition.Y;
                g.FillEllipse(brush, a, b, 10, 10);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseACtive = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseACtive = false;
        }
    }
}
