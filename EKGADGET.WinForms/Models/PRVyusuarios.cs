namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRVyusuarios
    {
        [Key]
        public int no { get; set; }

        [StringLength(50)]
        public string TIPO_USUARIO { get; set; }

        [Column("NO OPERADOR")]
        [StringLength(50)]
        public string NO_OPERADOR { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        [StringLength(50)]
        public string CONTRASEÑA { get; set; }

        [StringLength(50)]
        public string OPERACIONES { get; set; }

        [StringLength(50)]
        public string SISTEMAS { get; set; }

        [StringLength(50)]
        public string CAJAS { get; set; }

        [StringLength(50)]
        public string AUDITORIA { get; set; }

        [StringLength(50)]
        public string CONTABILIDAD { get; set; }

        [StringLength(50)]
        public string ADMINISTRACION { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FECHAALTA { get; set; }

        [StringLength(150)]
        public string ALTAPOR { get; set; }

        [StringLength(50)]
        public string LOCALIDAD { get; set; }

        [StringLength(50)]
        public string BLOQUEADO { get; set; }

        [StringLength(50)]
        public string FECHABLOQUEO { get; set; }

        [StringLength(50)]
        public string HORABLOQUEO { get; set; }

        [StringLength(50)]
        public string CAJA { get; set; }

        public int? DIAS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FECHA_CAMBIO { get; set; }
    }
}
