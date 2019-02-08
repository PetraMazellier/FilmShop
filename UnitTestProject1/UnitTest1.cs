using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilmShopLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestNom()
        {
            var NouvUtil = new Personne();
            NouvUtil.NomPersonne = "Mazellier";
            Assert.AreEqual("MAZELLIER", NouvUtil.NomPersonne);
        }

        [TestMethod]
        public void TestPrenom()
        {
            var NouvUtil = new Personne();
            NouvUtil.PrenomPersonne = "Petra";
            Assert.AreEqual("PETRA", NouvUtil.PrenomPersonne);
        }
        [TestMethod]
        public void TestNomEntier()
        {
            var NouvUtil = new Personne();

            NouvUtil.PrenomPersonne = "Petra";
            NouvUtil.NomPersonne = "Mazellier";
            Assert.AreEqual("PETRA MAZELLIER", NouvUtil.NomEntier);
        }


    }
}