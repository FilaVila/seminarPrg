using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulacka2._0
{
    public partial class Form1 : Form
    {
        string number ="";
        int n1; //number 1
        int n2; // number 2
        char o; //operation
        double result; //výsledek
        string Ans; //uložení paměti
        public Form1()
        {
            InitializeComponent();
        }

        public void RN1() //read number 1
        {
            n1 = Convert.ToInt32(textBox1.Text);
            number = "";
        }
        public void RN2() //read number 2
        {
            n2 = Convert.ToInt32(textBox1.Text);
            number = "";
        }

        public void PN() //print number
        {
            textBox1.Text = number;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number = number + "1";
            PN();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            number = number + "2";
            PN();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            number = number + "3";
            PN();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            number = number + "4";
            PN();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            number = number + "5";
            PN();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            number = number + "6";
            PN();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            number = number + "7";
            PN();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            number = number + "8";
            PN();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            number = number + "9";
            PN();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            number = number + "0";
            PN();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            RN1();
            o = 'p';
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            RN1();
            o = 'm';
        }

        private void buttonNas_Click(object sender, EventArgs e)
        {
            RN1();
            o = 'n';
        }

        private void buttonDeleno_Click(object sender, EventArgs e)
        {
            RN1();
            o = 'd';
        }

        private void buttonRov_Click(object sender, EventArgs e)
        {
            RN2();
            switch (o)
            {
                case 'p':
                    result = n1 + n2;
                    break;
                case 'm':
                    result = n1 - n2;
                    break;
                case 'n':
                    result = n1 * n2;
                    break;
                case 'd':
                    if (n2!=0)
                    {
                        result = n1 / n2;
                    }
                    else
                    {
                        textBox1.Text = "Na násobení 0 potřebuješ limitu a to fakt neumím";
                    }
                    break;
                default:
                    break;
            }
            textBox1.Text = result.ToString();
            Ans = result.ToString();            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void buttonAns_Click(object sender, EventArgs e)
        {
            textBox1.Text = Ans.ToString();
        }
    }
}
