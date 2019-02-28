namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Retiros
    {
        public int? no { get; set; }

        [StringLength(50)]
        public string caja { get; set; }

        [StringLength(50)]
        public string numcaja { get; set; }

        [StringLength(50)]
        public string pertenecea { get; set; }

        [Column(TypeName = "money")]
        public decimal? cantidad { get; set; }

        [StringLength(50)]
        public string concepto { get; set; }

        [Column(TypeName = "text")]
        public string descripcion { get; set; }

        [StringLength(50)]
        public string estatus { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha { get; set; }

        [StringLength(50)]
        public string hora { get; set; }

        [StringLength(255)]
        public string autorizo { get; set; }

        [StringLength(255)]
        public string usuario { get; set; }

        [StringLength(50)]
        public string nooperador { get; set; }

        [Key]
        public int comprobacionno { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha_compro { get; set; }

        [Column(TypeName = "text")]
        public string motivo { get; set; }

        [StringLength(255)]
        public string responsable_fondo { get; set; }

        [StringLength(255)]
        public string responsable_revisa { get; set; }

        [StringLength(255)]
        public string codigo_compro { get; set; }

        [StringLength(255)]
        public string documento_tipo { get; set; }

        [StringLength(255)]
        public string no_doc { get; set; }

        [StringLength(50)]
        public string folio { get; set; }
    }
}
