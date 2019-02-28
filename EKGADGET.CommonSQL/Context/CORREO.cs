namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CORREO")]
    public partial class CORREO
    {
        [StringLength(255)]
        public string HOST { get; set; }

        [StringLength(255)]
        public string PUERTO { get; set; }

        [Key]
        public int no { get; set; }

        [StringLength(255)]
        public string FTP { get; set; }
    }
}
