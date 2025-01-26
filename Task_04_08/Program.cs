using System;
namespace Task_04_08
{

    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int arraySize = 50;
            int[] numbers = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                numbers[i] = random.Next(0, 10); 
            }

            Console.WriteLine("Сгенерированный массив:");
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            int pairsCount = 0;

            int[] counts = new int[10]; 

            foreach (var number in numbers)
            {
                counts[number]++;
            }
            foreach (var count in counts)
            {
                if (count > 1)
                {
                    pairsCount += count / 2; 
                }
            }

            Console.WriteLine($"Количество пар элементов с одинаковыми значениями: {pairsCount}");
        }
    }
}
