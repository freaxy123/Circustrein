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
        public void stopDierInWagonTest_GroteVleeseterBijGrotePlanteneter_ShouldBeFalse()
        {
            //Arrange
            Wagon wagon = new Wagon(1);
            wagon.stopDierInWagon(new Dier(Dier.voer.vlees, Dier.grootte.groot));
            bool expected = false;
            bool actual = true;
            
            //Act
            if (wagon.stopDierInWagon(new Dier(Dier.voer.planten, Dier.grootte.groot)) == false)
                actual = false;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void stopDierInWagonTest_MiddelmatigeVleeseterBijKleinePlanteneter_ShouldBeFalse()
        {
            //Arrange
            Wagon wagon = new Wagon(1);
            wagon.stopDierInWagon(new Dier(Dier.voer.vlees, Dier.grootte.middelmatig));
            bool expected = false;
            bool actual = true;
            
            //Act
            if (wagon.stopDierInWagon(new Dier(Dier.voer.planten, Dier.grootte.klein)) == false)
                actual = false;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void stopDierInWagonTest_MiddelmatigePlanteneterBijGroteVleeseter_ShouldBeFalse()
        {
            //Arrange
            Wagon wagon = new Wagon(1);
            wagon.stopDierInWagon(new Dier(Dier.voer.planten, Dier.grootte.middelmatig));
            bool expected = false;
            bool actual = true;

            //Act
            if (wagon.stopDierInWagon(new Dier(Dier.voer.vlees, Dier.grootte.groot)) == false)
                actual = false;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void stopDierInWagonTest_KleinePlanteneterBijKleineVleeseter_ShouldBeFalse()
        {
            //Arrange
            Wagon wagon = new Wagon(1);
            wagon.stopDierInWagon(new Dier(Dier.voer.planten, Dier.grootte.klein));
            bool expected = false;
            bool actual = true;

            //Act
            if (wagon.stopDierInWagon(new Dier(Dier.voer.vlees, Dier.grootte.klein)) == false)
                actual = false;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void stopDierInWagonTest_MediumVleeseterBijKleineVleeseter_ShouldBeFalse()
        {
            //Arrange
            Wagon wagon = new Wagon(1);
            wagon.stopDierInWagon(new Dier(Dier.voer.vlees, Dier.grootte.middelmatig));
            bool expected = false;
            bool actual = true;

            //Act
            if (wagon.stopDierInWagon(new Dier(Dier.voer.vlees, Dier.grootte.klein)) == false)
                actual = false;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void stopDierInWagonTest_MiddelmatigeVleeseterBijGrotePlanteneter_ShouldBeTrue()
        {
            //Arrange
            Wagon wagon = new Wagon(1);
            wagon.stopDierInWagon(new Dier(Dier.voer.vlees, Dier.grootte.middelmatig));
            bool expected = true;
            bool actual = false;

            //Act
            if (wagon.stopDierInWagon(new Dier(Dier.voer.planten, Dier.grootte.groot)) == true)
                actual = true;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void stopDierInWagonTest_KleinePlanteneterBijMiddelmatigePlanteneter_ShouldBeTrue()
        {
            //Arrange
            Wagon wagon = new Wagon(1);
            wagon.stopDierInWagon(new Dier(Dier.voer.planten, Dier.grootte.klein));
            bool expected = true;
            bool actual = false;

            //Act
            if (wagon.stopDierInWagon(new Dier(Dier.voer.planten, Dier.grootte.middelmatig)) == true)
                actual = true;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void stopDierInWagonTest_MiddelmatigePlanteneterBijTweeGrotePlanteneters_ShouldReturnFalse()
        {
            //Arrange
            Wagon wagon = new Wagon(1);
            wagon.stopDierInWagon(new Dier(Dier.voer.planten, Dier.grootte.groot));
            wagon.stopDierInWagon(new Dier(Dier.voer.planten, Dier.grootte.groot));
            bool expected = false;
            bool actual = true;

            //Act
            if (wagon.stopDierInWagon(new Dier(Dier.voer.planten, Dier.grootte.middelmatig)) == false)
                actual = false;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void stopDierInWagonTest_MiddelmatigePlanteneterBijVolleWagon_ShouldReturnFalse()
        {
            //Arrange
            Wagon wagon = new Wagon(1);
            wagon.stopDierInWagon(new Dier(Dier.voer.vlees, Dier.grootte.middelmatig));
            wagon.stopDierInWagon(new Dier(Dier.voer.planten, Dier.grootte.middelmatig));
            wagon.stopDierInWagon(new Dier(Dier.voer.planten, Dier.grootte.middelmatig));
            wagon.stopDierInWagon(new Dier(Dier.voer.planten, Dier.grootte.klein));
            bool expected = false;
            bool actual = true;

            //Act
            if (wagon.stopDierInWagon(new Dier(Dier.voer.planten, Dier.grootte.middelmatig)) == false)
                actual = false;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void vrijeRuimteWagonTest_CorrecteRuimteTeruggeven_ShouldReturn2()
        {
            //Arrange
            Wagon wagon = new Wagon(1);
            wagon.stopDierInWagon(new Dier(Dier.voer.vlees, Dier.grootte.middelmatig));
            wagon.stopDierInWagon(new Dier(Dier.voer.planten, Dier.grootte.groot));

            //Act
            int actual = wagon.getVrijeRuimte();

            //Assert
            int expected = 2;
            Assert.AreEqual(actual, expected);
        }


        [TestMethod()]
        public void getDierenTest_DierenInWagonWordenCorrectBijgehouden_ShouldReturnTrue()
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