namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TPavaluos
    {
        [Key]
        public int no { get; set; }

        [StringLength(50)]
        public string definicion { get; set; }

        public string descripcion { get; set; }

        public string logo { get; set; }

        [StringLength(50)]
        public string Su_avaluo_sera { get; set; }

        [StringLength(255)]
        public string alta { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha_alta { get; set; }

        public int? premate { get; set; }

        public decimal? desc_primero { get; set; }

        public int? sremate { get; set; }

        public decimal? desc_segundo { get; set; }

        public int? remate { get; set; }

        public decimal? limite_precio { get; set; }

        public int? limite_refrendo { get; set; }
    }
}
