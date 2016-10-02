﻿using CSharpOv4.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOv4
{
    class Program
    {
        static void Main(string[] args)
        {
            Ståtribune feltA = new Ståtribune("Felt A", 50, 1000);
            Sittetribune feltB = new Sittetribune("Felt B", 250, 200, 20);
            VIPtribune kafeen = new VIPtribune("Kafe Fotball", 1000, 10, 2);
            String res = "";
            res += "Kapasitet på felt A: " + feltA.Kapasitet + "\n";
            res += "Kapasitet på felt B: " + feltB.Kapasitet + "\n";
            res += "Kapasitet i kafeen: " + kafeen.Kapasitet + "\n";
            if (feltA.SelgPlasser(20)) res += "20 plasser solgt\n";
            else res += "Ikke nok plass\n";
            if (feltB.SelgPlasser(10)) res += "10 plasser solgt\n";
            else res += "Ikke nok plass\n";
            if (kafeen.SelgPlasser(8)) res += "8 plasser solgt\n";
            else res += "Ikke nok plass\n";
            if (kafeen.SelgPlasser(5)) res += "5 plasser solgt\n";
            else res += "Ikke nok plass\n";
            if (feltB.SelgPlasser(50)) res += "50 plasser solgt\n";
            else res += "Ikke nok plass\n";
            /*          double solgtFor = feltA.AntallSolgtePlasser * feltA.Pris;
                      solgtFor += feltB.AntallSolgtePlasser * feltB.Pris;
                      solgtFor += kafeen.AntallSolgtePlasser * kafeen.Pris;*/
            double solgtFor = feltA.SolgtFor() + feltB.SolgtFor() + kafeen.SolgtFor();
            res += "Solgt for: " + solgtFor + " kroner\n";

            Console.WriteLine(res);

            Console.Read();

            //MessageBox.Show(res, "Tribuner", MessageBoxButtons.OK,
            //    MessageBoxIcon.Information);

            //           Console.WriteLine();
        }
    }
}