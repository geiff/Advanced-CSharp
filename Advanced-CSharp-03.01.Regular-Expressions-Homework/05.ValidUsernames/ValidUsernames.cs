using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _05.ValidUsernames
{
    class ValidUsernames
    {
        static void Main()
        {
            string inpuText = Console.ReadLine();

            string patern = @"\b[a-zA-Z]\w{2,24}\b";
            Regex regex = new Regex(patern);
            var matches = regex.Matches(inpuText);

            List<string> result = new List<string>();      //LINQ
                                            //List<string> result = (from Match match in matches select match.ToString()).ToList();
            foreach (Match match in matches)
            {
                result.Add(match.ToString());
            }

            int maxSum = int.MinValue;
            string firsElement = null;
            string secondElement = null;

            for (int i = 0; i < result.Count - 1; i++)
            {
                if (result[i].Length + result[i + 1].Length > maxSum)
                {
                    maxSum = result[i].Length + result[i + 1].Length;
                    firsElement = result[i];
                    secondElement = result[i + 1];
                }
            }

            Console.WriteLine(firsElement);
            Console.WriteLine(secondElement);
        }
    }
}