using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Tp1
{
    public class DataRepository : InterfejsCrud<Katalog>, InterfejsCrud<Wykaz>, InterfejsCrud<OpisStanu>, InterfejsCrud<Zdarzenie>
    {
        private DataContext data { get; set; }

        public DataRepository(DataFiller filler)
        {
            data = new DataContext();
            filler.fill(data);
        }


        public void Create(Katalog o)
        {
            data.ksiazki.Add(data.ksiazki.Count, o);
        }

        public void Create(Wykaz o)
        {
            data.osoba.Add(o);
        }

        public void Create(OpisStanu o)
        {
            data.stan.Add(o);
        }

        public void Create(Zdarzenie o)
        {
            data.zdarzenia.Add(o);
        }

        Zdarzenie InterfejsCrud<Zdarzenie>.Retrieve(int id)
        {
            if (data.zdarzenia[id] != null)
                return data.zdarzenia[id];
            else
                throw new ArgumentOutOfRangeException();
        }

        OpisStanu InterfejsCrud<OpisStanu>.Retrieve(int id)
        {
            if (data.stan[id] != null)
                return data.stan[id];
            else
                throw new ArgumentOutOfRangeException();
        }


        Wykaz InterfejsCrud<Wykaz>.Retrieve(int id)
        {
            if (data.osoba[id] != null)
                return data.osoba[id];
            else
                throw new ArgumentOutOfRangeException();
        }

        Katalog InterfejsCrud<Katalog>.Retrieve(int id)
        {
            if (data.ksiazki[id] != null)
                return data.ksiazki[id];
            else
                throw new ArgumentOutOfRangeException();
        }


        public void Update(int id, Zdarzenie obj)
        {
            if (data.zdarzenia[id] != null)
                data.zdarzenia[id] = obj;
            else
                throw new ArgumentOutOfRangeException();
        }

        public void Update(int id, OpisStanu obj)
        {
            if (data.stan[id] != null)
                data.stan[id] = obj;
            else
                throw new ArgumentOutOfRangeException();
        }

        public void Update(int id, Wykaz obj)
        {
            if (data.osoba[id] != null)
                data.osoba[id] = obj;
            else
                throw new ArgumentOutOfRangeException();
        }

        public void Update(int id, Katalog obj)
        {
            if (data.ksiazki[id] != null)
                data.ksiazki[id] = obj;
            else
                throw new ArgumentOutOfRangeException();
        }

        void InterfejsCrud<Zdarzenie>.Delete(int id)
        {
            if (data.zdarzenia[id] != null)
                data.zdarzenia.RemoveAt(id);
            else
                throw new ArgumentOutOfRangeException();
        }

        void InterfejsCrud<OpisStanu>.Delete(int id)
        {
            if (data.stan[id] != null)
                data.stan.RemoveAt(id);
            else
                throw new ArgumentOutOfRangeException();
        }


        void InterfejsCrud<Wykaz>.Delete(int id)
        {
            if (data.osoba[id] != null)
                data.osoba.RemoveAt(id);
            else
                throw new ArgumentOutOfRangeException();
        }

        void InterfejsCrud<Katalog>.Delete(int id)
        {
            if (data.ksiazki[id] != null)
                data.ksiazki.Remove(id);
            else
                throw new ArgumentOutOfRangeException();
        }


        public Dictionary<int, Katalog> getAllBooks()
        {
            return data.ksiazki;
        }

        public List<Wykaz> getAllPerson()
        {
            return data.osoba;
        }

        public List<OpisStanu> getAllState()
        {
            return data.stan;
        }

        public ObservableCollection<Zdarzenie> getAllEvents()
        {
            return data.zdarzenia;
        }
    }
}