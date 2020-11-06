using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_circustrein
{
    public class Wagon
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

        public bool stopDierInWagon(Dier inputDier)
        {
            if (kanDierBijWagonDieren(inputDier) == true)
            {
                if (isErRuimte(inputDier) == true)
                {
                    voegDierAanWagon(inputDier);
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

        private bool isErRuimte(Dier inputDier)
        {
            int vrijeRuimte = ruimte - inputDier.getGrootte();

            if (vrijeRuimte >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool kanDierBijWagonDieren(Dier inputDier)
        {
            foreach (Dier dier in dieren)
            {
                if ((dier.Voer == Dier.voer.vlees && inputDier.Grootte <= dier.Grootte) || (inputDier.Voer == Dier.voer.vlees && inputDier.Grootte >= dier.Grootte))
                {
                    return false;
                }
            }
            return true;
        }

        private void voegDierAanWagon(Dier dier)
        {
            dieren.Add(dier);
            ruimte -= dier.getGrootte();
        }

        public int getVrijeRuimte()
        {
            return ruimte;
        }

        public IReadOnlyList<Dier> getDieren()
        {
            return dieren.AsReadOnly();
        }

        public override string ToString()
        {
            return "Wagon " + Convert.ToString(nummer);
        }
    }
}
