using System.Collections.Generic;

namespace CalvertFormulaWorkSheet
{
   public class DoseModel
    {
       public DoseModel(List<AucModel> auc)
       {
           this.Auc = auc;
       }
       public GfrModel Gfr { get; set; }
       public List<AucModel> Auc { get; set; }
    }
}