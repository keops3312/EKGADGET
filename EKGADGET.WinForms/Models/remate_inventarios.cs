namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class remate_inventarios
    {
        [Key]
        public int no { get; set; }

        [StringLength(50)]
        public string tipo { get; set; }

        public int? premate { get; set; }

        public decimal? desc_primero { get; set; }

        public int? sremate { get; set; }

        public decimal? desc_segundo { get; set; }

        public int? remate { get; set; }
    }
}
