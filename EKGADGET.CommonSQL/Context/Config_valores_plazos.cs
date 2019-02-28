namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Config_valores_plazos
    {
        [Key]
        public int no { get; set; }

        [StringLength(255)]
        public string nombre_calendario { get; set; }

        [StringLength(255)]
        public string valor_en_cantidad { get; set; }

        [StringLength(255)]
        public string sigla_asignada { get; set; }

        [StringLength(255)]
        public string variable { get; set; }
    }
}
