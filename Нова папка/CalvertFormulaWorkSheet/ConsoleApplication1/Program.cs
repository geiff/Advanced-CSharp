using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalvertFormulaWorkSheet;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            string weightOrPound = Console.ReadLine();
            bool isFemale = bool.Parse(Console.ReadLine());
            int serumCreatininie = int.Parse(Console.ReadLine());
            List<AucModel> auc = new List<AucModel>();

            for (int i = 0; i < 3; i++)
            {
                auc.Add(new AucModel(Console.ReadLine(), int.Parse(Console.ReadLine())));
            }


            Dictionary<string, double> str = GfrCreate.Create(age, weight, weightOrPound, isFemale, serumCreatininie, auc);

            foreach (var s in str.OrderBy(x => x.Value))
            {
                Console.WriteLine("{0} {1:f2}", s.Key, s.Value);
            }

        }
    }
}
