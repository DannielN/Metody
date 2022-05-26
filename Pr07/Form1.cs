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

namespace Pr07
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
            int maly_pismena = 0, pocet_cifer = 0, jiny_znak = 0;
            bool prvcsl;
            bool je_neni = Retezutil.JeAlfanum(text, out maly_pismena, out pocet_cifer, out jiny_znak);

            if (je_neni)
            {
                label1.Text = ("Slova jsou alfanumerické");
            }
            else
            {
                label1.Text = ("Slova nejsou alfanumerická");
            }

            label2.Text = ("Počet malých písmen " + maly_pismena);
            prvcsl = Retezutil.Prvocislo(pocet_cifer);
            label3.Text = ("Obsahuje cifer " + pocet_cifer);
            label4.Text = ("Jiných znaků " + jiny_znak);
            
            if (prvcsl)
            {
                label5.Text = ("Počet znaků je prvočíslo");
            }
            else
            {
                label5.Text = ("Počet znaků neni prvočíslo");
            }
        }
    }
}
