using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tp1;

namespace UnitTestWykazImie
{

    [TestClass]
    public class UnitTest_ReadersByName
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataFiller dataFiller = new WypelnianieStalymi();
            DataRepository dataRep = new DataRepository(dataFiller);
            DataService dataS = new DataService(dataRep);

            foreach (Wykaz osoba in dataS.returnReadersByName("autor1"))
            {
                if (osoba.imie != "autor1")
                    Assert.Fail("Zwrocilo czytelnikow o zlym imieniu");
            }

        }
    }
}
