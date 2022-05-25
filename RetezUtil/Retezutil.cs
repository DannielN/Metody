using System;

namespace RetezUtil
{
    public class Retezutil
    {
        public static bool Prvocislo(int cislo)
        {
            if (cislo == 1 || cislo > 2 && cislo % 2 == 0) return false;
            for (int delitel = 3; delitel <= Math.Sqrt(cislo); delitel += 2)
            {
                if (cislo % delitel == 0) return false;
            }
            return true;
        }

        static public bool JeAlfanum(string text, out int maly_pismena, out int pocet_cifer, out int jiny_znak, out bool prvcsl)
        {
            bool je = true;
            maly_pismena = 0;
            pocet_cifer = 0;
            jiny_znak = 0;
            int pocetznaku = 0;

            foreach (char znaky in text)
            {
                if (znaky != ' ')
                {
                    pocetznaku++;
                    if (znaky >= 'a' && znaky <= 'z')
                    {
                        maly_pismena++;
                    }
                    else if (znaky >= 'A' && znaky <= 'Z') /* Te92*/
                    {

                    }
                    else if (znaky >= '0' && znaky <= '9')
                    {
                        pocet_cifer++;
                    }
                    else
                    {
                        jiny_znak++;
                        if (jiny_znak != 0)
                        {
                            je = false;
                        }
                    }
                }
                else
                {

                }
            }
            prvcsl = Retezutil.Prvocislo(pocetznaku);
            return je;
        }
    }
}
