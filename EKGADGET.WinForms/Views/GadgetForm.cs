

namespace EKGADGET.WinForms
{
   

    #region Libraries (Librerias)

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using DevComponents.DotNetBar;
    using EKGADGET.WinForms.Context;

    #endregion
    public partial class GadgetForm : DevComponents.DotNetBar.Office2007Form
    {

        #region Porperties (propiedades)
        private DatosGadget datosGadget;
        private DataTable datosGadgetResultados;
        #endregion

        #region Attributes (atributos)
        private string inicioFecha,finFecha,hoyFecha;
        private decimal prestamosMes;
        private decimal prestamosHoy;
        private decimal prestamosMensual;
        private decimal prestamosJefe;
        private decimal prestamosCajero;
        private int diasOperativos;
        private int cantidadSemanal;
        private decimal prestamosEstaSemana;
        #endregion

        #region Methods (Metodos)
        public GadgetForm()
        {
            InitializeComponent();
            datosGadget = new DatosGadget();
           
        }
        private void StartGadget()
        {
            try
            {

                string[] rango = new string[3];
                string[] rangoObjetivos = new string[7];

                datosGadget.datosGadget();
                datosGadget.Rango();


                inicioFecha = datosGadget.inicio.ToString("yyyy-MM-dd");
                finFecha = datosGadget.fin.ToString("yyyy-MM-dd");
                hoyFecha = datosGadget.medio.ToString("yyyy-MM-dd");

                rango = datosGadget.Semana(hoyFecha);
                rangoObjetivos = datosGadget.Objetivos(datosGadget.localidad, datosGadget.fechafin);

                lblAno.Text = datosGadget.ano;
                lblMes.Text = datosGadget.mes;
                lblFecha.Text = datosGadget.fecha;
                lblSucursal.Text = datosGadget.miSucursal;
               // lblEmpresa.Text = datosGadget.empresa;
                piclLogo.Load(datosGadget.logo);


                datosGadgetResultados = datosGadget.Result(inicioFecha, finFecha, hoyFecha, rango[0], rango[1]);

                prestamosMes = decimal.Parse(datosGadgetResultados.Rows[0][0].ToString());
                prestamosHoy = decimal.Parse(datosGadgetResultados.Rows[0][2].ToString());
                prestamosMensual = decimal.Parse(rangoObjetivos[0].ToString());
                prestamosJefe = decimal.Parse(rangoObjetivos[2].ToString());
                prestamosCajero = decimal.Parse(rangoObjetivos[3].ToString());
                diasOperativos = int.Parse(rangoObjetivos[1].ToString());
                prestamosEstaSemana = decimal.Parse(datosGadgetResultados.Rows[0][4].ToString());
                cantidadSemanal = int.Parse(datosGadgetResultados.Rows[0][5].ToString());

                lblAcumuladoHastaHoy.Text = "Acumulado Hasta Hoy: " + string.Format("{0:C2}", prestamosMes);
                lblTotalOperacionesPrestamos.Text = "Total de Prestamos Hasta Hoy: " + datosGadgetResultados.Rows[0][1].ToString();

                lblAcHoy.Text = "Hoy lleva: " + string.Format("{0:C2}", prestamosHoy);
                lblTotalHoy.Text = "Prestamos Hoy: " + datosGadgetResultados.Rows[0][3].ToString();

                lblMensual.Text = "Mensual: " + string.Format("{0:C2}", prestamosMensual);

                lblObjetivoSemJef.Text = "Semanal Jefe Suc: " + string.Format("{0:C2}",prestamosJefe);
                lblObjetivoSemCaje.Text = "Semanal Cajero: " + string.Format("{0:C2}", prestamosCajero);

                lblAcumuladoJefe.Text = "Esta semana llevas: " + string.Format("{0:c2}", prestamosEstaSemana);
                lblcantidadSemanal.Text = "Prestamos de esta semana: <b>" + cantidadSemanal +"</b>";

                lblDiasOperativo.Text = "Dias Operativos: "+"\n" + diasOperativos;

                lblObjetivoDiario.Text = "Diario: " + string.Format("{0:C2}",prestamosMensual / diasOperativos);

                decimal proyeccion = prestamosMes / int.Parse(rango[2]) * diasOperativos;
                decimal porcentaje = prestamosMes / prestamosMensual * 100;

                decimal haceUnAno = decimal.Parse(rangoObjetivos[5]);
                lblProyeccionMensual.Text = "Con esta Racha llegaras a fin de mes a: " +
                                "<b> " + string.Format("{0:C2}",proyeccion) + " </b>"+ " - " + "<b> " + string.Format("{0:N2}", porcentaje) + " </b>"+ " % de objetivo";

                lblDiasRestantes.Text = "Dias Restantes: "+ "\n" + Convert.ToString(diasOperativos - int.Parse(rango[2]));

                lblHaceUnAño.Text = "Hace un Año hiciste: " + 
                   "<b>"+ string.Format("{0:C2}", haceUnAno) + "</b> Año: " + "<b>"+ datosGadget.fechafin.Year.ToString() + "</b>";

                //CONFIGURANDO LOS OBJETOS
                //DIAS RESTANTES
                prdDiasRestantes.Maximum = diasOperativos;
                prdDiasRestantes.Minimum = 1;
                prdDiasRestantes.Value = int.Parse(rango[2]);
                //acumulado hasta hoy y mensual
                circPrestamos.Maximum = 100;
                circPrestamos.Minimum = 0;
                decimal porcentajePrestamos=prestamosMensual / prestamosMes * 10;
                circPrestamos.Value = Convert.ToInt32(porcentaje);
                ratingTotal.Rating = Convert.ToInt32(porcentaje/10);
               
                //acumulado el dia de hoy
                cirDiario.Maximum = 100;
                cirDiario.Minimum = 0;
                decimal objetivodiario = prestamosMensual / diasOperativos;
                decimal porcentajeDiarioPrestamos = prestamosHoy / objetivodiario * 100;
               
                if (porcentajeDiarioPrestamos > 100)
                {
                    cirDiario.Maximum = Convert.ToInt32(porcentajeDiarioPrestamos); 
                }
                cirDiario.Value = Convert.ToInt32(porcentajeDiarioPrestamos);

                //acumulado semanal del jefe de sucursal
                cirSemJefe.Maximum = 100;
                cirSemJefe.Minimum = 0;
                decimal porcentajeSemJefPrestamos =  prestamosEstaSemana / prestamosJefe * 100;

                if (porcentajeSemJefPrestamos > 100)
                {
                    cirSemJefe.Maximum = Convert.ToInt32(porcentajeSemJefPrestamos);
                }
                cirSemJefe.Value = Convert.ToInt32(porcentajeSemJefPrestamos);
              
                ratingStar1.Rating = Convert.ToInt32(porcentajeSemJefPrestamos / 10);


                //acumulado semanal del cajero
                cirSemCajero.Maximum = 100;
                cirSemCajero.Minimum = 0;
                decimal porcentajeSemCajeroPrestamos = prestamosEstaSemana / prestamosCajero * 100;

                if (porcentajeSemCajeroPrestamos > 100)
                {
                    cirSemCajero.Maximum = Convert.ToInt32(porcentajeSemCajeroPrestamos);
                }
                cirSemCajero.Value = Convert.ToInt32(porcentajeSemCajeroPrestamos);
                ratingStar2.Rating = Convert.ToInt32(porcentajeSemCajeroPrestamos / 10);

            }
            catch (Exception ex)
            {

                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show(ex.Message);
            }
          
        }

        private void lblHaceUnAño_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Events (Eventos)
        //Load
        private void GadgetForm_Load(object sender, EventArgs e)
        {
            try
            {
                StartGadget();

            }
            catch (Exception)
            {

                //throw;
            }
           
        }

       

        //Close Solution
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 
        #endregion
    }
}
