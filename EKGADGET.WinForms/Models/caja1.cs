namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class caja1
    {
        [StringLength(255)]
        public string plazo { get; set; }

        public double? CONTRATO { get; set; }

        [StringLength(255)]
        public string BOLSA { get; set; }

        public DateTime? FECHA { get; set; }

        [StringLength(255)]
        public string DESCRIPCION { get; set; }

        public double? Kt { get; set; }

        public double? Grs { get; set; }

        [Column("##")]
        [StringLength(255)]
        public string C__ { get; set; }

        [StringLength(255)]
        public string Inventario { get; set; }

        public double? Costo { get; set; }

        [Column("PRECIO 1")]
        public double? PRECIO_1 { get; set; }

        [StringLength(255)]
        public string Referencia { get; set; }

        [Column("PRECIO 2")]
        [StringLength(255)]
        public string PRECIO_2 { get; set; }

        [Column("PRECIO 3")]
        [StringLength(255)]
        public string PRECIO_3 { get; set; }

        [StringLength(255)]
        public string Venta { get; set; }

        [StringLength(255)]
        public string Factura { get; set; }

        [StringLength(255)]
        public string Utilidad { get; set; }

        public double? Prestamo { get; set; }

        [StringLength(50)]
        public string st { get; set; }

        public int? desc { get; set; }

        public int? kil { get; set; }

        public int? pes { get; set; }

        public int? total { get; set; }

        public int? agregado { get; set; }

        [Key]
        [Column("int")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int _int { get; set; }
    }
}
