namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Puestos
    {
        [Key]
        public int no { get; set; }

        [StringLength(150)]
        public string puesto { get; set; }

        [StringLength(150)]
        public string pertenecea { get; set; }
    }
}
