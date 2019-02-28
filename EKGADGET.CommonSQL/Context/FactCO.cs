namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FactCO")]
    public partial class FactCO
    {
        public double? oro_24 { get; set; }

        public double? oro_22 { get; set; }

        public double? oro_18 { get; set; }

        public double? oro_14 { get; set; }

        public double? oro_12 { get; set; }

        public double? oro_10 { get; set; }

        public double? oro_8 { get; set; }

        [Column(TypeName = "money")]
        public decimal? valor_24 { get; set; }

        [Column(TypeName = "money")]
        public decimal? valor_22 { get; set; }

        [Column(TypeName = "money")]
        public decimal? valor_18 { get; set; }

        [Column(TypeName = "money")]
        public decimal? valor_14 { get; set; }

        [Column(TypeName = "money")]
        public decimal? valor_12 { get; set; }

        [Column(TypeName = "money")]
        public decimal? valor_10 { get; set; }

        [Column(TypeName = "money")]
        public decimal? valor_8 { get; set; }

        [Key]
        public int indice { get; set; }

        public double? per1 { get; set; }

        public double? per2 { get; set; }

        public double? per3 { get; set; }

        public double? per4 { get; set; }

        public double? per5 { get; set; }

        public double? per6 { get; set; }

        public double? per7 { get; set; }
    }
}
