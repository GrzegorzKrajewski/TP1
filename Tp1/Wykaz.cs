using System;

namespace Tp1
{
    public class Wykaz
    {
        public static int autoid = 0;
        public int id { get; set; }
        public string imie { get; set; }
        private string nazwisko { get; set; }
        private string adres { get; set; }

        public Wykaz(string imie, string nazwisko, string adres)
        {
            id = autoid++;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.adres = adres;
        }

        public static void ZerujId()
        {
            autoid = 0;
        }

        public string getImie()
        {
            return imie;
        }
    }
}
