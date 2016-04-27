using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SortedSubsetSums
{
    class SortedSubsetSums
    {
        static void Main()
        {
            int sum = int.Parse(Console.ReadLine());
            string[] inputString = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arrayNum = new int[inputString.Length];

            List<List<int>> subsList = new List<List<int>>(); 

            for (int i = 0; i < inputString.Length; i++)
            {
                arrayNum[i] = int.Parse(inputString[i]);
            }

            arrayNum = arrayNum.Distinct().ToArray();

            int numsOfSubset = 1 << arrayNum.Length;

            for (int i = 1; i < numsOfSubset; i++)
            {
                int pos = arrayNum.Length - 1;
                int bit = i;
                List<int> subs = new List<int>();

                while (bit > 0)
                {
                    if ((bit & 1) == 1)
                    {
                        subs.Add(arrayNum[pos]);
                    }

                    bit >>= 1;
                    pos--;
                }

                if (subs.Sum() == sum)
                {
                    subs.Sort();
                    subsList.Add(subs);
                }
            }

            if (subsList.Count != 0)
            {
                subsList
                    .OrderBy(p => p.Count)
                    .ThenBy(p => p.FirstOrDefault())
                    .ToList()
                    .ForEach(list => Console.WriteLine("{0} = {1}", string.Join(" + ", list), sum));
            }
            else
            {
                Console.WriteLine("No matching subsets.");
            }
        }
    }
}
