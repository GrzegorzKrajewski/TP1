using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tp1;

namespace UnitTestProject1
{

    [TestClass]
    public class UnitTestZdarzenia
    {
        [TestMethod]
        public void Test_addEvent()
        {
            DataFiller dataFiller = new WypelnianieStalymi();
            DataRepository dataRep = new DataRepository(dataFiller);

            Zdarzenie ev = new Zdarzenie(((InterfejsCrud<Wykaz>)dataRep).Retrieve(1), ((InterfejsCrud<OpisStanu>)dataRep).Retrieve(1), DateTime.Now, DateTime.MaxValue);
            dataRep.Create(ev);
            Assert.AreEqual(4, dataRep.getAllEvents().Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
            "Wydarzenie o wybranym id nie istnieje w bazie")]
        public void Test_removeEvent()
        {

            DataFiller dataFiller = new WypelnianieStalymi();
            DataRepository dataRep = new DataRepository(dataFiller);
            ((InterfejsCrud<Zdarzenie>)dataRep).Delete(2);
            Assert.IsNull(((InterfejsCrud<Zdarzenie>)dataRep).Retrieve(2));
        }

        [TestMethod]
        public void Test_updateEvent()
        {
            DataFiller dataFiller = new WypelnianieStalymi();
            DataRepository dataRep = new DataRepository(dataFiller);
            Zdarzenie ev = new Zdarzenie(((InterfejsCrud<Wykaz>)dataRep).Retrieve(1), ((InterfejsCrud<OpisStanu>)dataRep).Retrieve(1), DateTime.Now, DateTime.MaxValue);
            dataRep.Update(1, ev);
            Assert.AreEqual(ev, ((InterfejsCrud<Zdarzenie>)dataRep).Retrieve(1));
        }
    }
}
