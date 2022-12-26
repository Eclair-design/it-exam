namespace Task9
{
    class Programm
    {
        static void Main()
        {
            int[,] matrix = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int gen = random.Next(0, 100);
                    matrix[i, j] = gen;
                    Console.Write(gen + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int result = 0;
            int prevMax = 0;
            for (int i = 0;i < matrix.GetLength(0); i++)
            {
                int count = 0;
                int max = 0;
                for (int j = 0;j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        count++;
                        max = matrix[i, j];
                    }
                 
                }
                if (count > prevMax)
                {
                    prevMax = count;
                    result = i + 1;
                }
            }
            Console.WriteLine(result);
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int t = matrix[i, 0];
                matrix[i, 0] = matrix[i,1];
                matrix[i, 1] = t;
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}