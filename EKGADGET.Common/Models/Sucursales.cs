

namespace EKGADGET.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Sucursales
    {
        [Key]
        public int localidadId { get; set; }
        public string localidad { get; set; }
        public string nombreSucursal { get; set; }
        /**/
        public DateTime fechaAlta { get; set; }
        /**/

        public string concepto { get; set; }
        public string encargado { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string calle { get; set; }
        public string colonia { get; set; }
        public string noint { get; set; }
        public string noext { get; set; }
        public string cp { get; set; }
        public string ciudad { get; set; }
        public string estado { get; set; }
        public string pais { get; set; }
        public string email { get; set; }
        public string marca { get; set; }
        public string empresa { get; set; }
        public string xxx { get; set; }
        public string objetivoMes { get; set; }
        public string bd { get; set; }
        public string central { get; set; }
        public string impresora { get; set; }
       
        /**/
        public int TonerEnMano { get; set; }
        public int TonerXrecibir { get; set; }
        public int TonerEnTransito { get; set; }
        public int diasOperaMes { get; set; }
        
        
        /**/
        public string ObjetivoSemanal { get; set; }

        public string ObjetivoSemanalJefe { get; set; }



    }
}
