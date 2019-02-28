namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class autorizaciones_prestamos
    {
        [Key]
        public int no { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha { get; set; }

        [StringLength(50)]
        public string hora { get; set; }

        [StringLength(50)]
        public string usuario { get; set; }

        [Column(TypeName = "money")]
        public decimal? anterior { get; set; }

        [Column(TypeName = "money")]
        public decimal? nuevo { get; set; }

        public string motivo { get; set; }

        [StringLength(50)]
        public string paraelcontrato { get; set; }
    }
}
