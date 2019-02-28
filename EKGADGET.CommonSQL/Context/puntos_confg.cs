namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class puntos_confg
    {
        [Key]
        public int no { get; set; }

        [StringLength(255)]
        public string documento { get; set; }

        [StringLength(255)]
        public string status_contratos { get; set; }

        [StringLength(255)]
        public string status_NP { get; set; }

        [Column(TypeName = "money")]
        public decimal? cantidad_C { get; set; }

        [Column(TypeName = "money")]
        public decimal? cantidad_NP { get; set; }

        public decimal? valor_pts_C { get; set; }

        public decimal? valor_pts_NP { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? vigencia_de { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? vigencia_a { get; set; }

        [StringLength(50)]
        public string activado { get; set; }

        [StringLength(255)]
        public string echo_por { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha { get; set; }
    }
}
