namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class auxiliar_puesto
    {
        [Key]
        public int no { get; set; }

        [StringLength(150)]
        public string auxp { get; set; }
    }
}
