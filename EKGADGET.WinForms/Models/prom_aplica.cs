namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prom_aplica
    {
        [Key]
        public int ind { get; set; }

        public int? por_cada_pt { get; set; }

        public decimal? vale_tipo { get; set; }

        [StringLength(50)]
        public string tipo { get; set; }

        [StringLength(50)]
        public string operacion { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? vigencia { get; set; }

        [StringLength(2)]
        public string activado { get; set; }
    }
}
