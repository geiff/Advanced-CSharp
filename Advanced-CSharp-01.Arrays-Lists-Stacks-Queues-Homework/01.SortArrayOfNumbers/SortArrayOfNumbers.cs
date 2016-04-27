using System;

namespace _01.SortArrayOfNumbers
{
    class SortArrayOfNumbers
    {
        static void Main()
        {
            string inputNumbers = Console.ReadLine();
            string[] arrayInputStringNumbers = inputNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[arrayInputStringNumbers.Length];

            for (int index = 0; index < arrayInputStringNumbers.Length; index++)
            {
                numbers[index] = int.Parse(arrayInputStringNumbers[index]);
            }

            bool swap = true;
            while (swap)
            {
                swap = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int old = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = old;
                        swap = true;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
