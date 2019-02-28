namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TASA_PRESTAMOS
    {
        [Key]
        public int no_plazo { get; set; }

        [StringLength(50)]
        public string Nombre_plazo { get; set; }

        [StringLength(50)]
        public string porcentaje_de_prestamo { get; set; }

        [StringLength(50)]
        public string tiempo_plazo { get; set; }

        [StringLength(50)]
        public string no_repeticiones_cantidad { get; set; }

        [StringLength(50)]
        public string tipo_de_repeticiones { get; set; }

        [StringLength(50)]
        public string tasa_de_interes { get; set; }

        [StringLength(50)]
        public string tipo_de_interes { get; set; }

        [StringLength(50)]
        public string estatus_plazo { get; set; }

        [StringLength(255)]
        public string Comentario_adicional { get; set; }

        [StringLength(150)]
        public string Alta_por { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_alta { get; set; }
    }
}
