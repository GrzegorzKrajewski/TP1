using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest_Reader
    {
        [TestMethod]
        public void Test_addReader()
        {
            DataFiller dataFiller = new WypelnianieStalymi();
            DataRepository dataRep = new DataRepository(dataFiller);
            Wykaz osoba = new Wykaz("imie", "nazwisko", "porzeczkowa");
            dataRep.Create(osoba);
            Assert.AreEqual(5, dataRep.getAllPerson().Count);
        }


        [TestMethod]
        public void Test_removeReader()
        {

            DataFiller dataFiller = new WypelnianieStalymi();
            DataRepository dataRep = new DataRepository(dataFiller);
            Wykaz osoba = ((InterfejsCrud<Wykaz>)dataRep).Retrieve(0);
            ((InterfejsCrud<Wykaz>)dataRep).Delete(0);
            Assert.AreNotEqual(((InterfejsCrud<Wykaz>)dataRep).Retrieve(0), osoba);
        }

        [TestMethod]
        public void Test_updateReader()
        {
            DataFiller dataFiller = new WypelnianieStalymi();
            DataRepository dataRep = new DataRepository(dataFiller);
            Wykaz osoba = new Wykaz("imie", "nazwisko", "bakłażanowa");
            dataRep.Update(3, osoba);
            Assert.AreEqual(osoba, ((InterfejsCrud<Wykaz>)dataRep).Retrieve(3));
        }


    }
}
