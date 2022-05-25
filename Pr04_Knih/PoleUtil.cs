using System;
using System.Windows.Forms;

namespace Pr04_Knih
{
    public class PoleUtil
    {
        public static void Nulovani(int[] pole, int x)
        {

            int cislo = 0;
            for (int m = 0; m < N; m++)
            {
                cislo = pole[m];
                if (cislo < 0)
                {
                    pole[m] = 0;
                }
                else
                {
                    
                    pole[m] = vysledek;
                }
                L.Items.Add(pole[m]);
            }
        }
    }
}
