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
    public partial class SaldosForm : DevComponents.DotNetBar.Office2007Form
    { 
        public SaldosForm()
        {
            InitializeComponent();
        }

        private void SaldosForm_Load(object sender, EventArgs e)
        {
            traerSaldos();
        }

        private void traerSaldos()
        {
            
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
    }
}
