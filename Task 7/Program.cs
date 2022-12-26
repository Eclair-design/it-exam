namespace Task7
{
    class Programm
    {
        static void Main()
        {
            int[,] matrix = new int[10, 8];
            Random random = new Random();
            int rand;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    rand = random.Next(-10, 100);
                    matrix[i, j] = rand;
                }
            }
            Console.WriteLine("Матрица №1");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                long result = 1;
                bool match = true;
                for (int j = 0; j < 8; j++)
                {
                    int value = matrix[i, j];
                    if (value < 0)
                    {
                        match = false;
                        break;
                    }
                    result += value;

                }
                if (match)
                    Console.WriteLine($"Результат: {result} в строке #{i + 1}");
            }
            Console.WriteLine();
            for (int j = 0; j < 8; j++)
            {
                var t = matrix[9, j];
                matrix[9, j] = matrix[8, j];
                matrix[8, j] = t;
            }
            Console.WriteLine("Матрица №2");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}