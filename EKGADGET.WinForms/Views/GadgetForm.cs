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

namespace EKGADGET.WinForms
{
    public partial class GadgetForm : DevComponents.DotNetBar.Office2007Form
    {
        ResultClass resultClass;
        public GadgetForm()
        {
            InitializeComponent();
            resultClass = new ResultClass();
        }

        private void GadgetForm_Load(object sender, EventArgs e)
        {
            resultClass.datosLocalidadSQL();
        }
    }
}
