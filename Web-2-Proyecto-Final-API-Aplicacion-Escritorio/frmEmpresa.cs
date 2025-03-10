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
    public partial class frmEmpresa : Form
    {
        empresaController empresa = new empresaController();
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            CargarDGV(empresa.GetEmpresas(), dgvEmpresa);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                clsEmpresa clsempresa = empresa.GetEmpresa(int.Parse(txtNumeroEmpresa.Text));
                txtNombreEmpresa.Text = clsempresa.pnombre;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                clsEmpresa clsempresa = new clsEmpresa
                {
                    accion = "I",
                    pnombre = txtNombreEmpresa.Text,
                    pestado = "A"
                };
                empresa.MantenimientoEmpresa(clsempresa);
                CargarDGV(empresa.GetEmpresas(), dgvEmpresa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualiszar_Click(object sender, EventArgs e)
        {
            try
            {
                clsEmpresa clsempresa = new clsEmpresa
                {
                    accion = "U",
                    pidempresa = int.Parse(txtNumeroEmpresa.Text),
                    pnombre = txtNombreEmpresa.Text,
                    pestado = "A"
                };
                empresa.MantenimientoEmpresa(clsempresa);
                CargarDGV(empresa.GetEmpresas(), dgvEmpresa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                clsEmpresa clsempresa = new clsEmpresa
                {
                    accion = "D",
                    pidempresa = int.Parse(txtNumeroEmpresa.Text),
                    pestado = "I"
                };
                empresa.MantenimientoEmpresa(clsempresa);
                CargarDGV(empresa.GetEmpresas(), dgvEmpresa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNumeroEmpresa.Text = dgvEmpresa.CurrentRow.Cells[0].Value.ToString();
                txtNombreEmpresa.Text = dgvEmpresa.CurrentRow.Cells[1].Value.ToString();
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
