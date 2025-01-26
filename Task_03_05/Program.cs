namespace Task_03_05
//Написать программу, которая выводит на экран таблицу соответствия температуры в градусах Цельсия и
//Фаренгейта(F = C * 1,8 + 32). Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во
//время работы программы
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите начальную температуру в градусах Цельсия: ");
            double startCelsius = double.Parse(Console.ReadLine());

            Console.Write("Введите конечную температуру в градусах Цельсия: ");
            double endCelsius = double.Parse(Console.ReadLine());

            Console.Write("Введите шаг изменения температуры: ");
            double step = double.Parse(Console.ReadLine());

            Console.WriteLine("\nТаблица соответствия температуры (Цельсий - Фаренгейт):");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Цельсий\t\tФаренгейт");
            Console.WriteLine("---------------------------------------------------");

            for (double celsius = startCelsius; celsius <= endCelsius; celsius += step)
            {
                double fahrenheit = celsius * 1.8 + 32;
                Console.WriteLine($"{celsius:F2}\t\t{fahrenheit:F2}");
            }

            Console.WriteLine("---------------------------------------------------");
        }
    }
}