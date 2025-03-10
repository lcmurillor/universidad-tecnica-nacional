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
    public partial class frmBodega : Form
    {
        bodegaController bodega = new bodegaController();
        empresaController empresa = new empresaController();

        public frmBodega()
        {
            InitializeComponent();
        }

        private void frmBodega_Load(object sender, EventArgs e)
        {
            CargarCBox(cboxEmpresa, empresa.GetEmpresas(), "nombre", "idEmpresa");
            CargarDGV(bodega.GetBodegas(), dgvBodega);
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

        private void dgvBodega_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNumeroBodega.Text = dgvBodega.CurrentRow.Cells[0].Value.ToString();
                txtNombreBodega.Text = dgvBodega.CurrentRow.Cells[1].Value.ToString();
                txtUbicacion.Text = dgvBodega.CurrentRow.Cells[2].Value.ToString();
                clsEmpresa clsempresa = empresa.GetEmpresa(int.Parse(dgvBodega.CurrentRow.Cells[3].Value.ToString()));
                cboxEmpresa.Text = clsempresa.pnombre;
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
                clsBodega clsbodega = bodega.GetBodega(int.Parse(txtNumeroBodega.Text));
                txtNombreBodega.Text = clsbodega.pnombre;
                clsEmpresa clsempresa = empresa.GetEmpresa(clsbodega.pidempresa);
                cboxEmpresa.Text = clsempresa.pnombre;
                txtUbicacion.Text = clsbodega.pubicacion;
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
                clsBodega clsbodega = new clsBodega
                {
                    accion = "I",
                    pidempresa = int.Parse(cboxEmpresa.SelectedValue.ToString()),
                    pnombre = txtNombreBodega.Text,
                    pubicacion = txtUbicacion.Text,
                    pestado = "A"
                };
                bodega.MantenimientoBodega(clsbodega);
                CargarDGV(bodega.GetBodegas(), dgvBodega);
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
                clsBodega clsbodega = new clsBodega
                {
                    accion = "U",
                    pidbodega = int.Parse(txtNumeroBodega.Text),
                    pidempresa = int.Parse(cboxEmpresa.SelectedValue.ToString()),
                    pnombre = txtNombreBodega.Text,
                    pubicacion = txtUbicacion.Text
                };
                bodega.MantenimientoBodega(clsbodega);
                CargarDGV(bodega.GetBodegas(), dgvBodega);
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
                clsBodega clsbodega = new clsBodega
                {
                    accion = "D",
                    pidbodega = int.Parse(txtNumeroBodega.Text),
                    pestado = "I"
                };
                bodega.MantenimientoBodega(clsbodega);
                CargarDGV(bodega.GetBodegas(), dgvBodega);
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, intentelo de nuevo");
            }

        }
    }
}
