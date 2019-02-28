namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("refrendo")]
    public partial class refrendo
    {
        [Key]
        public int no { get; set; }

        [Column("refrendo", TypeName = "money")]
        public decimal? refrendo1 { get; set; }

        [StringLength(50)]
        public string contrato { get; set; }

        public string caja { get; set; }
    }
}
