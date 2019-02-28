namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class costo_reimpresion
    {
        [Key]
        public int no { get; set; }

        [Column(TypeName = "money")]
        public decimal? costo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha { get; set; }

        [StringLength(255)]
        public string realizo { get; set; }
    }
}
