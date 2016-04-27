using System;

namespace _12.ToTheStars
{
    class ToTheStars
    {
        static void Main()
        {
            string[] inputString = Console.ReadLine().Split(' ');
            string planetNameOne = inputString[0];
            double planetXOne = double.Parse(inputString[1]);
            double planetYOne = double.Parse(inputString[2]);

            inputString = Console.ReadLine().Split(' ');
            string planetNameTwo = inputString[0];
            double planetXTwo = double.Parse(inputString[1]);
            double planetYTwo = double.Parse(inputString[2]);

            inputString = Console.ReadLine().Split(' ');
            string planetNameThree = inputString[0];
            double planetXThree = double.Parse(inputString[1]);
            double planetYThree = double.Parse(inputString[2]);

            inputString = Console.ReadLine().Split(' ');
            double normandyX = double.Parse(inputString[0]);
            double normandyY = double.Parse(inputString[1]);

            inputString = Console.ReadLine().Split(' ');
            int stepForNormandy = int.Parse(inputString[0]);

            for (int i = 0; i <= stepForNormandy; i++)
            {
                bool isSpace = true;
                if (normandyX >= planetXOne - 1 && normandyX <= planetXOne + 1 &&
                    normandyY >= planetYOne - 1 && normandyY <= planetYOne + 1)
                {
                    isSpace = false;
                    Console.WriteLine(planetNameOne.ToLower());
                }

                if (normandyX >= planetXTwo - 1 && normandyX <= planetXTwo + 1 &&
                    normandyY >= planetYTwo - 1 && normandyY <= planetYTwo + 1)
                {
                    isSpace = false;
                    Console.WriteLine(planetNameTwo.ToLower());
                }

                if (normandyX >= planetXThree - 1 && normandyX <= planetXThree + 1 &&
                    normandyY >= planetYThree - 1 && normandyY <= planetYThree + 1)
                {
                    isSpace = false;
                    Console.WriteLine(planetNameThree.ToLower());
                }

                if (isSpace)
                {
                    Console.WriteLine("space");
                }

                normandyY += 1;
            }
        }
    }
}