
namespace EKGADGET.WinForms
{
    #region Libraries (librerias)
    using System;
    using System.Data;
    using System.IO;
    using System.Linq;
    using EDsemp.Classes;
    using EKGADGET.WinForms.Context;
    using MySql.Data.MySqlClient; 
    #endregion



    public class DatosGadget
    {
        #region Properties (Propiedades)
        private SQLContext db;
        private DataTable totales;
        #endregion

        #region Attributes (Atributos)
        public string ano; 
        public string mes; 
        public string fecha;            
        public string miSucursal; 
        public string empresa;
        public string localidad;
        public DateTime inicio,fin,medio,fechafin,fechaInicio;
        public string logo;
        //cuantos domingo han pasado para restar esos dias
        int diasPasado = 0;
        #endregion

        #region Methods (Metodos)


        //2. BUSCO EL RANGO
        public void Rango()
        {

            int anoF, mesF, diaF;
            string mes = "", dia = "";
            string iniciof, finF, hoyF;
            anoF = DateTime.Now.Year;
            mesF = DateTime.Now.Month;
            diaF = DateTime.DaysInMonth(anoF, mesF);

            if (mesF < 10)
            {
                mes = "0" + mesF.ToString();
            }
            else
            {

                mes = mesF.ToString();
            }



            if (DateTime.Now.Day < 10)
            {
                dia = "0" + DateTime.Now.Day;
            }
            else
            {
                dia = DateTime.Now.Day.ToString();
            }




            iniciof = anoF + "-" + mes + "-" + "01";

            finF = anoF + "-" + mes + "-" + diaF;

            hoyF = anoF + "-" + mes + "-" + dia;


            inicio = Convert.ToDateTime(iniciof);
            fin = Convert.ToDateTime(finF);
            medio = Convert.ToDateTime(hoyF);

        }

        public string[] Semana(string fecha)
        {
            string[] resultado = new string[3];

            //LA FECHA BASE 
            DateTime Inicial = Convert.ToDateTime(fecha);
            DateTime fecha_lunes;
            DateTime fecha_domingo = Convert.ToDateTime(fecha);
            int MES_INICIO;
            int MES_FINAL;
            //DIA DE LA SEMANA
            int diaDeLaSemana = ((int)Inicial.DayOfWeek);
            int ano = Inicial.Year;
            int mesActual = Inicial.Month;
            int diasEnMes = DateTime.DaysInMonth(ano, mesActual);
            //MES CON CERO
            string mesCadena = mesActual.ToString();
            if (mesActual < 10) { mesCadena = "0" + mesActual; }
            //MI FECHA FINAL E INICIAL DEL MES
            DateTime fecha_dia_final = Convert.ToDateTime(ano + "-" + mesCadena + "-" + diasEnMes);


            fechafin = Convert.ToDateTime((ano-1) + "-" + mesCadena + "-" + diasEnMes); ;//para localizar en el mysql del año anterior
            fechaInicio = Convert.ToDateTime((ano - 1) + "-" + mesCadena + "-01"); ;//para localizar en el mysql del año anterior



            DateTime fecha_dia_Inicial = Convert.ToDateTime(ano + "-" + mesCadena + "-01");
            int resta = 0, suma = 0;
            //FECHA INICIAL
            if (Convert.ToInt32(diaDeLaSemana) == 1)//ES LUNES?
            {
                fecha_lunes = Inicial;
            }
            else
            {
                resta = Convert.ToInt32(diaDeLaSemana) - 1;//dias que restare para llegar al lunes
                fecha_lunes = Inicial.AddDays(-resta);
            }
            MES_INICIO = fecha_lunes.Month;
            if (MES_INICIO == mesActual && Convert.ToInt32(Convert.ToDateTime(fecha_lunes).DayOfWeek.ToString("d")) == 1)
            {
            }
            else
            {
                fecha_lunes = fecha_lunes.AddDays(1);
            }
            if (fecha_lunes.Month < mesActual)
            {
                fecha_lunes = fecha_dia_Inicial;
            }
            //FECHA FINAL
            if (Convert.ToInt32(diaDeLaSemana) == 0)// ES DOMINGO?
            {
                fecha_domingo = DateTime.Parse(fecha);
            }
            else
            {
                suma = 7 - Convert.ToInt32(diaDeLaSemana);//seran dias que sumare para llegar a domindngo
                fecha_domingo = Inicial.AddDays(suma);
            }
            MES_FINAL = fecha_domingo.Month;
            if (MES_FINAL == mesActual && Convert.ToInt32(Convert.ToDateTime(fecha_domingo).DayOfWeek.ToString("d")) == 0 && fecha_domingo > fecha_lunes)
            {

            }
            else
            {
                fecha_domingo = fecha_domingo.AddDays(suma);
            }
            if (fecha_domingo == fecha_lunes) //se entiende que domingo es igual a 7 y entonces sumo
            {
                fecha_domingo = fecha_domingo.AddDays(6);

            }
            if (fecha_domingo.Month != mesActual)
            {
                fecha_domingo = fecha_dia_final;
            }
            if (fecha_lunes > fecha_domingo)
            {
                fecha_lunes = fecha_domingo;
            }


            while (fecha_dia_Inicial  <= Inicial)
            {
                if (((int)fecha_dia_Inicial.DayOfWeek) != 0)
                {
                    diasPasado += 1;
                }
                fecha_dia_Inicial=fecha_dia_Inicial.AddDays(1); 
            } 
         


            resultado[0] = fecha_lunes.ToString();
            resultado[1] = fecha_domingo.ToString();
            resultado[2] = diasPasado.ToString();
            return resultado;


        }



