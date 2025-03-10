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
    public partial class frmInicio : Form
    {
        usuarioController usuario = new usuarioController();
        dynamic login;

        public frmInicio()
        {
            InitializeComponent();
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private Boolean ValidarUsuario()
        {
            login  = usuario.login(txtUsuario.Text, txtClave.Text);
            if (login != null)
            {
                return true;
            }
            return false;

        }
        private void btnIncioSesion_Click(object sender, EventArgs e)
        {
            if (ValidarUsuario())
            {
                CargarFormulario();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta");
            }

        }

        private void CargarFormulario()
        {
            this.Hide();
            frmPrincipal frm = new frmPrincipal();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }
    }
}
