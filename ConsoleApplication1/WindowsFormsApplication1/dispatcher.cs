namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bpm.dispatchers")]
    public partial class dispatcher
    {
        [Column(TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Column(TypeName = "uint")]
        public long? CurrentStateID { get; set; }

        [Column(TypeName = "uint")]
        public long? TransitionID { get; set; }

        [Column(TypeName = "uint")]
        public long? NextStateID { get; set; }

        public virtual state state { get; set; }

        public virtual state state1 { get; set; }

        public virtual transition transition { get; set; }
    }
}
