namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class paises
    {
        [Key]
        public int no { get; set; }

        [StringLength(50)]
        public string pais { get; set; }
    }
}
