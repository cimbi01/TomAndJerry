using System;
using System.Collections.Generic;

namespace TomAndJerry
{
    internal static class Csata
    {
        #region Private Fields

        private static List<Harcos> harcosok = new List<Harcos>();

        #endregion Private Fields

        #region Public Methods

        public static void Csatazas()
        {
            Init();
            for (int i = 0; harcosok[i % 2].Eletero > 0; i++)
            {
                int tamadasertek = harcosok[i % 2].Tamad();
                int elet = harcosok[(i + 1) % 2].Eletero;
                harcosok[(i + 1) % 2].Vedekezes(tamadasertek);
                // csak akkor ha valóban támadott (van változas az életben azaz nem nulla a
                // különbsége az eredetivel
                if (elet - harcosok[(i + 1) % 2].Eletero != 0)
                {
                    Console.WriteLine("{0} támadta {1}-t, {2} támadással, ennyi eletereje maradt: {3}",
                        harcosok[i % 2].Nev,
                        harcosok[(i + 1) % 2].Nev,
                        elet - harcosok[(i + 1) % 2].Eletero,
                        harcosok[(i + 1) % 2].Eletero);
                }
                // ha a támadás sikertelen
                else
                {
                    Console.WriteLine("{0} támadása {1} támadással sikertelen,  {2} védelme erősebb volt, {3} életereje maradt",
                        harcosok[i % 2].Nev,
                        tamadasertek,
                        harcosok[(i + 1) % 2].Nev,
                        harcosok[(i + 1) % 2].Eletero);
                }
            }
        }

        #endregion Public Methods

        #region Private Methods

        private static void Init()
        {
            Random rnd = new Random();
            harcosok.Add(new Harcos(rnd.Next(10, 40), "Tom"));
            harcosok.Add(new Harcos(rnd.Next(10, 40), "Jerry"));
        }

        #endregion Private Methods
    }
}
