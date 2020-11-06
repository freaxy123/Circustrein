using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_circustrein
{
    public class Trein
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
                if(stopDierInWagon(dier) == false)
                {
                    wagonToevoegen(dier);
                }
            }
        }

        private bool stopDierInWagon(Dier dier)
        {
            foreach (Wagon wagon in trein)
            {
                if (wagon.stopDierInWagon(dier) == true)
                {
                    return true;
                }
            }
            return false;
        }

        private void wagonToevoegen(Dier dier)
        {
                Wagon nieuweWagon = new Wagon(teller++);
                nieuweWagon.stopDierInWagon(dier);
                trein.Add(nieuweWagon);
        }

        public IReadOnlyList<Wagon> getTrein()
        {
            return trein.AsReadOnly();
        }
    }
}
