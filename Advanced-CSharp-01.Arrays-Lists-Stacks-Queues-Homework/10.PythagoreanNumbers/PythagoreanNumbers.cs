using System;

namespace _10.PythagoreanNumbers
{
    class PythagoreanNumbers
    {
        static void Main()
        {
            int numberCount = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = new int[numberCount];
            bool isEqual = false;

            for (int index = 0; index < numberCount; index++)
            {
                arrayOfNumbers[index] = int.Parse(Console.ReadLine());
            }

            for (int indexA = 0; indexA < arrayOfNumbers.Length; indexA++)
            {
                for (int indexB = 0; indexB < arrayOfNumbers.Length; indexB++)
                {
                    for (int indexSum = 0; indexSum < arrayOfNumbers.Length; indexSum++)
                    {
                        int numberA = arrayOfNumbers[indexA];
                        int numberB = arrayOfNumbers[indexB];
                        int numberSum = arrayOfNumbers[indexSum];

                        if (numberA <= numberB && Math.Pow(numberA, 2) + Math.Pow(numberB, 2) == Math.Pow(numberSum, 2))
                        {
                            Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", numberA, numberB, numberSum);
                            isEqual = true;
                        }
                    }
                }
            }

            if (!isEqual)
            {
                Console.WriteLine("No");
            }
        }
    }
}
