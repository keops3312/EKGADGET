namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class depositos_tipo
    {
        [StringLength(255)]
        public string tipo { get; set; }

        [Key]
        public int no { get; set; }
    }
}
