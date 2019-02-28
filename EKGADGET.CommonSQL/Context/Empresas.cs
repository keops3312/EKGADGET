namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Empresas
    {
        [StringLength(50)]
        public string NoControl { get; set; }

        [StringLength(255)]
        public string Empresa { get; set; }

        [StringLength(150)]
        public string Giro { get; set; }

        [StringLength(50)]
        public string RFC { get; set; }

        [StringLength(150)]
        public string Marca { get; set; }

        [StringLength(150)]
        public string Calle { get; set; }

        [StringLength(50)]
        public string noext { get; set; }

        [StringLength(50)]
        public string noint { get; set; }

        [StringLength(50)]
        public string cp { get; set; }

        [StringLength(150)]
        public string colonia { get; set; }

        [StringLength(150)]
        public string estado { get; set; }

        [StringLength(150)]
        public string ciudad { get; set; }

        [StringLength(150)]
        public string pais { get; set; }

        [StringLength(50)]
        public string telefono { get; set; }

        [StringLength(150)]
        public string email { get; set; }

        [StringLength(150)]
        public string paginaweb { get; set; }

        [StringLength(150)]
        public string seguro { get; set; }

        [StringLength(150)]
        public string poliza { get; set; }

        public string logotipo { get; set; }

        [StringLength(150)]
        public string representadopor { get; set; }

        [StringLength(50)]
        public string nofolioinicial { get; set; }

        [StringLength(50)]
        public string nofoliofinal { get; set; }

        [StringLength(50)]
        public string noaprobacion { get; set; }

        [StringLength(50)]
        public string vigenciade { get; set; }

        [StringLength(50)]
        public string vigenciafinal { get; set; }

        [StringLength(50)]
        public string serie { get; set; }

        public string cbb { get; set; }

        [StringLength(150)]
        public string altapor { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fechaalta { get; set; }

        [Key]
        public int consec { get; set; }
    }
}
