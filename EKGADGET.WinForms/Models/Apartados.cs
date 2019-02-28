namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Apartados
    {
        [Key]
        public int no { get; set; }

        [StringLength(50)]
        public string FOLIO_REM { get; set; }

        public int? bolsa { get; set; }

        [StringLength(255)]
        public string noinv { get; set; }

        [StringLength(255)]
        public string noserie { get; set; }

        [StringLength(255)]
        public string descripcion { get; set; }

        [Column(TypeName = "text")]
        public string detalles { get; set; }

        [Column(TypeName = "money")]
        public decimal? preciosugerido { get; set; }

        [Column(TypeName = "money")]
        public decimal? precioventa { get; set; }

        [StringLength(50)]
        public string kilates { get; set; }

        [StringLength(50)]
        public string peso_real { get; set; }

        [StringLength(50)]
        public string condiciones { get; set; }

        [StringLength(50)]
        public string tipo { get; set; }

        [StringLength(50)]
        public string status { get; set; }

        public double? apartado_con { get; set; }

        [Column(TypeName = "money")]
        public decimal? apartado_cantidad { get; set; }

        [StringLength(255)]
        public string aparto { get; set; }

        [StringLength(50)]
        public string idcliente { get; set; }

        [Column(TypeName = "money")]
        public decimal? resta_por_pagar { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha_de_apartado { get; set; }

        [StringLength(255)]
        public string usuario { get; set; }

        [StringLength(255)]
        public string realizado_en { get; set; }

        [Column(TypeName = "text")]
        public string comentario { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? liquido_fecha { get; set; }

        [StringLength(255)]
        public string nota_liquido { get; set; }

        public decimal? penalizado { get; set; }

        [Column(TypeName = "money")]
        public decimal? penalizado_precio { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_de_penalizacion { get; set; }

        [StringLength(255)]
        public string mot_penalizacion { get; set; }

        [StringLength(255)]
        public string cancelo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha_cancelo { get; set; }

        [Column(TypeName = "text")]
        public string mot_cancelo { get; set; }

        [StringLength(50)]
        public string folio_apartado { get; set; }

        [StringLength(255)]
        public string promocion { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? vigencia { get; set; }

        [Column(TypeName = "money")]
        public decimal? precio_origen { get; set; }

        public decimal? descuento { get; set; }

        [StringLength(50)]
        public string tipo_desc { get; set; }

        [Column(TypeName = "money")]
        public decimal? precio_remate { get; set; }

        public decimal? penalizacion_por { get; set; }

        public decimal? cancelacion_por { get; set; }

        public int? dias_minimo { get; set; }

        public int? dias_normal { get; set; }

        public int? dias_tolerancia { get; set; }

        public decimal? apartado_min { get; set; }

        public decimal? apartado_norm { get; set; }

        [StringLength(50)]
        public string nombre_plazo { get; set; }

        [StringLength(50)]
        public string tipo_apartado { get; set; }
    }
}
