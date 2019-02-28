namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("inventariopromocion")]
    public partial class inventariopromocion
    {
        public int? cantidad { get; set; }

        public string descripcion { get; set; }

        [Column(TypeName = "money")]
        public decimal? precio { get; set; }

        [StringLength(255)]
        public string detalles { get; set; }

        public string imagen { get; set; }

        public int? otorgado_por { get; set; }

        public string promocion_q_participa { get; set; }

        [Column(TypeName = "money")]
        public decimal? precioxcanje { get; set; }

        [Key]
        public int no { get; set; }

        public string alta_por { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha_alta { get; set; }

        public string no_inv { get; set; }
    }
}
