namespace CalvertFormulaWorkSheet
{
   public class AucModel
    {
       public AucModel(string name, int target)
       {
           this.Name = name;
           this.Target = target;
       }
       public string Name { get; set; }
       public int Target { get; set; }
    }
}