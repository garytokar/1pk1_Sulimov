using System;
namespace Task_04_05
{

    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int daysInMonth = 30;
            int[] precipitation = new int[daysInMonth];

            for (int i = 0; i < daysInMonth; i++)
            {
                precipitation[i] = random.Next(0, 301);
            }
          
            Console.WriteLine("День\tОсадки (мм)");
            for (int i = 0; i < daysInMonth; i++)
            {
                Console.WriteLine($"{i + 1}\t{precipitation[i]}");
            }
          
            for (int decade = 0; decade < 3; decade++)
            {
                int startDay = decade * 10;
                int totalPrecipitation = 0;

                for (int day = startDay; day < startDay + 10; day++)
                {
                    totalPrecipitation += precipitation[day];
                }

                Console.WriteLine($"\nОбщее количество осадков за декаду {decade + 1}: {totalPrecipitation} мм");
            }

            // Поиск дня с самыми сильными осадками
            int maxPrecipitation = 0;
            int dayWithMaxPrecipitation = 0;

            for (int i = 0; i < daysInMonth; i++)
            {
                if (precipitation[i] > maxPrecipitation)
                {
                    maxPrecipitation = precipitation[i];
                    dayWithMaxPrecipitation = i + 1; // +1 для отображения дня
                }
            }

            Console.WriteLine($"\nДень с самыми сильными осадками: {dayWithMaxPrecipitation} (осадки: {maxPrecipitation} мм)");

            // Вывод дней без осадков
            Console.WriteLine("\nДни без осадков:");
            for (int i = 0; i < daysInMonth; i++)
            {
                if (precipitation[i] == 0)
                {
                    Console.WriteLine($"День {i + 1}");
                }
            }
        }
    }
}
