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
    public partial class frmCategoria : Form
    {
        categoriaController categoria = new categoriaController();

        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            CargarDGV(categoria.GetCategorias(), dgvCategoria);
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

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNumeroCategoria.Text = dgvCategoria.CurrentRow.Cells[0].Value.ToString();
                txtDescripcion.Text = dgvCategoria.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                clsCategoria clscategoria = categoria.GetCategoria(int.Parse(txtNumeroCategoria.Text));
                txtDescripcion.Text = clscategoria.pdescripcion;
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
                clsCategoria clscategoria = new clsCategoria
                {
                    accion = "I",
                    pdescripcion = txtDescripcion.Text,
                    pestado = "A"
                };
                categoria.MantenimientoCategoria(clscategoria);
                CargarDGV(categoria.GetCategorias(), dgvCategoria);
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
                clsCategoria clscategoria = new clsCategoria
                {
                    accion = "U",
                    pidcategoria = int.Parse(txtNumeroCategoria.Text),
                    pdescripcion = txtDescripcion.Text
                };
                categoria.MantenimientoCategoria(clscategoria);
                CargarDGV(categoria.GetCategorias(), dgvCategoria);
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
                clsCategoria clscategoria = new clsCategoria
                {
                    accion = "D",
                    pidcategoria = int.Parse(txtNumeroCategoria.Text),
                    pdescripcion = txtDescripcion.Text,
                    pestado = "I"
                };
                categoria.MantenimientoCategoria(clscategoria);
                CargarDGV(categoria.GetCategorias(), dgvCategoria);
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, intentelo de nuevo");
            }

        }
    }
}
