using System;

namespace _09.TerroristsWin
{
    class TerroristsWin
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int starIndex = input.IndexOf('|');
            int endIndex = input.IndexOf('|', starIndex + 1);

            while (starIndex >= 0)
            {
                int sum = 0;
                for (int j = starIndex + 1; j <= endIndex - 1; j++)
                {
                    sum += input[j];
                }

                int n = sum % 10;
                input = input.Remove(starIndex, endIndex + 1 - starIndex);
                input = input.Insert(starIndex, new string('.', endIndex + 1 - starIndex));

                if (starIndex - n >= 0)
                {
                    input = input.Remove(starIndex - n, n);
                    input = input.Insert(starIndex - n, new string('.', n));
                }

                if (endIndex + 1 + n < input.Length)
                {
                    input = input.Remove(endIndex + 1, n);
                    input = input.Insert(endIndex + 1, new string('.', n));
                }

                starIndex = input.IndexOf('|', endIndex + 1);
                endIndex = input.IndexOf('|', starIndex + 1);
            }

            Console.WriteLine(input);
        }
    }
}