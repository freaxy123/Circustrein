using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_circustrein
{
    class Trein
    {
        private List<Wagon> trein;
        private int teller = 1;

        public Trein()
        {
           trein = new List<Wagon>();
        }

        public void vulTrein(List<Dier> dieren)
        {
            foreach(Dier dier in dieren)
            {
                bool kanDierInWagon = false;
                foreach(Wagon wagon in trein)
                {
                    if(wagon.kanDierInWagon(dier) == true)
                    {
                        kanDierInWagon = true;
                        wagon.voegDierAanWagon(dier);
                        break;
                    }
                }
                if(kanDierInWagon == false)
                {
                    Wagon nieuweWagon = new Wagon(teller++);
                    nieuweWagon.voegDierAanWagon(dier);
                    trein.Add(nieuweWagon);
                }
            }
        }

        public List<Wagon> getTrein()
        {
            return trein;
        }


    }
}
