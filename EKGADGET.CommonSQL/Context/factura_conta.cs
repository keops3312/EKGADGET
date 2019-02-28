namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class factura_conta
    {
        [Key]
        public int no { get; set; }

        [StringLength(255)]
        public string cuenta { get; set; }
    }
}
