using System;
// Написать программу, которая выводит таблицу значений функции: 𝑦=|𝑥|для -4≤x≤4, с шагом h = 0,5
namespace Task_03_06
{

    class Program
    {
        static void Main()
        {
            double startX = -4.0;
            double endX = 4.0;
            double step = 0.5;

            Console.WriteLine("Таблица значений функции y = |x|:");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("   x\t\t   y");
            Console.WriteLine("---------------------------------------------------");

            for (double x = startX; x <= endX; x += step)
            {
                double y = Math.Abs(x);
                Console.WriteLine($"{x:F1}\t\t{y:F1}");
            }

            Console.WriteLine("---------------------------------------------------");
        }
    }
}