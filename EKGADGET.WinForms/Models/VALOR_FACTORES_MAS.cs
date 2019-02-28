namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VALOR_FACTORES_MAS
    {
        [Key]
        public int No_Factor { get; set; }

        [StringLength(150)]
        public string Nombre_Factor { get; set; }

        [StringLength(50)]
        public string Porcentaje_a_considerar { get; set; }

        [StringLength(50)]
        public string Estatus_del_Factor { get; set; }
    }
}
