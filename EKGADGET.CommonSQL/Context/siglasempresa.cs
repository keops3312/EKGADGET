namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("siglasempresa")]
    public partial class siglasempresa
    {
        [Key]
        public int no { get; set; }

        [StringLength(150)]
        public string empresa { get; set; }

        [Column("siglasempresa")]
        [StringLength(150)]
        public string siglasempresa1 { get; set; }
    }
}
