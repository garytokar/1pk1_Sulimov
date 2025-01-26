using System;
namespace Task_04_09
{

    class Program
    {
        static void Main()
        {           
            int arraySize = 50;
            int[] numbers = new int[arraySize];
            Random random = new Random();

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

            Console.WriteLine("Уникальные элементы:");
            for (int i = 0; i < arraySize; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < arraySize; j++)
                {
                    if (i != j && numbers[i] == numbers[j])
                    {
                        isUnique = false;
                        break; 
                    }
                }
                if (isUnique)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
