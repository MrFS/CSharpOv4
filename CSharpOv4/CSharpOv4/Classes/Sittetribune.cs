using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOv4.Classes
{
    public class Sittetribune : Tribune
    {
        private int[] antallSolgtPrRad;

        public Sittetribune(string navn, double pris, int kap, int antRader)
            : base(navn, pris, kap)
        {
            AntallRader = antRader;
            antallSolgtPrRad = new int[AntallRader];
            for (int i = 0; i < AntallRader; i++) antallSolgtPrRad[i] = 0;
        }

        public int AntallRader
        {
            get;
            private set;
        }

        public override int AntallSolgtePlasser
        {
            get
            {
                int total = 0;
                for (int i = 0; i < AntallRader; i++) total += antallSolgtPrRad[i];
                return total;
            }
        }

        private bool SelgPlasser(int antall)
        {
            int kapPrRad = Kapasitet / AntallRader;
            int i = 0;
            while (i < AntallRader && antallSolgtPrRad[i] + antall > kapPrRad) i++;
            if (i < AntallRader)
            {
                antallSolgtPrRad[i] += antall;
                return true;
            }
            else return false;
        }
        public override string ToString()
        {
            return base.ToString() + " Antall rader er " + AntallRader + ".";
        }
    }
}
