namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class artventas201
    {
        [StringLength(50)]
        public string no { get; set; }

        public int? contrato { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha { get; set; }

        public int? bolsa { get; set; }

        [StringLength(50)]
        public string noinv { get; set; }

        [StringLength(50)]
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

        public int? mov { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? rematado { get; set; }

        [StringLength(255)]
        public string rematado_por { get; set; }

        [StringLength(255)]
        public string mod_extemporanea { get; set; }

        [StringLength(255)]
        public string transferido { get; set; }

        [StringLength(255)]
        public string sucursal { get; set; }

        [StringLength(255)]
        public string status_transferido { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha_trans { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? actualizacion { get; set; }

        [StringLength(255)]
        public string codigotrans { get; set; }

        [StringLength(50)]
        public string pneto { get; set; }

        [StringLength(255)]
        public string NOTAS { get; set; }

        [StringLength(255)]
        public string AOM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? rematadoEJ { get; set; }

        [Column(TypeName = "money")]
        public decimal? precio_promocion { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fechaPP { get; set; }

        [Column(TypeName = "money")]
        public decimal? precioPromo2 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fechaPP2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? precioPromo3 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fechaPP3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? precioRemate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fechaPRem { get; set; }

        [Column(TypeName = "money")]
        public decimal? precio_origen { get; set; }

        [StringLength(255)]
        public string actualizo { get; set; }

        [StringLength(255)]
        public string actualizo2 { get; set; }

        [StringLength(255)]
        public string actualizo3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? prestamo { get; set; }

        public int? contrato2 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha_contrato { get; set; }

        [Key]
        public int indice { get; set; }
    }
}
