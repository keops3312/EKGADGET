namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLONA")]
    public partial class CLONA
    {
        public int? Folio { get; set; }

        public int? Contrato { get; set; }

        [StringLength(50)]
        public string Fecha { get; set; }

        public int? Bolsa { get; set; }

        public int? IdClientes { get; set; }

        [StringLength(255)]
        public string NCliente { get; set; }

        [StringLength(255)]
        public string AutorizoA { get; set; }

        [StringLength(255)]
        public string Plazo { get; set; }

        [StringLength(255)]
        public string Status { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FechaDesemp { get; set; }

        [Column(TypeName = "text")]
        public string Comentario { get; set; }

        [StringLength(255)]
        public string Dias { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FechaCons { get; set; }

        [Column(TypeName = "money")]
        public decimal? Prestamo { get; set; }

        public double? Interes { get; set; }

        public double? seguro { get; set; }

        public double? almacenaje { get; set; }

        [StringLength(255)]
        public string plazo1 { get; set; }

        [StringLength(255)]
        public string plazo2 { get; set; }

        [StringLength(255)]
        public string plazo3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? avaluo { get; set; }

        [StringLength(255)]
        public string valuacion_tipo { get; set; }

        [StringLength(255)]
        public string cancelado { get; set; }

        [Column(TypeName = "text")]
        public string comentariocancelado { get; set; }

        [Column(TypeName = "money")]
        public decimal? prestamoprom { get; set; }

        [StringLength(50)]
        public string origen { get; set; }

        [StringLength(50)]
        public string folioavaluo { get; set; }

        public int? clasificacion { get; set; }

        [StringLength(10)]
        public string santerior { get; set; }

        public string caja { get; set; }

        [StringLength(10)]
        public string pension { get; set; }

        [StringLength(2)]
        public string Rev { get; set; }

        [Key]
        public int reg { get; set; }

        public double? temp { get; set; }

        [StringLength(255)]
        public string VenOVig { get; set; }

        [StringLength(255)]
        public string realizo { get; set; }

        public decimal? cobroOriginal { get; set; }

        [StringLength(255)]
        public string BLOQUEADO_COMENTARIO { get; set; }
    }
}
