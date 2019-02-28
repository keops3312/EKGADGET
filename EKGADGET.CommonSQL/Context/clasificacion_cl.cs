namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class clasificacion_cl
    {
        [Key]
        public int no { get; set; }

        [StringLength(150)]
        public string Estatus_Considerados { get; set; }

        [StringLength(150)]
        public string Preferencia { get; set; }

        [StringLength(20)]
        public string activado { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? realizados_entre { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? realizados_entre2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Importes1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Importes2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Importes3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Importes4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Importes5 { get; set; }

        public double? descuento1 { get; set; }

        public double? descuento2 { get; set; }

        public double? descuento3 { get; set; }

        public double? descuento4 { get; set; }

        public double? descuento5 { get; set; }

        public decimal? cantidad1 { get; set; }

        public decimal? cantidad2 { get; set; }

        public decimal? cantidad3 { get; set; }

        public decimal? cantidad4 { get; set; }

        public decimal? cantidad5 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? feccha { get; set; }

        [StringLength(255)]
        public string realizo { get; set; }

        public string imagen1 { get; set; }

        public string imagen2 { get; set; }

        public string imagen3 { get; set; }

        public string imagen4 { get; set; }

        public string imagen5 { get; set; }

        public int? dias { get; set; }
    }
}
