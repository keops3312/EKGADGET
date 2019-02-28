namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class interes
    {
        [Key]
        public int no { get; set; }

        [Column("interes", TypeName = "money")]
        public decimal? interes1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? seguro { get; set; }

        [Column(TypeName = "money")]
        public decimal? almacenaje { get; set; }

        [StringLength(50)]
        public string contrato { get; set; }

        public string caja { get; set; }
    }
}
