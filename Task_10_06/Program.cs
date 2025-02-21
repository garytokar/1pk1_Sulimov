namespace Task_10_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива n: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                ArrayGeneration(n);
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное положительное целое число.");
            }
        }
        static void ArrayGeneration(int n)
        {
            const int minValue = 1;
            const int maxValue = 100; 
            int[,] array = new int[n, n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(minValue, maxValue);
                }
            }
            Console.WriteLine("Сгенерированный массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
