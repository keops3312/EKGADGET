namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class gastos
    {
        [Key]
        public int no { get; set; }

        [Column("GASTOS")]
        public string GASTOS1 { get; set; }
    }
}
