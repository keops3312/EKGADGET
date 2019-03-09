using EKGADGET.WinForms.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKGADGET.WinForms.Classes
{
    public class SaldosGadget
    {
        #region Properties (Propiedades)
        private SQLContext db;
        private DataTable totales;
        #endregion

        public string [] Saldos()
        {
            string[] saldo = new string[7];

            var cajas = db.selcaja.ToList();

            foreach (var item in cajas)
            {
                using (var con = new EntityConnection("name=SchoolDBEntities"))
                {
                    con.Open();
                    EntityCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT saldo FROM SchoolDBEntities.Students as st where st.StudentName='Bill'";
                    Dictionary<int, string> dict = new Dictionary<int, string>();
                    using (EntityDataReader rdr = cmd.ExecuteReader(CommandBehavior.SequentialAccess | CommandBehavior.CloseConnection))
                    {
                        while (rdr.Read())
                        {
                            int a = rdr.GetInt32(0);
                            var b = rdr.GetString(1);
                            dict.Add(a, b);
                        }
                    }
                }

            }


            return saldo;
        }


    }
}
