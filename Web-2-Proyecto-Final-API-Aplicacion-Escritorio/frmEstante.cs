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
    public partial class frmEstante : Form
    {
        estanteController estante = new estanteController();
        bodegaController bodega = new bodegaController();
        seccionContorller seccion = new seccionContorller();

        public frmEstante()
        {
            InitializeComponent();
        }

        private void frmEstante_Load(object sender, EventArgs e)
        {
            //Cargar combo box bodega
            CargarCBox(cboxBodega, bodega.GetBodegas(), "nombre", "idbodega");
            //Cargar combo box seccion 
            CargarCBox(cboxSeccion, seccion.GetSecciones(), "descripcion", "idseccion");
            //Cargar tabla de estates
            CargarDGV(estante.GetEstantes(), dgvEstante);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                clsEstante clsestante = estante.GetEstante(int.Parse(txtNumeroEstante.Text));
                clsBodega clsbodega = bodega.GetBodega(clsestante.pidbodega);
                cboxBodega.Text = clsbodega.pnombre;
                clsSeccion clsseccion = seccion.GetSeccion(clsestante.pidseccion);
                cboxSeccion.Text = clsseccion.pdescripcion;
                txtDescripcion.Text = clsestante.pdescripcion;
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
                clsEstante clsestante = new clsEstante
                {
                    accion = "I",
                    pidbodega = int.Parse(cboxBodega.SelectedValue.ToString()),
                    pidseccion = int.Parse(cboxSeccion.SelectedValue.ToString()),
                    pdescripcion = txtDescripcion.Text,
                    pestado = "A"
                };
                estante.MantenimientoEstante(clsestante);
                CargarDGV(estante.GetEstantes(), dgvEstante);
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
                clsEstante clsestante = new clsEstante
                {
                    accion = "U",
                    pidestante = int.Parse(txtNumeroEstante.Text),
                    pidbodega = int.Parse(cboxBodega.SelectedValue.ToString()),
                    pidseccion = int.Parse(cboxSeccion.SelectedValue.ToString()),
                    pdescripcion = txtDescripcion.Text,
                    pestado = "A"
                };
                estante.MantenimientoEstante(clsestante);
                CargarDGV(estante.GetEstantes(), dgvEstante);
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
                clsEstante clsestante = new clsEstante
                {
                    accion = "D",
                    pidestante = int.Parse(txtNumeroEstante.Text),
                    pestado = "I"
                };
                estante.MantenimientoEstante(clsestante);
                CargarDGV(estante.GetEstantes(), dgvEstante);
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, intentelo de nuevo");
            }
        }
        private void dgvEstante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNumeroEstante.Text = dgvEstante.CurrentRow.Cells[0].Value.ToString();
                clsBodega clsbodega = bodega.GetBodega(int.Parse(dgvEstante.CurrentRow.Cells[1].Value.ToString()));
                cboxBodega.Text = clsbodega.pnombre;
                clsSeccion clsseccion = seccion.GetSeccion(int.Parse(dgvEstante.CurrentRow.Cells[2].Value.ToString()));
                cboxSeccion.Text = clsseccion.pdescripcion;
                txtDescripcion.Text = dgvEstante.CurrentRow.Cells[3].Value.ToString();
            }catch (Exception ex)
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
                datagridview.DataSource = dgv.items;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
