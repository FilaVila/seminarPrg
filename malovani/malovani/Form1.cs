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
        int x2; //počáteční bod obrazců
        int y2;
        int g=0;
        int w; //šířka a výška obrazců
        int h;
        char obj;
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
            trackBarSize.Enabled = true;
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
        private void panel1_MouseDown(object sender, MouseEventArgs e) //funkce zjistí jestli držím LTM a zjistí polohu kurzoru
        {
            MouseACtive = true; 
            x = e.X;
            y = e.Y;
            if (g == 1)
            {
                x2 = e.X;
                y2 = e.Y;
                textBoxPB.Text = x2.ToString() + ";" + y2.ToString();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseACtive = false;
            x = 0;
            y = 0;
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
                    case 'B':
                        Pen PaintingB = new Pen(Color.FromArgb(17,pen.Color),pen.Width); //definoval jsem nový štětec, který je transparentní, Alpha = 17
                        PaintingB.StartCap = PaintingB.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        graphics.DrawLine(PaintingB, new Point(x, y), e.Location);
                        x = e.X;
                        y = e.Y;
                        break;
                    case 'C': //zde pomohl ChatGpt s výpočtem vzdálenosti                    
                        double distance = Math.Sqrt(Math.Pow(e.X - x, 2) + Math.Pow(e.Y - y, 2));
                        double speed = distance/pen.Width; // simuluje rychlost
                        float CWidth =(float)(pen.Width/speed);//čím pomalejší tím širší
                        Pen Cpen = new Pen(pen.Color, CWidth);
                        Cpen.StartCap = Cpen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        graphics.DrawLine(Cpen, new Point(x, y), e.Location);
                        x = e.X;
                        y = e.Y;
                        break;
                    case 'D':
                        int CrWidth = Convert.ToInt32(pen.Width);
                        Pen Crayon = new Pen(Color.FromArgb(9,pen.Color), CrWidth+rnd.Next(-5,5));
                        Crayon.StartCap = Crayon.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        for (int i = -CrWidth/2; i < CrWidth/2; i++)
                        {
                            graphics.DrawLine(Crayon, x, y, e.X + 1, e.Y + i);                          
                        }
                        x = e.X;
                        y = e.Y;
                        break;
                    case 'E':
                        int off = Convert.ToInt32(pen.Width);
                        int eS = rnd.Next(1, off/2);//poměry of jsou pokus omyl
                        graphics.FillEllipse(brush, e.X + rnd.Next(off,off*2), e.Y + rnd.Next(off, off*2),eS,eS); //malé kruhy náhodně od pozice
                        break;
                    default:

                        break;
                }
            }
        }
        private void buttonNew_Click(object sender, EventArgs e)
        {
            SolidBrush brushClear = new SolidBrush((Color)Color.White);
            graphics.FillRectangle(brushClear, -1, -1, panel1.Width+1, panel1.Height+1);
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
            pen.Width = 20;
            SliderSet(pen);
        }
        private void buttonPen_Click(object sender, EventArgs e)
        {
            tool = 'C';
            pen.Width = 3;
            SetColor(Color.FromArgb(51,0,102));
            trackBarSize.Enabled = false; //efekt není nad 3px vidět
            textBoxSize.Text = "ʕ•ᴥ•ʔ";

        }
        private void buttonVoskovka_Click(object sender, EventArgs e)
        {
            tool = 'D';
        }
        private void buttonSpray_Click(object sender, EventArgs e)
        {
            tool = 'E';
            pen.Width= 10;
            SliderSet(pen);
        }
        private void buttonEraser_Click(object sender, EventArgs e)
        {
            SetColor(Color.White);
            pen.Width = 5;
            SliderSet(pen);
        }
        private void trackBarSize_Scroll(object sender, EventArgs e) //mimochodem když používám slider tak se mění kurzor na ručičku
        {
            textBoxSize.Text = trackBarSize.Value.ToString() + " px";
            pen.Width = trackBarSize.Value;

        }        
        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            g = 1;
            obj = 'E';

        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            g = 1;
            obj = 'R';
        }

        private void buttonPaint_Click(object sender, EventArgs e)
        {
            g = 0;
            textBoxPB.Text = "";
            h = Convert.ToInt32(textBoxVyska.Text);
            w = Convert.ToInt32(textBoxSirka.Text);

            switch (obj)
            {
                case 'E':
                    graphics.DrawEllipse(pen, x2-w/2, y2-h/2, w, h);
                    if (checkBoxFill.Checked)
                    {
                        graphics.FillEllipse(brush, x2 - w/2, y2 - h / 2, w, h);
                    }
                    break;
                case 'R':
                    graphics.DrawRectangle(pen, x2 - w/2, y2 - h / 2, w, h);
                    if (checkBoxFill.Checked)
                    {
                        graphics.FillEllipse(brush, x2 - w/2, y2 - h / 2, w, h);
                    }
                    break;
                default:
                    break;
            }
        }
        private void textBoxSize_TextChanged(object sender, EventArgs e) //nešahat
        {

        }
        private void panel1_Move(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_Click(object sender, EventArgs e)
        {

        }
    }
}
