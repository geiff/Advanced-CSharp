using System;
using System.Collections.Generic;

namespace _05.ReverseNumber
{
    class ReverseNumber
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine(GetRevursedNumber(number));
        }

        static double GetRevursedNumber(double number)
        {
            List<string> reversedNum = new List<string>();
            string num = number.ToString();

            for (int i = num.Length - 1; i >= 0; i--)
            {
                reversedNum.Add(num[i].ToString());
            }

            string newNum = string.Join("", reversedNum);
            double reversedNumbers = double.Parse(newNum);
            return reversedNumbers;
        }
    }
}
