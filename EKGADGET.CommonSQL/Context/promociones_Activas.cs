namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class promociones_Activas
    {
        [StringLength(50)]
        public string promociones { get; set; }

        [StringLength(10)]
        public string activa { get; set; }

        public string descripcion { get; set; }

        public decimal? descuento_porciento { get; set; }

        [Column(TypeName = "money")]
        public decimal? descuento_cantidad { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? VIGENCIA { get; set; }

        [StringLength(50)]
        public string tipo { get; set; }

        [StringLength(50)]
        public string operacion { get; set; }

        [StringLength(50)]
        public string tipo_desc { get; set; }

        [Column(TypeName = "money")]
        public decimal? compra_mayor_a { get; set; }

        [StringLength(50)]
        public string DOCUMENTO_REQUERIDO { get; set; }

        public int? requeridas { get; set; }

        public int? cobrar { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha { get; set; }

        [StringLength(255)]
        public string realizo { get; set; }

        [Key]
        [Column("int")]
        public int _int { get; set; }
    }
}
