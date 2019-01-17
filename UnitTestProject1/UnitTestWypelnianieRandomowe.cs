using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestWypelnianieRandomowe
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Podano nieprawidłową ilość elementów!")]
        public void Test_fill_negativeNumberOfElements()
        {
            DataFiller filler = new WypelnianieLosowe(-1);
        }

        [TestMethod]
        public void Test_fill()
        {
            int n = 5000;
            DataFiller filler = new WypelnianieLosowe(n);
            DataRepository repo = new DataRepository(filler);
            Assert.AreEqual(n, repo.getAllBooks().Count);
            Assert.AreEqual(n, repo.getAllPerson().Count);
            Assert.AreEqual(n, repo.getAllState().Count);
            Assert.AreEqual(n, repo.getAllEvents().Count);
        }

        [TestMethod]
        public void Test_fill_eff1_16k()
        {
            DataFiller filler = new WypelnianieLosowe(16000);
            DataRepository repo = new DataRepository(filler);
        }

        [TestMethod]
        public void Test_fill_eff2_32k()
        {
            DataFiller filler = new WypelnianieLosowe(32000);
            DataRepository repo = new DataRepository(filler);
        }

        [TestMethod]
        public void Test_fill_eff3_64k()
        {
            DataFiller filler = new WypelnianieLosowe(64000);
            DataRepository repo = new DataRepository(filler);
        }

        [TestMethod]
        public void Test_fill_eff4_128k()
        {
            DataFiller filler = new WypelnianieLosowe(128000);
            DataRepository repo = new DataRepository(filler);
        }

        [TestMethod]
        public void Test_fill_eff5_256k()
        {
            DataFiller filler = new WypelnianieLosowe(256000);
            DataRepository repo = new DataRepository(filler);
        }

        [TestMethod]
        public void Test_fill_eff6_512k()
        {
            DataFiller filler = new WypelnianieLosowe(512000);
            DataRepository repo = new DataRepository(filler);
        }
    }
}
