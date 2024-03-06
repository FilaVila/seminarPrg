using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kameni
{
    public partial class Form1 : Form
    {
        public Form1() //konstruktor
        {
            InitializeComponent();
        }

        private void mujCudlik_Click(object sender, EventArgs e)
        {
            mujCudlik.Text = "kliknuto";
            mujCudlik.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
