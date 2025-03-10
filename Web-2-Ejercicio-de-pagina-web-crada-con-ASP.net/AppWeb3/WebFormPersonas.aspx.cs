using AppWeb3.Clases;
using System;

namespace AppWeb3
{
    public partial class WebFormPersonas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            ClsPersona persona = new ClsPersona(txtCedula.Text, txtNombre.Text, txtApe1.Text, txtApe2.Text, txtCorreo.Text);
            persona.AgregarPersona(persona, "I");
        }
    }
}