namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bolsas_OTROS
    {
        public int? Contrato { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha { get; set; }

        public int? Bolsa { get; set; }

        public string Descripcion { get; set; }

        public string SubDescripcion { get; set; }

        [StringLength(100)]
        public string Tipo { get; set; }

        [Column(TypeName = "money")]
        public decimal? Avaluo { get; set; }

        [StringLength(100)]
        public string Estatus_Prenda { get; set; }

        [Column(TypeName = "text")]
        public string Condiciones { get; set; }

        public int? Cantidad { get; set; }

        [StringLength(255)]
        public string Localidad { get; set; }

        [StringLength(255)]
        public string Ubicacion { get; set; }

        [StringLength(255)]
        public string Posicion { get; set; }

        [StringLength(250)]
        public string sucursal { get; set; }

        [StringLength(250)]
        public string registro { get; set; }

        public string NO { get; set; }

        [StringLength(50)]
        public string folio { get; set; }

        [StringLength(50)]
        public string origen { get; set; }

        [Column(TypeName = "money")]
        public decimal? prestamo { get; set; }

        [Key]
        public int INT { get; set; }

        [Column(TypeName = "text")]
        public string detalles { get; set; }

        public string caja { get; set; }

        public string detalles_art { get; set; }

        [StringLength(255)]
        public string modelo { get; set; }

        [StringLength(255)]
        public string noserie { get; set; }
    }
}
