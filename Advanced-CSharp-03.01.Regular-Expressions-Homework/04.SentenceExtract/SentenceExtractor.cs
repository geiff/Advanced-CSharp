using System;
using System.Text.RegularExpressions;

namespace _04.SentenceExtract
{
    class SentenceExtractor
    {
        static void Main()
        {
            string str = Console.ReadLine();
            string text = Console.ReadLine();
            string patern = string.Format(@"(?<=\s |^)[^!.?]*\b{0}\b[^ !.?]*[!.?]", str);
            //[A-Z][\w\s\b{0}\b\s\w+]+?(?=\!|\.|\?)(\.|\?|!)
            MatchCollection matches = Regex.Matches(text, patern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
