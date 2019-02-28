namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VALOR_FACTORES
    {
        [Key]
        public int No_Factor { get; set; }

        [StringLength(150)]
        public string Nombre_Factor { get; set; }

        [StringLength(50)]
        public string Porcentaje_a_considerar { get; set; }

        [StringLength(50)]
        public string Estatus_del_Factor { get; set; }

        [StringLength(50)]
        public string Factor_24_kt { get; set; }

        [StringLength(50)]
        public string Factor_22_kt { get; set; }

        [StringLength(50)]
        public string Factor_18_kt { get; set; }

        [StringLength(50)]
        public string Factor_14_kt { get; set; }

        [StringLength(50)]
        public string Factor_12_kt { get; set; }

        [StringLength(50)]
        public string Factor_10_kt { get; set; }

        [StringLength(50)]
        public string Factor_8_kt { get; set; }

        [StringLength(255)]
        public string Comentario_adicional { get; set; }

        [StringLength(150)]
        public string Alta_por { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_alta { get; set; }

        [StringLength(10)]
        public string p1 { get; set; }

        [StringLength(10)]
        public string p2 { get; set; }

        [StringLength(10)]
        public string p3 { get; set; }

        [StringLength(10)]
        public string p4 { get; set; }

        [StringLength(10)]
        public string p5 { get; set; }

        [StringLength(10)]
        public string p6 { get; set; }

        [StringLength(10)]
        public string p7 { get; set; }

        [StringLength(10)]
        public string ad1 { get; set; }

        [StringLength(10)]
        public string ad2 { get; set; }

        [StringLength(10)]
        public string ad3 { get; set; }

        [StringLength(10)]
        public string ad4 { get; set; }

        [StringLength(10)]
        public string ad5 { get; set; }

        [StringLength(10)]
        public string ad6 { get; set; }

        [StringLength(10)]
        public string ad7 { get; set; }
    }
}
