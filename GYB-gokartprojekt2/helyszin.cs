using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYB_gokartprojekt2
{
    internal class Helyszin
    {
        public string Nev { get; }
        public string Cim { get; }
        public string Telefonszam { get; }
        public string Weboldal { get; }

        public Helyszin(string nev, string cim, string telefonszam, string weboldal)
        {
            Nev = nev;
            Cim = cim;
            Telefonszam = telefonszam;
            Weboldal = weboldal;
        }

        public void AdatokKiirasa()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine($" {Nev}");
            Console.WriteLine($" Cím: {Cim}");
            Console.WriteLine($" Telefon: {Telefonszam}");
            Console.WriteLine($" Weboldal: {Weboldal}");
            Console.WriteLine("==========================================");
        }
    }
}
