using System;
using System.Collections.Generic;

namespace _10.PlusRemove
{
    class PlusRemove
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Queue<string> inpuStr = new Queue<string>();
            int bestColLength = 0;

            while (input != "END")
            {
                inpuStr.Enqueue(input);
                if (input.Length > bestColLength)
                {
                    bestColLength = input.Length;
                }

                input = Console.ReadLine();
            }


            char[,] matrix = new char[inpuStr.Count, bestColLength];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string elemQue = inpuStr.Dequeue().PadRight(bestColLength, ' ');
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elemQue[col];
                }

            }

            HashSet<KeyValuePair<int, int>> listForRemove = new HashSet<KeyValuePair<int, int>>();
            for (int row = 1; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 1; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col].ToString().ToUpper() == matrix[row - 1, col].ToString().ToUpper() &&
                        matrix[row, col].ToString().ToUpper() == matrix[row, col - 1].ToString().ToUpper() &&
                        matrix[row, col].ToString().ToUpper() == matrix[row + 1, col].ToString().ToUpper() &&
                        matrix[row, col].ToString().ToUpper() == matrix[row, col + 1].ToString().ToUpper())
                    {
                        listForRemove.Add(new KeyValuePair<int, int>(row, col));
                        listForRemove.Add(new KeyValuePair<int, int>(row - 1, col));
                        listForRemove.Add(new KeyValuePair<int, int>(row, col - 1));
                        listForRemove.Add(new KeyValuePair<int, int>(row + 1, col));
                        listForRemove.Add(new KeyValuePair<int, int>(row, col + 1));
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    KeyValuePair<int, int> isCharForRemove = new KeyValuePair<int, int>(row, col);

                    if (!listForRemove.Contains(isCharForRemove))
                    {
                        Console.Write(matrix[row, col]);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}