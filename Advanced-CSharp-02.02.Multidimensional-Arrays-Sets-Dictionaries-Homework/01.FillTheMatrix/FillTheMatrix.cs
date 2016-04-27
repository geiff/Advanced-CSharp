using System;

namespace _01.FillTheMatrix
{
    class FillTheMatrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrixTopToBottom = new int[n, n];
            int[,] matrixLeftToRight = new int[n, n];

            MatrixFillAsTopToBottom(matrixTopToBottom);
            MatrixFillAsLeftToRight(matrixLeftToRight);
            PrinMatrix(matrixTopToBottom);
            Console.WriteLine();
            PrinMatrix(matrixLeftToRight);
        }

        static int[,] MatrixFillAsTopToBottom(int[,] matrix)
        {
            int number = 1;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col % 2 == 0 || col == 0)

                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, col] = number;
                        number++;
                    }
                }
                else
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, col] = number;
                        number++;
                    }
                }
            }

            return matrix;
        }

        static int[,] MatrixFillAsLeftToRight(int[,] matrix)
        {
            int number = 1;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col % 2 == 0 || col == 0)

                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, col] = number;
                        number++;
                    }
                }
                else
                {
                    for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                    {
                        matrix[row, col] = number;
                        number++;
                    }
                }
            }

            return matrix;
        }

        static void PrinMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 5}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
