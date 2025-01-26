namespace Task_04_10
{
    using System;

    class Program
    {
        static void Main()
        {
            int[] numbers = new int[10];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-10, 11);
            }
            Console.WriteLine("Исходный массив:");
            PrintArray(numbers);
            ReverseArray(numbers, 0, numbers.Length / 2 - 1);
            ReverseArray(numbers, numbers.Length / 2, numbers.Length - 1);
            Console.WriteLine("Массив после реверса:");
            PrintArray(numbers);
        }
        static void ReverseArray(int[] array, int start, int end)
        {
            while (start < end)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
        }

        static void PrintArray(int[] array)
        {
            foreach (var num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
