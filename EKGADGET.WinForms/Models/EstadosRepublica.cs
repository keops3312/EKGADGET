namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstadosRepublica")]
    public partial class EstadosRepublica
    {
        [Key]
        public int no { get; set; }

        [StringLength(150)]
        public string Estado { get; set; }

        [StringLength(150)]
        public string clave { get; set; }

        [StringLength(50)]
        public string nom { get; set; }

        public int? nom2 { get; set; }
    }
}
