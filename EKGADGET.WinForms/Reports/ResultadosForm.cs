using EKGADGET.WinForms.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EKGADGET.WinForms.Views
{
    public partial class ResultadosForm : DevComponents.DotNetBar.Office2007Form
    {

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
        public ResultadosForm()
        {
            InitializeComponent();
        }

        private void ResultadosForm_Load(object sender, EventArgs e)
        {

            rptGadget ob = new rptGadget();
            ob.SetParameterValue("sucursal", sucursal);
            ob.SetParameterValue("marca", marca);
            ob.SetParameterValue("empresa", empresa);
            ob.SetParameterValue("objetivoMensual", objetivoMensual);
            ob.SetParameterValue("objetivoSemanalJef", objetivoSemanalJef);
            ob.SetParameterValue("mesOperativo", mesOperativo);
            ob.SetParameterValue("objetivoSemanalCajero", objetivoSemanalCajero);
            ob.SetParameterValue("anoOperativo", anoOperativo);
            ob.SetParameterValue("diasOperativos", diasOperativos);
            ob.SetParameterValue("totalHoy",totalHoy);
            ob.SetParameterValue("diasRestantes", diasRestantes);
            ob.SetParameterValue("racha", racha);
            ob.SetParameterValue("direccion", direccion);
            ob.SetParameterValue("jefe", jefe);
            ob.SetParameterValue("cHoy", cHoy);
            ob.SetParameterValue("aSemana",aSemana);
            ob.SetParameterValue("cSemana", cSemana);
            ob.SetParameterValue("prestamosHoy", prestamosHoy);
            ob.SetParameterValue("acumuladoHoy", acumuladoHoy);
            crystalReportViewer1.ReportSource = ob;
            crystalReportViewer1.Refresh();
        }
    }
}
