namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class calificacion_aud
    {
        [Key]
        public int no { get; set; }

        public int? indice { get; set; }

        public int? calificacion { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha { get; set; }

        public int? valor { get; set; }

        [StringLength(255)]
        public string sucursal { get; set; }

        [StringLength(255)]
        public string encargado { get; set; }

        [StringLength(50)]
        public string sigla { get; set; }

        [StringLength(255)]
        public string empresa { get; set; }

        [StringLength(255)]
        public string audito { get; set; }

        [Column(TypeName = "text")]
        public string detalles { get; set; }

        [StringLength(255)]
        public string folio { get; set; }

        public int? total { get; set; }

        public int? valorobtenido { get; set; }

        [StringLength(255)]
        public string proce { get; set; }

        [Column(TypeName = "text")]
        public string concepto { get; set; }

        public int? un { get; set; }
    }
}
