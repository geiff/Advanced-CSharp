using System;

namespace _02.MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            string inputRazmer = Console.ReadLine();
            string[] inputRazmerArr = inputRazmer.Split(' ');

            int n = int.Parse(inputRazmerArr[0]);
            int m = int.Parse(inputRazmerArr[1]);

            int[,] matrix = new int[n, m];

            ParseMatrix(matrix);
            Console.WriteLine();
            Console.WriteLine("The input matrix is:");
            PrinMatrix(matrix);
            Console.WriteLine();
            Console.WriteLine("The result is:");
            MaximSum(matrix);
        }

        static void MaximSum(int[,] matrix)
        {
            int sumMax = Int32.MinValue;
            int[,] newMaxSumMatrix = new int[3, 3];
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int curentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                                + matrix[row + 1, col] + matrix[row + 2, col] + matrix[row + 1, col + 1]
                                + matrix[row + 1, col + 2] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (curentSum > sumMax)
                    {
                        sumMax = curentSum;
                        newMaxSumMatrix[0, 0] = matrix[row, col];
                        newMaxSumMatrix[0, 1] = matrix[row, col + 1];
                        newMaxSumMatrix[0, 2] = matrix[row, col + 2];
                        newMaxSumMatrix[1, 0] = matrix[row + 1, col];
                        newMaxSumMatrix[1, 1] = matrix[row + 1, col + 1];
                        newMaxSumMatrix[1, 2] = matrix[row + 1, col + 2];
                        newMaxSumMatrix[2, 0] = matrix[row + 2, col];
                        newMaxSumMatrix[2, 1] = matrix[row + 2, col + 1];
                        newMaxSumMatrix[2, 2] = matrix[row + 2, col + 2];
                    }
                }
            }

            Console.WriteLine("Sum = {0}", sumMax);
            PrinMatrix(newMaxSumMatrix);
        }

        static void ParseMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string inputMatrix = Console.ReadLine();
                string[] inputMatrixArr = inputMatrix.Split(' ');
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(inputMatrixArr[j]);
                }
            }
        }

        static void PrinMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 3}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
