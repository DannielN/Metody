using Pr03_Knih;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text); 
            int c = Convert.ToInt32(textBox3.Text);

            int obsah = Obsah_Objem.O
            if (radioButton1.Checked)
            {
                label4.Text = ("Obsah čtverce " + Math.Round(,3));
                label5.Text = ("Úhlopříčka čtverce " + Math.Round(,3));
            }
            else if (radioButton2.Checked)
            {
                
                label4.Text = ("Obsah obdelníku " + Math.Round(obsah,3));
                label5.Text = ("Úhlopříčka obdelníku " + Math.Round(uhlopricka,3));

            } else if (radioButton3.Checked)
            {
                

                label4.Text = ("Objem krychle " + Math.Round(objem_k,3));
                label5.Text = ("Úhlopříčka krychle " + Math.Round(uhlopricka_k,3));
            } else
            {
                
                label4.Text = ("Objem kvádru " + Math.Round(objem_k, 3));
                label5.Text = ("Úhlopříčka kvádru " + Math.Round(uhlopricka_k, 3));
            }
        }
        /* čtverec úhlopříčka u = a* sqrt 2 */
        /* obdelník obsah a * b */
        /* objem krychle a^3  uhlopricka a*sqrt 3*/
        /* objem kvadru a * b * c uhlopricka = sqrt a^2 + b^2 + c^2 */
    }
}
