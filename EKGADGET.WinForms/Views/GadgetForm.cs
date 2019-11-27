

namespace EKGADGET.WinForms
{


    #region Libraries (Librerias)
    using DevComponents.DotNetBar;
    using EKGADGET.WinForms.Context;
    using EKGADGET.WinForms.Views;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    #endregion
    public partial class GadgetForm : DevComponents.DotNetBar.Office2007Form
    {

        #region Porperties (propiedades)
        private DatosGadget datosGadget;
        private DataTable datosGadgetResultados;
        private DataTable prestamosTipos;
        private SQLContext db;
        private DataTable prestamosTiposTabla; 
        #endregion

        #region Attributes (atributos)
        private string inicioFecha,finFecha,hoyFecha;
        private decimal prestamosMes=0;
        private decimal prestamosHoy = 0;
        private decimal prestamosMensual = 0;
        private decimal prestamosJefe = 0;
        private decimal prestamosCajero = 0;
        private int diasOperativos = 0;
        private int cantidadSemanal = 0;
        private decimal prestamosEstaSemana = 0;
        private int diasRestantes = 0;
        private int cHoy = 0;
        private int prestamosCHoy = 0;
        #endregion

        #region Methods (Metodos)
        public GadgetForm()
        {
            InitializeComponent();
        }
        private void StartGadget()
        {
            try
            {
                datosGadget = new DatosGadget();
                datosGadgetResultados = new DataTable();
                prestamosTipos = new DataTable();

                string[] rango = new string[3];
                string[] rangoObjetivos = new string[7];

                datosGadget.datosGadget();
                datosGadget.Rango();


                inicioFecha = datosGadget.inicio.ToString("yyyy-MM-dd");
                finFecha = datosGadget.fin.ToString("yyyy-MM-dd");
                hoyFecha = datosGadget.medio.ToString("yyyy-MM-dd");

                rango = datosGadget.Semana(hoyFecha);
                rangoObjetivos = datosGadget.Objetivos(datosGadget.localidad, datosGadget.fechafin,datosGadget.fechaInicio);

                lblAno.Text = datosGadget.ano;
                lblMes.Text = datosGadget.mes;
                lblFecha.Text = datosGadget.fecha;
                lblSucursal.Text = datosGadget.miSucursal;
               // lblEmpresa.Text = datosGadget.empresa;
                piclLogo.Load(datosGadget.logo);


                datosGadgetResultados = datosGadget.Result(inicioFecha, finFecha, hoyFecha, rango[0], rango[1]);
                prestamosTipos= datosGadget.prestamostipo(inicioFecha, finFecha);



                prestamosMes = 0;
                prestamosHoy = 0;
                prestamosMensual = 0;
                prestamosJefe = 0;
                prestamosCajero = 0;
                diasOperativos = 0;
                prestamosEstaSemana = 0;
                cantidadSemanal = 0; 

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

                cHoy =int.Parse(datosGadgetResultados.Rows[0][1].ToString());

                lblAcHoy.Text = "Hoy lleva: " + string.Format("{0:C2}", prestamosHoy);

                
                lblTotalHoy.Text = "Prestamos Hoy: " + datosGadgetResultados.Rows[0][3].ToString();
                prestamosCHoy= int.Parse(datosGadgetResultados.Rows[0][3].ToString());

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

                diasRestantes = diasOperativos - int.Parse(rango[2]);
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
                if (prestamosMes != 0)
                {
                    decimal porcentajePrestamos = prestamosMensual / prestamosMes * 10;
                    circPrestamos.Value = Convert.ToInt32(porcentaje);
                    ratingTotal.Rating = Convert.ToInt32(porcentaje / 10);
                }
               
               
                //acumulado el dia de hoy
                cirDiario.Maximum = 100;
                cirDiario.Minimum = 0;
                if (prestamosMes != 0)
                {
                    decimal objetivodiario = prestamosMensual / diasOperativos;
                    decimal porcentajeDiarioPrestamos = prestamosHoy / objetivodiario * 100;

                    if (porcentajeDiarioPrestamos > 100)
                    {
                        cirDiario.Maximum = Convert.ToInt32(porcentajeDiarioPrestamos);
                    }
                    cirDiario.Value = Convert.ToInt32(porcentajeDiarioPrestamos);

                }
                

                //acumulado semanal del jefe de sucursal
                cirSemJefe.Maximum = 100;
                cirSemJefe.Minimum = 0;
                if (prestamosMes != 0)
                {
                    decimal porcentajeSemJefPrestamos = prestamosEstaSemana / prestamosJefe * 100;

                    if (porcentajeSemJefPrestamos > 100)
                    {
                        cirSemJefe.Maximum = Convert.ToInt32(porcentajeSemJefPrestamos);
                    }
                    cirSemJefe.Value = Convert.ToInt32(porcentajeSemJefPrestamos);

                    ratingStar1.Rating = Convert.ToInt32(porcentajeSemJefPrestamos / 10);


                }


                //acumulado semanal del cajero
                cirSemCajero.Maximum = 100;
                cirSemCajero.Minimum = 0;
                if (prestamosMes != 0)
                {
                    decimal porcentajeSemCajeroPrestamos = prestamosEstaSemana / prestamosCajero * 100;

                    if (porcentajeSemCajeroPrestamos > 100)
                    {
                        cirSemCajero.Maximum = Convert.ToInt32(porcentajeSemCajeroPrestamos);
                    }
                    cirSemCajero.Value = Convert.ToInt32(porcentajeSemCajeroPrestamos);
                    ratingStar2.Rating = Convert.ToInt32(porcentajeSemCajeroPrestamos / 10);

                }


                //ahora muestro los prestamos por tipo
                radialMenu1.Items.Clear();

                prestamosTiposTabla = new DataTable("Prestamos");
                prestamosTiposTabla.Columns.Add("Tipo");
                prestamosTiposTabla.Columns.Add("Prestamo");
                prestamosTiposTabla.Columns.Add("Cantidad");

                if (prestamosTipos.Rows.Count > 0)
                {
                    string avaluoTipo, cantidadTipo;
                    decimal prestamoTipo;
                   

                    foreach (DataRow item in prestamosTipos.Rows)
                    {
                        //create item
                        avaluoTipo = item[0].ToString();
                        cantidadTipo = item[1].ToString();
                        prestamoTipo = decimal.Parse(item[2].ToString()); 
                        RadialMenuItem items = new RadialMenuItem();

                        items.Text = avaluoTipo + "\n C-" + cantidadTipo + 
                            " \n" + string.Format("{0:C2}", prestamoTipo);
                        items.Symbol = "\uf040";
                        items.SymbolSize = 8;
                        


                        radialMenu1.Items.Add(items);

                        prestamosTiposTabla.Rows.Add(avaluoTipo,prestamoTipo, cantidadTipo);
                    }

                }

               





            }
            catch (Exception ex)
            {

                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show(ex.Message);
            }
          
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

        //Envio de Saldos
        private void btnSaldos_Click(object sender, EventArgs e)
        {
            //Enviar Resultados Finales o Saldos

            SaldosForm saldosForm = new SaldosForm();
            saldosForm.sucursal = lblSucursal.Text;
            saldosForm.ShowDialog();

        }

        //Envio de Reporte
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Crear Reporte de Avances y Resultados
            ResultadosForm resultadosForm = new ResultadosForm();
            db = new SQLContext();
            var sucursal = db.Localidades.Where(r => r.impresora == "RAIZ").First();
            resultadosForm.sucursal=sucursal.Nombre_Sucursal;
            resultadosForm.marca=sucursal.Marca;
            resultadosForm.empresa=sucursal.Empresa;
            resultadosForm.jefe = sucursal.ENCARGADO;
            resultadosForm.direccion = sucursal.DIRECCION;

            resultadosForm.objetivoMensual= string.Format("{0:C2}", prestamosMensual);
            resultadosForm.objetivoSemanalJef= string.Format("{0:C2}", prestamosJefe);
            resultadosForm.objetivoSemanalCajero= string.Format("{0:C2}", prestamosCajero);
            resultadosForm.mesOperativo=lblMes.Text;
           

            resultadosForm.anoOperativo=DateTime.Now.Year.ToString();
            resultadosForm.diasOperativos=diasOperativos.ToString();
            resultadosForm.totalHoy= string.Format("{0:C2}", prestamosMes);
            resultadosForm.diasRestantes=diasRestantes.ToString();
            resultadosForm.racha=lblProyeccionMensual.Text;

           

            resultadosForm.cHoy = cHoy.ToString();
            resultadosForm.aSemana = string.Format("{0:c2}", prestamosEstaSemana);
            resultadosForm.cSemana = cantidadSemanal.ToString();

           

            resultadosForm.acumuladoHoy = string.Format("{0:C2}", prestamosHoy);
            resultadosForm.prestamosHoy = prestamosCHoy.ToString();

         
            resultadosForm.prestamoTipo = prestamosTiposTabla;


            resultadosForm.ShowDialog();
        }
        
        //compresion y abertura de ventana
        private void switchButton1_ValueChanged(object sender, EventArgs e)
        {
            if (switchButton1.Value == false)
            {
                this.Size = new Size(1000, 680);

            }
            else
            {
                this.Size = new Size(1000, 408);
            }


        }

       
        //actualizacion en segundo plano
        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            try
            {
                //Write what you want to do
                StartGadget();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\n" + ex.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Timer para que lo haga por x tiempo
        private void timer1_Tick(object sender, EventArgs e)
        {

            StartGadget();
            //backgroundWorker1.RunWorkerAsync();

            
        }

        


        #endregion
    }
}
