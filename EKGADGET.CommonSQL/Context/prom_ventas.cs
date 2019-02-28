namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prom_ventas
    {
        [Key]
        public int ind { get; set; }

        [Column(TypeName = "money")]
        public decimal? venta { get; set; }

        public decimal? puntos { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? vigencia { get; set; }

        [StringLength(2)]
        public string activado { get; set; }
    }
}
