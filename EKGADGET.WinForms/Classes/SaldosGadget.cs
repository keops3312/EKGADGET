

namespace EKGADGET.WinForms.Classes
{
    #region Libraries (librerias)
    using System;
    using System.Data;
    using System.IO;
    using System.Linq;
    using EDsemp.Classes;
    using EKGADGET.WinForms.Context; 
    #endregion

    public class SaldosGadget
    {
        #region Properties (Propiedades)
        private SQLContext db;
        #endregion

        #region Methods (metodos)
        class misaldo
        {
            public decimal saldo { get; set; }

        }

        public DataTable Saldos()
        {
            db = new SQLContext();
            DataTable resultados = new DataTable();
            resultados.Columns.Add();
            resultados.Columns.Add();

            var cajas = db.selcaja.ToList();

            foreach (var item in cajas)
            {
                var result = db.Database.SqlQuery<misaldo>("SELECT Top(1) saldo FROM " + item.NumCaja + " order by mov desc").ToList();

                // saldos[2] = result[0].saldo.ToString();
                resultados.Rows.Add(item.Caja, result[0].saldo.ToString());

            }


            return resultados;
        }

        public void EnviarSaldos(string sucursal,
            decimal SaldoC1, decimal SaldoC2,
            decimal efectivoC1, decimal efectivoC2, DataTable infoC1, DataTable infoC2, string caja1, string caja2)
        {


            var envios = db.Envios.Where(p => p.tipo_operacion.Contains("saldos")).ToList();
            foreach (var item in envios)
            {
                EnviarCorreo(item.correo_enviar, sucursal,
                SaldoC1, SaldoC2,
                efectivoC1, efectivoC2, infoC1, infoC2, caja1, caja2);
            }




        }

        private void EnviarCorreo(string destinatario, string sucursal,
            decimal SaldoC1, decimal SaldoC2,
            decimal efectivoC1, decimal efectivoC2, DataTable infoC1, DataTable infoC2, string caja1, string caja2)
        {

            var infoLoc = db.Localidades.Where(p => p.impresora == "RAIZ").FirstOrDefault();
            var mailSend = db.CORREO.Where(p => p.no == 1).First();
            //aligual que las demas aplicaciones cargaremos nuestra llave al servidor de oficinas para la conexion directa
            string cadena = "C:/SEMP2013/cdb/KeyChar.txt";
            using (StreamReader sr1 = new StreamReader(cadena, true))
            {
                string lineA = sr1.ReadLine();
                string lineB = sr1.ReadLine();
                string lineC = sr1.ReadLine();
                string lineF = sr1.ReadLine();

                //ahora desecrypto la informacion             
                lineA = Encriptar_Desencriptar.DecryptKeyMD5(lineA);
                lineB = Encriptar_Desencriptar.DecryptKeyMD5(lineB);
                lineC = Encriptar_Desencriptar.DecryptKeyMD5(lineC);
                lineF = Encriptar_Desencriptar.DecryptKeyMD5(lineF);

            }

            /*-------------------------MENSAJE DE CORREO----------------------*/

            //Creamos un nuevo Objeto de mensaje
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            //Direccion de correo electronico a la que queremos enviar el mensaje
            mmsg.To.Add(destinatario);

            //Nota: La propiedad To es una colección que permite enviar el mensaje a más de un destinatario

            //Asunto
            mmsg.Subject = "SALDOS: " + infoLoc.Nombre_Sucursal + " fecha: " + DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            //Direccion de correo electronico que queremos que reciba una copia del mensaje
            // mmsg.Bcc.Add("destinatariocopia@servidordominio.com"); //Opcional

            //Cuerpo del Mensaje
            string c1 = "";
            string c2 = "";
            foreach (DataRow item in infoC1.Rows)
            {
                c1 += "<p>" + item[0].ToString() + " - " + item[1].ToString() + "</p>";
            }
            foreach (DataRow item in infoC2.Rows)
            {
                c2 += "<p>" + item[0].ToString() + " - " + item[1].ToString() + "</p>";
            }
            String BODY = "" +
             "<h2>Saldos de Caja(s): " + infoLoc.Nombre_Sucursal + " </h2>" +
             "<p>---------------------------------------- </p>" +
             "<p>Caja: " + caja1 + "</p>" +
             "<p>Saldo : " + string.Format("{0:C2}", SaldoC1) + "<p>" +
             "<p>--- Vales, cheques, gastos, otros---</p>" +
              c1 +
             "<p>Total : " + string.Format("{0:C2}", efectivoC1) + "<p>" +
             "<p>---------------------------------------- </p>" +
             "<p>Caja: " + caja2 + "</p>" +
             "<p>Saldo : " + string.Format("{0:C2}", SaldoC2) + "<p>" +
             "<p>--- Vales, cheques, gastos, otros---</p>" +
              c2 +
              "<p>---------------------------------------- </p>" +
             "<p>Total : " + string.Format("{0:C2}", efectivoC2) + "<p>" +
             "<p>--------------FIN DE INFORME----------- </p>";

            mmsg.Body = BODY;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true; //Si no queremos que se envíe como HTML

            //Correo electronico desde la que enviamos el mensaje
            mmsg.From = new System.Net.Mail.MailAddress(infoLoc.email);


            /*-------------------------CLIENTE DE CORREO----------------------*/

            //Creamos un objeto de cliente de correo
            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            //Hay que crear las credenciales del correo emisor
            cliente.Credentials =
                new System.Net.NetworkCredential(infoLoc.email, infoLoc.XXX);

            //Lo siguiente es obligatorio si enviamos el mensaje desde Gmail
            int PORT = int.Parse(mailSend.PUERTO);
            cliente.Port = PORT;
            /*
            cliente.EnableSsl = true;
            */

            cliente.Host = mailSend.HOST; //Para Gmail "smtp.gmail.com";


            /*-------------------------ENVIO DE CORREO----------------------*/

            try
            {
                //Enviamos el mensaje      
                cliente.Send(mmsg);
            }
            catch (System.Net.Mail.SmtpException ex)
            {

                //Aquí gestionamos los errores al intentar enviar el correo
                Console.Write(ex.Message);

            }
        }



