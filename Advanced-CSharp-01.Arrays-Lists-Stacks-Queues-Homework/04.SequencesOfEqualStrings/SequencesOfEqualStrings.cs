using System;
using System.Collections.Generic;

namespace _04.SequencesOfEqualStrings
{
    class SequencesOfEqualStrings
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<string> inputList = new List<string>(input.Split(' '));
            List<string> newlist = new List<string>();
            int count = 0;

            for (int i = 0; i < inputList.Count; i++)
            {
                for (int j = i + 1; j < inputList.Count; j++)
                {
                    if (inputList[i] == inputList[j])
                    {
                        count++;
                        if (newlist.Count == 0)
                        {
                            newlist.Add(inputList[i]);
                        }

                        newlist.Add(inputList[j]);
                        inputList.RemoveAt(j);
                        j--;
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine(inputList[i]);
                }

                if (newlist.Count != 0)
                {
                    Console.WriteLine(string.Join(" ", newlist));
                }

                count = 0;
                newlist.RemoveRange(0, newlist.Count);
            }
        }
    }
}
