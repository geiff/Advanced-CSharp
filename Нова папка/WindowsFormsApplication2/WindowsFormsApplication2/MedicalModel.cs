using System.Collections.Generic;

namespace WindowsFormsApplication2
{
    public class MedicalModel
    {
        public MedicalModel(string name, List<int> days)
        {
            this.Name = name;
            this.Days = days;
        }
        public string Name { get; set; }
        public List<int> Days { get; set; }
    }
}