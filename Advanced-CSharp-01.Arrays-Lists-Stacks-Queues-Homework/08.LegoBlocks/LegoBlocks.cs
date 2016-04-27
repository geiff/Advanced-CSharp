using System;
using System.Linq;

namespace _08.LegoBlocks
{
    class LegoBlocks
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[][] juggetOne = new int[n][];
            int[][] juggetTwo = new int[n][];

            for (int i = 0; i < juggetOne.GetLength(0); i++)
            {
                string[] inputNumber = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                juggetOne[i] = new int[inputNumber.Length];

                for (int j = 0; j < inputNumber.Length; j++)
                {
                    juggetOne[i][j] = int.Parse(inputNumber[j]);
                }
            }

            for (int i = 0; i < juggetTwo.GetLength(0); i++)
            {
                string[] inputNumber = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                juggetTwo[i] = new int[inputNumber.Length];

                for (int j = 0; j < inputNumber.Length; j++)
                {
                    juggetTwo[i][j] = int.Parse(inputNumber[j]);
                }
            }

            for (int i = 0; i < juggetTwo.GetLength(0); i++)
            {
                juggetTwo[i] = juggetTwo[i].Reverse().ToArray();
            }

            int[][] matchedArr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matchedArr[i] = juggetOne[i].Concat(juggetTwo[i]).ToArray();
            }

            int index = 0;
            bool isEqual = true;
            while (index < matchedArr.GetLength(0) - 1)
            {
                if (matchedArr[index].Length == matchedArr[index + 1].Length)
                {
                    index++;
                }
                else
                {
                    isEqual = false;
                    index++;
                }
            }

            if (isEqual)
            {
                for (int i = 0; i < matchedArr.GetLength(0); i++)
                {
                    Console.WriteLine("[{0}]", string.Join(", ", matchedArr[i]));
                }
            }
            else
            {
                int sum = 0;
                for (int m = 0; m < matchedArr.GetLength(0); m++)
                {
                    sum += matchedArr[m].Count();
                }

                Console.WriteLine("The total number of cells is: {0}", sum);
            }
        }
    }
}
