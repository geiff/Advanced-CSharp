using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.StuckNumbers
{
    class StuckNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> listInput = new List<string>();
            listInput = Console.ReadLine().Split(' ').ToList();
            bool isHaveAddToList = false;
            List<string> listOut = new List<string>();

            for (int indexA = 0; indexA < n; indexA++)
            {
                for (int indexB = 0; indexB < n; indexB++)
                {
                    string strContactAB = string.Concat(listInput[indexA], listInput[indexB]);

                    for (int indexC = 0; indexC < n; indexC++)
                    {
                        for (int indexD = 0; indexD < n; indexD++)
                        {
                            string strContactCD = string.Concat(listInput[indexC], listInput[indexD]);
                            bool isEqual = listInput[indexA] != listInput[indexB] &&
                                           listInput[indexA] != listInput[indexC] && 
                                           listInput[indexA] != listInput[indexD] &&
                                           listInput[indexB] != listInput[indexC] &&
                                           listInput[indexB] != listInput[indexD] && 
                                           listInput[indexC] != listInput[indexD] &&
                                           strContactAB == strContactCD;

                            if (isEqual)
                            {
                                string strContactListOut = string.Concat(listInput[indexA], "|", listInput[indexB], "==", 
                                    listInput[indexC], "|", listInput[indexD]);
                                listOut.Add(strContactListOut);
                                isHaveAddToList = true;
                            }
                        }
                    }
                }
            }

            listOut.ForEach(Console.WriteLine);
            if (!isHaveAddToList)
            {
                Console.WriteLine("No");
            }
        }
    }
}
