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
        int x;
        int y;
        Graphics graphics;
        Pen pen;
        SolidBrush brush;
        public Form1()
        {
            InitializeComponent();
            graphics = panel1.CreateGraphics();
            graphics.SmoothingMode =System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5); //abych mohl použít pen.StartCap musím prvně definovat jakékoliv Pen
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round; //převzato z oficiální microsoft podpory
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseACtive = true;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseACtive = false;
            x = 0;
            y = 0;
        }

        private void buttonPencil_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black, 3);
            brush = new SolidBrush(Color.Black);
        }

        private void panel1_Move(object sender, EventArgs e) //nepoužívat
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseACtive && x!=0 &&y!=0)
            {
                graphics.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            SolidBrush brushClear = new SolidBrush((Color)Color.White);
            graphics.FillRectangle(brushClear, 0, 0, panel1.Width, panel1.Height);
        }
    }
}
