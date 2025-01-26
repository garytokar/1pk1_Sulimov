using System;
// Написать программу, которая выводит таблицу скорости (через каждые 0,5с) свободно падающего тела v = g t ,
// где 2 g = 9,8 м/с2 – ускорение свободного падения.
namespace Task_03_07
{

    class Program
    {
        static void Main()
        {
            double g = 9.8;
            double timeStep = 0.5;

            Console.Write("Введите общее время падения в секундах: ");
            double totalTime = double.Parse(Console.ReadLine());

            Console.WriteLine("\nТаблица скорости свободно падающего тела:");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("   Время (с)\t   Скорость (м/с)");
            Console.WriteLine("---------------------------------------------------");

            for (double t = 0; t <= totalTime; t += timeStep)
            {
                double velocity = g * t;
                Console.WriteLine($"{t:F1}\t\t{velocity:F2}");
            }

            Console.WriteLine("---------------------------------------------------");
        }
    }
}