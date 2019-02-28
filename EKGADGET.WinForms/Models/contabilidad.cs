namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("contabilidad")]
    public partial class contabilidad
    {
        [Key]
        public int no { get; set; }

        [StringLength(255)]
        public string Nombre { get; set; }

        [StringLength(255)]
        public string Localidad { get; set; }

        [StringLength(255)]
        public string Caja { get; set; }

        [StringLength(255)]
        public string Clave { get; set; }

        [StringLength(255)]
        public string Cuenta_prestamos { get; set; }

        [StringLength(255)]
        public string Cuenta_caja { get; set; }

        [StringLength(255)]
        public string Cuenta_interes { get; set; }

        [StringLength(255)]
        public string Cuenta_iva { get; set; }

        [StringLength(255)]
        public string departamento { get; set; }

        [StringLength(255)]
        public string leyenda1 { get; set; }

        [StringLength(255)]
        public string leyenda2 { get; set; }

        [StringLength(255)]
        public string leyenda3 { get; set; }
    }
}
