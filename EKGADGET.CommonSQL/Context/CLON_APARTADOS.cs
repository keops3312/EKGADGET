namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLON_APARTADOS
    {
        [Key]
        public int mov { get; set; }

        [StringLength(255)]
        public string Caja { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha { get; set; }

        [StringLength(255)]
        public string Hora { get; set; }

        [StringLength(255)]
        public string Concepto { get; set; }

        [StringLength(255)]
        public string Folio { get; set; }

        public decimal? Apartado_no { get; set; }

        [Column(TypeName = "money")]
        public decimal? abono { get; set; }

        [Column(TypeName = "money")]
        public decimal? abono_acumulado { get; set; }

        [Column(TypeName = "money")]
        public decimal? debe { get; set; }

        [Column(TypeName = "money")]
        public decimal? haber { get; set; }

        [Column(TypeName = "money")]
        public decimal? Saldo { get; set; }

        [Column(TypeName = "money")]
        public decimal? otros_saldo { get; set; }

        [StringLength(255)]
        public string usuario { get; set; }

        [StringLength(255)]
        public string Status { get; set; }

        [Column(TypeName = "text")]
        public string Comentario { get; set; }

        [Column(TypeName = "money")]
        public decimal? debe2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? haber2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? otros_saldo2 { get; set; }
    }
}
