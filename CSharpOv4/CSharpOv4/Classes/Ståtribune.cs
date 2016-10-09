using System;
using System.Collections.Generic;
using System.Data;
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

        public int Plass
        {
            get;
            set;
        }

        private Tuple<bool, int> SelgPlasser(int antall)
        {
            if (AntallSolgtePlasser + antall <= Kapasitet)
            {
                antallSolgtePlasser += antall;

                Plass++;

                Tuple<bool, int> tup = new Tuple<bool, int>(true, Plass);

                return tup;
            }
            else { Tuple<bool, int> tup = new Tuple<bool, int>(false, 0); return tup; }
        }

        public DataTable KjøpBillett(int antVoksne, int antBarn)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Tribunenavn", typeof(string));
            dt.Columns.Add("PlassNr", typeof(int));
            dt.Columns.Add("Pris", typeof(double));

            for (int i = 0; i < antVoksne; i++)
            {
                Tuple<bool, int> getTuple = SelgPlasser(i);
                
                if (getTuple.Item1)
                {
                    SolgteVoksne++;
                    dt.Rows.Add(Navn, getTuple.Item2, Pris); //Tribunenavn, PLASSNR, PRIS
                }
                else if (!getTuple.Item1) { break; }
            }

            for (int i = 0; i < antBarn; i++)
            {
                Tuple<bool, int> getTuple = SelgPlasser(i);
                
                if (getTuple.Item1)
                {
                    SolgteBarn++;
                    dt.Rows.Add(Navn, getTuple.Item2, BarnePris()); //Tribunenavn, PLASSNR, PRIS
                }
                else if (!getTuple.Item1) { break; }
            }

            return dt;

        }
    }

}
