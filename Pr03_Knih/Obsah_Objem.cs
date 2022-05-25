using System;

namespace Pr03_Knih
{
    public class Obsah_Objem
    {
        /// <summary>
        /// Vypočítá obsah a úhlopříčku u čtverce
        /// </summary>
        /// <param name="a"> strana čtverce </param>
        /// <param name="uhlopricka"> úhlopříčka čtverce </param>
        /// <returns> Vrací obsah čtverce </returns>
        public int Obsah(int a, out double uhlopricka)
        {
            int obsah = a * a;
            uhlopricka = a * Math.Sqrt(2);

            return obsah;
        }

        /// <summary>
        /// Vypočítá obsah pro obdelník
        /// </summary>
        /// <param name="a"> strana a obdelníku </param>
        /// <param name="b"> strana b obdelníku </param>
        /// <param name="uhlopricka"> úhlopříčka obdelníku </param>
        /// <returns> vrací obsah obdelníku </returns>
        public int Obsah(int a, int b, out double uhlopricka)
        {
            int obsah = (a * b);
            uhlopricka = (Math.Sqrt((a * a) + (b * b)));

            return obsah;
        }

        /// <summary>
        /// Výpočet objemu krychle 
        /// </summary>
        /// <param name="a"> strana a krychle </param>
        /// <param name="b"> strana b krychle </param>
        /// <param name="uhlopricka_k"> úhlopříčka krychle </param>
        /// <returns> vrací objem krychle </returns>
        public double Objem(int a, double b, out double uhlopricka_k)
        {
            double objem_k = ((a * a) * a);
            uhlopricka_k = (a * Math.Sqrt(3));

            return objem_k;
        }

        /// <summary>
        /// Vypočet objemu kvádru
        /// </summary>
        /// <param name="a"> strana a kvádru </param>
        /// <param name="b"> strana b kvádru </param>
        /// <param name="c"> strana c kvádru </param>
        /// <param name="uhlopricka_k"> úhlopříčka kvádru </param>
        /// <returns> Vrací objem kvádru </returns>
        public double Objem(int a, double b, double c, out double uhlopricka_k)
        {
            double objem_k = (a * b * c);
            uhlopricka_k = (Math.Sqrt((a * a) + (b * b) + (c * c)));

            return objem_k;
        }
    }
}
