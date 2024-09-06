using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


                                                // 1. Variant

//Ü 1. Введите с клавиатуры строку произвольной длины и подсчитайте процент вхождения заданного символа в строку.

namespace IseseisevToo_ValeriaAllikTARpv23
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Sisestage rida : ");
            string sisestatudRida = Console.ReadLine();
            string text = "a";
            char[] texts = text.ToCharArray();
            int count = 0;
            double protsent = Math.Round((double)count / sisestatudRida.Length * 100);
            for (int i = 0; i < sisestatudRida.Length; i++)
            {
                if (sisestatudRida[i]=="a")
                {
                    count++;
                    Console.WriteLine("Sümbol : " + text);
                    Console.WriteLine("Protsent : " + protsent + "%");
                }
                else
                {
                    Console.WriteLine("Sümbolit a ei ole");
                    break;
                }
            }
        }
    }
}


