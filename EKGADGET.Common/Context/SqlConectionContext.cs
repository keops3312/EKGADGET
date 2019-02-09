using EKGADGET.Common.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKGADGET.Common.Clases
{
   
    public class SqlConectionContext: DbContext
    {
        static SqlConectionContext()
        {
            Database.SetInitializer<SqlConectionContext>(null);
        }

        public SqlConectionContext()
            : base("Data Source=.;Initial Catalog=SEMP2013;" +
                  "Persist Security Info=True;User ID=sa;" +
                  "Password=020986;MultipleActiveResultSets=True")
        {
        }

      
        public DbSet<Localidades> localidades { get; set; }

    }

       

}

