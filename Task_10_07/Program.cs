namespace Task_10_07
{
    class Program
    { 
        const int RUSSIAN_ALPHABET_SIZE = 33; 
        const char START_CAPITAL_LETTER = 'А';
        const char START_SMALL_LETTER = 'а';
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива n: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                char[,] array = GenerateCharacterArray(n);
                PrintCharacterArray(array);
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите положительное целое число.");
            }
        }
        static char[,] GenerateCharacterArray(int n)
        {
            char[,] array = new char[n, n]; 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int index = (i * n + j) % RUSSIAN_ALPHABET_SIZE; 
                    array[i, j] = (i % 2 == 0) ? (char)(START_CAPITAL_LETTER + index) : (char)(START_SMALL_LETTER + index);
                }
            }

            return array; 
        }
        static void PrintCharacterArray(char[,] array)
        {
            int size = array.GetLength(0); 
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(array[i, j] + "\t"); 
                }
                Console.WriteLine();
            }
        }
    }
}
