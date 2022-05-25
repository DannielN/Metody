using System;
using System.Windows.Forms;

namespace MatematikaUtil
{
    public class Matematikautil
    {
        /// <summary>
        /// Funkce vrací výsledek mocniny y^x
        /// </summary>
        /// <param name="x"> číslo na které mocnime </param>
        /// <param name="y"> mocněné číslo </param>
        /// <returns></returns>
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
