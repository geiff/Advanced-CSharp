using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.NumbersFindMinMaxAverage
{
    class NumbersFindMinMaxAverage
    {
        static void Main()
        {
            string inputString = Console.ReadLine();
            string[] inputArrayString = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            decimal[] numbers = new decimal[inputArrayString.Length];
            List<decimal> floatPointNumbers = new List<decimal>() { };
            List<decimal> integerNumbers = new List<decimal>() { };

            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = decimal.Parse(inputArrayString[index]);
                if (numbers[index] % 1 != 0)
                {
                    floatPointNumbers.Add(numbers[index]);
                }
                else
                {
                    integerNumbers.Add(numbers[index]);
                }
            }


            Console.WriteLine("[{0}] -> min: {1:F2}, max: {2:F2}, sum: {3:F2}, avg: {4:F2}", 
                string.Join(", ", floatPointNumbers), floatPointNumbers.Min(), floatPointNumbers.Max(),
                           floatPointNumbers.Sum(), floatPointNumbers.Average());

            Console.WriteLine("[{0}] -> min: {1:F2}, max: {2:F2}, sum: {3:F2}, avg: {4:F2}",
                string.Join(", ", integerNumbers), integerNumbers.Min(), integerNumbers.Max(),
                           integerNumbers.Sum(), integerNumbers.Average());
        }
    }
}
