namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class comprobaciones_gastos
    {
        [Key]
        public int no { get; set; }

        [StringLength(255)]
        public string caja { get; set; }

        [StringLength(255)]
        public string tipo { get; set; }

        [StringLength(255)]
        public string comprobante { get; set; }

        [Column(TypeName = "money")]
        public decimal? cantidad { get; set; }

        [StringLength(255)]
        public string comentario { get; set; }

        [StringLength(255)]
        public string poliza { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha { get; set; }

        [StringLength(255)]
        public string gasto { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fechag { get; set; }
    }
}
