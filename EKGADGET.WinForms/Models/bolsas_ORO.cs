namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bolsas_ORO
    {
        public int? Contrato { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha { get; set; }

        public int? Bolsa { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        [StringLength(255)]
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

        public string caja { get; set; }

        [StringLength(50)]
        public string pneto { get; set; }
    }
}
