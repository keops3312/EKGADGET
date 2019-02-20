

namespace EKGADGET.Common.Clases
{
    using EKGADGET.Common.Context;
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
        private int ano;
        private int mes;
        private DateTime fecha;

        private string logotipo;
        private string empresa;
        private string sucursal;
        private int diasOperativos;
        private int diasRestantes;


        public SqlConectionContext db = new SqlConectionContext();
        public SqlConectionContextMySql MySqldb =new SqlConectionContextMySql();

        public DataTable datosLocalidad;
        public DataTable datosResultados;

        public DataTable datosLocalidadSQL()
        {
            datosLocalidad = new DataTable();
            //Aqui vamos a Agregar unas columnas con los datos para despues recolectarlos desde la vista
            datosLocalidad.Columns.Add("Ano");
            datosLocalidad.Columns.Add("Mes");
            datosLocalidad.Columns.Add("Fecha");
            datosLocalidad.Columns.Add("DiasOperativos");
            datosLocalidad.Columns.Add("DiasRestantes");
            datosLocalidad.Columns.Add("Sucursal");
            datosLocalidad.Columns.Add("Empresa");

            var localidad = db.localidades.Where(p => p.impresora == "RAIZ").First();

            //Ahora Buscamos el Nombre de la Localidad Por Completo
            var LocalidadMySql = MySqldb.localidades.Where(p => p.LOCALIDAD == localidad.LOCALIDAD).First(); ;

            ano = DateTime.Now.Year;

            mes = DateTime.Now.Month;

            fecha = DateTime.Now;

            logotipo = localidad.Logotipo;

            diasOperativos = 26;//LocalidadMySql.dias_opera_mes;

            diasRestantes = diasOperativos - 0;

            sucursal =LocalidadMySql.NombreSucursal;

            empresa = LocalidadMySql.EMPRESA;


            //datosLocalidad.Rows.Add(ano,mes,fecha,diasOperativos,diasRestantes,sucursal,empresa, logotipo);
            //DatosDelMySQL

            //Sucursal;
            //Empresa;
            


            return datosLocalidad;
        }


        public DataTable datosResultadosSQL()
        {


            return datosResultados;
        }
        
    }
}
