

namespace EKGADGET.WinForms
{
    #region Libraries (Librerias)
    using EKGADGET.Common.Clases;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms; 
    #endregion
    public partial class GadgetForm : DevComponents.DotNetBar.Office2007Form
    {
        #region Properties (Propiedades)
        private ResultClass resultClass;
        private DataTable dataGadget;
        #endregion

        #region Methods (Metodos)
        public GadgetForm()
        {
            InitializeComponent();
            resultClass = new ResultClass();
        }
        private void StartGadget()
        {
            try
            {
                dataGadget = new DataTable();
                dataGadget = resultClass.datosLocalidadSQL();
                //foreach (DataRow item in dataGadget.Rows)
                //{
                //    lblAno.Text ="Año: " + item[0].ToString();
                //    lblMes.Text = "Mes: " + item[1].ToString();
                //    lblFecha.Text = "Fecha: " + DateTime.Parse(item[2].ToString()).ToString("ddd dd ,MMM YYYY");

                //}
            }
            catch (Exception)
            {

                throw;
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

                throw;
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
