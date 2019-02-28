namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class auditoria_resumen
    {
        [Key]
        public int no { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha_reviso { get; set; }

        [StringLength(255)]
        public string auditor { get; set; }

        public double? calificacion { get; set; }

        [StringLength(255)]
        public string jefe { get; set; }

        [StringLength(255)]
        public string sucursal { get; set; }

        [StringLength(255)]
        public string empresa { get; set; }

        [StringLength(255)]
        public string sigla { get; set; }
    }
}
