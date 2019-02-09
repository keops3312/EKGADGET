using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKGADGET.Common.ModelsMysql
{
    public class Localidades
    {
        [Key]
        public int No { get; set; }
        public string LOCALIDAD { get; set; }
        public string NombreSucursal { get; set; }
        public DateTime FECHAALTA { get; set; }
        public string CONCEPTO { get; set; }
        public string ENCARGADO { get; set; }
        public string DIRECCION { get; set; }
        public string EMAIL { get; set; }
        public string MARCA { get; set; }
        public string EMPRESA { get; set; }
        public string XXX { get; set; }
        public string OBJETIVOMES { get; set; }
        public string BD { get; set; }
        public string CENTRAL { get; set; }
        public string dias_opera_mes { get; set; }



    }
}
