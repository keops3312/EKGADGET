namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tabla_result
    {
        [Key]
        public int no { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha { get; set; }

        [StringLength(50)]
        public string mes { get; set; }

        public int? dia { get; set; }

        public int? ano { get; set; }

        [StringLength(255)]
        public string loc { get; set; }

        [StringLength(255)]
        public string suc { get; set; }

        [StringLength(255)]
        public string marca { get; set; }

        [StringLength(255)]
        public string empresa { get; set; }

        public decimal? moneda_pres { get; set; }

        public decimal? cantidad_pres { get; set; }

        [StringLength(50)]
        public string tipo_pres { get; set; }

        public decimal? moneda_ref { get; set; }

        public decimal? cantidad_ref { get; set; }

        public decimal? moneda_rem { get; set; }

        public decimal? cantidad_rem { get; set; }

        public decimal? moneda_reimp { get; set; }

        public decimal? cantidad_reimp { get; set; }

        public decimal? moneda_dep { get; set; }

        public decimal? cantidad_dep { get; set; }

        public decimal? moneda_ret { get; set; }

        public decimal? cantidad_ret { get; set; }
    }
}
