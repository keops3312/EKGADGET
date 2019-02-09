using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EKGADGET.Common.Models
{
    public class Localidades
    {

        [Key]
        public int No { get; set; }
        public string LOCALIDAD { get; set; }
        public string Logotipo { get; set; }
        public string  CONCEPTO { get; set; }
        public string ENCARGADO { get; set; }
        public string email { get; set; }
        public string Marca { get; set; }
        public string Empresa { get; set; }
        public string XXX { get; set; }
        public string impresora { get; set; }
        public string central { get; set; }
        public string uno { get; set; }



    }
}
