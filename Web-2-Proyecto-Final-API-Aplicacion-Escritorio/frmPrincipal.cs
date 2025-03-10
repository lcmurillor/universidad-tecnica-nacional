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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            GenerarVentana(new frmFacturaGenerar());
        }

        private void GenerarVentana(Form frm)
        {
            if (this.pnlPrincipal.Controls.Count > 0)
            {
                pnlPrincipal.Controls.RemoveAt(0);
            }
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.pnlPrincipal.Controls.Add(frm);
            this.pnlPrincipal.Tag = frm;
            frm.Show();
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            GenerarVentana(new frmFacturaGenerar());
        }

        private void btnBuscarFactura_Click(object sender, EventArgs e)
        {
            GenerarVentana(new frmFacturaEditar());
        }

        private void btnEditarDetalleFacutra_Click(object sender, EventArgs e)
        {
            GenerarVentana(new frmFacturaDetalleEditar());
        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            GenerarVentana(new frmArticulo());
        }

        private void btnBodega_Click(object sender, EventArgs e)
        {
            GenerarVentana(new frmBodega());
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            GenerarVentana(new frmCategoria());
        }

        private void btnEstante_Click(object sender, EventArgs e)
        {
            GenerarVentana(new frmEstante());
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            GenerarVentana(new frmInventario());
        }

        private void btnSeccion_Click(object sender, EventArgs e)
        {
            GenerarVentana(new frmSeccion());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            GenerarVentana(new frmCliente());
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            GenerarVentana(new frmEmpleado());
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            GenerarVentana(new frmEmpresa());
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            GenerarVentana(new frmProveedor());
        }

        private void btnSucursal_Click(object sender, EventArgs e)
        {
            GenerarVentana(new frmSucursal());
        }

        private void uSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarVentana(new frmUsuario());
        }
    }
}