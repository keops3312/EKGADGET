

namespace EKGADGET.Common.Models
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Accounts
    {

        [Key]
        //[JsonProperty(PropertyName = "IdAccounts")]
        public int IdAccounts { get; set; }

        public string Username { get; set; }


        public string Password { get; set; }


        public string Roles { get; set; }


        public DateTime Alta { get; set; }

        public int IdUsuario { get; set; }

        public int localidadId { get; set; }
    }
}
