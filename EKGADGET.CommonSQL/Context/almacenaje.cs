namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("almacenaje")]
    public partial class almacenaje
    {
        [Key]
        public int no { get; set; }

        [Column("almacenaje", TypeName = "money")]
        public decimal? almacenaje1 { get; set; }

        [StringLength(50)]
        public string contrato { get; set; }

        public string caja { get; set; }
    }
}
