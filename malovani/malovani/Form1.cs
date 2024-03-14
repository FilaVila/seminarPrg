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
        Pen pen = new Pen (Color.Black,3);
        SolidBrush brush = new SolidBrush (Color.Black);
        public Form1()
        {
            InitializeComponent();
            graphics = panel1.CreateGraphics();
            graphics.SmoothingMode =System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round; //převzato z oficiální microsoft podpory
            textBoxSize.Text = "3 px"; //aby textbox ukazoval hodnotu hned po spuštění
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
            pictureBoxCheck.BackColor = Color.Black;
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

        private void pictureBoxRainbow_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxYellow_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Yellow;
            brush.Color = Color.Yellow;
            pictureBoxCheck.BackColor = Color.Yellow;
        }

        private void pictureBoxGray_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Gray;
            brush.Color = Color.Gray;
            pictureBoxCheck.BackColor = Color.Gray;
        }

        private void pictureBoxGreen_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Lime;
            brush.Color = Color.Lime;
            pictureBoxCheck.BackColor = Color.Lime;
        }

        private void pictureBoxPink_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Fuchsia;
            brush.Color = Color.Fuchsia;
            pictureBoxCheck.BackColor = Color.Fuchsia;
        }

        private void pictureBoxBlue_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Blue;
            brush.Color = Color.Blue;
            pictureBoxCheck.BackColor = Color.Blue;
        }

        private void pictureBoxBlack_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Black;
            brush.Color = Color.Black;
            pictureBoxCheck.BackColor = Color.Black;
        }

        private void pictureBoxRed_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
            brush.Color = Color.Red;
            pictureBoxCheck.BackColor = Color.Red;
        }

        private void buttonEraser_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
            brush.Color = Color.White;
            pictureBoxCheck.BackColor = Color.White;
        }

        private void trackBarSize_Scroll(object sender, EventArgs e)
        {
            textBoxSize.Text = trackBarSize.Value.ToString() + " px";
            pen.Width = trackBarSize.Value;
            
        }

        private void textBoxSize_TextChanged(object sender, EventArgs e) //nešahat
        {

        }

        private void buttonBrush_Click(object sender, EventArgs e)
        {

        }

        private void buttonPen_Click(object sender, EventArgs e)
        {

        }

        private void buttonVoskovka_Click(object sender, EventArgs e)
        {

        }

        private void buttonSpray_Click(object sender, EventArgs e)
        {

        }
    }
}
