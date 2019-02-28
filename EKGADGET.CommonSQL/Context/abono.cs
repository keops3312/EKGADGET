namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("abono")]
    public partial class abono
    {
        public int? contrato { get; set; }

        [Column("int")]
        public int? _int { get; set; }

        [Column(TypeName = "money")]
        public decimal? prestamo { get; set; }

        [Key]
        public int indice { get; set; }

        [Column(TypeName = "money")]
        public decimal? abonado { get; set; }
    }
}
