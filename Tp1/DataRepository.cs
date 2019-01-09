using System;
using System.Collections.Generic;
using System.Text;

namespace Tp1
{
    public class DataRepository
    {
        private DataContext dataCon { get; set; }

        public DataRepository(DataFiller filler)
        {
            dataCon = new DataContext();
            filler.fill(dataCon);
        }
    }
}
