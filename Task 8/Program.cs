namespace Task8
{
    class Programm
    {
        static void Main()
        {
            int[,] matrix = new int[5,5];
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int gen = random.Next(0, 100);
                    matrix[i, j] = gen;
                    Console.Write(gen+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int max = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    if (i == j)
                    {
                        int value = matrix[i, j];
                        
                        if (value > max)
                            max = value;
                    }
                }
            }
            Console.WriteLine(max);
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int t = matrix[0, i];
                matrix[0, i] = matrix[1,i];
                matrix[1, i] = t;
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}