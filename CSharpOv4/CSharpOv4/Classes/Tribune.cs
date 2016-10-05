using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOv4.Classes
{
    public class Tribune
    {
        public Tribune(string navn, double pris, int kap)
        {
            Navn = navn;
            Pris = pris;
            Kapasitet = kap;
        }

        public string Navn
        {
            get;
            private set;
        }

        public double Pris
        {
            get;
            private set;
        }

        public int Kapasitet
        {
            get;
            private set;
        }

        public double SolgtFor()
        {
            return AntallSolgtePlasser * Pris;
        }
        public virtual int AntallSolgtePlasser
        {
            get
            {
                return 0;
            }
        }

        public virtual double barnePris()
        {
            return Pris / 2;
        }
        public override string ToString()
        {
            return Navn + " har kapasitet " + Kapasitet + " og pris " + Pris + " kroner.";
        }
    }
}
