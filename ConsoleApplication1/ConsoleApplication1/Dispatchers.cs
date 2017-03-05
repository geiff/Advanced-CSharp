namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Dispatchers
    {
        public Dispatchers()
        {
            this.States = new States();
            this.States1 = new States();
            this.Trasitions = new Trasitions();
        }
        public int Id { get; set; }

        public int CurrentStateID { get; set; }

        public int TransitionID { get; set; }

        public int NextStateID { get; set; }

        public virtual States States { get; set; }

        public virtual States States1 { get; set; }

        public virtual Trasitions Trasitions { get; set; }
    }
}
