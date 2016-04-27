using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.NightLife
{
    class NightLife
    {
        static void Main()
        {
            string inputInformation = Console.ReadLine();
            Dictionary<string, Dictionary<string, List<string>>> nightLife =
                new Dictionary<string, Dictionary<string, List<string>>>();

            while (inputInformation != "END")
            {
                string[] inputSplit = inputInformation.Split(';');
                string city = inputSplit[0];
                string venue = inputSplit[1];
                string performer = inputSplit[2];

                if (!nightLife.ContainsKey(city))
                {
                    nightLife.Add(city, new Dictionary<string, List<string>>());
                }

                if (!nightLife[city].ContainsKey(venue))
                {
                    nightLife[city].Add(venue, new List<string>());
                }

                nightLife[city][venue].Add(performer);

                inputInformation = Console.ReadLine();
            }

            foreach (var elem in nightLife)
            {
                Console.WriteLine("{0}", elem.Key);
                var elems = elem.Value.OrderBy(x => x.Key);
                foreach (var l in elems)
                {
                    Console.WriteLine("->{0}: {1}", l.Key, string.Join(", ", l.Value.Distinct().OrderBy(x => x)));
                }
            }
        }
    }
}
