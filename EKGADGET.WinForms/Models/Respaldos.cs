namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Respaldos
    {
        [Key]
        public int no { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha { get; set; }

        [StringLength(50)]
        public string hora { get; set; }

        [StringLength(255)]
        public string fecha_texto { get; set; }

        [StringLength(2)]
        public string realizado { get; set; }

        [StringLength(255)]
        public string enviado_a { get; set; }
    }
}
