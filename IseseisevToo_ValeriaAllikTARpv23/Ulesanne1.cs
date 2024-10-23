using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IseseisevToo_ValeriaAllikTARpv23
{
    internal class Ulesanne1
    {
        public static void Ulesanne_1()
        {
            Console.WriteLine("Sisestage rida: ");
            string sisestatudRida = Console.ReadLine();
            char searchChar = 'a'; // Using a char
            int count = 0;

            for (int i = 0; i < sisestatudRida.Length; i++)
            {
                if (sisestatudRida[i] == searchChar)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                double protsent = Math.Round((double)count / sisestatudRida.Length * 100);
                Console.WriteLine($"Sümbol: {searchChar}");
                Console.WriteLine($"Protsent: {protsent}%");
            }
            else
            {
                Console.WriteLine("Sümbolit 'a' ei ole.");
            }
        }
    }
}
