﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using potapljanje_brodova;
namespace test
{
    [TestClass]
    public class testPolje
    {
        [TestMethod]
        public void Polje_redakIStupacJednakiSuArgumentimaKonstruktora()
        {
            Polje p = new Polje(2, 3);
            Assert.AreEqual(2, p.Redak);
            Assert.AreEqual(3, p.Stupac);
        }

        [TestMethod]
        public void Polje_ZaDvaPoljaKojaImajuIsteKoordinateMetodaEqualsVracaTrue()
        {
            Polje p1 = new Polje(2, 3);
            Polje p2 = new Polje(2, 3);
            Assert.IsTrue(p1.Equals(p2));
            
        }

        [TestMethod]
        public void Polje_ZaDvaPoljaKojaImajuIsteKoordinateMetodaEqualsVracaFalse()
        {
            Polje p1 = new Polje(2, 3);
            Polje p2 = new Polje(1, 3);
            Assert.IsFalse(p1.Equals(p2));
            Polje p3 = new Polje(2, 4);
            Assert.IsFalse(p1.Equals(p3));


        }
    }
}
