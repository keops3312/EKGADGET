namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ETQ_VENTA
    {
        [Key]
        public int no { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        public string Detalles { get; set; }

        [StringLength(50)]
        public string kt { get; set; }

        [StringLength(50)]
        public string Peso { get; set; }

        [Column(TypeName = "money")]
        public decimal? Precio { get; set; }

        [StringLength(50)]
        public string tipo { get; set; }

        [StringLength(50)]
        public string Inventario { get; set; }

        [Column(TypeName = "money")]
        public decimal? especial { get; set; }

        [StringLength(2)]
        public string pr { get; set; }

        [Column(TypeName = "money")]
        public decimal? REMATE_UNO { get; set; }

        [Column(TypeName = "money")]
        public decimal? REMATE_DOS { get; set; }

        [Column(TypeName = "money")]
        public decimal? REMATE_TRES { get; set; }
    }
}
