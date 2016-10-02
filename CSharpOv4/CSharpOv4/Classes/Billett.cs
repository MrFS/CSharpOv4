using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOv4.Classes
{
    public class Billett
    {
        Billett(string tribunenavn, double pris)
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

    public class Ståbillett
    {
        Ståbillett()
        {

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

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