        public void EnviarReporte(string sucursal, string archivo)
        {
            db = new SQLContext();

            var envios = db.Envios.Where(p => p.tipo_operacion.Contains("saldos")).ToList();
            foreach (var item in envios)
            {
                EnviarCorreoReporte(item.correo_enviar, sucursal, archivo);
            }




        }

        private void EnviarCorreoReporte(string destinatario, string sucursal, string archivo)
        {

            var infoLoc = db.Localidades.Where(p => p.impresora == "RAIZ").FirstOrDefault();
            var mailSend = db.CORREO.Where(p => p.no == 1).First();
            //aligual que las demas aplicaciones cargaremos nuestra llave al servidor de oficinas para la conexion directa
            string cadena = "C:/SEMP2013/cdb/KeyChar.txt";
            using (StreamReader sr1 = new StreamReader(cadena, true))
            {
                string lineA = sr1.ReadLine();
                string lineB = sr1.ReadLine();
                string lineC = sr1.ReadLine();
                string lineF = sr1.ReadLine();

                //ahora desecrypto la informacion             
                lineA = Encriptar_Desencriptar.DecryptKeyMD5(lineA);
                lineB = Encriptar_Desencriptar.DecryptKeyMD5(lineB);
                lineC = Encriptar_Desencriptar.DecryptKeyMD5(lineC);
                lineF = Encriptar_Desencriptar.DecryptKeyMD5(lineF);

            }

            /*-------------------------MENSAJE DE CORREO----------------------*/

            //Creamos un nuevo Objeto de mensaje
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            //Direccion de correo electronico a la que queremos enviar el mensaje
            mmsg.To.Add(destinatario);

            //Nota: La propiedad To es una colección que permite enviar el mensaje a más de un destinatario

            //Asunto
            mmsg.Subject = "Reporte Avance: " + infoLoc.Nombre_Sucursal + " fecha: " + DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;


            //Cuerpo del Mensaje
            mmsg.Attachments.Add(new System.Net.Mail.Attachment(archivo));
            String BODY = "";

            mmsg.Body = BODY;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true; //Si no queremos que se envíe como HTML

            //Correo electronico desde la que enviamos el mensaje
            mmsg.From = new System.Net.Mail.MailAddress(infoLoc.email);


            /*-------------------------CLIENTE DE CORREO----------------------*/

            //Creamos un objeto de cliente de correo
            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            //Hay que crear las credenciales del correo emisor
            cliente.Credentials =
                new System.Net.NetworkCredential(infoLoc.email, infoLoc.XXX);

            //Lo siguiente es obligatorio si enviamos el mensaje desde Gmail
            int PORT = int.Parse(mailSend.PUERTO);
            cliente.Port = PORT;
            /*
            cliente.EnableSsl = true;
            */

            cliente.Host = mailSend.HOST; //Para Gmail "smtp.gmail.com";


            /*-------------------------ENVIO DE CORREO----------------------*/

            try
            {
                //Enviamos el mensaje      
                cliente.Send(mmsg);
            }
            catch (System.Net.Mail.SmtpException ex)
            {

                //Aquí gestionamos los errores al intentar enviar el correo
                Console.Write(ex.Message);

            }
        }

        #endregion

    }
}
