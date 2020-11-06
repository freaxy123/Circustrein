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
    public class WagonTests
    {
        [TestMethod()]
        public void stopDierInWagonTest()
        {
            //Arrange
            Wagon wagon = new Wagon(1);
            wagon.stopDierInWagon(new Dier(Dier.voer.vlees, Dier.grootte.middelmatig));

            //Act
            bool actual = wagon.stopDierInWagon(new Dier(Dier.voer.vlees, Dier.grootte.groot));
            if(actual == false)
                wagon.stopDierInWagon(new Dier(Dier.voer.planten, Dier.grootte.groot));

            //Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod()]
        public void vrijeRuimteWagonTest()
        {
            //Arrange
            Wagon wagon = new Wagon(1);
            wagon.stopDierInWagon(new Dier(Dier.voer.vlees, Dier.grootte.middelmatig));
            wagon.stopDierInWagon(new Dier(Dier.voer.vlees, Dier.grootte.groot));
            wagon.stopDierInWagon(new Dier(Dier.voer.vlees, Dier.grootte.klein));
            wagon.stopDierInWagon(new Dier(Dier.voer.planten, Dier.grootte.groot));
            wagon.stopDierInWagon(new Dier(Dier.voer.planten, Dier.grootte.middelmatig));
            wagon.stopDierInWagon(new Dier(Dier.voer.planten, Dier.grootte.klein));

            //Act
            int actual = wagon.getVrijeRuimte();

            //Assert
            int expected = 2;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void getDierenTest()
        {
            //Arrange
            Wagon wagon = new Wagon(1);
            wagon.stopDierInWagon(new Dier(Dier.voer.planten, Dier.grootte.groot));
            wagon.stopDierInWagon(new Dier(Dier.voer.planten, Dier.grootte.middelmatig));

            List<Dier> expected = new List<Dier>();
            expected.Add(new Dier(Dier.voer.planten, Dier.grootte.groot));
            expected.Add(new Dier(Dier.voer.planten, Dier.grootte.middelmatig));

            

            //Act
            IReadOnlyList<Dier> actual = wagon.getDieren();

            //Assert
            bool hetzelfde = true;
            int i = 0;
            foreach (Dier dier in actual)
            {
                if (expected[i].Grootte != dier.Grootte || expected[i].Voer != dier.Voer)
                {
                    hetzelfde = false;
                }
                i++;
            }

            Assert.AreEqual(true, hetzelfde);
        }
    }
}