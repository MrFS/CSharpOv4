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

        public bool SelgPlasser(int antall)
        {
            if (AntallSolgtePlasser + antall <= Kapasitet)
            {
                antallSolgtePlasser += antall;
                return true;
            }
            else return false;
        }
    }
}
