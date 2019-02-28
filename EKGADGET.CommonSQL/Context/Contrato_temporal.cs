namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contrato_temporal
    {
        public int? No { get; set; }

        [StringLength(255)]
        public string Primer_plazo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_de_pago { get; set; }

        [Column(TypeName = "money")]
        public decimal? monto_prestamo { get; set; }

        [Column(TypeName = "money")]
        public decimal? Interes { get; set; }

        [Column(TypeName = "money")]
        public decimal? Seguro { get; set; }

        [Column(TypeName = "money")]
        public decimal? Almacenaje { get; set; }

        [Column(TypeName = "money")]
        public decimal? Total_a_pagar { get; set; }

        [Column(TypeName = "money")]
        public decimal? Refrendo { get; set; }

        public int? Fecha_sistema { get; set; }

        [StringLength(50)]
        public string contrato { get; set; }

        public string caja { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha_compara { get; set; }

        [Key]
        public int indice { get; set; }
    }
}
