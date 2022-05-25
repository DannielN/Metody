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

namespace Pr06
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
            string nejslovo = string.Empty;
            string nejmslovo = string.Empty;
            bool obsahuje = Retezutil.ObsahujeSlovo(text, out nejslovo, out nejmslovo);

            if (obsahuje)
            {
                label1.Text = ("Řetězec obsahuje slovo");
                label2.Text = ("Nejdelsi slovo " + nejslovo);
                label3.Text = ("Nejmensi slovo " + nejmslovo);
            }
            else
            {
                label1.Text = ("Řetězec neobsahuje slovo");
            }
        }
    }
}
