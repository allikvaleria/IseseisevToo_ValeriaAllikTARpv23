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
            Console.Write("Sisestage rida: ");
            string sisestatudRida = Console.ReadLine();
            Console.Write("Sisestage sümbol, mida otsida: ");
            // Ищет символ в строке, который ввел пользователь
            char searchChar = Console.ReadLine()[0]; 
            int count = 0; // Сохроняет количество символов
            //Проходит по каждому символу строки
            for (int i = 0; i < sisestatudRida.Length; i++)
            {
                //Увеличивает count если символ в строке совпадает с поиском
                if (sisestatudRida[i] == searchChar)
                {
                    count++;
                }
            }
            // Вывод результата
            if (count > 0)
            {
                // Считает процент
                double protsent = Math.Round((double)count / sisestatudRida.Length * 100);
                Console.WriteLine($"Sümbol: {searchChar}");
                Console.WriteLine($"Protsent: {protsent}%");
            }
            else
            {
                Console.WriteLine($"Sümbolit {searchChar} ei ole.");
            }
        }
    }
}
