using System;
using System.Collections.Generic;
using System.Text;

namespace Tp1
{
    public class Katalog
    {
        public string tytul { get; set; }
        public string autor { get; set; }
        public int rok { get; set; }

        public Katalog(string tytul, string autor, int rok)
        {
            this.tytul = tytul;
            this.autor = autor;
            this.rok = rok;
        }

    }
}
