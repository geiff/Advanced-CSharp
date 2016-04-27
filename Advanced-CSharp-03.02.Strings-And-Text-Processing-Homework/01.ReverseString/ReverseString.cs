using System;
using System.Linq;
using System.Text;

namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            Console.WriteLine("Enter string");
            string input = Console.ReadLine();
            Console.WriteLine("First variation on revers string: " + string.Join("", input.Reverse()));
            Console.Write("Second variation with String Builder on revers string: ");
            StringBuilderRevers(input);
        }

        static void StringBuilderRevers(string strInput)
        {
            StringBuilder revers = new StringBuilder();
            for (int index = strInput.Length - 1; index >= 0; index--)
            {
                revers.Append(strInput[index]);
            }

            Console.WriteLine(revers.ToString());
        }
    }
}
