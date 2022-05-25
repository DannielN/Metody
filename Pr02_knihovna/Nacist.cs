using System;

namespace Pr02_knihovna
{
    public class generuj
    {
        /// <summary>
        ///  Generace aritmetické posloupnosti 
        /// </summary>
        /// <param name="pocet"></param>
        /// <param name="od1"></param>
        /// <param name="do2"></param>
        /// <returns></returns>
        static public int[] Nacti(int pocet, int od1 = 1, int do2 = 100)
        {
            int[] pole = new int[pocet];
            Random rnd = new Random();

            for (int k = 0; k < pocet; k++)
            {
                int x = rnd.Next(od1, do2 + 1);
                pole[k] = x;
            }
            return pole;
        }
    }
}
