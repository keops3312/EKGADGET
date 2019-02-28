namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("promocionesregalo")]
    public partial class promocionesregalo
    {
        [Key]
        public int no { get; set; }

        [StringLength(255)]
        public string nombre { get; set; }

        [StringLength(50)]
        public string activa { get; set; }

        [Column(TypeName = "text")]
        public string descripcion { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? vigencia_i { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? vigenci_f { get; set; }
    }
}
