using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestKatalog
    {
        [TestMethod]
        public void Test_addBook()
        {
            DataFiller fill = new WypelnianieStalymi();
            DataRepository dataRep = new DataRepository(fill);
            Katalog ksiazka = new Katalog("title1", "author2", 1884);
            dataRep.Create(ksiazka);
            Assert.AreEqual(6, dataRep.getAllBooks().Count);
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException),
            "Stan o wybranym id nie istnieje w bazie")]
        public void Test_removeBook()
        {

            DataFiller fill = new WypelnianieStalymi();
            DataRepository dataRep = new DataRepository(fill);
            ((InterfejsCrud<Katalog>)dataRep).Delete(2);
            Assert.IsNull(((InterfejsCrud<Katalog>)dataRep).Retrieve(2));
        }

        [TestMethod]
        public void Test_updateBook()
        {
            DataFiller dataFiller = new WypelnianieStalymi();
            DataRepository dataRep = new DataRepository(dataFiller);
            Katalog ksiazka = new Katalog("title1", "author2", 1884);
            dataRep.Update(3, ksiazka);
            Assert.AreEqual(ksiazka, ((InterfejsCrud<Katalog>)dataRep).Retrieve(3));
        }


    }
}
