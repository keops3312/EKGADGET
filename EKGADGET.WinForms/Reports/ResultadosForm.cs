

namespace EKGADGET.WinForms.Views
{

    #region Libraries (librerias)
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Windows.Forms;
    using CrystalDecisions.Shared;
    using DevComponents.DotNetBar;
    using EKGADGET.WinForms.Classes;
    using EKGADGET.WinForms.Reports; 
    #endregion
    public partial class ResultadosForm : DevComponents.DotNetBar.Office2007Form
    {

        #region Properties (propiedades)
        SaldosGadget saldosGadget;

        #endregion

        #region Attributes (atributos)
        public string sucursal;
        public string marca;
        public string empresa;
        public string objetivoMensual;
        public string objetivoSemanalJef;
        public string mesOperativo;
        public string objetivoSemanalCajero;
        public string anoOperativo;
        public string diasOperativos;
        public string totalHoy;
        public string diasRestantes;
        public string racha;
        public string jefe;
        public string direccion;
        public string cHoy;
        public string aSemana;
        public string cSemana;
        public string acumuladoHoy;
        public string prestamosHoy;
        public DataTable prestamoTipo;
        public string archivo;
        #endregion

        #region Methods (Metodos)
        public ResultadosForm()
        {
            saldosGadget = new SaldosGadget();
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }
        #endregion

        #region Events (Eventos)
        private void ResultadosForm_Load(object sender, EventArgs e)
        {
            prestamoTipo.TableName = "Prestamos";

            dataSetPrestamos1.Tables.Remove("Prestamos");
            dataSetPrestamos1.Tables.Add(prestamoTipo);
            rptGadget ob = new rptGadget();
            ob.SetDataSource(dataSetPrestamos1);
            ob.SetParameterValue("sucursal", sucursal);
            ob.SetParameterValue("marca", marca);
            ob.SetParameterValue("empresa", empresa);
            ob.SetParameterValue("objetivoMensual", objetivoMensual);
            ob.SetParameterValue("objetivoSemanalJef", objetivoSemanalJef);
            ob.SetParameterValue("mesOperativo", mesOperativo);
            ob.SetParameterValue("objetivoSemanalCajero", objetivoSemanalCajero);
            ob.SetParameterValue("anoOperativo", anoOperativo);
            ob.SetParameterValue("diasOperativos", diasOperativos);
            ob.SetParameterValue("totalHoy", totalHoy);
            ob.SetParameterValue("diasRestantes", diasRestantes);
            ob.SetParameterValue("racha", racha);
            ob.SetParameterValue("direccion", direccion);
            ob.SetParameterValue("jefe", jefe);
            ob.SetParameterValue("cHoy", cHoy);
            ob.SetParameterValue("aSemana", aSemana);
            ob.SetParameterValue("cSemana", cSemana);
            ob.SetParameterValue("prestamosHoy", prestamosHoy);
            ob.SetParameterValue("acumuladoHoy", acumuladoHoy);

            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();


            //exportar a pdf para poder enviar
            //Autoguardamos el documento en PDF en la ruta que corresponde

            CrystalDecisions.Shared.ExportOptions CrExportOptions;
            DiskFileDestinationOptions CrDiskFileDestinationOptions = new DiskFileDestinationOptions();
            PdfRtfWordFormatOptions CrFormatTypeOptions = new PdfRtfWordFormatOptions();

            archivo = "C:/SEMP2013/EKGADGET/misReportes/" + DateTime.Now.ToString("ddMMMyyyyHH_mm") + ".pdf";

            CrDiskFileDestinationOptions.DiskFileName = archivo;
            CrExportOptions = ob.ExportOptions;
            {
                CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions;
                CrExportOptions.FormatOptions = CrFormatTypeOptions;
            }
            ob.Export();

        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            DialogResult dialogResult = MessageBoxEx.Show(
                "¿DESEAS ENVIAR REPORTE EN ESTE MOMENTO?", "EKGADGET",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                ////ENVIAMOS LOS SALDOS AL CORREO
                backgroundWorker1.RunWorkerAsync();
              

            }
        }
        #endregion

        #region BackGroundWorkers (Hilos )
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //ENVIAMOS AL CORREO     
            saldosGadget.EnviarReporte(sucursal, archivo);
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            circularProgress1.Visible = true;
            circularProgress1.IsRunning = true;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

            MessageBoxEx.Show(
                "Correo enviado con Exito", "EKGADGET",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            circularProgress1.Visible = false;
            circularProgress1.IsRunning = false;
        }
        #endregion


    }
}
