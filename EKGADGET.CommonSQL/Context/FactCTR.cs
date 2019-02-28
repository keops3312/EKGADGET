namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FactCTR")]
    public partial class FactCTR
    {
        [StringLength(255)]
        public string tipo { get; set; }

        public double? porcentaje { get; set; }

        [Key]
        public int indice { get; set; }

        [StringLength(10)]
        public string sugerido { get; set; }
    }
}
