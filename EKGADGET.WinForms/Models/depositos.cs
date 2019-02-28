namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class depositos
    {
        [Key]
        public int no { get; set; }

        [Column(TypeName = "money")]
        public decimal? deposito { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha { get; set; }

        [StringLength(255)]
        public string realizo { get; set; }

        [StringLength(255)]
        public string caja { get; set; }

        [Column(TypeName = "text")]
        public string comentario { get; set; }

        [StringLength(255)]
        public string tipo_deposito { get; set; }
    }
}
