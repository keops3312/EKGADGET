
namespace EKGADGET.Backend.Models
{
    using EKGADGET.Domain.Models;
    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<EKGADGET.Common.Models.Sucursales> sucursales { get; set; }


        public System.Data.Entity.DbSet<EKGADGET.Common.Models.Accounts> accounts { get; set; }


        public System.Data.Entity.DbSet<EKGADGET.Common.Models.Cargos> cargos { get; set; }


        public System.Data.Entity.DbSet<EKGADGET.Common.Models.Usuarios> usuarios { get; set; }
    }
}