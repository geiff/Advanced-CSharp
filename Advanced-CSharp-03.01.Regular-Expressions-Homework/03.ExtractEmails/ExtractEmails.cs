using System;
using System.Text.RegularExpressions;

namespace _03.ExtractEmails
{
    class ExtractEmails
    {
        static void Main()
        {
            var text = Console.ReadLine();

            var pattern = @"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@[a-z]+\-?[a-z]+(?:\.[a-z]+)+)\b";
            var mathces = Regex.Matches(text, pattern);
            Console.WriteLine("Valid emails are:");
            foreach (var match in mathces)
            {
                Console.WriteLine(match);
            }
        }
    }
}
