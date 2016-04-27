using System;
using System.Collections.Generic;

namespace _06.CountSymbols
{
    class CountSymbols
    {
        static void Main()
        {
            string inputStr = Console.ReadLine();
            SortedSet<char> alphabeticals = new SortedSet<char>();

            for (int index = 0; index < inputStr.Length; index++)
            {
                alphabeticals.Add(inputStr[index]);
            }

            int count = 0;
            foreach (var alpha in alphabeticals)
            {
                for (int i = 0; i < inputStr.Length; i++)
                {
                    if (alpha == inputStr[i])
                    {
                        count++;
                    }
                }

                Console.WriteLine("{0}: {1} time/s", alpha, count);
                count = 0;
            }
        }
    }
}
