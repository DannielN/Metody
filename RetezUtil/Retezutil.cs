using System;

namespace RetezUtil
{
    public class Retezutil
    {
        /// <summary>
        /// Funkce vrací bool zda je námi zadané číslo prvočíslo či ne
        /// </summary>
        /// <param name="cislo"> číslo pro které zjištujeme zda je prvočíslo nejvíce optamalizovanou metodou </param>
        /// <returns></returns>
        public static bool Prvocislo(int cislo)
        {
            if (cislo == 1 || cislo > 2 && cislo % 2 == 0) return false;
            for (int delitel = 3; delitel <= Math.Sqrt(cislo); delitel += 2)
            {
                if (cislo % delitel == 0) return false;
            }
            return true;
        }

        /// <summary>
        /// Celá funkce vrací bool jestli je funkce alfanumerická či ne, parametry a jejich funkce popsané níže
        /// </summary>
        /// <param name="text"> bere text s kterým budeme pracovat </param>
        /// <param name="maly_pismena"> ze stringu počítá počet malých písmen </param>
        /// <param name="pocet_cifer"> počet cifer ze stringu </param>
        /// <param name="jiny_znak"> počítá počet jiných znaku než jsou čísla a písmena </param>
        /// <param name="prvcsl"> bool který zjištuje zda je počet všech znaku bez mezer prvočíslo </param>
        /// <returns></returns>
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

        /// <summary>
        /// Funkce vrátí text bez čísel
        /// </summary>
        /// <param name="text"> Text zadaný uživatelem </param>
        /// <returns></returns>
        static public string Smaz(string text)
        {
            string novy_text = string.Empty;

            foreach (char znaky in text)
            {
                if (znaky != ' ')
                {
                    if (znaky < '0' || znaky > '9')
                    {
                        novy_text += znaky;
                    }
                }
            }
            return novy_text;
        }

        /// <summary>
        /// Funkce vrací bool jestli se ve stringu nacházi slovo či ne
        /// </summary>
        /// <param name="text"> text ve stringové podobě zadané uživatelem </param>
        /// <param name="dlouheslovo"> string s nejdelším slovem </param>
        /// <param name="kratekeslovo"> string s nejkratším slovem </param>
        /// <returns></returns>
        static public bool ObsahujeSlovo(string text, out string dlouheslovo, out string kratekeslovo)
        {
            bool obsahuje = true;
            string slovo = string.Empty;

            int delkaslova = 0;
            int nejdelsislovo = 0;
            int nejkratsislovo = 0;
            kratekeslovo = string.Empty;
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

                    delkaslova = slovo.Length;
                    if (delkaslova > nejdelsislovo)
                    {
                        nejdelsislovo = delkaslova;
                        dlouheslovo = slovo;
                    }
                    else if (delkaslova < nejkratsislovo)
                    {
                        nejkratsislovo = delkaslova;
                        kratekeslovo = slovo;
                    }
                    else
                    {
                        delkaslova = 0;
                        slovo = string.Empty;
                    }
                }
                else
                { }
            }

            return obsahuje;
        }
    }
}
