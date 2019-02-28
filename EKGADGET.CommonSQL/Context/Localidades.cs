namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Localidades
    {
        [Key]
        public int No { get; set; }

        [StringLength(50)]
        public string LOCALIDAD { get; set; }

        [Column("Nombre Sucursal")]
        [StringLength(150)]
        public string Nombre_Sucursal { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FECHAALTA { get; set; }

        [StringLength(150)]
        public string CONCEPTO { get; set; }

        [StringLength(150)]
        public string ENCARGADO { get; set; }

        [StringLength(255)]
        public string DIRECCION { get; set; }

        [StringLength(50)]
        public string TELEFONO { get; set; }

        [StringLength(100)]
        public string CALLE { get; set; }

        [StringLength(100)]
        public string COLONIA { get; set; }

        [Column("NO int")]
        [StringLength(50)]
        public string NO_int { get; set; }

        [Column("NO ext")]
        [StringLength(50)]
        public string NO_ext { get; set; }

        [StringLength(50)]
        public string CP { get; set; }

        [StringLength(100)]
        public string Ciudad { get; set; }

        [StringLength(100)]
        public string Estado { get; set; }

        [StringLength(50)]
        public string Pais { get; set; }

        [StringLength(150)]
        public string email { get; set; }

        [Column("Tel adicional")]
        [StringLength(50)]
        public string Tel_adicional { get; set; }

        [StringLength(50)]
        public string Bomberos { get; set; }

        [Column("Seguridad Publica")]
        [StringLength(50)]
        public string Seguridad_Publica { get; set; }

        [StringLength(50)]
        public string Marca { get; set; }

        [StringLength(50)]
        public string Empresa { get; set; }

        public string Logotipo { get; set; }

        [StringLength(50)]
        public string Proteccioncivil { get; set; }

        [StringLength(50)]
        public string XXX { get; set; }

        [Column(TypeName = "money")]
        public decimal? objetivoMEs { get; set; }

        [StringLength(10)]
        public string formato { get; set; }

        [Column(TypeName = "text")]
        public string CAS { get; set; }

        [StringLength(50)]
        public string lugar_conta { get; set; }

        public string impresora { get; set; }

        public string contador { get; set; }

        public string copia { get; set; }

        [StringLength(255)]
        public string BD { get; set; }

        [StringLength(255)]
        public string central { get; set; }

        [StringLength(255)]
        public string uno { get; set; }

        public int? codigo { get; set; }

        public int? remformato { get; set; }

        public int? NOTADEPAGO { get; set; }

        public int? HABILITADO { get; set; }

        public TimeSpan? Hora { get; set; }
    }
}
