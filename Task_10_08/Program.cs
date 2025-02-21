namespace Task_10_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 5, 7, 9, 12, 15, 20 };

            Console.Write("Введите число для поиска: ");
            if (int.TryParse(Console.ReadLine(), out int numberToFind))
            {
                int index = FindElementIndex(array, numberToFind);
                if (index != -1)
                {
                    Console.WriteLine($"Элемент {numberToFind} найден на индексе {index}.");
                }
                else
                {
                    Console.WriteLine($"Элемент {numberToFind} не найден в массиве.");
                }
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное целое число.");
            }
        }
        static int FindElementIndex(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
