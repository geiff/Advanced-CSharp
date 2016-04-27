using System;

namespace _01.BiggerNumber
{
    class BiggerNumber
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int maxNumber = GetMax(firstNumber, secondNumber);
            Console.WriteLine(maxNumber);
        }

        static int GetMax(int numberOne, int  numberTwo)
        {
            if (numberOne > numberTwo)
            {
                return numberOne;
            }

            return numberTwo;
        }
    }
}
