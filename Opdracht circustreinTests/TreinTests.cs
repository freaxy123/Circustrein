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
        public void vulTreinTest_CheckJuisteAantalWagons()
        {
            //Arrange 
            Trein trein = new Trein();

            List<Dier> gesorteerd = new List<Dier>();    //List in order
            gesorteerd.Add(new Dier(Dier.voer.vlees, Dier.grootte.groot));
            gesorteerd.Add(new Dier(Dier.voer.vlees, Dier.grootte.groot));
            gesorteerd.Add(new Dier(Dier.voer.vlees, Dier.grootte.middelmatig));
            gesorteerd.Add(new Dier(Dier.voer.vlees, Dier.grootte.klein));
            gesorteerd.Add(new Dier(Dier.voer.planten, Dier.grootte.klein));
            gesorteerd.Add(new Dier(Dier.voer.planten, Dier.grootte.groot));     
            gesorteerd.Add(new Dier(Dier.voer.planten, Dier.grootte.groot));            
            gesorteerd.Add(new Dier(Dier.voer.planten, Dier.grootte.middelmatig));
            
            //Act
            trein.vulTrein(gesorteerd); //Vul trein met aangegeven dieren

            //Assert
            IReadOnlyList<Wagon> wagons = trein.getTrein();

            int actual = wagons.Count;
            int expected = 5;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void vulTreinTest_checkAlgoritme()
        {
            //Arrange 
            Trein trein = new Trein();

            List<Dier> gesorteerd = new List<Dier>();    //List in order
            gesorteerd.Add(new Dier(Dier.voer.vlees, Dier.grootte.groot));
            gesorteerd.Add(new Dier(Dier.voer.vlees, Dier.grootte.groot));
            gesorteerd.Add(new Dier(Dier.voer.vlees, Dier.grootte.middelmatig));
            gesorteerd.Add(new Dier(Dier.voer.vlees, Dier.grootte.klein));
            gesorteerd.Add(new Dier(Dier.voer.planten, Dier.grootte.klein));
            gesorteerd.Add(new Dier(Dier.voer.planten, Dier.grootte.groot));
            gesorteerd.Add(new Dier(Dier.voer.planten, Dier.grootte.groot));
            gesorteerd.Add(new Dier(Dier.voer.planten, Dier.grootte.middelmatig));

            //Act
            trein.vulTrein(gesorteerd); //Vul trein met aangegeven dieren

            //Assert
            bool expected = true;
            bool actual = true;
            IReadOnlyList<Wagon> wagons = trein.getTrein();

            
            //Check of trein gelijk is aan optimale trein
            for (int i = 0; i < wagons.Count; i++)
            {
                IReadOnlyList<Dier> dieren = wagons[i].getDieren();
                if (i < 2)
                {
                    if(!(dieren[0].Grootte == Dier.grootte.groot && dieren[0].Voer == Dier.voer.vlees))
                    {
                        actual = false;
                    }
                }
                if(i == 2)
                {
                    if (!((dieren[0].Grootte == Dier.grootte.middelmatig && dieren[0].Voer == Dier.voer.vlees) || (dieren[0].Grootte == Dier.grootte.groot && dieren[0].Voer == Dier.voer.planten)))
                    {
                        actual = false;
                    }
                }
                if(i == 3)
                {
                    if (!((dieren[0].Grootte == Dier.grootte.klein && dieren[0].Voer == Dier.voer.vlees) || (dieren[0].Grootte == Dier.grootte.groot && dieren[0].Voer == Dier.voer.planten) || (dieren[0].Grootte == Dier.grootte.middelmatig && dieren[0].Voer == Dier.voer.planten)))
                    {
                        actual = false;
                    }
                }
                if(i == 4)
                {
                    if (!(dieren[0].Grootte == Dier.grootte.klein && dieren[0].Voer == Dier.voer.planten))
                    {
                        actual = false;
                    }
                }
            }

            Assert.AreEqual(actual, expected);
        }
    }
}