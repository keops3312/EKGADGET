namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vencidos
    {
        public int? Contrato { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha { get; set; }

        public int? Bolsa { get; set; }

        public string Descripcion { get; set; }

        [Column(TypeName = "text")]
        public string SubDescripcion { get; set; }

        [StringLength(12)]
        public string Kilates { get; set; }

        [StringLength(12)]
        public string PesoReal { get; set; }

        [StringLength(100)]
        public string Tipo { get; set; }

        [Column(TypeName = "money")]
        public decimal? Avaluo { get; set; }

        [Column(TypeName = "money")]
        public decimal? Prestamo { get; set; }

        [StringLength(255)]
        public string EstatusPrenda { get; set; }

        [StringLength(255)]
        public string Cantidad { get; set; }

        [StringLength(255)]
        public string Localidad { get; set; }

        [StringLength(255)]
        public string Ubicacion { get; set; }

        [StringLength(255)]
        public string Posicion { get; set; }

        [StringLength(250)]
        public string registro { get; set; }

        [StringLength(50)]
        public string folio { get; set; }

        [StringLength(50)]
        public string origen { get; set; }

        [Key]
        public int INT { get; set; }

        [StringLength(50)]
        public string condiciones { get; set; }

        public int? indice { get; set; }

        [Column(TypeName = "text")]
        public string descripcion_ant { get; set; }

        [Column(TypeName = "text")]
        public string subdescripcion_ant { get; set; }

        [StringLength(12)]
        public string kilate_ant { get; set; }

        [StringLength(12)]
        public string peso_ant { get; set; }

        [Column(TypeName = "money")]
        public decimal? prestamo_ant { get; set; }

        [Column(TypeName = "money")]
        public decimal? avaluo_ant { get; set; }

        [StringLength(100)]
        public string tipo_ant { get; set; }

        [StringLength(50)]
        public string condiciones_ant { get; set; }

        [StringLength(50)]
        public string peso_neto_ant { get; set; }

        [StringLength(50)]
        public string no_inventario { get; set; }

        [StringLength(50)]
        public string no_serie { get; set; }

        [Column(TypeName = "money")]
        public decimal? Precio_venta { get; set; }

        [Column(TypeName = "money")]
        public decimal? Precio_remate { get; set; }

        [StringLength(255)]
        public string no_control_v { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha_control { get; set; }

        [StringLength(255)]
        public string mod_agre { get; set; }

        [StringLength(12)]
        public string Pneto { get; set; }

        public string caja { get; set; }

        [StringLength(50)]
        public string cambio { get; set; }

        public string notas { get; set; }

        public string ESPECIFICOS { get; set; }

        public string STATUS_CONTRATO { get; set; }

        public string DETALLES_CONTRATO { get; set; }
    }
}
