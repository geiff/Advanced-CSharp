using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SequenceInMatrix
{
    class SequenceInMatrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, m];

            ReadMatrix(matrix, n, m);
            PrintMatrix(matrix);

            int maxCount = 0;
            List<string> maxReapeadWord = new List<string>();
            string wordRepead = null;

            for (int row = 0; row < matrix.GetLength(0); row++) 
            {
                bool isEqual = false;
                int col = 0;
                int countLengthRight = 1;
                while (col < matrix.GetLength(1) - 1)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        isEqual = true;
                        wordRepead = matrix[row, col];
                        countLengthRight++;
                    }

                    if (isEqual)
                    {
                        if (countLengthRight >= maxCount)
                        {
                            if (countLengthRight == maxCount)
                            {
                                maxCount = countLengthRight;
                                maxReapeadWord.Add(wordRepead);
                            }
                            else
                            {
                                maxCount = countLengthRight;
                                maxReapeadWord.Clear();
                                maxReapeadWord.Add(wordRepead);
                            }
                        }
                    }

                    col++;
                }
            }

            for (int row = 0; row < n; row++) 
            {                                 
                int colDiagonal = 0;
                bool isEqualDiagonal = false;
                int countLengthDiagonal = 1;
                int rowDiagonal = row;
                while (rowDiagonal < matrix.GetLength(0) - 1 && colDiagonal < matrix.GetLength(1) - 1)
                {
                    if (matrix[rowDiagonal, colDiagonal] == matrix[rowDiagonal + 1, colDiagonal + 1])
                    {
                        isEqualDiagonal = true;
                        wordRepead = matrix[rowDiagonal, colDiagonal];
                        countLengthDiagonal++;
                    }

                    if (isEqualDiagonal)
                    {
                        if (countLengthDiagonal >= maxCount)
                        {
                            if (countLengthDiagonal == maxCount)
                            {
                                maxCount = countLengthDiagonal;
                                maxReapeadWord.Add(wordRepead);
                            }
                            else
                            {
                                maxCount = countLengthDiagonal;
                                maxReapeadWord.Clear();
                                maxReapeadWord.Add(wordRepead);
                            }
                        }
                    }

                    rowDiagonal++;
                    colDiagonal++;
                }
            }

            for (int col = 1; col < n; col++)   
            {                                   
                int rowDiagonal = 0;
                bool isEqualDiagonal = false;
                int countLengthDiagonal = 1;
                int colDiagonal = col;
                while (rowDiagonal < matrix.GetLength(0) - 1 && colDiagonal < matrix.GetLength(1) - 1)
                {
                    if (matrix[rowDiagonal, colDiagonal] == matrix[rowDiagonal + 1, colDiagonal + 1])
                    {
                        isEqualDiagonal = true;
                        wordRepead = matrix[rowDiagonal, colDiagonal];
                        countLengthDiagonal++;
                    }

                    if (isEqualDiagonal)
                    {
                        if (countLengthDiagonal >= maxCount)
                        {
                            if (countLengthDiagonal == maxCount)
                            {
                                maxCount = countLengthDiagonal;
                                maxReapeadWord.Add(wordRepead);
                            }
                            else
                            {
                                maxCount = countLengthDiagonal;
                                maxReapeadWord.Clear();
                                maxReapeadWord.Add(wordRepead);
                            }
                        }
                    }

                    rowDiagonal++;
                    colDiagonal++;
                }

            }


            for (int col = 0; col < matrix.GetLength(1); col++) 
            {
                bool isEqual = false;
                int row = 0;
                int countLengthDown = 1;
                while (row < matrix.GetLength(0) - 1)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        isEqual = true;
                        wordRepead = matrix[row, col];
                        countLengthDown++;
                    }

                    if (isEqual)
                    {
                        if (countLengthDown >= maxCount)
                        {
                            if (countLengthDown == maxCount)
                            {
                                maxCount = countLengthDown;
                                maxReapeadWord.Add(wordRepead);
                            }
                            else
                            {
                                maxCount = countLengthDown;
                                maxReapeadWord.Clear();
                                maxReapeadWord.Add(wordRepead);
                            }
                        }
                    }

                    row++;
                }
            }

            for (int row = 0; row < n; row++)  
            {                                  
                int colDiagonal = matrix.GetLength(1) - 1;
                bool isEqualDiagonal = false;
                int countLengthDiagonal = 1;
                int rowDiagonal = row;
                while (rowDiagonal < matrix.GetLength(0) - 1 && colDiagonal >= 0)
                {
                    if (matrix[rowDiagonal, colDiagonal] == matrix[rowDiagonal + 1, colDiagonal - 1])
                    {
                        isEqualDiagonal = true;
                        wordRepead = matrix[rowDiagonal, colDiagonal];
                        countLengthDiagonal++;
                    }

                    if (isEqualDiagonal)
                    {
                        if (countLengthDiagonal >= maxCount)
                        {
                            if (countLengthDiagonal == maxCount)
                            {
                                maxCount = countLengthDiagonal;
                                maxReapeadWord.Add(wordRepead);
                            }
                            else
                            {
                                maxCount = countLengthDiagonal;
                                maxReapeadWord.Clear();
                                maxReapeadWord.Add(wordRepead);
                            }
                        }
                    }

                    rowDiagonal++;
                    colDiagonal--;
                }
            }

            for (int col = matrix.GetLength(1) - 2; col >= 0; col--)
            {                                                  
                int rowDiagonal = 0;                           
                bool isEqualDiagonal = false;
                int countLengthDiagonal = 1;
                int colDiagonal = col;
                while (rowDiagonal < matrix.GetLength(0) - 1 && colDiagonal > 0)
                {
                    if (matrix[rowDiagonal, colDiagonal] == matrix[rowDiagonal + 1, colDiagonal - 1])
                    {
                        isEqualDiagonal = true;
                        wordRepead = matrix[rowDiagonal, colDiagonal];
                        countLengthDiagonal++;
                    }

                    if (isEqualDiagonal)
                    {
                        if (countLengthDiagonal >= maxCount)
                        {
                            if (countLengthDiagonal == maxCount)
                            {
                                maxCount = countLengthDiagonal;
                                maxReapeadWord.Add(wordRepead);
                            }
                            else
                            {
                                maxCount = countLengthDiagonal;
                                maxReapeadWord.Clear();
                                maxReapeadWord.Add(wordRepead);
                            }
                        }
                    }

                    rowDiagonal++;
                    colDiagonal--;
                }
            }

            maxReapeadWord = maxReapeadWord.Distinct().ToList();
            Console.WriteLine();
            Console.WriteLine("The longest sequence of equal strings in the matrix is ");
            if (maxReapeadWord.Count > 0)
            {
                for (int i = 0; i < maxReapeadWord.Count; i++)
                {
                    for (int j = 0; j < maxCount; j++)
                    {
                        Console.Write("{0} ", maxReapeadWord[i]);
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No repead!");
            }
        }

        static string[,] ReadMatrix(string[,] matrix, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }

                Console.WriteLine();
            }

            return matrix;
        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int indexRow = 0; indexRow < matrix.GetLength(0); indexRow++)
            {
                for (int indexCol = 0; indexCol < matrix.GetLength(1); indexCol++)
                {
                    Console.Write("{0, 3}", matrix[indexRow, indexCol]);
                }

                Console.WriteLine();
            }
        }
    }
}
