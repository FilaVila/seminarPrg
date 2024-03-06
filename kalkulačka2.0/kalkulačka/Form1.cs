using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulačka
{
    public partial class Form1 : Form
    {
        string number ="";
        int a;
        int b;
        int op;
        int vysledek;
        int answer;
        public Form1()
        {
            InitializeComponent();
        }

        private void b1() 
        {
            number = number + "1";
            textBoxCislo1.Text = number;
        }
        private void b2()
        {
            number = number + "2";
            textBoxCislo1.Text = number;
        }
        private void b3()
        {
            number = number + "3";
            textBoxCislo1.Text = number;
        }
        private void b4()
        {
            number = number + "4";
            textBoxCislo1.Text = number;
        }
        private void b5()
        {
            number = number + "5";
            textBoxCislo1.Text = number;
        }
        private void b6()
        {
            number = number + "6";
            textBoxCislo1.Text = number;
        }
        private void b7()
        {
            number = number + "7";
            textBoxCislo1.Text = number;
        }
        private void b8()
        {
            number = number + "8";
            textBoxCislo1.Text = number;
        }
        private void b9()
        {
            number = number + "9";
            textBoxCislo1.Text = number;
        }
        private void b0()
        {
            number = number + "0";
            textBoxCislo1.Text = number;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b3();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            b4();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            b5();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            b6();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            b7();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            b8();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            b9();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            b0();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            number = "";
            textBoxCislo1.Text = "";
            textBoxCislo2.Text = "";
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            number = answer.ToString();
        }

        private void buttonRovnase_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBoxCislo1.Text);
            op = listBoxOperator.SelectedIndex;
            b = Convert.ToInt32(textBoxCislo2.Text);
            switch (op)
            {
                case 0:
                    vysledek = a + b;
                    break;
                case 1:
                    vysledek = a - b;
                    break;
                case 2:
                    vysledek = a * b;
                    break;
                case 3:
                    if (b != 0)
                    {
                        vysledek = a / b;
                    }
                    break;
                default:
                    break;
            }
            textBoxVysledek.Text = vysledek.ToString();
            answer = vysledek;
        }
    }
}
