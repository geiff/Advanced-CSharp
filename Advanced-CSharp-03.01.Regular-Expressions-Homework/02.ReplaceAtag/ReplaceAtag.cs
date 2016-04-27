using System;
using System.Text.RegularExpressions;

namespace _02.ReplaceAtag
{
    class ReplaceAtag
    {
        static void Main()
        {
            string textInput = Console.ReadLine();
            string text = null;
            while (!string.IsNullOrEmpty(textInput))
            {
                text += textInput + "\n";
                textInput = Console.ReadLine();
            }

            string pattern = @"<\s*a\s[^>]*?\bhref\s*=\s*('[^']*'|""[^""]*""|\S*)[^>]*>((.|\s)*?)<\s*\/a\s*>";
            Regex regex = new Regex(pattern);
            string replace = @"[URL href=$1]$2[/URL]";
            text = regex.Replace(text, replace);
           
            Console.WriteLine(text);
        }
    }
}
