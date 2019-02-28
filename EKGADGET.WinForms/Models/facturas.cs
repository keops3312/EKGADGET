namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class facturas
    {
        [StringLength(255)]
        public string Factura { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FechaFact { get; set; }

        [StringLength(255)]
        public string HoraFact { get; set; }

        public int? Contrato { get; set; }

        public int? Bolsa { get; set; }

        public int? Folio { get; set; }

        [Column(TypeName = "text")]
        public string DescripcionFact { get; set; }

        [Column(TypeName = "money")]
        public decimal? ImporteFact { get; set; }

        [Column(TypeName = "money")]
        public decimal? IVAFact { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalFact { get; set; }

        public int? IdCliente { get; set; }

        [Column(TypeName = "text")]
        public string Comentario { get; set; }

        [Column(TypeName = "money")]
        public decimal? Abono { get; set; }

        [Column("R-D")]
        [StringLength(10)]
        public string R_D { get; set; }

        [Key]
        public int NO { get; set; }

        [StringLength(50)]
        public string caja { get; set; }

        [Column(TypeName = "money")]
        public decimal? Gastos_Operacion { get; set; }

        [Column(TypeName = "money")]
        public decimal? gastos { get; set; }

        [Column(TypeName = "money")]
        public decimal? descuento_gastos_op { get; set; }

        [Column("total gastos_op", TypeName = "money")]
        public decimal? total_gastos_op { get; set; }

        [StringLength(255)]
        public string leyendas { get; set; }

        [StringLength(255)]
        public string leyenda2 { get; set; }

        [StringLength(255)]
        public string leyenda3 { get; set; }

        [StringLength(50)]
        public string STATUS { get; set; }

        [StringLength(50)]
        public string origen { get; set; }

        [StringLength(250)]
        public string cliente_Promocion { get; set; }

        [Column(TypeName = "text")]
        public string Nota { get; set; }

        [Column(TypeName = "money")]
        public decimal? antes_refrendo { get; set; }

        [Column(TypeName = "money")]
        public decimal? ahora_refrendo { get; set; }

        [Column(TypeName = "money")]
        public decimal? antes_desempeño { get; set; }

        [Column(TypeName = "money")]
        public decimal? ahora_desempeño { get; set; }

        public double? descuento_preferente { get; set; }

        [StringLength(255)]
        public string leyendag { get; set; }

        [StringLength(255)]
        public string leyendadescg { get; set; }

        [StringLength(255)]
        public string leyendatotalg { get; set; }

        [StringLength(255)]
        public string leyendaA { get; set; }

        [StringLength(255)]
        public string plazo { get; set; }

        [Column(TypeName = "money")]
        public decimal? interes_N { get; set; }

        [Column(TypeName = "money")]
        public decimal? interes_A { get; set; }

        [StringLength(255)]
        public string realizo { get; set; }
    }
}
