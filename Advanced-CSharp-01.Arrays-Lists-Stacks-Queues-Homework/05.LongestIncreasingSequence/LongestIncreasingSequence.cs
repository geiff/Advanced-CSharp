using System;
using System.Collections.Generic;

namespace _05.LongestIncreasingSequence
{
    class LongestIncreasingSequence
    {
        static void Main()
        {
            string inputString = Console.ReadLine();
            string[] inputArrayString = inputString.Split(' ');
            int[] numbers = new int[inputArrayString.Length];

            for (int i = 0; i < inputArrayString.Length; i++)
            {
                numbers[i] = int.Parse(inputArrayString[i]);
            }

            List<int> listMax = new List<int>();
            List<int> listCurent = new List<int>();
            int index = 0;
            listCurent.Add(numbers[index]);

            while (index <= numbers.Length - 1)
            {
                if (index != numbers.Length - 1 && numbers[index] < numbers[index + 1])
                {
                    listCurent.Add(numbers[index + 1]);
                    index++;
                }
                else
                {
                    if (listCurent.Count >= listMax.Count)
                    {
                        if (listCurent.Count == listMax.Count)
                        {
                            int sumCurent = 0;
                            int sumMax = 0;

                            for (int i = 0; i < listCurent.Count; i++)
                            {
                                sumCurent += listCurent[i];
                            }

                            for (int j = 0; j < listMax.Count; j++)
                            {
                                sumMax += listMax[j];
                            }

                            if (sumCurent > sumMax)
                            {
                                listMax.Clear();
                                for (int i = 0; i < listCurent.Count; i++)
                                {
                                    listMax.Add(listCurent[i]);
                                }
                            }
                        }
                        else
                        {
                            listMax.Clear();
                            for (int i = 0; i < listCurent.Count; i++)
                            {
                                listMax.Add(listCurent[i]);
                            }
                        }
                    }

                    listCurent.ForEach(i => Console.Write(i + " "));
                    Console.WriteLine();
                    listCurent.Clear();

                    if (index + 1 < numbers.Length)
                    {
                        listCurent.Add(numbers[index + 1]);
                    }

                    index++;
                }
            }

            Console.Write("Longest: ");
            listMax.ForEach(i => Console.Write(i + " "));
            Console.WriteLine();
        }
    }
}
