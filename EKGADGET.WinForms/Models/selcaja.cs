namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("selcaja")]
    public partial class selcaja
    {
        [StringLength(255)]
        public string Caja { get; set; }

        [StringLength(255)]
        public string Status { get; set; }

        [StringLength(255)]
        public string NumCaja { get; set; }

        [StringLength(255)]
        public string UltimoCont { get; set; }

        [StringLength(255)]
        public string UltimoBolsa { get; set; }

        [StringLength(255)]
        public string CajaAbrev { get; set; }

        [StringLength(255)]
        public string ultfolio { get; set; }

        [StringLength(255)]
        public string pertenecea { get; set; }

        [StringLength(255)]
        public string altapor { get; set; }

        [StringLength(255)]
        public string fechaalta { get; set; }

        [Key]
        public int Consec { get; set; }

        [StringLength(255)]
        public string sucursal { get; set; }

        [StringLength(255)]
        public string foliosNP { get; set; }

        public string impresora { get; set; }

        public int? ocupada { get; set; }

        [StringLength(50)]
        public string folio_apartado { get; set; }

        [StringLength(255)]
        public string opcion_color { get; set; }

        [StringLength(255)]
        public string opcion_font { get; set; }

        [StringLength(255)]
        public string FOLIONP { get; set; }

        [StringLength(255)]
        public string FOLIONR { get; set; }
    }
}
