using System;

namespace Pr01_Knih
{
    public class Posloupnost
    {
        static public int SoucetArPosl(int prvni_cislo, int druhy_cislo, int n, out int pamatuji, out int rozdil)
        {
            rozdil = druhy_cislo - prvni_cislo;
            pamatuji = prvni_cislo;
            int soucet = prvni_cislo;

            for (int k = 0; k < n - 1; k++)
            {
                prvni_cislo += rozdil;
                soucet += prvni_cislo;
                pamatuji += rozdil;
            }
            return soucet;
        }
    }
}
