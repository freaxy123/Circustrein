using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_circustrein
{
    public class Dier
    {
        public enum voer
        {
            vlees,
            planten
        }

        public enum grootte
        {
            klein = 1,
            middelmatig = 3,
            groot = 5
        }

        public voer Voer { get; private set; }
        public grootte Grootte { get; private set; }

        public Dier(voer inputVoer, grootte inputGrootte)
        {
            Voer = inputVoer;
            Grootte = inputGrootte;
        }

        public int getGrootte()
        {
            return (int)this.Grootte;
        }

        public override string ToString()
        {
            string text;
            if(Grootte == grootte.klein)
            {
                text = "Kleine";
            }
            else if (Grootte == grootte.middelmatig)
            {
                text = "Middelmatige";
            }
            else
            {
                text = "Grote";
            }

            if (Voer == voer.planten)
            {
                text += " Planteneter";
            }
            else
            {
                text += " Vleeseter";
            }
            return text;
        }
    }
}