        //1. CARGO DATOS GENERALES
        public void datosGadget()
        {
            db = new SQLContext();
            var sucursal = db.Localidades.Where(r => r.impresora == "RAIZ").First();

            localidad = sucursal.LOCALIDAD;
            ano = "Año: " + DateTime.Now.Year;
            mes = "Mes: " + DateTime.Now.ToString("MMMM");
            fecha = "Fecha: " + DateTime.Now.ToString(string.Format("dddd{2} dd {2}{0} MMMM {2}{1} yyyy", "De", "Del"," ")); 
            miSucursal = "Sucursal: \n" + sucursal.Nombre_Sucursal;
            empresa = "Empresa: " + sucursal.Empresa;
            logo = sucursal.Logotipo;


        }

        

        public DataTable Result(string dateStart, string dateEnd, string hoy, string InicioSemana, string FinSemana)
        {

            totales = new DataTable();
            totales.Columns.Add();
            totales.Columns.Add();
            totales.Columns.Add();
            totales.Columns.Add();
            totales.Columns.Add();
            totales.Columns.Add();

            DateTime dt = DateTime.Parse(dateStart);
            DateTime dt2 = DateTime.Parse(dateEnd);
            DateTime dt3 = DateTime.Parse(hoy);

            DateTime dt4 = DateTime.Parse(InicioSemana);
            DateTime dt5 = DateTime.Parse(FinSemana);


            decimal suma = 0;
            int total = 0;
            decimal cHoy = 0;
            int totalHoy = 0;
            decimal cHoyS = 0;
            int totalHoyS = 0;

            var contratos =db.contratos.Where(p => p.Status != "CANCELADO" &&
                               p.FechaCons >= dt
                               && p.FechaCons <= dt2)
                                .ToList();

            if (contratos.Count >0)
            {

                suma = db.contratos.Where(p => p.Status != "CANCELADO" &&
                                   p.FechaCons >= dt
                                   && p.FechaCons <= dt2)
                                    .Sum(p => p.Prestamo);

                total = db.contratos.Count(p => p.Status != "CANCELADO" &&
                                   p.FechaCons >= dt
                                   && p.FechaCons <= dt2);

            }




            var contratosHoy = db.contratos.Where(p => p.Status != "CANCELADO" &&
                               p.FechaCons == dt3)
                               .ToList();
           

            if (contratosHoy.Count > 0)
            {
                 cHoy = db.contratos.Where(p => p.Status != "CANCELADO" &&
                                p.FechaCons == dt3
                                )
                               .Sum(p => p.Prestamo);
                totalHoy = db.contratos.Count(p => p.Status != "CANCELADO" &&
                             p.FechaCons == dt3);
            }



            var contratosS = db.contratos.Where(p => p.Status != "CANCELADO" &&
                                p.FechaCons >= dt4
                                && p.FechaCons <= dt5)
                              .ToList();

            if (contratosS.Count > 0)
            {
                 cHoyS = db.contratos.Where(p => p.Status != "CANCELADO" &&
                             p.FechaCons >= dt4
                             && p.FechaCons <= dt5
                             )
                            .Sum(p => p.Prestamo);


               totalHoyS = db.contratos.Count(p => p.Status != "CANCELADO" &&
                                    p.FechaCons >= dt4
                                    && p.FechaCons <= dt5);
            }



           


            totales.Rows.Add(suma, total, cHoy, totalHoy, cHoyS, totalHoyS);




            return totales;
        } 

