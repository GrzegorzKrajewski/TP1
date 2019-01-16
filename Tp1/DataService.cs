using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Tp1
{
    public class DataService
    {
        private DataRepository data;

        public DataService(DataRepository data)
        {
            this.data = data;
        }


        /////////////////////// CREATE
        public void addPerson(string imie, string nazwisko, string adres) =>
            data.Create(new Wykaz(imie, nazwisko, adres));

        public void addCatalog(string tytul, string autor, int rok) => data.Create(new Katalog(tytul, autor, rok));

        public void addEvent(Wykaz osoba, OpisStanu stan, DateTime dataWypozyczenia, DateTime dataZwrotu) =>
            data.Create(new Zdarzenie(osoba, stan, dataWypozyczenia, dataZwrotu));

        public void addState(Katalog ksiazka, int ilosc, double cena) => data.Create(new OpisStanu(ksiazka, ilosc, cena));


        /////////////////////// DELETE

        public void removePerson(int id) => ((InterfejsCrud<Wykaz>)data).Delete(id);

        public void removeCatalog(int id) => ((InterfejsCrud<Katalog>)data).Delete(id);

        public void removeEvent(int id) => ((InterfejsCrud<Zdarzenie>)data).Delete(id);

        public void removeState(int id) => ((InterfejsCrud<OpisStanu>)data).Delete(id);


        /////////////////////// RETRIEVE

        public Wykaz retrieveReader(int id) => ((InterfejsCrud<Wykaz>)data).Retrieve(id);

        public Zdarzenie retrieveEvent(int id) => ((InterfejsCrud<Zdarzenie>)data).Retrieve(id);
        public OpisStanu retrieveState(int id) => ((InterfejsCrud<OpisStanu>)data).Retrieve(id);
        public Katalog retrieveCatalog(int id) => ((InterfejsCrud<Katalog>)data).Retrieve(id);


        /////////////////////// RETRIEVEALL
        public Dictionary<int, Katalog> RetrieveAll() => data.getAllBooks();


        public List<Wykaz> getAllPerson() => data.getAllPerson();


        public List<OpisStanu> getAllState() => data.getAllState();


        public ObservableCollection<Zdarzenie> getAllEvents() => data.getAllEvents();


        /////////////////////// UPDATE
        public void Update(int id, Zdarzenie obj) => data.Update(id, obj);


        public void Update(int id, OpisStanu obj) => data.Update(id, obj);


        public void Update(int id, Wykaz obj) => data.Update(id, obj);


        public void Update(int id, Katalog obj) => data.Update(id, obj);


        /// ////////////////// powiązanie wykaz - zdarzenia

        public ObservableCollection<Zdarzenie> returnEventsByPerson()
        {
            ObservableCollection<Zdarzenie> tmp = new ObservableCollection<Zdarzenie>();
            foreach (var i in data.getAllPerson())
            {
                foreach (var j in data.getAllEvents())
                {
                    if (j.osoba == i) tmp.Add(j);
                }
            }

            return tmp;
        }


        ///.////////////////////////////// powiązanie pozycje katalogu po ksiazce
        public Dictionary<int, Katalog> returnBooksByStates()
        {

            Dictionary<int, Katalog> tmp = new Dictionary<int, Katalog>();
            int k = 0;
            foreach (var i in data.getAllBooks())
            {
                foreach (var j in data.getAllState())
                {

                    if (j.ksiazka == i.Value) tmp.Add(k, j.ksiazka);
                    k++;
                }
            }

            return tmp;
        }

        ///.///////////////////// wyszukiwanie po zadanym kryterium //po imieniu

        public List<Wykaz> returnReadersByName(string imie)
        {
            List<Wykaz> tmp = new List<Wykaz>();
            foreach (var i in data.getAllPerson())
            {
                if (i.getImie() == imie)
                    tmp.Add(i);
            }
            return tmp; ///////////// 
        }



    }
}