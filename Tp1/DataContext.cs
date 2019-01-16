using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Tp1
{
    class DataContext
    {
        public List<Wykaz> osoba;
        public Dictionary<int, Katalog> ksiazki;
        public ObservableCollection<Zdarzenie> zdarzenia;
        public List<OpisStanu> stan;

        public DataContext()
        {
            osoba = new List<Wykaz>();
            ksiazki = new Dictionary<int, Katalog>();
            zdarzenia = new ObservableCollection<Zdarzenie>();
            stan = new List<OpisStanu>();
        }
    }
}
