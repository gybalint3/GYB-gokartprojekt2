using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYB_gokartprojekt2
{
    internal class program
    {
        static void Main(string[] args)
        {
            Helyszin helyszin = new Helyszin(
                "GYB Gokartpálya",
                "6066, Tiszaalpár Rohonci út 12.",
                "+36-30-512-8847",
                "gyb-gokart.hu"
            );

            helyszin.AdatokKiirasa();
        }

    }
}
