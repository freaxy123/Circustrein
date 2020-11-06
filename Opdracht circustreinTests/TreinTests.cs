using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opdracht_circustrein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_circustrein.Tests
{
    [TestClass()]
    public class TreinTests
    {
        [TestMethod()]
        public void vulTreinTest()
        {
            //Arrange 
            Trein trein = new Trein();

            List<Dier> gesorteerd = new List<Dier>();    //List in order
            gesorteerd.Add(new Dier(Dier.voer.vlees, Dier.grootte.groot));
            gesorteerd.Add(new Dier(Dier.voer.vlees, Dier.grootte.groot));
            gesorteerd.Add(new Dier(Dier.voer.vlees, Dier.grootte.middelmatig));
            gesorteerd.Add(new Dier(Dier.voer.vlees, Dier.grootte.klein));
            gesorteerd.Add(new Dier(Dier.voer.planten, Dier.grootte.groot));
            gesorteerd.Add(new Dier(Dier.voer.planten, Dier.grootte.groot));
            gesorteerd.Add(new Dier(Dier.voer.planten, Dier.grootte.middelmatig));
            gesorteerd.Add(new Dier(Dier.voer.planten, Dier.grootte.klein));

            //Act
            trein.vulTrein(gesorteerd); //Vul trein met aangegeven dieren

            //Assert
            IReadOnlyList<Wagon> wagons = trein.getTrein();

            int actual = wagons.Count;
            int expected = 5;

            Assert.AreEqual(actual, expected);
        }
    }
}