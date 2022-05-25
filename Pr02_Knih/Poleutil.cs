using MatematikaUtil;
using System;
using System.Windows.Forms;

namespace Pr02_Knih
{
    public class Poleutil
    {
        /// <summary>
        /// Funkce generuje pole čísel v intervalu zadaným uživatelem, pokud nezadá maximální číslo intervalu bude 100, uživatel
        /// si zadá i počet čísel který to vygeneruje
        /// </summary>
        /// <param name="pocet"> Velikost pole, počet prvků </param>
        /// <param name="od1"> Kde interval bude začínat </param>
        /// <param name="do2"> Kde interval končí </param>
        /// <returns> Funkce vrací pole čísel </returns>
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
        /// <summary>
        /// Pole čísel uloží do listboxu
        /// </summary>
        /// <param name="generuj"> Vygenerované pole čísel </param>
        /// <param name="l"> listbox </param>
        static public void Zobraz(int[] generuj, ListBox l)
        {
            l.Items.Clear();
            for (int k = 0; k < generuj.Length; k++)
            {
                l.Items.Add(generuj[k]);
            }
        }
        /// <summary>
        /// Funkce počítá součet sudých čísel a počet lichých čísel
        /// </summary>
        /// <param name="generuj"> Vygenerované pole čísel </param>
        /// <param name="pocet"> Počet lichých </param>
        /// <returns> Vrací součet sudých </returns>
        static public int Soucet_sud_pocet(int[] generuj, out int pocet)
        {
            int soucet = 0;
            pocet = 0;
            for (int k = 0; k < generuj.Length; k++)
            {
                if (generuj[k] % 2 == 0)
                {
                    soucet += generuj[k];
                }
                else
                {
                    pocet++;
                }
            }
            return soucet;
        }
        /// <summary>
        /// Funkce zjištujě či je pole v rostoucí nebo klesajicí posloupnosti 
        /// </summary>
        /// <param name="generuj"> Vygenerované pole čísel </param>
        /// <returns> Vrací bool pokud je true posloupnost je rostoucí </returns>
        public static bool Ne_rostouci(int[] generuj)
        {
            int predchozi = generuj[0];

            for (int k = 1; k < generuj.Length; k++)
            {
                if (generuj[k] > predchozi)
                {
                    predchozi = generuj[k];
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Funkce vymění poslední prvek s maximálním prvkem
        /// </summary>
        /// <param name="generuj"> Vygenerované pole čísel </param>
        /// <param name="dabel"> ListBox </param>
        public static void Vymena(int[] generuj)
        {
            int max = generuj[0];
            int pozice = 0;
            for (int k = 0; k < generuj.Length; k++)
            {
                if (generuj[k] > max)
                {
                    max = generuj[k];
                    pozice = k;
                }
            }
            generuj[pozice] = generuj[generuj.Length - 1];
            generuj[generuj.Length - 1] = max;
        }

        public static void Nulovani(int[] pole, int x, ListBox M)
        {
            int cislo = 0;
            for (int m = 0; m < pole.Length; m++)
            {
                int vysledek = 1;
                cislo = pole[m];
                if (cislo < 0)
                {
                    pole[m] = 0;
                }
                else
                {
                    // volame mocninu
                    pole[m] = Matematikautil.Mocnina(cislo, pole[m]);
                }
                M.Items.Add(vysledek);
            }
        }
        public static int ObsahujeCifru(string text, out int soucetlich)
        {
            soucetlich = 0;
            int pocetcifer = 0;
            foreach (char znak in text)
            {
                if (znak > '0' && znak < '9')
                {
                    pocetcifer++;
                    if (znak % 2 != 0)
                    {
                        soucetlich += (znak - 48);
                    }
                }
            }
            return pocetcifer;
        }
    }
}
