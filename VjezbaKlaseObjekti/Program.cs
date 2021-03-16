using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaKlaseObjekti
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Prvi Zadatak
            PrviZadatak.Bijelogoricno hrast = new PrviZadatak.Bijelogoricno(true);
            PrviZadatak.Crnogoricno bor = new PrviZadatak.Crnogoricno(false);

            Console.WriteLine($"Hrastu pada lišće: {hrast.OpadajuListovi}");
            Console.WriteLine($"Boru pada lišće: {bor.OpadajuListovi}");

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Drugi Zadatak
            DrugiZadatak.Trokut trokut = new DrugiZadatak.Trokut();
            DrugiZadatak.Kvadrat kvadrat = new DrugiZadatak.Kvadrat();

            Console.WriteLine("Unesite stranice za Trokut:");
            trokut.UcitajStranice();
            float opsegTrokuta = trokut.Opseg();

            Console.WriteLine();
            Console.WriteLine("Unesite stranice za Kvadrat:");
            kvadrat.UcitajStranice();
            float opsegKvadrata = kvadrat.Opseg();

            Console.WriteLine();
            Console.WriteLine($"Opseg trokuta je: {opsegTrokuta}");
            Console.WriteLine($"Opseg kvadrata je: {opsegKvadrata}");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Treci Zadatak
            TreciZadatak.KlasaX x = new TreciZadatak.KlasaX();
            for (x.indeks = 0; x.indeks < 100; x.indeks++)
            {
                x.niz[x.indeks] = x.indeks + 1;
            }
            Console.WriteLine($"Uneseno je prvih 100 brojeva, a 50 indeks je {x.niz[50]}");
            Console.ReadKey();
            Console.Clear();
            #endregion

            Console.WriteLine("Kraj!");
            Console.ReadKey();
        }

    }
}
