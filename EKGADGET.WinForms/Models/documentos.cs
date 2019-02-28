namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class documentos
    {
        [StringLength(50)]
        public string tipo_Doc { get; set; }

        [Key]
        public int no { get; set; }
    }
}
