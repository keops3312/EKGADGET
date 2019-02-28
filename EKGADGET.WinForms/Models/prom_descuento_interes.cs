namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prom_descuento_interes
    {
        [Key]
        public int ind { get; set; }

        [Column(TypeName = "money")]
        public decimal? prestamo { get; set; }

        public decimal? puntos { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? vigencia { get; set; }

        [StringLength(2)]
        public string activado { get; set; }
    }
}
