namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tipos_localidad
    {
        [Key]
        public int no { get; set; }

        [StringLength(150)]
        public string TIPO { get; set; }
    }
}
