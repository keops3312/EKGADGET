namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstatusApartado")]
    public partial class EstatusApartado
    {
        [Key]
        public int EstatusId { get; set; }

        [StringLength(50)]
        public string Estatus { get; set; }
    }
}
