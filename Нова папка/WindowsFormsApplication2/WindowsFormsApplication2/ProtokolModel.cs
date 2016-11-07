using System.Collections.Generic;

namespace WindowsFormsApplication2
{
    public class ProtokolModel
    {
        public ProtokolModel(int circle, List<MedicalModel> medical)
        {
            this.Circle = circle;
            this.Medicals = medical;
        }
        public int Circle { get; set; }
        public List<MedicalModel> Medicals { get; set; }
      
    }
}