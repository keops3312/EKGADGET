namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Envios
    {
        [StringLength(255)]
        public string correo_enviar { get; set; }

        [StringLength(255)]
        public string tipo_operacion { get; set; }

        [Key]
        [Column("int")]
        public int _int { get; set; }
    }
}
