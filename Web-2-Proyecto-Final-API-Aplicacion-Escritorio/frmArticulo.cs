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
    public partial class frmArticulo : Form
    {
        categoriaController categoria = new categoriaController();
        articuloController articulo = new articuloController();
        proveedorController proveedor = new proveedorController();

        public frmArticulo()
        {
            InitializeComponent();
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            //cargar combobox proveedor
            CargarCBox(cboxProveedor, proveedor.GetProveedores(), "nombre", "idproveedor");
            //cargar combobox categoria
            CargarCBox(cboxCategoria, categoria.GetCategorias(), "descripcion", "idcategoria");
            //Cargar la tabla de articulos
            CargarDGV(articulo.GetArticulos(), dgvArticulos);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                clsArticulo clsarticulo = articulo.GetArticulo(int.Parse(txtNumeroArticulo.Text));
                clsCategoria clscategoria = categoria.GetCategoria(clsarticulo.pidcategoria);
                clsProveedor clsproveedor = proveedor.GetProveedor(clsarticulo.pidproveedor);
                txtDescripcion.Text = clsarticulo.pdescripcion;
                cboxProveedor.Text = clsproveedor.pnombre;
                cboxCategoria.Text = clscategoria.pdescripcion;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, intentelo de nuevo");
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                clsArticulo clsarticulo = new clsArticulo
                {
                    accion = "I",
                    pidproveedor = int.Parse(cboxProveedor.SelectedValue.ToString()),
                    pidcategoria = int.Parse(cboxCategoria.SelectedValue.ToString()),
                    pdescripcion = txtDescripcion.Text,
                    pestado = "A"
                };
                articulo.MantenimientoArticulo(clsarticulo);
                CargarDGV(articulo.GetArticulos(), dgvArticulos);
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
                clsArticulo clsarticulo = new clsArticulo
                {
                    accion = "U",
                    pidarticulo = int.Parse(txtNumeroArticulo.Text),
                    pidproveedor = int.Parse(cboxProveedor.SelectedValue.ToString()),
                    pidcategoria = int.Parse(cboxCategoria.SelectedValue.ToString()),
                    pdescripcion = txtDescripcion.Text,
                    pestado = "A"
                };
                articulo.MantenimientoArticulo(clsarticulo);
                CargarDGV(articulo.GetArticulos(), dgvArticulos);
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, intentelo de nuevo");
            }

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                clsArticulo clsarticulo = new clsArticulo
                {
                    accion = "D",
                    pidarticulo = int.Parse(txtNumeroArticulo.Text),
                    pestado = "I"
                };
                articulo.MantenimientoArticulo(clsarticulo);
                CargarDGV(articulo.GetArticulos(), dgvArticulos);

            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, intentelo de nuevo");
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
                datagridview.DataSource = dgv.items;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNumeroArticulo.Text = dgvArticulos.CurrentRow.Cells[0].Value.ToString();
                clsProveedor clsproveedor = proveedor.GetProveedor(int.Parse(dgvArticulos.CurrentRow.Cells[1].Value.ToString()));
                cboxProveedor.Text = clsproveedor.pnombre;
                clsCategoria clscategoria = categoria.GetCategoria(int.Parse(dgvArticulos.CurrentRow.Cells[2].Value.ToString()));
                cboxCategoria.Text = clscategoria.pdescripcion;
                txtDescripcion.Text = dgvArticulos.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
