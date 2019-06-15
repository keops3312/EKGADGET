
namespace EKGADGET.Domain.Models
{
    using EKGADGET.Common.Models;
    using System.Data.Entity;

    public class DataContext:DbContext
    {

        public DataContext() : base("name=EKGADGET.CONNECTION")
        {

        }

        public DbSet<Sucursales> sucursales { get; set; }

        public DbSet<Usuarios> usuarios { get; set; }

        public DbSet<Cargos> cargos { get; set; }

        public DbSet<Accounts> accounts { get; set; }
    }
}
