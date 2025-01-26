using System;
using System.Collections.Generic;
namespace Task_04_06
{

    class Program
    {
        static void Main()
        {
            int size = 30;
            HashSet<int> uniqueAbsValues = new HashSet<int>();
            Random random = new Random();
            int[] numbers = new int[size];
            int index = 0;
            while (index < size)
            {
                int num = random.Next(-size, size + 1);
                if (num != 0 && uniqueAbsValues.Add(Math.Abs(num)))
                {
                    numbers[index] = num;
                    index++;
                }
            }
            int maxValue = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (Math.Abs(numbers[i]) > Math.Abs(maxValue))
                {
                    maxValue = numbers[i];
                }
            }
            Console.WriteLine("Сгенерированный массив:");
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine($"Наибольшее по модулю число: {maxValue} (по модулю: {Math.Abs(maxValue)})");
        }
    }
}
