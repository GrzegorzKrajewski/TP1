using System;
using System.Collections.Generic;
using System.Text;

namespace Tp1
{
    public class OpisStanu
    {
        private static int autoid = 0;
        public int id { get; set; }
        public Katalog ksiazka { get; set; }
        public int ilosc { get; set; }
        public double cena { get; set; }

        public OpisStanu(Katalog book, int ilosc, double cena)
        {
            this.ksiazka = ksiazka;
            this.ilosc = ilosc;
            this.cena = cena;
        }

        public static void ZerujId()
        {
            autoid = 0;
        }
    }
}
