using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static public bool ObsahujeSlovo(string text, out string dlouheslovo)
        {
            bool obsahuje = true;
            string slovo = string.Empty;
            
            int delkaslova = 0;
            int nejdelsislovo = 0;
            dlouheslovo = string.Empty;

            foreach (char znaky in text)
            {
                if (znaky != ' ')
                {
                    if (znaky > '0' && znaky < '9')
                    {
                        slovo = string.Empty;
                    }
                    else
                    {
                        slovo += znaky;
                    }
                }
                else
                {
                    delkaslova = slovo.Length;
                    if (delkaslova > nejdelsislovo)
                    {
                        nejdelsislovo = delkaslova;
                        dlouheslovo = slovo;
                    }
                    else
                    {
                        delkaslova = 0;
                        slovo = string.Empty;
                    }
                }
            }

            return obsahuje;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string nejslovo = string.Empty;
            bool obsahuje = ObsahujeSlovo(text, out nejslovo);

            if (obsahuje)
            {
                label1.Text = ("Řetězec obsahuje slovo");
                label2.Text = ("Nejdelsi slovo " + nejslovo);
            }
            else
            {
                label1.Text = ("Řetězec neobsahuje slovo");
            }
        }
    }
}
