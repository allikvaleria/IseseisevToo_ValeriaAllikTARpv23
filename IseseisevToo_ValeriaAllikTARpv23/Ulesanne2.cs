using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IseseisevToo_ValeriaAllikTARpv23
{
    internal class Ulesanne2
    {
        public static void Ulesanne_2()
        {
            double[,] matrix = new double[10, 10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = rand.Next(1, 10);
                }
            }
            for (int i = 0; i < 10; i++)
            {
                double sum = 0;
                for (int j = 0; j < 10; j++)
                {
                    sum += matrix[i, j];
                }
                Console.WriteLine($"Rea summa {i + 1}: {sum}");
            }
            for (int j = 0; j < 10; j++)
            {
                double product = 1;
                for (int i = 0; i < 10; i++)
                {
                    product *= matrix[i, j];
                }
                Console.WriteLine($"Veeru teos {j + 1}: {product}");
            }
            double max = matrix[0, 0];
            for (int i = 1; i < 10; i++)
            {
                if (matrix[i, i] > max)
                {
                    max = matrix[i, i];
                }
            }
            Console.WriteLine($"Maksimaalne element peadiagonaalil: {max}");
        }
    }
}
