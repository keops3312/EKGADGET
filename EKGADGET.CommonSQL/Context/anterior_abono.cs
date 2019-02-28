namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class anterior_abono
    {
        public int? cantidad { get; set; }

        [StringLength(255)]
        public string descripcion { get; set; }

        [StringLength(255)]
        public string subdescripcion { get; set; }

        [Column(TypeName = "money")]
        public decimal? valor_prenda { get; set; }

        [Column(TypeName = "money")]
        public decimal? prestamo { get; set; }

        public int? registro { get; set; }

        public int? folio_contrato { get; set; }

        [StringLength(50)]
        public string origen { get; set; }

        [StringLength(50)]
        public string caja { get; set; }

        [Key]
        public int no { get; set; }
    }
}
