using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Opdracht_circustrein.Tests
{
    [TestClass()]
    public class SorterenTests
    {
        [TestMethod()]
        public void sorteerLijstTest()
        {
            //Arrange 
            List<Dier> randomList = new List<Dier>();   //List out of order
            randomList.Add(new Dier(Dier.voer.vlees, Dier.grootte.middelmatig));
            randomList.Add(new Dier(Dier.voer.planten, Dier.grootte.groot));
            randomList.Add(new Dier(Dier.voer.planten, Dier.grootte.klein));
            randomList.Add(new Dier(Dier.voer.vlees, Dier.grootte.groot));
            randomList.Add(new Dier(Dier.voer.planten, Dier.grootte.middelmatig));
            randomList.Add(new Dier(Dier.voer.planten, Dier.grootte.groot));
            randomList.Add(new Dier(Dier.voer.vlees, Dier.grootte.klein));
            randomList.Add(new Dier(Dier.voer.vlees, Dier.grootte.groot));

            List<Dier> expected = new List<Dier>();    //List in order
            expected.Add(new Dier(Dier.voer.vlees, Dier.grootte.groot));
            expected.Add(new Dier(Dier.voer.vlees, Dier.grootte.groot));
            expected.Add(new Dier(Dier.voer.vlees, Dier.grootte.middelmatig));
            expected.Add(new Dier(Dier.voer.vlees, Dier.grootte.klein));
            expected.Add(new Dier(Dier.voer.planten, Dier.grootte.groot));
            expected.Add(new Dier(Dier.voer.planten, Dier.grootte.groot));
            expected.Add(new Dier(Dier.voer.planten, Dier.grootte.middelmatig));
            expected.Add(new Dier(Dier.voer.planten, Dier.grootte.klein));

            Sorteren sort = new Sorteren();

            //Act
            List<Dier> actual = sort.sorteerLijst(randomList);

            //Assert 
            bool hetzelfde = true;
            int i = 0;
            foreach (Dier dier in expected)
            {
                if (actual[i].Grootte != dier.Grootte || actual[i].Voer != dier.Voer)
                {
                    hetzelfde = false;
                }
                i++;
            }

            Assert.AreEqual(true, hetzelfde);
        }

        //Private methods
        /*
        [TestMethod()]
        public void sorteerOpVoerTest()
        {
            //Arrange
            List<Dier> randomList = new List<Dier>();   //List out of order
            randomList.Add(new Dier(Dier.voer.vlees, Dier.grootte.middelmatig));
            randomList.Add(new Dier(Dier.voer.planten, Dier.grootte.groot));
            randomList.Add(new Dier(Dier.voer.planten, Dier.grootte.klein));
            randomList.Add(new Dier(Dier.voer.vlees, Dier.grootte.groot));
            randomList.Add(new Dier(Dier.voer.planten, Dier.grootte.middelmatig));
            randomList.Add(new Dier(Dier.voer.planten, Dier.grootte.groot));
            randomList.Add(new Dier(Dier.voer.vlees, Dier.grootte.klein));
            randomList.Add(new Dier(Dier.voer.vlees, Dier.grootte.groot));

            List<Dier> listVlees = new List<Dier>();   //List out of order
            listVlees.Add(new Dier(Dier.voer.vlees, Dier.grootte.middelmatig));
            listVlees.Add(new Dier(Dier.voer.vlees, Dier.grootte.groot));
            listVlees.Add(new Dier(Dier.voer.vlees, Dier.grootte.klein));
            listVlees.Add(new Dier(Dier.voer.vlees, Dier.grootte.groot));

            List<Dier> listPlanten = new List<Dier>();   //List out of order
            listPlanten.Add(new Dier(Dier.voer.planten, Dier.grootte.groot));
            listPlanten.Add(new Dier(Dier.voer.planten, Dier.grootte.klein));
            listPlanten.Add(new Dier(Dier.voer.planten, Dier.grootte.middelmatig));
            listPlanten.Add(new Dier(Dier.voer.planten, Dier.grootte.groot));

            Sorteren logica = new Sorteren();

            //Act
            List<Dier> actualVlees = logica.sorteerOpVoer(randomList, Dier.voer.vlees);
            List<Dier> actualPlanten = logica.sorteerOpVoer(randomList, Dier.voer.planten);

            //Assert
            bool hetzelfde = true;
            int i = 0;
            foreach (Dier dier in listVlees)
            {
                if (actualVlees[i].Grootte != dier.Grootte || actualVlees[i].Voer != dier.Voer)
                {
                    hetzelfde = false;
                }
                i++;
            }

            i = 0;
            foreach (Dier dier in listPlanten)
            {
                if (actualPlanten[i].Grootte != dier.Grootte || actualPlanten[i].Voer != dier.Voer)
                {
                    hetzelfde = false;
                }
                i++;
            }

            Assert.AreEqual(true, hetzelfde);
        }

        
        [TestMethod()]
        public void sorteerGrootNaarKleinTest()
        {
            //Arrange
            List<Dier> randomList = new List<Dier>();   //List out of order
            randomList.Add(new Dier(Dier.voer.vlees, Dier.grootte.middelmatig));
            randomList.Add(new Dier(Dier.voer.planten, Dier.grootte.groot));
            randomList.Add(new Dier(Dier.voer.planten, Dier.grootte.klein));
            randomList.Add(new Dier(Dier.voer.vlees, Dier.grootte.groot));
            randomList.Add(new Dier(Dier.voer.planten, Dier.grootte.middelmatig));
            randomList.Add(new Dier(Dier.voer.planten, Dier.grootte.groot));
            randomList.Add(new Dier(Dier.voer.vlees, Dier.grootte.klein));
            randomList.Add(new Dier(Dier.voer.vlees, Dier.grootte.groot));

            List<Dier> GrootnaarkleinList = new List<Dier>();   //List out of order
            GrootnaarkleinList.Add(new Dier(Dier.voer.planten, Dier.grootte.groot));
            GrootnaarkleinList.Add(new Dier(Dier.voer.vlees, Dier.grootte.groot));
            GrootnaarkleinList.Add(new Dier(Dier.voer.planten, Dier.grootte.groot));
            GrootnaarkleinList.Add(new Dier(Dier.voer.vlees, Dier.grootte.groot));
            GrootnaarkleinList.Add(new Dier(Dier.voer.vlees, Dier.grootte.middelmatig));
            GrootnaarkleinList.Add(new Dier(Dier.voer.planten, Dier.grootte.middelmatig));
            GrootnaarkleinList.Add(new Dier(Dier.voer.planten, Dier.grootte.klein));
            GrootnaarkleinList.Add(new Dier(Dier.voer.vlees, Dier.grootte.klein));

            Sorteren logica = new Sorteren();

            //Act
            List<Dier> actualList = logica.sorteerGrootNaarKlein(randomList);

            //Assert
            bool hetzelfde = true;
            int i = 0;

            foreach (Dier dier in GrootnaarkleinList)
            {
                if (actualList[i].Grootte != dier.Grootte || actualList[i].Voer != dier.Voer)
                {
                    hetzelfde = false;
                }
                i++;
            }

            Assert.AreEqual(true, hetzelfde);
        }
        */
    }
}