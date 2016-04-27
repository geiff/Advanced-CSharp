using System;
using System.Text.RegularExpressions;

namespace _01.SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                string regexString = string.Format("{0}*[?={0}]", text[i]);
                Regex reg = new Regex(regexString);
                text = reg.Replace(text, text[i].ToString());
            }

            Console.WriteLine(text);
        }
    }
}