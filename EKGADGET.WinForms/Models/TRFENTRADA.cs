namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRFENTRADA")]
    public partial class TRFENTRADA
    {
        [Key]
        public int no { get; set; }

        [StringLength(255)]
        public string envia { get; set; }

        [StringLength(50)]
        public string no_suc { get; set; }

        [StringLength(255)]
        public string remitente { get; set; }

        [StringLength(50)]
        public string telefono { get; set; }

        [Column(TypeName = "text")]
        public string direccion { get; set; }

        [StringLength(255)]
        public string sucursal { get; set; }

        [StringLength(255)]
        public string correo { get; set; }

        [StringLength(255)]
        public string empresa { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha_envio { get; set; }

        [StringLength(50)]
        public string hora { get; set; }

        [StringLength(255)]
        public string noserieC { get; set; }

        [StringLength(50)]
        public string no_suc2 { get; set; }

        [StringLength(255)]
        public string destinatario { get; set; }

        [StringLength(50)]
        public string telefono2 { get; set; }

        [Column(TypeName = "text")]
        public string direccion2 { get; set; }

        [StringLength(255)]
        public string sucursal2 { get; set; }

        [StringLength(255)]
        public string empresa2 { get; set; }

        [StringLength(255)]
        public string correo2 { get; set; }

        [StringLength(255)]
        public string transporta { get; set; }

        [StringLength(255)]
        public string autoriza { get; set; }

        [Column(TypeName = "text")]
        public string comentarios { get; set; }

        [StringLength(255)]
        public string status_TRF { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha_cierre { get; set; }

        [StringLength(255)]
        public string condicones_entrega { get; set; }

        [StringLength(255)]
        public string notificado_remitente { get; set; }

        [StringLength(255)]
        public string suc_recibe { get; set; }

        [StringLength(255)]
        public string quien_recibe { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? cerro_fecha { get; set; }

        [StringLength(255)]
        public string codigo_recibo { get; set; }

        [Column(TypeName = "text")]
        public string observaciones { get; set; }
    }
}
