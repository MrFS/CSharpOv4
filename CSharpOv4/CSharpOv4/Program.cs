using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpOv4.Classes;
using System.Windows.Forms;
using System.Data;

namespace CSharpOv4
{
    class Program
    {
        static void Main(string[] args)
        {

            DataTable dt = new DataTable();
            
            Ståtribune feltA = new Ståtribune("Felt A", 50, 1000);
            Sittetribune feltB = new Sittetribune("Felt B", 250, 200, 20);
            VIPtribune feltC = new VIPtribune("Felt C", 500, 100, 2);

            dt = feltB.KjøpBillett(10, 5);

            string res = "";

            Console.WriteLine("Sittetribune\nNavn\tRad\tPlassnr\tPris");

            foreach (DataRow item in dt.Rows)
            {
                foreach (var i in item.ItemArray)
                {
                    res += i + "\t";
                }

                Console.WriteLine(res);
                res = "";
            }

            Console.WriteLine("Totalt solgt for " + 
                              feltB.SolgtFor() + 
                              ",-\nAntall Voksne: " + 
                              feltB.SolgteVoksne + 
                              "\nAntall barn: " + 
                              feltB.SolgteBarn);

            Console.WriteLine("\nStåtribune\nNavn\tPlassnr\tPris");

            dt.Clear();
            
            dt = feltA.KjøpBillett(10, 2);

            foreach (DataRow item in dt.Rows)
            {
                foreach (var i in item.ItemArray)
                {
                    res += i + "\t";
                }

                Console.WriteLine(res);
                res = "";
            }

            Console.WriteLine("Totalt solgt for " +
                              feltA.SolgtFor() +
                              ",-\nAntall Voksne: " +
                              feltA.SolgteVoksne +
                              "\nAntall barn: " +
                              feltA.SolgteBarn);

            dt.Clear();

            Console.WriteLine("\nVIPtribune\nNavn\tRad\tPlassnr\tPris");
           
            dt = feltC.KjøpBillett(10, 5);

            foreach (DataRow item in dt.Rows)
            {
                foreach (var i in item.ItemArray)
                {
                    res += i + "\t";
                }

                Console.WriteLine(res);
                res = "";
            }

            Console.WriteLine("Totalt solgt for " +
                              feltC.SolgtFor() +
                              ",-\nAntall Voksne: " +
                              feltC.SolgteVoksne +
                              "\nAntall barn: " +
                              feltC.SolgteBarn);

            Console.Read();
        }
    }
}
