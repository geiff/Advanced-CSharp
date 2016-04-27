using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Palindromes
{
    class Palindromes
    {
        static void Main()
        {
            char[] symbols = { ',', '?', '!', '.', ' ' };
            List<string> words =
                Console.ReadLine().Split(symbols, StringSplitOptions.RemoveEmptyEntries).Select(p => p).ToList();
            SortedSet<string> result = new SortedSet<string>();

            foreach (var word in words)
            {
                if (IsPalindroms(word))
                {
                    result.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }

        static bool IsPalindroms(string word)
        {
            int lenghtSubstring = word.Length / 2;
            string firstSubstring = word.Substring(0, lenghtSubstring);
            string secondSubstring = null;

            if (word.Length % 2 == 0)
            {
                secondSubstring = word.Substring(lenghtSubstring, lenghtSubstring);
            }
            else
            {
                secondSubstring = word.Substring(lenghtSubstring + 1, lenghtSubstring);
            }

            if (firstSubstring.Equals(string.Join("", secondSubstring.Reverse())))
            {
                return true;
            }

            return false;
        }
    }
}
