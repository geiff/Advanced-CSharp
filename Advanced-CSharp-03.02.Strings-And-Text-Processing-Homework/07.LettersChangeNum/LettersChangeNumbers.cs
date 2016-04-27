using System;
using System.Linq;

namespace _07.LettersChangeNum
{
    class LettersChangeNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] arrStr = input.Split(new[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);
            decimal sum = 0;
            
            foreach (var str in arrStr)        /*decimal sum = arrStr.Sum(str => LettersChangeNum(str));*/
            {
                sum += LettersChangeNum(str);
            }

            Console.WriteLine("{0:F2}", sum);
        }

        static decimal LettersChangeNum(string str)
        {
            bool isFirstLetterBig = char.IsUpper(str, 0);
            bool isLastLetterBig = char.IsUpper(str, str.Length - 1);
            int num = int.Parse(str.Substring(1, str.Length - 2));
            decimal sum = 0;
            
            if (isFirstLetterBig)
            {
                decimal index = 1;
                for (char i = 'A'; i <= 'Z'; i++)
                {
                    if (str.FirstOrDefault() == i)
                    {
                        sum = num / index;
                        break;
                    }

                    index++;
                }
            }
            else
            {
                decimal index = 1;
                for (char i = 'a'; i <= 'z'; i++)
                {
                    if (str.FirstOrDefault() == i)
                    {
                        sum = num * index;
                        break;
                    }

                    index++;
                }
            }

            if (isLastLetterBig)
            {
                decimal index = 1;
                for (char i = 'A'; i <= 'Z'; i++)
                {
                    if (str.LastOrDefault() == i)
                    {
                        sum -=  index;
                        break;
                    }

                    index++;
                }
            }
            else
            {
                decimal index = 1;
                for (char i = 'a'; i <= 'z'; i++)
                {
                    if (str.LastOrDefault() == i)
                    {
                        sum += index;
                        break;
                    }

                    index++;
                }
            }

            return sum;
        }
    }
}
