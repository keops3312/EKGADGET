namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("promocioncaja")]
    public partial class promocioncaja
    {
        [Key]
        public int no { get; set; }

        [StringLength(255)]
        public string regalo { get; set; }

        [StringLength(255)]
        public string concepto { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha { get; set; }

        public int? promocion { get; set; }

        [StringLength(255)]
        public string realizo { get; set; }

        [StringLength(255)]
        public string caja { get; set; }

        [StringLength(255)]
        public string sucursal { get; set; }

        [Column(TypeName = "money")]
        public decimal? importe { get; set; }

        [Column(TypeName = "money")]
        public decimal? valor_prenda { get; set; }

        [StringLength(255)]
        public string entregado_a { get; set; }

        [StringLength(50)]
        public string noserie { get; set; }

        [StringLength(50)]
        public string NO_INV { get; set; }
    }
}
