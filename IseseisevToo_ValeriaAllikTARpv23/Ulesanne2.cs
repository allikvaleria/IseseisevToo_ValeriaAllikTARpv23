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
            Random random = new Random();
            //Заполняем матрицу случайными числами
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                    Console.Write($"{matrix[i, j]:0} ");
                }
                Console.WriteLine();
            }
            //сумма элементов для каждой строки
            Console.WriteLine();
            Console.WriteLine("Iga rea elementide summa");
            for (int i = 0; i < 10; i++)
            {
                double sum = 0;
                for (int j = 0; j < 10; j++)
                {
                    // Суммируем элементы каждой строки
                    sum += matrix[i, j];
                }
                // Выводим сумму для каждой строки
                Console.WriteLine($"Rea summa {i + 1}: {sum}");
                // i - индекс строки, i + 1 - добавляет 1 к индексу, пишет номер строки 
            }
            //произведение элементов для каждого столбца
            Console.WriteLine();
            Console.WriteLine("Iga veeru elementide teosed");
            for (int j = 0; j < 10; j++)
            {
                double product = 1;
                // Перемножаем элементы каждого столбца
                for (int i = 0; i < 10; i++)
                {
                    product *= matrix[i, j];
                }
                Console.WriteLine($"Veeru teos {j + 1}: {product}");
            }
            // Находим максимальный элемент на главной диагонали
            double max = matrix[0, 0];
            for (int i = 1; i < 10; i++)
            {
                // Если текущий элемент диагонали больше max, обновляем max
                if (matrix[i, i] > max)
                {
                    max = matrix[i, i];
                }
            }
            Console.WriteLine($"Maksimaalne element peadiagonaalil: {max}");
        }
    }
}
