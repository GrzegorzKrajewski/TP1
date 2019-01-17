using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestOpisStanu
    {
        [TestMethod]
        public void Test_addState()
        {
            DataFiller dataFiller = new WypelnianieStalymi();
            DataRepository dataRep = new DataRepository(dataFiller);
            OpisStanu stan = new OpisStanu(((InterfejsCrud<Katalog>)dataRep).Retrieve(0), 2, 55.50);
            dataRep.Create(stan);
            Assert.AreEqual(5, dataRep.getAllState().Count);
        }


        [TestMethod]
        public void Test_removeState()
        {

            DataFiller dataFiller = new WypelnianieStalymi();
            DataRepository dataRep = new DataRepository(dataFiller);
            OpisStanu r = ((InterfejsCrud<OpisStanu>)dataRep).Retrieve(0);
            ((InterfejsCrud<OpisStanu>)dataRep).Delete(0);
            Assert.AreNotEqual(((InterfejsCrud<OpisStanu>)dataRep).Retrieve(0), r);
        }

        [TestMethod]
        public void Test_updateState()
        {
            DataFiller dataFiller = new WypelnianieStalymi();
            DataRepository dataRep = new DataRepository(dataFiller);
            OpisStanu stan = new OpisStanu(((InterfejsCrud<Katalog>)dataRep).Retrieve(0), 2, 55.50);
            dataRep.Update(3, stan);
            Assert.AreEqual(stan, ((InterfejsCrud<OpisStanu>)dataRep).Retrieve(3));
        }
    }
}
