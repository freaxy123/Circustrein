using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_circustrein
{
    class Userinterface
    {
        private List<Dier> dieren;

        public Userinterface()
        {
            dieren = new List<Dier>();
        }

        public void voegDierAanLijst(Dier dier)
        {
            dieren.Add(dier);
        }

        public List<Dier> getLijstDieren()
        {
            return dieren;
        }

        public List<Dier> sorteerLijst(List<Dier> ongesorteerd)
        {
            List<Dier> gesorteerd = new List<Dier>();

            List<Dier> vleesetersOpVolgorde = sorteerGrootNaarKlein(sorteerOpVoer(ongesorteerd, Dier.voer.vlees));
            List<Dier> plantenetersOpVolgorde = sorteerGrootNaarKlein(sorteerOpVoer(ongesorteerd, Dier.voer.planten));

            gesorteerd.AddRange(vleesetersOpVolgorde);
            gesorteerd.AddRange(plantenetersOpVolgorde);

            return gesorteerd;
        }

        public List<Dier> sorteerOpVoer(List<Dier> ongesorteerd, Dier.voer Voer)
        {
            List<Dier> gesorteerd = new List<Dier>();
            foreach (Dier dier in ongesorteerd)
            {
                if(dier.Voer == Voer)
                {
                    gesorteerd.Add(dier);
                }
            }
            return gesorteerd;
        }

        public List<Dier> sorteerGrootNaarKlein(List<Dier> ongesorteerd)
        {
            List<Dier> gesorteerd = new List<Dier>();
            List<Dier> temp = ongesorteerd.ToList();

            for(int i = 0; i < ongesorteerd.Count; i++)
            {
                Dier search = zoekLijstOpGrootte(temp, Dier.grootte.groot);
                if (search != null)
                {
                    gesorteerd.Add(search);
                    temp.Remove(search);
                }
                else
                {
                    search = zoekLijstOpGrootte(temp, Dier.grootte.middelmatig);
                    if (search != null)
                    {
                        gesorteerd.Add(search);
                        temp.Remove(search);
                    }
                    else
                    {
                        search = zoekLijstOpGrootte(temp, Dier.grootte.klein);
                        if (search != null)
                        {
                            gesorteerd.Add(search);
                            temp.Remove(search);
                        }
                    }
                }

            }
            return gesorteerd;
        }

        public Dier zoekLijstOpGrootte(List<Dier> lijst, Dier.grootte Grootte)
        {
            foreach (Dier dier in lijst)
            {
                if (dier.Grootte == Grootte)
                {
                    return dier;
                }
            }
            return null;
        }
    }
}
