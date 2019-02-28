namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("seguro")]
    public partial class seguro
    {
        [Key]
        public int no { get; set; }

        [Column("seguro", TypeName = "money")]
        public decimal? seguro1 { get; set; }

        [StringLength(50)]
        public string contrato { get; set; }

        public string caja { get; set; }
    }
}
