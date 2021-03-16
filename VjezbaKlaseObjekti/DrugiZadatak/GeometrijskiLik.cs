using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaKlaseObjekti.DrugiZadatak
{
    public class GeometrijskiLik
    {
        public int BrojStranica { get; set; }
        public float[] Stranice { get; set; }

        public GeometrijskiLik(int brojStranica)
        {
            BrojStranica = brojStranica;
        }

        public void UcitajStranice()
        {
            Stranice = new float[BrojStranica];
            for (int i=0; i < BrojStranica; i++)
            {
                Console.Write($"Unesite {i+1}. stranica: ");
                Stranice[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public float Opseg()
        {
            float vrati = 0;
            foreach (var broj in Stranice)
            {
                vrati += broj;
            }
            return vrati;
        }
    }
}
