using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GYB_gokartprojekt2
{
    internal class NevBetolto
    {
        public static List<string> NevekBetoltese(string fajlNev)
        {
            string tartalom = File.ReadAllText(fajlNev);

           
            tartalom = tartalom.Replace("'", "");

            
            string[] nevekTomb = tartalom.Split(',');

            List<string> nevek = new List<string>();
            foreach (string nev in nevekTomb)
            {
                nevek.Add(nev.Trim());
            }

            return nevek;
        }
    }
}
