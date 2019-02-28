namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Apartados_confg
    {
        [Key]
        public int no { get; set; }

        [StringLength(255)]
        public string Nombre_plazo { get; set; }

        public int? dias { get; set; }

        public decimal? apartado_natural { get; set; }

        public decimal? apartado_minimo { get; set; }

        public int? dias_tolerancia { get; set; }

        public int? dias_minimo { get; set; }

        public decimal? penalizacion { get; set; }

        public decimal? cancelacion { get; set; }

        public int? ACTIVADO { get; set; }
    }
}
