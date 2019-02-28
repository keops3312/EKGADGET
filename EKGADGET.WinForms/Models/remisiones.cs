namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class remisiones
    {
        [StringLength(255)]
        public string NumRemision { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha { get; set; }

        [StringLength(255)]
        public string Cliente { get; set; }

        [StringLength(255)]
        public string Inventario { get; set; }

        [Column(TypeName = "money")]
        public decimal? Precio { get; set; }

        public double? Descuento { get; set; }

        [Column(TypeName = "money")]
        public decimal? Importe { get; set; }

        public int? Cantidad { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        [StringLength(255)]
        public string conceptopromocion { get; set; }

        [StringLength(255)]
        public string noserieart { get; set; }

        [StringLength(255)]
        public string codebar { get; set; }

        [StringLength(255)]
        public string vendio { get; set; }

        [StringLength(255)]
        public string suc { get; set; }

        [StringLength(50)]
        public string status { get; set; }

        [StringLength(50)]
        public string idcliente { get; set; }

        [Column(TypeName = "text")]
        public string comentarios { get; set; }

        [StringLength(50)]
        public string caja { get; set; }

        [StringLength(50)]
        public string tipo_desc { get; set; }

        [StringLength(50)]
        public string tipo_prenda { get; set; }

        [Key]
        public int consec { get; set; }
    }
}
