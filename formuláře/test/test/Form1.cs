using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int counter = 0;
            if (a == 7)
            {
                counter++;
            }
            if (b == 9)
            {
                counter++;
            }
            if (c == 5)
            {
                counter++;
            }
            progressBar1.Value = counter;
            switch (counter)
            {
                case 0:
                    labelVysledek.Text = "jedinej důvod proč nejsi v babyboxu \n jsou tvoje rozměry --- s láskou máma";
                    break;
                case 1:
                    labelVysledek.Text = "rodiče tě možná pozvou na Vánoce";
                    break;
                case 2:
                    labelVysledek.Text = "no dejme tomu";
                    break;
                case 3:
                    labelVysledek.Text = "hranice geniality byly posunuty";
                    break;
                default:
                    break;
            }
        }
    }
}
