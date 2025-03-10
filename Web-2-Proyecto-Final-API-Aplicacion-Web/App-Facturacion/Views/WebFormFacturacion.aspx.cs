using FacturacionAPI.Controladores;
using FacturacionAPI.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace App_Facturacion.Views
{
    public partial class WebFormFacturacion : System.Web.UI.Page
    {
        public int cont;
        public DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarClientes();
                cargarProductos();
                txtFecha.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm");
                cont = 0;
                dt = new DataTable();
                crearTablaHeader();
            }
            else
            {
                txtFecha.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm");
            }
        }

        private void cargarClientes()
        {
            clienteContorller cCliente = new clienteContorller();
            personaController cPersona = new personaController();
            dynamic clientes = cCliente.GetClientes();
            ListItem i;
            cboCliente.Items.Add(new ListItem("Clientes.....", "0"));
            foreach (var item in clientes.items)
            {
                clsPersona persona = cPersona.GetPersona(item.idpersona.ToString());
                string nombreCliente = persona.nombre.Trim() + " " + persona.apellido1.Trim() + " " + persona.apellido2.Trim();
                i = new ListItem(nombreCliente, item.idcliente.ToString());
                cboCliente.Items.Add(i);
            }
        }

        private void cargarProductos()
        {
            inventarioController cInventario = new inventarioController();
            articuloController cArticulo = new articuloController();
            dynamic inventarios = cInventario.GetInventarios();
            ListItem i;
            cboProducto.Items.Add(new ListItem("Articulos.....", "0"));
            foreach (var item in inventarios.items)
            {
                clsArticulo articulo = cArticulo.GetArticulo(int.Parse(item.idarticulo.ToString()));
                i = new ListItem(articulo.pdescripcion, articulo.pidarticulo.ToString());
                cboProducto.Items.Add(i);
            }
        }

        private void crearTablaHeader()
        {
            dt.Columns.Add("# Linea");
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Producto");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Descuento");
            dt.Columns.Add("Impuesto");
            dt.Columns.Add("Total");
            tablaDetalleFactura.DataSource = dt;
        }

        private void crearTablaBody(decimal precio)
        {
            double monto = double.Parse(precio.ToString()) * int.Parse(txtCantidad.Text);
            double descuento = int.Parse(txtDescuento.Text);
            if (descuento != 0)
            {
                descuento = monto * (int.Parse(txtDescuento.Text) / 100);
            }
            double impuesto = monto * 0.13;
            double total = monto - descuento + impuesto;

            DataRow row = dt.NewRow();

            row["# Linea"] = cont.ToString();
            row["Codigo"] = cboProducto.SelectedItem.Value;
            row["Nombre"] = cboProducto.SelectedItem.Text;
            row["Cantidad"] = txtCantidad.Text;
            row["Precio"] = precio.ToString();
            row["Descuento"] = descuento.ToString();
            row["Impuesto"] = impuesto.ToString();
            row["Total"] = total.ToString();
            dt.Rows.Add(row);
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            cont = cont + 1;
            inventarioController controller = new inventarioController();
            dynamic inventarios = controller.GetInventarios();
            decimal precio = 0;
            foreach (var item in inventarios.items)
            {
                if(cboProducto.SelectedItem.Value.Equals(item.idarticulo.ToString()))
                {
                    precio = item.preciounit;
                }
            }
            crearTablaBody(precio);
        }

        protected void tablaDetalleFactura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        
    }
}