using System;
using System.Windows.Forms;

namespace MatematikaUtil
{
    public class Matematikautil
    {
        public static int Mocnina( int x, int y)
        {
            int vysledek = 1;
            for (int l = 0; l < x; l++)
            {
                int cislo = y;
                vysledek = vysledek * cislo;
            }
            return vysledek;
        }
    }
}
