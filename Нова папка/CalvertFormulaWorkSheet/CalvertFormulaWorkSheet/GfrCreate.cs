using System.Collections.Generic;

namespace CalvertFormulaWorkSheet
{
    public class GfrCreate
    {
        public static Dictionary<string, double> Create(int age, double weight, string weightOrPound, bool isFemale, int serumCreatininie, List<AucModel> aucArr)
        {
            GfrModel gfr = new GfrModel();
            gfr.Age = age;
            gfr.Weight = weight;
            gfr.WeightOrPound = weightOrPound;
            gfr.IsFemale = isFemale;
            gfr.SerumCreatininie = serumCreatininie;
           
            DoseModel dose = new DoseModel(aucArr);
            dose.Gfr = gfr;
           

            double resultGfr = Calcilate(gfr.Age, gfr.Weight, gfr.WeightOrPound, gfr.IsFemale, gfr.SerumCreatininie);

            Dictionary<string, double> result = new Dictionary<string, double>();
            for (int i = 0; i < dose.Auc.Count; i++)
            {
                double res = (resultGfr + 25) * dose.Auc[i].Target;
                result[dose.Auc[i].Name] = res;
            }

            
            return result;
        }

        public static double Calcilate(int age, double weight, string weightOrPound, bool isFemale, int serumCreatinie)
        {
            double coefcFemale;
            if (isFemale)
            {
                coefcFemale = 0.85;
            }
            else
            {
                coefcFemale = 1d;
            }

            if (weightOrPound.Equals("pounds"))
            {
                weight = 0.45359237 * weight;
            }

            double gfrResult = ((140 - age) * weight * coefcFemale) / (72 * serumCreatinie);

            return gfrResult;
        }   
    }
}