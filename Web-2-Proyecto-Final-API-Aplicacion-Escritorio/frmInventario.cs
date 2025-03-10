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
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            txtCaducidad.Text = "hola mundo";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           // txtCaducidad.Text = "hola mundo";
        }
    }
}
