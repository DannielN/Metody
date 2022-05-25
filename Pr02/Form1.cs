using Pr02_Knih;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            int pocet = Convert.ToInt32(textBox1.Text);
            int[] generuj;

            if (textBox2.Text != "" && textBox3.Text != "")
            {
                int od = Convert.ToInt32(textBox2.Text);
                int do_ = Convert.ToInt32(textBox3.Text);
                generuj = Generace.Nacti(pocet, od, do_);
            }
            else
            {
                generuj = Generace.Nacti(pocet);
            }


            Generace.Zobraz(generuj, listBox1);
            int ssp = Generace.Soucet_sud_pocet(generuj, out pocet);
            label4.Text = ("Součet sudých " + ssp + " Počet lichých " + pocet);

            if (Generace.Ne_rostouci(generuj))
            {
                label5.Text = ("Pole je rostoucí ");
            }
            else
            {
                label5.Text = ("Pole není roustoucí ");
            } 
            Generace.Vymena(generuj, listBox1);
            Generace.Zobraz(generuj, listBox2);

        }
    }
}
