using System;
using System.Collections.Generic;
using System.Linq;

namespace _17.OfficeStuff
{
    class OfficeStuff
    {
        static void Main()
        {
            int numberRow = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<int>>> officeStuff = new Dictionary<string, Dictionary<string, List<int>>>();
            for (int i = 0; i < numberRow; i++)
            {
                string[] inputStr = Console.ReadLine().Split(new char[] { '|', ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
                string company = inputStr[0];
                int amount = int.Parse(inputStr[1]);
                string product = inputStr[2];

                if (!officeStuff.ContainsKey(company))
                {
                    officeStuff.Add(company, new Dictionary<string, List<int>>());
                }

                if (!officeStuff[company].ContainsKey(product))
                {
                    officeStuff[company].Add(product, new List<int>());
                }

                officeStuff[company][product].Add(amount);
            }

            var officeStuffSort = officeStuff.OrderBy(x => x.Key);
            foreach (var compan in officeStuffSort)
            {
                Console.Write("{0}: ", compan.Key);

                Console.WriteLine(string.Join(", ", compan.Value.Select(produc => produc.Key + "-" + produc.Value.Sum())));
            }
        }
    }
}