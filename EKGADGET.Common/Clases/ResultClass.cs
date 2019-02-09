

namespace EKGADGET.Common.Clases
{
    #region Libraries (Librerias)
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    //using System.Data.Sql;
    //using System.Data.SqlClient;
    #endregion

    
    public class ResultClass
    {
        public int ano;
        public int mes;
        public DateTime fecha;

        public SqlConectionContext db = new SqlConectionContext();

        public DataTable datosLocalidad;
        public DataTable datosLocalidadSQL()
        {
            datosLocalidad = new DataTable();

            var localidad = db.localidades.Where(p => p.impresora == "RAIZ").FirstOrDefault();

            //Ahora Buscamos el Nombre de la Localidad Por Completo
            var LocalidadMySql =;

            ano = DateTime.Now.Year;

            mes = DateTime.Now.Month;

            fecha = DateTime.Now;

            //Aqui vamos a Agregar unas columnas con los datos para despues recolectarlos desde la vista

            return datosLocalidad;
        }
        
    }
}
