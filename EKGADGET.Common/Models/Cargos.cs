using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKGADGET.Common.Models
{
    public class Cargos
    {
        [Key]
        public int IdCargos { get; set; }
        public string Cargo { get; set; }

        public DateTime Alta { get; set; }

        public string Operador { get; set; }

        public string ActInac { get; set; }


    }
}
