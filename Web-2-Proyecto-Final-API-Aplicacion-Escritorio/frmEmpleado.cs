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
    public partial class frmEmpleado : Form
    {
        empleadoController empleado = new empleadoController();
        sucursalController sucursal = new sucursalController();
        empresaController empresa = new empresaController();
        personaController persona = new personaController();

        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            //cargar tabla empleados
            CargarDGV(empleado.GetEmpleados(), dgvEmpleado);
            //cargar combo box sucursal
            CargarCBox(cboxSucursal, sucursal.GetSucursales(), "nombre", "idsucursal");
            //cargar combo box empresa
            CargarCBox(cboxEmpresa, empresa.GetEmpresas(), "nombre", "idEmpresa");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                clsEmpleado clsempleado = empleado.GetEmpleado(int.Parse(txtNumeroEmpleado.Text));
                clsSucursal clssucursal = sucursal.GetSucursal(clsempleado.pidsucursal);
                cboxSucursal.Text = clssucursal.pnombre;
                clsEmpresa clsempresa = empresa.GetEmpresa(clsempleado.pidempresa);
                cboxEmpresa.Text = clsempresa.pnombre;
                clsPersona clspersona = persona.GetPersona(clsempleado.pcedula);
                txtPersona.Text = clspersona.cedula;
                switch (clsempleado.ppuesto)
                {
                    case "C":
                        cboxPuesto.Text = "CAJERO";
                        break;
                    case "P":
                        cboxPuesto.Text = "PROVEDURIA";
                        break;
                    default:
                        cboxPuesto.Text = "ADMINISTADOR";
                        break;
                }
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
                clsEmpleado clsempelado = new clsEmpleado
                {
                    accion = "I",
                    pidsucursal = int.Parse(cboxSucursal.SelectedValue.ToString()),
                    pidempresa = int.Parse(cboxEmpresa.SelectedValue.ToString()),
                    pcedula = txtPersona.Text,
                    ppuesto = puesto(cboxPuesto),
                    pestado = "A"
                };
                empleado.MantenimientoEmpleado(clsempelado);
                CargarDGV(empleado.GetEmpleados(), dgvEmpleado);
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, intentelo de nuevo");
            }
        }

        private string puesto(ComboBox box)
        {
            switch (box.SelectedIndex)
            {
                case 1:
                    return "C";
                case 2:
                    return "P";
                default:
                    return "A";
            }
        }

        private void btnActualiszar_Click(object sender, EventArgs e)
        {
            try
            {
                clsEmpleado clsempelado = new clsEmpleado
                {
                    accion = "U",
                    pidempleado = int.Parse(txtNumeroEmpleado.Text),
                    pidsucursal = int.Parse(cboxSucursal.SelectedValue.ToString()),
                    pidempresa = int.Parse(cboxEmpresa.SelectedValue.ToString()),
                    ppuesto = puesto(cboxPuesto),
                    pestado = "A"
                };
                empleado.MantenimientoEmpleado(clsempelado);
                CargarDGV(empleado.GetEmpleados(), dgvEmpleado);
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
                clsEmpleado clsempelado = new clsEmpleado
                {
                    accion = "D",
                    pidempleado = int.Parse(txtNumeroEmpleado.Text),
                    pestado = "I"
                };
                empleado.MantenimientoEmpleado(clsempelado);
                CargarDGV(empleado.GetEmpleados(), dgvEmpleado);
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, intentelo de nuevo");
            }
        }

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNumeroEmpleado.Text = dgvEmpleado.CurrentRow.Cells[0].Value.ToString();                    
                clsSucursal clssucursal = sucursal.GetSucursal(int.Parse(dgvEmpleado.CurrentRow.Cells[1].Value.ToString()));
                cboxSucursal.Text = clssucursal.pnombre;
                clsEmpresa clsempresa = empresa.GetEmpresa(int.Parse(dgvEmpleado.CurrentRow.Cells[2].Value.ToString()));
                cboxEmpresa.Text = clsempresa.pnombre;
                clsPersona clspersona = persona.GetPersona(dgvEmpleado.CurrentRow.Cells[3].Value.ToString());
                txtPersona.Text = clspersona.cedula;
                switch (dgvEmpleado.CurrentRow.Cells[4].Value.ToString())
                {
                    case "C":
                        cboxPuesto.Text = "CAJERO";
                        break;
                    case "P":
                        cboxPuesto.Text = "PROVEDURIA";
                        break;
                    default:
                        cboxPuesto.Text = "ADMINISTADOR";
                        break;
                }
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
                datagridview.DataSource = dgv.items;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