        public DataTable prestamostipo(string dateStart, string dateEnd)
        {
            DataTable resultados= new DataTable();
            DateTime dt = DateTime.Parse(dateStart);
            DateTime dt2 = DateTime.Parse(dateEnd);
            resultados.Columns.Add();
            resultados.Columns.Add();
            resultados.Columns.Add();
            //prestamos por categoria
            var tipoPrestamos = (from p in db.contratos
                                 where p.Status != "CANCELADO" &&
                                     p.FechaCons >= dt
                                     && p.FechaCons <= dt2
                                 select p.valuacion_tipo).Distinct();
            foreach (var item in tipoPrestamos)
            {
               decimal D = db.contratos.Where(p => p.Status != "CANCELADO" &&
                            p.FechaCons >= dt
                            && p.FechaCons <= dt2 && p.valuacion_tipo==item
                            )
                           .Sum(p => p.Prestamo);


                int C = db.contratos.Count(p => p.Status != "CANCELADO" &&
                                     p.FechaCons >= dt
                                     && p.FechaCons <= dt2 && p.valuacion_tipo == item);

                resultados.Rows.Add(item, C, D);
            }

            
            return resultados;
        }

        public string[] Objetivos(string sucursal,DateTime fecha_final,DateTime dateStart)
        {
            string[] resultado = new string[7];

            string objetivoMensual="";
            string diasOperativos = "";
            string semanalJefe = "";
            string semanalCajero = "";
            string objetivoLogradoAnteriorC = "";
            string objetivoLogradoAnteriorP = "";


            string lineA;
            string lineB;
            string lineC;
            string lineF;

            //aligual que las demas aplicaciones cargaremos nuestra llave al servidor de oficinas para la conexion directa
            string cadena = "C:/SEMP2013/cdb/KeyChar.txt";
            using (StreamReader sr1 = new StreamReader(cadena, true))
            {
               lineA = sr1.ReadLine();
               lineB = sr1.ReadLine();
               lineC = sr1.ReadLine();
               lineF = sr1.ReadLine();

                //ahroa desecrypto la informacion             
                lineA = Encriptar_Desencriptar.DecryptKeyMD5(lineA);
                lineB = Encriptar_Desencriptar.DecryptKeyMD5(lineB);
                lineC = Encriptar_Desencriptar.DecryptKeyMD5(lineC);
                lineF = Encriptar_Desencriptar.DecryptKeyMD5(lineF);
            
            }

        
                MySqlConnectionStringBuilder cnx =
                    new MySqlConnectionStringBuilder();
                cnx.Server = lineA;
                cnx.Database = lineB;
                cnx.UserID = lineC;
                cnx.Password = lineF;

                MySqlConnection myConnection = new MySqlConnection(cnx.ConnectionString);
                myConnection.Open();


             MySqlCommand cmd = new MySqlCommand("SELECT objetivoMes,diasOperaMes, ObjetivoSemanal, ObjetivoSemanalJefe" +
               " from Sucursales where localidad='" + sucursal + "'",myConnection);
               


                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    objetivoMensual = reader[0].ToString();
                    diasOperativos = reader[1].ToString();
                    semanalCajero = reader[2].ToString();
                    semanalJefe = reader[3].ToString();

                }
            myConnection.Close();



            //SELECT * FROM monter_BD_RSsuc.CRM_SEMP_TOTAL where localidad_Nom='prg_1'
            //and fecha_NOM between '2018-03-01'  and '2018-03-31' order by idcrm_semp_total desc;


            myConnection.Open();
            MySqlCommand cmdAnt = new MySqlCommand("SELECT PRESTAMO_C, PRESTAMO_P" +
             " from CRM_SEMP_TOTAL where localidad_NOM='" + sucursal.Trim() + "' and FECHA_NOM between " +
             " '" + dateStart.ToString("yyyy-MM-dd") + "' and " +
             " '" + fecha_final.ToString("yyyy-MM-dd") + "'  " +
             "order by idcrm_semp_total desc limit 1", myConnection);
            MySqlDataReader reader2 = cmdAnt.ExecuteReader();
            while (reader2.Read())
            {
                objetivoLogradoAnteriorC = reader2[0].ToString();
                objetivoLogradoAnteriorP = reader2[1].ToString();
                

            }
            myConnection.Close();



            resultado[0] = objetivoMensual;
            resultado[1] = diasOperativos;
            resultado[2] = semanalJefe;
            resultado[3] = semanalCajero;
            resultado[4] = objetivoLogradoAnteriorC;
            resultado[5] = objetivoLogradoAnteriorP;
            return resultado;


        }

       
        #endregion

    }
}
