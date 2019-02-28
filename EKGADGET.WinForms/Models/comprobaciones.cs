namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class comprobaciones
    {
        [Key]
        public int comprobacion_no { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha_comprobacion { get; set; }

        [StringLength(255)]
        public string codigo_comprobacion { get; set; }

        [StringLength(255)]
        public string empresa { get; set; }

        [StringLength(255)]
        public string suc { get; set; }

        [Column(TypeName = "text")]
        public string dir { get; set; }

        [StringLength(255)]
        public string responsable { get; set; }

        [StringLength(255)]
        public string superviso { get; set; }
    }
}
