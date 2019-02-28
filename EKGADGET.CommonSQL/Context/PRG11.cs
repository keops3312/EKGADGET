namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRG11
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

        public int? Contrato { get; set; }

        [Column(TypeName = "money")]
        public decimal? Debe { get; set; }

        [Column(TypeName = "money")]
        public decimal? Haber { get; set; }

        [Column(TypeName = "money")]
        public decimal? Saldo { get; set; }

        [StringLength(255)]
        public string Usuario { get; set; }

        [StringLength(255)]
        public string Movim { get; set; }

        [StringLength(255)]
        public string Status { get; set; }

        [Column(TypeName = "text")]
        public string Comentario { get; set; }
    }
}
