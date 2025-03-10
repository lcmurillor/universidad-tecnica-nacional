using FacturacionAPI.Controladores;
using FacturacionAPI.Modelos;
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
    public partial class frmFacturaDetalleEditar : Form
    {
        facturaController factura = new facturaController();
        articuloController articulo = new articuloController();
        
        public frmFacturaDetalleEditar()
        {
            InitializeComponent();
        }

        private void frmFacturaDetalleEditar_Load(object sender, EventArgs e)
        {
            CargarCBox(cboxArticulo,articulo.GetArticulos(), "descripcion", "idarticulo");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //clsFacturaDetalle clsfacturadetalle = factura.GetFacturaDetalles(int.Parse(txtNumeroFatura.Text));
                CargarDGV(factura.GetFacturaDetalles(int.Parse(txtNumeroFatura.Text)), dgvFacturaDetalle);

            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, intentelo de nuevo");
            }
        }

        private void btnActualiszar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, intentelo de nuevo");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, intentelo de nuevo");
            }
        }
        private void dgvFacturaDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarCBox(ComboBox combobox, dynamic cbox, string displaymember, string valuemenber)
        {
            try
            {
                dynamic box = cbox;
                combobox.DataSource = box.items;
                combobox.DisplayMember = displaymember;
                combobox.ValueMember = valuemenber;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarDGV(dynamic dynamic, DataGridView datagridview)
        {
            try
            {
                dynamic dgv = dynamic;
                datagridview.DataSource = dgv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
