using System;

namespace _02.StringLength
{
    class StringLength
    {
        static void Main()
        {
            Console.WriteLine("Enter string");
            string input = Console.ReadLine();

            if (input.Length < 20)
            {
                Console.WriteLine(string.Concat(input, new string('*', 20 - input.Length)));
            }
            else
            {
                Console.WriteLine(input.Substring(0, 20));
            }
        }
    }
}
