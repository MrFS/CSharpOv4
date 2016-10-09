using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CSharpOv4.Classes
{
    public class Sittetribune : Tribune
    {
        private int[] antallSolgtPrRad;
        private int _sete;

        public Sittetribune(string navn, double pris, int kap, int antRader) : base(navn, pris, kap)
        {
            Rad = 1;
            AntallRader = antRader;
            antallSolgtPrRad = new int[AntallRader];
            for (int i = 0; i < AntallRader; i++) antallSolgtPrRad[i] = 0;
        }

        public int AntallRader
        {
            get;
            private set;
        }

        public int Sete
        {
            get
            {
                return _sete;
            }
            set
            {
                if (_sete > Kapasitet / AntallRader)
                {
                    Rad++;
                    _sete = 1;
                }
                else
                {
                    _sete++;
                }
            }
        }

        public int Rad
        {
            get;
            set;
        }

        public override int AntallSolgtePlasser
        {
            get
            {
                int total = 0;

                for (int i = 0; i < AntallRader; i++)
                {
                    total += antallSolgtPrRad[i];
                }

                return total;
            }
        }

        //public bool SelgPlasser(int antall)
        //{
        //    int kapPrRad = Kapasitet / AntallRader;
        //    int i = 0;
        //    while (i < AntallRader && antallSolgtPrRad[i] + antall > kapPrRad) i++;
        //    if (i < AntallRader)
        //    {
        //        antallSolgtPrRad[i] += antall;
        //        return true;
        //    }
        //    else return false;
        //}

        private Tuple<bool, int, int> SelgPlasser(int antall)
        {
            List<string> lst = new List<string>();
            
            int kapPrRad = Kapasitet / AntallRader;
            int i = 0;
            while (i < AntallRader && antallSolgtPrRad[i] + antall > kapPrRad) i++;
            if (i < AntallRader)
            {
             
                antallSolgtPrRad[i] += antall;
                
                Sete++;

                Tuple<bool, int, int> tup = new Tuple<bool, int, int>(true, Rad, Sete); // rad først så plass

                return tup;
            }
            else {

                Tuple<bool, int, int> tup = new Tuple<bool, int, int>(false, 0, 0);
                return tup;

            }
        }

        public DataTable KjøpBillett(int antVoksne, int antBarn)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Tribunenavn", typeof(string));
            dt.Columns.Add("Rad", typeof(int));
            dt.Columns.Add("PlassNr", typeof(int));
            dt.Columns.Add("Pris", typeof(double));

            for (int i = 0; i < antVoksne; i++)
            {
                Tuple<bool, int, int> getTuple = SelgPlasser(i);
                
                if (getTuple.Item1)
                {
                    SolgteVoksne++;
                    dt.Rows.Add(Navn, getTuple.Item2, getTuple.Item3, Pris); //Tribunenavn, RAD, PLASSNR, PRIS
                }else if (!getTuple.Item1){ break; }
            }

            for (int i = 0; i < antBarn; i++)
            {
                Tuple<bool, int, int> getTuple = SelgPlasser(i);
                
                if (getTuple.Item1)
                {
                    SolgteBarn++;
                    dt.Rows.Add(Navn, getTuple.Item2, getTuple.Item3, BarnePris()); //Tribunenavn, RAD, PLASSNR, PRIS
                }
                else if (!getTuple.Item1) { break; }
            }

            return dt;
            
        }
        public override string ToString()
        {
            return base.ToString() + " Antall rader er " + AntallRader + ".";
        }
    }

}
