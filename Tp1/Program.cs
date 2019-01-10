using System;
using System.Collections.Generic;
using System.Text;

namespace Tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataFiller fill = new WypelnianieStalymi();
            DataRepository repo = new DataRepository(fill);
            Console.ReadKey();
        }
    }
}
