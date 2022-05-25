using Pr01_Knih;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int prvni = Convert.ToInt32(textBox2.Text);
            int druhy = Convert.ToInt32(textBox3.Text);

            int soucet = Posloupnost.SoucetArPosl(prvni, druhy, n, out int p, out int r);

            label4.Text = ("Součet je " + soucet + " poslední prvek je " + p + " , a diference je " + r);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
