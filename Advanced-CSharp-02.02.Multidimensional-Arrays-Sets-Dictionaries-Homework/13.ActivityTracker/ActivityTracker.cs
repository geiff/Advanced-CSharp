using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.ActivityTracker
{
    class ActivityTracker
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, Dictionary<string, List<int>>> activityTracker = 
                new Dictionary<int, Dictionary<string, List<int>>>();

            for (int i = 0; i < n; i++)
            {
                string inputStr = Console.ReadLine();
                string[] inputStrSplit = inputStr.Split(' ');
                string[] date = inputStrSplit[0].Split('/');

                int month = int.Parse(date[1]);
                string user = inputStrSplit[1];
                int distance = int.Parse(inputStrSplit[2]);

                if (!activityTracker.ContainsKey(month))
                {
                    activityTracker.Add(month, new Dictionary<string, List<int>>());
                }

                if (!activityTracker[month].ContainsKey(user))
                {
                    activityTracker[month].Add(user, new List<int>());
                }

                activityTracker[month][user].Add(distance);
            }

            var activityTrackerSort = activityTracker.OrderBy(x => x.Key);
            foreach (var months in activityTrackerSort)
            {
                Console.Write("{0}: ", months.Key);

                var userDistanceSort = months.Value.OrderBy(x => x.Key);
                Console.WriteLine(string.Join(", ", userDistanceSort.Select(x => x.Key + "(" + x.Value.Sum() + ")")));
            }
        }
    }
}