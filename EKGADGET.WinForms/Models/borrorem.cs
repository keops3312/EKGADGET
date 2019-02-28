namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("borrorem")]
    public partial class borrorem
    {
        [Key]
        public int NO { get; set; }

        [StringLength(50)]
        public string NOINV { get; set; }
    }
}
