namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GradoEstudios
    {
        [Key]
        public int no { get; set; }

        [StringLength(150)]
        public string GRADO { get; set; }
    }
}
