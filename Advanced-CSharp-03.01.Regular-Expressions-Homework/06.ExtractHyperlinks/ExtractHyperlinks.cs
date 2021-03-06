﻿using System;
using System.Text.RegularExpressions;

namespace _06_ExtractHyperlinks
{  
    class ExtractHyperlinks
    {
        static void Main()
        {                                                        //мой вариант
            string textInput = Console.ReadLine();
            string text = null;
            while (textInput != "END")
            {
                text += textInput + "\n";
                textInput = Console.ReadLine();
            }

            string pattern = @"<\s*a\s[^>]*?\bhref\s*=\s*('[^']*'|""[^""]*""|\S*)(.|\s)*?[>|'|""|\s*|<]\b";

            Regex regex = new Regex(pattern);
            var matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                string paternHtt = @"(?<=""|'|\b).+(?=""|'|""|\b)";
                Regex reg = new Regex(paternHtt);
                var mat = reg.Match(match.Groups[1].ToString());
                Console.WriteLine(mat);
            }
        }
    }
}

//На друг вариант
//using System;
//using System.Text;
//using System.Text.RegularExpressions;

//class ExtractHyperlinks
//{
//    static void Main(string[] args)
//    {
//        string inputLine;
//        StringBuilder sb = new StringBuilder();
//        while (!((inputLine = Console.ReadLine()) == "END"))
//        {
//            sb.Append(inputLine);
//        }
//        string text = sb.ToString();
//        //     Nakov   @"<\s*a\s[^>]*?\bhref\s*=\s*('(?<url>[^']*)'|""(?<url>[^""]*)""|(?<url>\S*))[^>]*>(?<linktext>(.|\s)*?)<\s*/a\s*>";
//        //     Innos   @"(?<=<a\s+(?:[^>]+\s+)?href\s*=\s*)(?:""([^""]*)""|'([^']*)'|([^\s>]+))(?=[^>]*>)";
//        string pattern = @"<a\s+(?:[^>]+\s+)?href\s*=\s*(?:'(?<url>[^']*)'|""(?<url>[^""]*)""|(?<url>[^\s>]+))[^>]*>";
//        Regex users = new Regex(pattern);
//        MatchCollection matches = users.Matches(text);
//        //Console.WriteLine("Found {0} matches", matches.Count);
//        foreach (Match hyperlink in matches)
//        {
//            Console.WriteLine(hyperlink.Groups["url"]);
//        }
//    }
//}