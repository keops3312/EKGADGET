namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class promociones
    {
        [Key]
        public int no { get; set; }

        [StringLength(50)]
        public string folio { get; set; }

        [StringLength(255)]
        public string concepto { get; set; }

        public double? descuento { get; set; }

        [Column(TypeName = "money")]
        public decimal? anterior { get; set; }

        [Column(TypeName = "money")]
        public decimal? nuevo { get; set; }

        [StringLength(50)]
        public string inv { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha { get; set; }

        [StringLength(255)]
        public string realizo { get; set; }

        [StringLength(50)]
        public string clave { get; set; }

        [StringLength(50)]
        public string caja { get; set; }

        [StringLength(50)]
        public string suc { get; set; }
    }
}
