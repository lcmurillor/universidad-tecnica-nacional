using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProyecto2
{
    public partial class frmFacturaEditar : Form
    {
        public frmFacturaEditar()
        {
            InitializeComponent();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Desa anular la factura?", "Advertencia", MessageBoxButtons.YesNo);
        }
    }
}
