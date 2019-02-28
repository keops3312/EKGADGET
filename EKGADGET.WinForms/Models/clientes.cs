namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class clientes
    {
        [StringLength(255)]
        public string idClientes { get; set; }

        [StringLength(255)]
        public string Nombre { get; set; }

        [StringLength(255)]
        public string Calle { get; set; }

        [StringLength(255)]
        public string Numero { get; set; }

        [StringLength(255)]
        public string Colonia { get; set; }

        [StringLength(255)]
        public string CP { get; set; }

        [StringLength(255)]
        public string IFE { get; set; }

        [StringLength(255)]
        public string Lada { get; set; }

        [StringLength(255)]
        public string Tel { get; set; }

        [StringLength(255)]
        public string Puntos { get; set; }

        [StringLength(50)]
        public string Nombres { get; set; }

        [StringLength(50)]
        public string noext { get; set; }

        [StringLength(50)]
        public string noint { get; set; }

        [StringLength(50)]
        public string estado { get; set; }

        [StringLength(50)]
        public string ciudad { get; set; }

        [StringLength(50)]
        public string pais { get; set; }

        [StringLength(50)]
        public string celular { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string sitio { get; set; }

        [StringLength(50)]
        public string rfc { get; set; }

        public string contactoalt { get; set; }

        [StringLength(50)]
        public string Apaterno { get; set; }

        [StringLength(50)]
        public string Amaterno { get; set; }

        [StringLength(50)]
        public string tipo { get; set; }

        [StringLength(150)]
        public string altapor { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha { get; set; }

        [Key]
        public int consec { get; set; }

        public string id1 { get; set; }

        public string id2 { get; set; }

        public int? tipocliente { get; set; }

        [StringLength(255)]
        public string nombre2 { get; set; }

        public decimal? puntos_cliente { get; set; }

        public decimal? PUNTOS_USADOS { get; set; }

        public int? puntos_aumento { get; set; }

        public int? puntos_interes { get; set; }

        public int? puntos_venta { get; set; }
    }
}
