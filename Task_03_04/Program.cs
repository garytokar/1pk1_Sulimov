using System;
//Пользователь вводить в консоли произвольный текст. После каждого ввода консоль очищается.
//Когда пользователь вводить слово «exit» или пустую строку – ввод останавливается и выводиться количество строк
//введенных пользователем
namespace Task_03_04
{
    class Program
    {
        static void Main()
        {
            int lineCount = 0;
            string input;

            Console.WriteLine("Введите текст (введите 'exit' или пустую строку для выхода):");

            while (true)
            {
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input) || input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                lineCount++;
                Console.Clear();
            }

            Console.WriteLine($"Количество введенных строк: {lineCount}");
        }
    }
}