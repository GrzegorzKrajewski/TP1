using System;
using System.Collections.Generic;
using System.Text;

namespace Tp1
{
    public class WypelnianieLosowe : DataFiller
    {

        private int ile;
        private Random rnd;
        private static string[] id = { "Wiosna", "Lato", "Jesien", "Zima", "Drzewa", "Encyklopedia",
                                            "Matematyka", "Historia", "Grzyby", "Zagadka", "Zbrodnia" };
        private static string[] imie = { "Mateusz", "Marek", "Ania", "Maria", "Beata", "Tadeusz", "Adam",
                                            "Jerzy", "Jan", "Magda", "Stefan", "Edward", "Krystyna" };
        private static string[] nazwisko = { "Nowak", "Szczupak", "Mickiewicz", "Jakubiak", "Kononowicz",
                                            "Kowal", "Walczak", "Brzechwa", "Koper", "Trynkiewicz", "Tkacz" };
        private static string[] adres = { "Czerwona", "Zielona", "Niebieska", "Niska", "Wysoka", "Krzywa", "Rynkowa",
                                            "Wojskowa", "Czarna", "Wodna", "Piotrkowska", "Przybyszewskiego" };

        private DateTime start;
        private int rng;

        public WypelnianieLosowe(int ile)
        {
            if (ile >= 0) this.ile = ile;
            else throw new ArgumentException();
            rnd = new Random();
            start = new DateTime(2000, 1, 1);
            rng = (DateTime.Today - start).Days;
        }

        internal override void fill(DataContext context)
        {
            Wykaz.ZerujId();
            OpisStanu.ZerujId();
            Zdarzenie.ZerujId();
            for (int i = 1; i <= ile; i++)
            {
                context.ksiazki.Add(i, new Katalog(id[rnd.Next(11)],
                                                    imie[rnd.Next(13)] + nazwisko[rnd.Next(11)],
                                                    rnd.Next(1900, 2017)));

                context.osoba.Add(new Wykaz(imie[rnd.Next(13)],
                                                    nazwisko[rnd.Next(11)],
                                                    adres[rnd.Next(12)]));


                context.stan.Add(new OpisStanu(context.ksiazki[rnd.Next(1, i)],
                                                rnd.Next(5, 100),
                                                Math.Round(rnd.NextDouble() * 20 + 15, 2)));

                context.zdarzenia.Add(new Zdarzenie(context.osoba[rnd.Next(i)],
                                                    context.stan[rnd.Next(i)],
                                                    start.AddDays(rnd.Next(rng)),
                                                    start.AddDays(rnd.Next(rng + 100))));
            }
        }
    }
}
