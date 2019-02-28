namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cobros_poliza
    {
        [Key]
        public int no { get; set; }

        [StringLength(255)]
        public string cuenta { get; set; }

        [StringLength(255)]
        public string caja { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha { get; set; }
    }
}
