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
    public partial class frmCliente : Form
    {
        clienteContorller cliente = new clienteContorller();
        personaController persona = new personaController();
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            CargarDGV(cliente.GetClientes(), dgvCliente);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                clsCliente clscliente = cliente.GetCliente(int.Parse(txtNumeroCliente.Text));
                clsPersona clspersona = persona.GetPersona(clscliente.pcedula);
                txtCedula.Text = clspersona.cedula;
                txtCorreo.Text = clscliente.pcorreo;
                txtTelefono.Text = clscliente.ptelefono;
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
                clsCliente clscliente = new clsCliente
                {
                    accion = "I",
                    pcedula = txtCedula.Text,
                    pcorreo = txtCorreo.Text,
                    ptelefono = txtTelefono.Text,
                    pestado = "A"
                };
                cliente.MantenimientoCliente(clscliente);
                CargarDGV(cliente.GetClientes(), dgvCliente);
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
                clsCliente clscliente = new clsCliente
                {
                    accion = "U",
                    pidcliente = int.Parse(txtNumeroCliente.Text),
                    pcedula = txtCedula.Text,
                    pcorreo = txtCorreo.Text,
                    ptelefono = txtTelefono.Text,
                    pestado = "A"
                };
                cliente.MantenimientoCliente(clscliente);
                CargarDGV(cliente.GetClientes(), dgvCliente);
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
                clsCliente clscliente = new clsCliente
                {
                    accion = "D",
                    pidcliente = int.Parse(txtNumeroCliente.Text),
                    pestado = "I"
                };
                cliente.MantenimientoCliente(clscliente);
                CargarDGV(cliente.GetClientes(), dgvCliente);
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, intentelo de nuevo");
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

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNumeroCliente.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
                clsPersona clspersona = persona.GetPersona(dgvCliente.CurrentRow.Cells[1].Value.ToString());
                txtCedula.Text = clspersona.cedula;
                txtCorreo.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
                txtTelefono.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
