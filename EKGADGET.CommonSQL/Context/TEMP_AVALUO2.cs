namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TEMP_AVALUO2
    {
        [StringLength(50)]
        public string Cantidad { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        [StringLength(150)]
        public string Subdescripcion { get; set; }

        [StringLength(50)]
        public string Condiciones { get; set; }

        [Column(TypeName = "money")]
        public decimal? Valor_prenda { get; set; }

        [Column(TypeName = "text")]
        public string Detalles_de_prenda { get; set; }

        [StringLength(50)]
        public string Penalizado_con { get; set; }

        [StringLength(50)]
        public string Plazo { get; set; }

        [Column(TypeName = "money")]
        public decimal? Prestamo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha { get; set; }

        [StringLength(150)]
        public string alta_por { get; set; }

        [StringLength(50)]
        public string folio { get; set; }

        [Key]
        public int no { get; set; }

        [Column(TypeName = "money")]
        public decimal? A { get; set; }

        [Column(TypeName = "money")]
        public decimal? B { get; set; }

        [StringLength(50)]
        public string tipo { get; set; }

        [StringLength(255)]
        public string modelo { get; set; }

        [StringLength(255)]
        public string noserie { get; set; }
    }
}
