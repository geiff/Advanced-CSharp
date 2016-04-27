using System;
using System.Collections.Generic;

namespace _11.StringMatrixRotation
{
    class StringMatrixRotation
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputStrSplit = input.Split(new[] { "(", ")" }, StringSplitOptions.RemoveEmptyEntries);

            int rotation = int.Parse(inputStrSplit[1]);
            input = Console.ReadLine();

            Queue<string> inputQueue = new Queue<string>();
            int bestColLength = 0;

            while (input != "END")
            {
                inputQueue.Enqueue(input);   
                if (input.Length > bestColLength) 
                {
                    bestColLength = input.Length;
                }

                input = Console.ReadLine();
            }

            char[,] matrix = new char[inputQueue.Count, bestColLength];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string elemQue = inputQueue.Dequeue().PadRight(bestColLength, ' ');

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elemQue[col];
                }
            }


            int factorForQuadrant = rotation / 360;
            int quadrant = (rotation - factorForQuadrant * 360) / 90;

            if (quadrant == 1)
            {
                for (int row = 0; row < matrix.GetLength(1); row++) 
                {
                    for (int col = matrix.GetLength(0) - 1; col >= 0; col--)
                    {
                        Console.Write("{0}", matrix[col, row]);
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }

            if (quadrant == 2)
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--) 
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        Console.Write("{0}", matrix[row, col]);
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }

            if (quadrant == 3)
            {
                for (int row = matrix.GetLength(1) - 1; row >= 0; row--) 
                {
                    for (int col = 0; col < matrix.GetLength(0); col++)
                    {
                        Console.Write("{0}", matrix[col, row]);
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }

            if (quadrant == 0 || quadrant == 4)
            {
                for (int row = 0; row < matrix.GetLength(0); row++) 
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write("{0}", matrix[row, col]);
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }
}