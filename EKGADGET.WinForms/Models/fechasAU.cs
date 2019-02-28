namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fechasAU")]
    public partial class fechasAU
    {
        [Column(TypeName = "smalldatetime")]
        public DateTime? f1 { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? f2 { get; set; }

        [Key]
        [Column("int")]
        public int _int { get; set; }
    }
}
