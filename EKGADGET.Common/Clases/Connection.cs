using EDsemp.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EKGADGET.Common.Clases
{
    public class Connection
    {
        private string sqlcnx;
        private string Mysqlcnx;
        private string server;
        private string dataBase;
        private string usr;
        private string psw;

        public string CheckDataConection()
        {


            //aligual que las demas aplicaciones cargaremos nuestra llave al servidor de oficinas para la conexion directa
            string cadena = "C:/SEMP2013/EKPolizaGastos/EKPolizaGastos/cdb.txt";

            using (StreamReader sr1 = new StreamReader(cadena, true))
            {

                string lineA = sr1.ReadLine();
                string lineB = sr1.ReadLine();
                string lineC = sr1.ReadLine();
                string lineF = sr1.ReadLine();

                //ahroa desecrypto la informacion             
                server = Encriptar_Desencriptar.DecryptKeyMD5(lineA);
                dataBase = Encriptar_Desencriptar.DecryptKeyMD5(lineB);
                usr = Encriptar_Desencriptar.DecryptKeyMD5(lineC);
                psw = Encriptar_Desencriptar.DecryptKeyMD5(lineF);
                //ahora realizo la conexion par amostrar las sucursales


                sqlcnx = "Data Source=" + server + " ;" +
                    "Initial Catalog=" + dataBase + ";" +
                    "Persist Security Info=True;" +
                    "User ID=" + usr + ";Password=" + psw + "";
                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = sqlcnx;
                conexion.Open();

                if (true)
                {
                    return sqlcnx;
                }




            }




        }

        public string CheckDataConectionMySQL()
        {
            //aligual que las demas aplicaciones cargaremos nuestra llave al servidor de oficinas para la conexion directa
            string cadena = "C:/SEMP2013/EKPolizaGastos/EKPolizaGastos/KeyChar.txt";

            using (StreamReader sr1 = new StreamReader(cadena, true))
            {

                string lineA = sr1.ReadLine();
                string lineB = sr1.ReadLine();
                string lineC = sr1.ReadLine();
                string lineF = sr1.ReadLine();

                //ahroa desecrypto la informacion             
                server = Encriptar_Desencriptar.DecryptKeyMD5(lineA);
                dataBase = Encriptar_Desencriptar.DecryptKeyMD5(lineB);
                usr = Encriptar_Desencriptar.DecryptKeyMD5(lineC);
                psw = Encriptar_Desencriptar.DecryptKeyMD5(lineF);
                //ahora realizo la conexion par amostrar las sucursales


                sqlcnx = "Data Source=" + server + " ;" +
                    "Initial Catalog=" + dataBase + ";" +
                    "Persist Security Info=True;" +
                    "User ID=" + usr + ";Password=" + psw + "";
                MySqlConnection conexion = new MySqlConnection();
                conexion.ConnectionString = Mysqlcnx;
                conexion.Open();

                if (true)
                {
                    return Mysqlcnx;
                }




            }


        }
    }
}
