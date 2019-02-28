namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INFS
    {
        [StringLength(255)]
        public string localidad { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha { get; set; }

        public decimal? prestamos_n { get; set; }

        public decimal? prestamos_r { get; set; }

        public int? cantidad_n { get; set; }

        public int? cantidad_ref { get; set; }

        public decimal? n_pago_d { get; set; }

        public decimal? n_pago_r { get; set; }

        public int? cantidad_d { get; set; }

        public int? cantidad_r { get; set; }

        public decimal? rem_v { get; set; }

        public int? cantidad_v { get; set; }

        public decimal? depositos { get; set; }

        public decimal? retiros { get; set; }

        public int? dep_cantidad { get; set; }

        public int? ret_cantidad { get; set; }

        public decimal? obsequio { get; set; }

        public int? cantidad_obs { get; set; }

        public decimal? saldo_caja_in { get; set; }

        public decimal? saldo_caja_fin { get; set; }

        [StringLength(255)]
        public string caja_loc { get; set; }

        [StringLength(255)]
        public string usuario_cj { get; set; }

        public decimal? cancel_p { get; set; }

        public int? cantidad_p_c { get; set; }

        public decimal? cancel_np { get; set; }

        public int? cantidad_np_c { get; set; }

        public decimal? cancel_rem { get; set; }

        public int? cantidad_r_c { get; set; }

        public decimal? p_autos { get; set; }

        public int? c_autos { get; set; }

        public decimal? p_joyeria { get; set; }

        public int? c_joyeria { get; set; }

        public decimal? p_elect { get; set; }

        public int? c_elect { get; set; }

        public decimal? p_otr { get; set; }

        public int? c_otr { get; set; }

        public decimal? abono { get; set; }

        public int? c_abono { get; set; }

        public int? total_trans { get; set; }

        public int id { get; set; }

        public decimal? reimp { get; set; }

        public int? cimp { get; set; }
    }
}
