namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Auditoria")]
    public partial class Auditoria
    {
        [Key]
        public int no { get; set; }

        public int? Valor { get; set; }

        [Column(TypeName = "text")]
        public string Concepto { get; set; }

        [Column(TypeName = "text")]
        public string Procedimiento { get; set; }

        [Column(TypeName = "text")]
        public string Area { get; set; }

        public int? Total { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fechaAlta { get; set; }
    }
}
