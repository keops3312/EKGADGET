

namespace EKGADGET.Common.Models
{

    using System;
    using System.ComponentModel.DataAnnotations;
    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }

        public string Usuario { get; set; }
       
        public DateTime Alta { get; set; }

        public string Operador { get; set; }


        public string ActInac { get; set; }

        public string Sexo { get; set; }

        public string Foto { get; set; }



        public int IdCargo { get; set; }



    }
}
