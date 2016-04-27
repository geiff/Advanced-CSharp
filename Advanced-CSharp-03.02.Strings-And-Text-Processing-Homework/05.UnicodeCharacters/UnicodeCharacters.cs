using System;

namespace _05.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                string escape = "\\u" + ((int)ch).ToString("x").PadLeft(4, '0');
                Console.Write(escape);
            }

            Console.WriteLine();
        }
    }
}
