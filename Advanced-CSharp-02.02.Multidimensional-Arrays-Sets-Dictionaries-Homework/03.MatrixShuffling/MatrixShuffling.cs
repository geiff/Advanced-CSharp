using System;

namespace _03.MatrixShuffling
{
    class MatrixShuffling
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, m];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] inputArr = input.Split(' ');
                if (inputArr[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    int x1 = int.Parse(inputArr[1]);
                    int y1 = int.Parse(inputArr[2]);
                    int x2 = int.Parse(inputArr[3]);
                    int y2 = int.Parse(inputArr[4]);
                    if (x1 < n && y1 < m && x2 < n && y2 < m)
                    {
                        Swap(matrix, x1, y1, x2, y2);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                    PrinMatrix(matrix);
                }

                input = Console.ReadLine();
            }
        }

        static void Swap(string[,] matrix, int x1, int y1, int x2, int y2)
        {
            string old = matrix[x1, y1];
            matrix[x1, y1] = matrix[x2, y2];
            matrix[x2, y2] = old;
        }

        static void PrinMatrix<T>(T[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 7}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}