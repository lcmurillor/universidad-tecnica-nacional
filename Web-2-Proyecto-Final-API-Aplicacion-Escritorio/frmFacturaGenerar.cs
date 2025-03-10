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
    public partial class frmFacturaGenerar : Form
    {
        facturaController factura = new facturaController();
        clienteContorller cCliente = new clienteContorller();
        personaController cPersona = new personaController();
        inventarioController cInventario = new inventarioController();
        articuloController cArticulo = new articuloController();
        DataTable dt = new DataTable();
        int cont = 0;
        public frmFacturaGenerar()
        {
            InitializeComponent();
        }

        private void frmFacturaGenerar_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();
            cargarClientes();
            cargarProductos();
            creaTablaHeader();
        }

        private void cargarClientes()
        {
            dynamic clientes = cCliente.GetClientes();
            dynamic i = new List<cboCliente>();
            foreach (var item in clientes.items)
            {
                clsPersona persona = cPersona.GetPersona(item.idpersona.ToString());
                string nombreCliente = persona.nombre.Trim() + " " + persona.apellido1.Trim() + " " + persona.apellido2.Trim();
                i.Add(new cboCliente { idCliente = item.idcliente, nombreCliente = nombreCliente });
            }

            cboxCliente.DataSource = i;
            cboxCliente.DisplayMember = "nombreCliente";
            cboxCliente.ValueMember = "idCliente";
        }

        private void cargarProductos()
        {
            dynamic inventarios = cInventario.GetInventarios();
            dynamic i = new List<clsArticulo>();

            foreach (var item in inventarios.items)
            {
                clsArticulo articulo = cArticulo.GetArticulo(int.Parse(item.idarticulo.ToString()));
                i.Add(articulo);
            }

            cboxArticulo.DataSource = i;
            cboxArticulo.DisplayMember = "pdescripcion";
            cboxArticulo.ValueMember = "pidarticulo";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                cont = cont + 1;
                double precio = Extraerprecio(), monto = calcularMonto(precio);
                CargarDGV(cont, precio, monto, calcularDescuento(monto), calcularImpuesto(monto));
                calcularDetalle();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, intentelo de nuevo");
            }
        }

        private double Extraerprecio()
        {
            double precio = 0;
            dynamic inventarios = cInventario.GetInventarios();
            foreach (var item in inventarios.items)
            {
                if (cboxArticulo.SelectedValue.ToString().Equals(item.idarticulo.ToString()))
                {
                    precio = double.Parse(item.preciounit.ToString());
                }
            }
            return precio;
        }

        private double calcularMonto(double precio)
        {
            return precio * int.Parse(txtCantidad.Text);
        }

        private double calcularImpuesto(double monto)
        {
            return monto * 0.13;
        }

        private double calcularDescuento(double monto)
        {
            double descuento = 0;

            if (!txtDescuento.Text.Equals("0"))
            {
                descuento = monto * (double.Parse(txtDescuento.Text) / 100);
            }

            return descuento;
        }

        private void calcularDetalle()
        {
            double subTotal=0, impuesto=0, descuento=0, total=0;

            foreach (DataGridViewRow item in dgvFactura.Rows)
            {
                subTotal += double.Parse(item.Cells[7].Value.ToString());
                impuesto += double.Parse(item.Cells[6].Value.ToString());
                descuento += double.Parse(item.Cells[5].Value.ToString());
            }

            total = subTotal + impuesto - descuento;

            txtSubtotal.Text = subTotal.ToString();
            txtIva.Text = impuesto.ToString();
            txtDescuento2.Text = descuento.ToString();
            txtTotal.Text = total.ToString();
        }

        private void CargarDGV(int cont, double precio, double monto, double descuento, double impuesto)
        {
            try
            {
                double totalLinea = monto - descuento + impuesto;
                dt.Rows.Add(new Object[]
                {
                    cont,
                    int.Parse(cboxArticulo.SelectedValue.ToString()),
                    cboxArticulo.Text,
                    txtCantidad.Text,
                    precio,
                    descuento,
                    impuesto,
                    totalLinea
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void creaTablaHeader()
        {
            
            dt.Columns.Add("# Linea");
            dt.Columns.Add("Código");
            dt.Columns.Add("Producto");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Descuento");
            dt.Columns.Add("Impuesto");
            dt.Columns.Add("Total Linea");
            dgvFactura.DataSource = dt;
            
        }

        private void dgvFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, intentelo de nuevo");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                clsFactura fact = new clsFactura
                {
                    accion = "I",
                    pidfactura = 1,
                    pidcliente = int.Parse(cboxCliente.SelectedValue.ToString()),
                    pidempleado = 1,
                    pidempresa = 1,
                    pidsucursal = 1,
                    pfecha = DateTime.Now,
                    pestado = "A"
                };

                factura.MantenimientoFactura(fact);

                foreach (DataGridViewRow item in dgvFactura.Rows)
                {
                    clsFacturaDetalle factDet = new clsFacturaDetalle
                    {
                        accion = "I",
                        piddetallefactura = int.Parse(item.Cells[0].Value.ToString()),
                        pnumerolinea = int.Parse(item.Cells[0].Value.ToString()),
                        pidarticulo = int.Parse(item.Cells[1].Value.ToString()),
                        pidfactura = 21,
                        pcantidad = int.Parse(item.Cells[3].Value.ToString()),
                        pprecio = int.Parse(item.Cells[4].Value.ToString()),
                        pdescuento = int.Parse(item.Cells[5].Value.ToString()),
                        pimpuesto = int.Parse(item.Cells[6].Value.ToString()),
                        pestado = "A"
                    };
                }

            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, intentelo de nuevo");
            }
        }
    }


    public class cboCliente
    {
        public int idCliente { get; set; }
        public string nombreCliente { get; set; }
    }
}
