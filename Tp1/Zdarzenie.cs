using System;
using System.Collections.Generic;
using System.Text;

namespace Tp1
{
    public class Zdarzenie
    {
        private static int autoid = 0;
        public int id { get; set; }
        public Wykaz osoba { get; set; }
        public OpisStanu stan { get; set; }
        public DateTime dataWypozyczenia { get; set; }
        public DateTime dataZwrotu { get; set; }

        public Zdarzenie(Wykaz osoba, OpisStanu stan, DateTime dataWypozyczenia, DateTime dataZwrotu)
        {
            this.osoba = osoba;
            this.stan = stan;
            this.dataWypozyczenia = dataWypozyczenia;
            this.dataZwrotu = dataZwrotu;
        }
        public static void ZerujId()
        {
            autoid = 0;
        }
    }
}
