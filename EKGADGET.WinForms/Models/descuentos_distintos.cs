namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class descuentos_distintos
    {
        [Key]
        public int no { get; set; }

        [StringLength(50)]
        public string folio { get; set; }

        public int? contrato { get; set; }

        public int? bolsa { get; set; }

        [StringLength(50)]
        public string idcliente { get; set; }

        [Column("R-D")]
        [StringLength(10)]
        public string R_D { get; set; }

        [StringLength(50)]
        public string tipo_C { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha { get; set; }

        [StringLength(50)]
        public string Status_contrato { get; set; }

        [StringLength(50)]
        public string tipo_desc { get; set; }

        public double? descuento { get; set; }

        public string comentario { get; set; }

        [Column(TypeName = "money")]
        public decimal? A_desempeñar { get; set; }

        [Column(TypeName = "money")]
        public decimal? D_desempeñar { get; set; }

        [Column(TypeName = "money")]
        public decimal? A_refrendar { get; set; }

        [Column(TypeName = "money")]
        public decimal? D_refrendar { get; set; }

        [Column(TypeName = "money")]
        public decimal? antes_prestamo { get; set; }

        [Column(TypeName = "money")]
        public decimal? ahora_prestamo { get; set; }

        [Column(TypeName = "money")]
        public decimal? antes_pension { get; set; }

        [Column(TypeName = "money")]
        public decimal? ahora_pension { get; set; }

        [Column(TypeName = "money")]
        public decimal? antes_resmision { get; set; }

        [Column(TypeName = "money")]
        public decimal? ahora_remision { get; set; }

        [StringLength(255)]
        public string autorizo { get; set; }

        [StringLength(50)]
        public string caja { get; set; }

        [StringLength(50)]
        public string status { get; set; }
    }
}
