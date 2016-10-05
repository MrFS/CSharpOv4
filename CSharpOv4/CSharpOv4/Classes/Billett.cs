using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOv4.Classes
{
    public class Billett
    {
        public Billett(string tribunenavn, double pris)
        {
            Tribunenavn = tribunenavn;
            Pris = pris;
        }

        public string Tribunenavn
        {
            get;
            set;
        }

        public double Pris
        {
            get;
            set;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class Ståbillett : Ståtribune
    {
        public Ståbillett(string navn, double pris, int kap) : base(navn, pris, kap)
        {

        }

        public DataTable KjøpBillett(int antVoksne, int antBarn)
        {
            DataTable dt = new DataTable();
            List<string> lst = new List<string>();
            
            dt.Columns.Add("Plass", typeof(string));
            dt.Columns.Add("Pris", typeof(string));
            for (int i = 0; i < antVoksne; i++)
            {
                lst = SelgPlasser(antVoksne);
                dt.Rows.Add(lst.ElementAt(0), Pris);
            }

            lst.Clear();

            for (int i = 0; i < antBarn; i++)
            {
                lst = SelgPlasser(antBarn);
                dt.Rows.Add(lst.ElementAt(0), barnePris());
            }

            return dt;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class Sittebillett
    {
        Sittebillett(string tribunenavn, double pris, int rad, int plassnr)
        {
            Tribunenavn = tribunenavn;
            Pris = pris;
            Rad = rad;
            Plassnr = plassnr;
        }

        public string Tribunenavn
        {
            get;
            set;
        }

        public double Pris
        {
            get;
            set;
        }

        public int Rad
        {
            get;
            set;
        }

        public int Plassnr
        {
            get;
            set;
        }

        public DataTable KjøpBillett(int antVoksne, int antBarn)
        {
            DataTable dt = new DataTable();

            return dt;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
