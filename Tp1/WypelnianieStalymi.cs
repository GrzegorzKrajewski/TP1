using System;
using System.Collections.Generic;
using System.Text;

namespace Tp1
{
    public class WypelnianieStalymi : DataFiller
    {
        internal override void fill(DataContext dataContext)
        {
            Wykaz.ZerujId();
            OpisStanu.ZerujId();
            Zdarzenie.ZerujId();
            dataContext.osoba.Add(new Wykaz("Adam", "Małysz", "Wisła"));
            dataContext.osoba.Add(new Wykaz("Jan", "Kowalski", "Szczyrk"));
            dataContext.osoba.Add(new Wykaz("Adam", "Nowak", "Kraków"));
            dataContext.osoba.Add(new Wykaz("Magda", "Maj", "Warszawa"));
            dataContext.ksiazki.Add(0, new Katalog("Quo Vadis", "Henryk Sienkiewicz", 2000));
            dataContext.ksiazki.Add(1, new Katalog("Władca Pierścieni", "J.R.R Tolkien", 1998));
            dataContext.ksiazki.Add(2, new Katalog("Lalka", "Bolesław Prus", 2014));
            dataContext.ksiazki.Add(3, new Katalog("Być fit", "Krzysztof Ibisz", 1965));
            dataContext.ksiazki.Add(4, new Katalog("Jacek Balcerzak", "Skierowanko", 1811));
            dataContext.stan.Add(new OpisStanu(dataContext.ksiazki[0], 2, 12.50));
            dataContext.stan.Add(new OpisStanu(dataContext.ksiazki[1], 2, 12.50));
            dataContext.stan.Add(new OpisStanu(dataContext.ksiazki[2], 2, 12.50));
            dataContext.stan.Add(new OpisStanu(dataContext.ksiazki[3], 2, 12.50));
            dataContext.zdarzenia.Add(new Zdarzenie(dataContext.osoba[0], dataContext.stan[2], new DateTime(2018, 10, 12),
                new DateTime(2018, 10, 21)));
            dataContext.zdarzenia.Add(new Zdarzenie(dataContext.osoba[1], dataContext.stan[1], new DateTime(2018, 11, 14),
                new DateTime(2018, 11, 23)));
            dataContext.zdarzenia.Add(new Zdarzenie(dataContext.osoba[2], dataContext.stan[0], new DateTime(2018, 12, 30),
                new DateTime(2018,12, 01)));
        }
    }
}
