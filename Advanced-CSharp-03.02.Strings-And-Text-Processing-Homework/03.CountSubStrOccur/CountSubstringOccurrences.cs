using System;

namespace _03.CountSubStrOccur
{
    class CountSubstringOccurrences
    {
        static void Main()
        {
            string inputString = Console.ReadLine().ToLower();
            string subString = Console.ReadLine().ToLower();

            int count = 0;
            int index = 0;

            while (index < inputString.Length)
            {
                int indexResulatat = inputString.IndexOf(subString, index);
                if (indexResulatat >= 0)
                {
                    count++;
                    index = indexResulatat + 1;
                }
                else
                {
                    index = inputString.Length;
                }
            }

            Console.WriteLine(count);
        }
    }
}