


namespace EKGADGET.WinForms.Views
{
    #region Libraries (Librerias)
    using System;
    using System.Data;
    using System.Globalization;
    using System.Windows.Forms;
    using DevComponents.DotNetBar;
    using EKGADGET.WinForms.Classes;
    #endregion

    public partial class SaldosForm : DevComponents.DotNetBar.Office2007Form
    {

        #region Properties (propiedades)
        SaldosGadget saldosGadget;
        DataTable infoC1;   
        DataTable infoC2;
       
        #endregion

        #region Attributes (atributos)
        private decimal TotalC1 = 0;
        private decimal TotalC2 = 0;
        private decimal efectivo1 = 0;
        private decimal efectivo2 = 0;
        public string sucursal;
        #endregion

        #region Methods (metodos)
        public SaldosForm()
        {
            saldosGadget = new SaldosGadget();
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void OperacionSaldos()
        {
            decimal total = 0;
            decimal suma = 0;
            //decimal efectivo = 0;

            decimal total2 = 0;
            decimal suma2 = 0;
            //decimal efectivo2 = 0;

            if (!string.IsNullOrEmpty(txtSaldoC1.Text))
            {
                total = TotalC1;
                foreach (DataGridViewRow item in dataGridViewX1.Rows)
                {
                    if (!string.IsNullOrEmpty(item.Cells[1].Value.ToString()))
                    {
                        suma += decimal.Parse(item.Cells[1].Value.ToString());
                    }

                }

                efectivo1 = total - suma;
                txtRestaC1.Text = string.Format("{0:C2}", efectivo1);
            }


            if (!string.IsNullOrEmpty(txtSaldoC2.Text))
            {
                total2 = TotalC2;
                foreach (DataGridViewRow item in dataGridViewX2.Rows)
                {
                    if (!string.IsNullOrEmpty(item.Cells[1].Value.ToString()))
                    {
                        suma2 += decimal.Parse(item.Cells[1].Value.ToString());
                    }

                }

                efectivo2 = total2 - suma2;
                txtRestaC2.Text = string.Format("{0:C2}", efectivo2);
            }



        }
        #endregion

        #region Events (Eventos)

        private void SaldosForm_Load(object sender, EventArgs e)
        {
            circularProgress1.Visible = false;
            DataTable saldos = new DataTable();
            saldos = saldosGadget.Saldos();

            if (saldos.Rows.Count != 1)
            {
                txtSaldoC1.Text = string.Format("{0:C2}", decimal.Parse(saldos.Rows[0][1].ToString()));
                lblC1.Text = saldos.Rows[0][0].ToString();
                txtSaldoC2.Text = string.Format("{0:C2}", decimal.Parse(saldos.Rows[1][1].ToString()));
                lblC2.Text = saldos.Rows[1][0].ToString();
                TotalC1 = decimal.Parse(saldos.Rows[0][1].ToString());
                TotalC2 = decimal.Parse(saldos.Rows[1][1].ToString());
                txtRestaC1.Text = string.Format("{0:C2}", decimal.Parse(saldos.Rows[0][1].ToString()));
                txtRestaC2.Text = string.Format("{0:C2}", decimal.Parse(saldos.Rows[1][1].ToString()));
            }
            else
            {
                TotalC1 = decimal.Parse(saldos.Rows[0][1].ToString());
                txtSaldoC1.Text = string.Format("{0:C2}", decimal.Parse(saldos.Rows[0][1].ToString()));
                lblC1.Text = saldos.Rows[0][0].ToString();
                txtRestaC1.Text = string.Format("{0:C2}", decimal.Parse(saldos.Rows[0][1].ToString()));
            }

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //AGREGAR NUEVA FILA


            int i = dataGridViewX1.Rows.Count;

            dataGridViewX1.Rows.Insert(i, "Descripcion", "0.00");
            dataGridViewX1.FirstDisplayedScrollingRowIndex = dataGridViewX1.RowCount - 1;
            dataGridViewX1.Rows[i].Selected = true;



        }

        private void btnCaja2_Click(object sender, EventArgs e)
        {
            //AGREGAR NUEVA FILA


            int i = dataGridViewX2.Rows.Count;

            dataGridViewX2.Rows.Insert(i, "Descripcion", "0.00");
            dataGridViewX2.FirstDisplayedScrollingRowIndex = dataGridViewX2.RowCount - 1;
            dataGridViewX2.Rows[i].Selected = true;
        }

        private void dataGridViewX1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                OperacionSaldos();
            }
            catch (Exception)
            {

                // throw;
            }
        }
        private void dataGridViewX2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                OperacionSaldos();
            }
            catch (Exception)
            {

                // throw;
            }
        }
        //SOLO NUMEROS EN CELDA DE DATA GRID VIEWS

        private void dataGridViewX1_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Donde el numero "1" es el numero de tu columna

            if (dataGridViewX1.CurrentCell.ColumnIndex == 1)
            {

                CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

                if (char.IsNumber(e.KeyChar) ||

                    e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator

                    )

                    e.Handled = false;

                else

                    e.Handled = true;

                //if (e.KeyChar == (char)Keys.Back || char.IsNumber(e.KeyChar))

                //    e.Handled = false;

                //else

                //    e.Handled = true;

            }

        }

        private void dataGridViewX1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridViewX1.CurrentCell.ColumnIndex == 1)

            {

                TextBox txt = e.Control as TextBox;

                if (txt != null)

                {

                    txt.KeyPress -= new KeyPressEventHandler(dataGridViewX1_KeyPress);

                    txt.KeyPress += new KeyPressEventHandler(dataGridViewX1_KeyPress);

                }

            }
        }

        private void dataGridViewX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridViewX2.CurrentCell.ColumnIndex == 1)

            {

                CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

                if (char.IsNumber(e.KeyChar) ||

                    e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator

                    )

                    e.Handled = false;

                else

                    e.Handled = true;

                //if (e.KeyChar == (char)Keys.Back || char.IsNumber(e.KeyChar))

                //    e.Handled = false;

                //else

                //    e.Handled = true;

            }
        }

        private void dataGridViewX2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridViewX2.CurrentCell.ColumnIndex == 1)

            {

                TextBox txt = e.Control as TextBox;

                if (txt != null)

                {

                    txt.KeyPress -= new KeyPressEventHandler(dataGridViewX2_KeyPress);

                    txt.KeyPress += new KeyPressEventHandler(dataGridViewX2_KeyPress);

                }

            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            DialogResult dialogResult = MessageBoxEx.Show(
                "¿DESEAS ENVIAR SALDOS EN ESTE MOMENTO?", "EKGADGET",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                infoC1 = new DataTable();
                infoC1.Columns.Add();
                infoC1.Columns.Add();
                infoC2 = new DataTable();
                infoC2.Columns.Add();
                infoC2.Columns.Add();


                foreach (DataGridViewRow item in dataGridViewX1.Rows)
                {

                    infoC1.Rows.Add(item.Cells[0].Value.ToString(), item.Cells[1].Value.ToString());
                }

                foreach (DataGridViewRow item in dataGridViewX2.Rows)
                {

                    infoC2.Rows.Add(item.Cells[0].Value.ToString(), item.Cells[1].Value.ToString());
                }

                ////ENVIAMOS LOS SALDOS AL CORREO
                backgroundWorker1.RunWorkerAsync();
               
            }

        }


        private void dataGridViewX1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                OperacionSaldos();
            }
            catch (Exception)
            {

                // throw;
            }
        }

        private void dataGridViewX2_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                OperacionSaldos();
            }
            catch (Exception)
            {

                // throw;
            }
        }


        #endregion

        #region BackGround (Hilos)
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            circularProgress1.Visible = true;
            circularProgress1.IsRunning = true;
            //ENVIAMOS LOS SALDOS AL CORREO
            saldosGadget.EnviarSaldos(sucursal,
                TotalC1, TotalC2,
                    efectivo1, efectivo2, infoC1, infoC2, lblC1.Text, lblC2.Text);
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
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
