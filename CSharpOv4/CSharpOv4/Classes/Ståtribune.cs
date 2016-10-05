using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOv4.Classes
{
    public class Ståtribune : Tribune
    {
        private int antallSolgtePlasser;
        public Ståtribune(string navn, double pris, int kap)
            : base(navn, pris, kap)
        {
            antallSolgtePlasser = 0;
        }
        public override int AntallSolgtePlasser
        {
            get
            {
                return antallSolgtePlasser;
            }
        }

        public List<string> SelgPlasser(int antall)
        {
            List<string> lst = new List<string>();
            if (AntallSolgtePlasser + antall <= Kapasitet)
            {
                antallSolgtePlasser += antall;

                int plass = Kapasitet - antallSolgtePlasser;

                lst.Add("Du har ståplass " + plass);
                return lst;
            }
            else { lst.Add("Ingen ledige plasser for ståtribunen"); return lst; };

        }


    }
}
