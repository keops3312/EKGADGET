namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reimpresiones
    {
        [Key]
        public int no { get; set; }

        [StringLength(50)]
        public string reimpresion { get; set; }

        [Column(TypeName = "money")]
        public decimal? costo { get; set; }

        [StringLength(50)]
        public string folio_reimpreso { get; set; }

        [StringLength(50)]
        public string folio_nuevo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha { get; set; }

        [StringLength(50)]
        public string caja { get; set; }

        [StringLength(255)]
        public string cliente { get; set; }

        [StringLength(50)]
        public string id_cliente { get; set; }

        [StringLength(255)]
        public string realizo { get; set; }
    }
}
