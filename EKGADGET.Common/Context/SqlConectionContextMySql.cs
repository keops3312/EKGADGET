using EKGADGET.Common.ModelsMysql;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKGADGET.Common.Context
{
    public class SqlConectionContextMySql:DbContext
    {

        static SqlConectionContextMySql()
        {
            Database.SetInitializer<SqlConectionContextMySql>(null);
        }

        public SqlConectionContextMySql()
            : base("SqlConectionContextMySql")
        {
        }


        public DbSet<Localidades> localidades { get; set; }
    }
}
