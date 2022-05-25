using MatematikaUtil;
using Pr02_Knih;
using RetezUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int soucetlich = 1;

            int pocetcifer = Poleutil.ObsahujeCifru(text, out soucetlich);
          
            label1.Text = ("Pocet cifer " + pocetcifer + " Soucet lich cifer " + soucetlich);
            bool Prv = Retezutil.Prvocislo(soucetlich);
            if (Prv)
            {
                label2.Text = ("Soucet lich cisel je prvocislo ");
            }
            else
            {
                label2.Text = ("Soucet lich cisel neni prvocislo ");
            }
        }
    }
}
