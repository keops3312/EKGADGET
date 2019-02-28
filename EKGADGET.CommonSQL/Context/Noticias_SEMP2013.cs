namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Noticias_SEMP2013
    {
        [Column(TypeName = "text")]
        public string noticia { get; set; }

        [Key]
        public int NO { get; set; }
    }
}
