using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_circustrein
{
    class Wagon
    {
        private List<Dier> dieren;
        private int ruimte;
        private int nummer;

        public Wagon(int teller)
        {
            ruimte = 10;
            dieren = new List<Dier>();
            nummer = teller;
        }

        public bool kanDierInWagon(Dier inputDier)
        {
            bool kanDierInWagonBool = true;
            foreach (Dier dier in dieren)
            {
                if ((dier.Voer == Dier.voer.vlees && inputDier.Grootte <= dier.Grootte) || (inputDier.Voer == Dier.voer.vlees && inputDier.Grootte >= dier.Grootte))
                {
                    kanDierInWagonBool = false;
                }
            }
            if (kanDierInWagonBool == true)
            {
                int vrijeRuimte = ruimte - inputDier.getRuimte();
                if (vrijeRuimte >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void voegDierAanWagon(Dier dier)
        {
            dieren.Add(dier);
            ruimte -= dier.getRuimte();
        }

        public int vrijeRuimteWagon()
        {
            return ruimte;
        }

        public List<Dier> getDieren()
        {
            return dieren;
        }

        public override string ToString()
        {
            return "Wagon " + Convert.ToString(nummer);
        }


    }
}
