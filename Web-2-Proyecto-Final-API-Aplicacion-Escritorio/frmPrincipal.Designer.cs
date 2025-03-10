
namespace WindowsFormsProyecto2
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.btnUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSucursal = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFacturacion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditarFactura = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditarDetalleFacutra = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGenerarFactura = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVENTARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBodega = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEstante = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSeccion = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUsuario = new System.Windows.Forms.ToolStripTextBox();
            this.txtSucursal = new System.Windows.Forms.ToolStripTextBox();
            this.txtEmpresa = new System.Windows.Forms.ToolStripTextBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUsuario,
            this.btnFacturacion,
            this.iNVENTARIOToolStripMenuItem,
            this.txtUsuario,
            this.txtSucursal,
            this.txtEmpresa});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1264, 27);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "MENU";
            // 
            // btnUsuario
            // 
            this.btnUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCliente,
            this.btnEmpleado,
            this.btnEmpresa,
            this.btnProveedor,
            this.btnSucursal,
            this.uSUARIOToolStripMenuItem});
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(67, 23);
            this.btnUsuario.Text = "ENTIDAD";
            // 
            // btnCliente
            // 
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(140, 22);
            this.btnCliente.Text = "CLIENTE";
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(140, 22);
            this.btnEmpleado.Text = "EMPLEADO";
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(140, 22);
            this.btnEmpresa.Text = "EMPRESA";
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(140, 22);
            this.btnProveedor.Text = "PROVEEDOR";
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnSucursal
            // 
            this.btnSucursal.Name = "btnSucursal";
            this.btnSucursal.Size = new System.Drawing.Size(140, 22);
            this.btnSucursal.Text = "SUCURSAL";
            this.btnSucursal.Click += new System.EventHandler(this.btnSucursal_Click);
            // 
            // uSUARIOToolStripMenuItem
            // 
            this.uSUARIOToolStripMenuItem.Name = "uSUARIOToolStripMenuItem";
            this.uSUARIOToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.uSUARIOToolStripMenuItem.Text = "USUARIO";
            this.uSUARIOToolStripMenuItem.Click += new System.EventHandler(this.uSUARIOToolStripMenuItem_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditarFactura,
            this.btnEditarDetalleFacutra,
            this.btnGenerarFactura});
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(98, 23);
            this.btnFacturacion.Text = "FACTURACION";
            // 
            // btnEditarFactura
            // 
            this.btnEditarFactura.Name = "btnEditarFactura";
            this.btnEditarFactura.Size = new System.Drawing.Size(212, 22);
            this.btnEditarFactura.Text = "EDITAR FACRUTA";
            this.btnEditarFactura.Click += new System.EventHandler(this.btnBuscarFactura_Click);
            // 
            // btnEditarDetalleFacutra
            // 
            this.btnEditarDetalleFacutra.Name = "btnEditarDetalleFacutra";
            this.btnEditarDetalleFacutra.Size = new System.Drawing.Size(212, 22);
            this.btnEditarDetalleFacutra.Text = "EDITAR DETALLE FACTURA";
            this.btnEditarDetalleFacutra.Click += new System.EventHandler(this.btnEditarDetalleFacutra_Click);
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(212, 22);
            this.btnGenerarFactura.Text = "GENERAR FACTURA";
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // iNVENTARIOToolStripMenuItem
            // 
            this.iNVENTARIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnArticulo,
            this.btnBodega,
            this.btnCategoria,
            this.btnEstante,
            this.btnInventario,
            this.btnSeccion});
            this.iNVENTARIOToolStripMenuItem.Name = "iNVENTARIOToolStripMenuItem";
            this.iNVENTARIOToolStripMenuItem.Size = new System.Drawing.Size(85, 23);
            this.iNVENTARIOToolStripMenuItem.Text = "INVENTARIO";
            // 
            // btnArticulo
            // 
            this.btnArticulo.Name = "btnArticulo";
            this.btnArticulo.Size = new System.Drawing.Size(140, 22);
            this.btnArticulo.Text = "ARTICULO";
            this.btnArticulo.Click += new System.EventHandler(this.btnArticulo_Click);
            // 
            // btnBodega
            // 
            this.btnBodega.Name = "btnBodega";
            this.btnBodega.Size = new System.Drawing.Size(140, 22);
            this.btnBodega.Text = "BODEGA";
            this.btnBodega.Click += new System.EventHandler(this.btnBodega_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(140, 22);
            this.btnCategoria.Text = "CATEGORIA";
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnEstante
            // 
            this.btnEstante.Name = "btnEstante";
            this.btnEstante.Size = new System.Drawing.Size(140, 22);
            this.btnEstante.Text = "ESTANTE";
            this.btnEstante.Click += new System.EventHandler(this.btnEstante_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(140, 22);
            this.btnInventario.Text = "INVENTARIO";
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnSeccion
            // 
            this.btnSeccion.Name = "btnSeccion";
            this.btnSeccion.Size = new System.Drawing.Size(140, 22);
            this.btnSeccion.Text = "SECCION";
            this.btnSeccion.Click += new System.EventHandler(this.btnSeccion_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(300, 23);
            this.txtUsuario.Text = "USUARIO";
            // 
            // txtSucursal
            // 
            this.txtSucursal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.ReadOnly = true;
            this.txtSucursal.Size = new System.Drawing.Size(200, 23);
            this.txtSucursal.Text = "SUCURSAL";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtEmpresa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.ReadOnly = true;
            this.txtEmpresa.Size = new System.Drawing.Size(200, 23);
            this.txtEmpresa.Text = "EMPRESA";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 27);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1264, 654);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supermercados Patitos S.A.";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem btnFacturacion;
        private System.Windows.Forms.ToolStripMenuItem iNVENTARIOToolStripMenuItem;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.ToolStripMenuItem btnGenerarFactura;
        private System.Windows.Forms.ToolStripMenuItem btnEditarFactura;
        private System.Windows.Forms.ToolStripMenuItem btnArticulo;
        private System.Windows.Forms.ToolStripMenuItem btnBodega;
        private System.Windows.Forms.ToolStripMenuItem btnEstante;
        private System.Windows.Forms.ToolStripMenuItem btnSeccion;
        private System.Windows.Forms.ToolStripMenuItem btnUsuario;
        private System.Windows.Forms.ToolStripMenuItem btnCliente;
        private System.Windows.Forms.ToolStripMenuItem btnEmpleado;
        private System.Windows.Forms.ToolStripMenuItem btnEmpresa;
        private System.Windows.Forms.ToolStripMenuItem btnSucursal;
        private System.Windows.Forms.ToolStripMenuItem btnProveedor;
        private System.Windows.Forms.ToolStripMenuItem btnEditarDetalleFacutra;
        private System.Windows.Forms.ToolStripMenuItem btnInventario;
        private System.Windows.Forms.ToolStripMenuItem btnCategoria;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuBar;
        public System.Windows.Forms.ToolStripTextBox txtEmpresa;
        public System.Windows.Forms.ToolStripTextBox txtUsuario;
        public System.Windows.Forms.ToolStripTextBox txtSucursal;
    }
}

