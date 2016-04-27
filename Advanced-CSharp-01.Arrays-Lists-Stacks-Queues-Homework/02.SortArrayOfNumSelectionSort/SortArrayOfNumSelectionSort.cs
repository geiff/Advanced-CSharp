using System;

namespace _02.SortArrayOfNumSelectionSort
{
    class SortArrayOfNumSelectionSort
    {
        static void Main()
        {
            string inputStirng = Console.ReadLine();
            string[] inputArrayString = inputStirng.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[inputArrayString.Length];

            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = int.Parse(inputArrayString[index]);
            }

            for (int indexCurrent = 0; indexCurrent < numbers.Length - 1; indexCurrent++)
            {
                for (int indexNext = indexCurrent + 1; indexNext < numbers.Length; indexNext++)
                {
                    if (numbers[indexCurrent] > numbers[indexNext])
                    {
                        int old = numbers[indexCurrent];
                        numbers[indexCurrent] = numbers[indexNext];
                        numbers[indexNext] = old;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
