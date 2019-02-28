namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Niveles_acceso
    {
        [Key]
        public int no { get; set; }

        [StringLength(150)]
        public string Nivel { get; set; }

        [Column(TypeName = "text")]
        public string descripcion { get; set; }
    }
}
