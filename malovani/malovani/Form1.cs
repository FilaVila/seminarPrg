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
        bool RainbowActiv;
        int x;
        int y;
        char tool = 'A';
        Random rnd = new Random();
        Graphics graphics;
        Pen pen = new Pen (Color.Black,3);
        SolidBrush brush = new SolidBrush (Color.Black); //musím mít nastavený nějaký pen, abych mohl použít pen.StartCap
        public Form1()
        {
            InitializeComponent();
            graphics = panel1.CreateGraphics();
            graphics.SmoothingMode =System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round; //převzato z oficiální microsoft podpory
            textBoxSize.Text = "3 px"; //aby textbox ukazoval hodnotu hned po spuštění
        }
        public void SliderSet(Pen pen) //každý štětec má předpřipravenou tloušťku, když si ho vyberu tak se trackBar společne s textboxem nastaví na tuto hodnotu
        {
            trackBarSize.Value = Convert.ToInt32(pen.Width);
            textBoxSize.Text = trackBarSize.Value.ToString() + " px";
        }
        public void SetColor(Color color) 
        {
            RainbowActiv = false;
            pen.Color = color;
            brush.Color = color;
            pictureBoxCheck.BackColor = color;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) //funkce zjistí jestli vdržím LTM a zjistí polohu kurzoru
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
        private void panel1_Move(object sender, EventArgs e) //nepoužívat
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e) //this is where the magic happens
        {
            if (MouseACtive && x!=0 &&y!=0)
            {
                if (RainbowActiv)
                {
                    Color rainbow = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                    pen.Color = rainbow;
                    brush.Color = rainbow;
                    pictureBoxCheck.BackColor = rainbow;
                }
                switch (tool)
                {

                    case 'A':
                        graphics.DrawLine(pen, new Point(x, y), e.Location);
                        x = e.X;
                        y = e.Y;
                        break;
                    default:

                        break;
                }
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            SolidBrush brushClear = new SolidBrush((Color)Color.White);
            graphics.FillRectangle(brushClear, -1, -1, panel1.Width, panel1.Height);
        }

        private void pictureBoxRainbow_Click(object sender, EventArgs e)
        {
            RainbowActiv = true;
        }

        private void pictureBoxYellow_Click(object sender, EventArgs e)
        {
            SetColor(Color.Yellow);
        }

        private void pictureBoxGray_Click(object sender, EventArgs e)
        {
            SetColor(Color.Gray);
        }

        private void pictureBoxGreen_Click(object sender, EventArgs e)
        {
            SetColor(Color.Lime);
        }

        private void pictureBoxPink_Click(object sender, EventArgs e)
        {
            SetColor(Color.Fuchsia);
        }

        private void pictureBoxBlue_Click(object sender, EventArgs e)
        {
            SetColor(Color.Blue);
        }

        private void pictureBoxBlack_Click(object sender, EventArgs e)
        {
            SetColor(Color.Black);
        }

        private void pictureBoxRed_Click(object sender, EventArgs e)
        {
            SetColor(Color.Red);
        }

        private void buttonEraser_Click(object sender, EventArgs e)
        {
            SetColor(Color.White);
            
        }

        private void trackBarSize_Scroll(object sender, EventArgs e) //mimochodem když používám slider tak se mění kurzor na ručičku
        {
            textBoxSize.Text = trackBarSize.Value.ToString() + " px";
            pen.Width = trackBarSize.Value;
            
        }

        private void textBoxSize_TextChanged(object sender, EventArgs e) //nešahat
        {

        }
        private void buttonPencil_Click(object sender, EventArgs e)
        {
            tool = 'A';
            pen.Width = 3;
            SetColor(Color.Black);
            SliderSet(pen);

        }
        private void buttonBrush_Click(object sender, EventArgs e)
        {
            tool = 'B';
        }

        private void buttonPen_Click(object sender, EventArgs e)
        {
            tool = 'C';
        }

        private void buttonVoskovka_Click(object sender, EventArgs e)
        {
            tool = 'D';
        }

        private void buttonSpray_Click(object sender, EventArgs e)
        {
            tool = 'E';
        }
    }
}
