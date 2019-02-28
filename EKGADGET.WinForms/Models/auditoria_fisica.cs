namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class auditoria_fisica
    {
        [Key]
        public int no { get; set; }

        public int? contrato { get; set; }

        [Column(TypeName = "money")]
        public decimal? prendas { get; set; }

        [StringLength(255)]
        public string encontrado { get; set; }

        [StringLength(255)]
        public string detalles { get; set; }

        [StringLength(255)]
        public string tipo { get; set; }

        [StringLength(255)]
        public string prendas_sistema { get; set; }

        [StringLength(255)]
        public string status_contrato { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha_contrato { get; set; }

        [StringLength(255)]
        public string audito { get; set; }

        [StringLength(255)]
        public string superviso { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha_auditoria { get; set; }

        [StringLength(255)]
        public string localidad { get; set; }

        [StringLength(255)]
        public string diferencia { get; set; }
    }
}
