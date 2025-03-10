
namespace WindowsFormsProyecto2
{
    partial class frmInventario
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
            this.pnlGeneralFacturaDetalleEditar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCaducidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxArticulo = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.comboxSucursal = new System.Windows.Forms.ComboBox();
            this.cboxEmpresa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnActualiszar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNumeroEstante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.pnlGeneralFacturaDetalleEditar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGeneralFacturaDetalleEditar
            // 
            this.pnlGeneralFacturaDetalleEditar.Controls.Add(this.panel3);
            this.pnlGeneralFacturaDetalleEditar.Controls.Add(this.dgvFactura);
            this.pnlGeneralFacturaDetalleEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneralFacturaDetalleEditar.Location = new System.Drawing.Point(0, 0);
            this.pnlGeneralFacturaDetalleEditar.Name = "pnlGeneralFacturaDetalleEditar";
            this.pnlGeneralFacturaDetalleEditar.Size = new System.Drawing.Size(1264, 654);
            this.pnlGeneralFacturaDetalleEditar.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtPrecio);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtCaducidad);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtMinimo);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtMaximo);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtCantidad);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cboxArticulo);
            this.panel3.Controls.Add(this.btnAgregar);
            this.panel3.Controls.Add(this.comboxSucursal);
            this.panel3.Controls.Add(this.cboxEmpresa);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnAnular);
            this.panel3.Controls.Add(this.btnActualiszar);
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.txtNumeroEstante);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1240, 277);
            this.panel3.TabIndex = 34;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(229, 231);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(218, 20);
            this.txtPrecio.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "PRECIO";
            // 
            // txtCaducidad
            // 
            this.txtCaducidad.Location = new System.Drawing.Point(876, 151);
            this.txtCaducidad.Name = "txtCaducidad";
            this.txtCaducidad.Size = new System.Drawing.Size(218, 20);
            this.txtCaducidad.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(674, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "CADUCIDAD";
            // 
            // txtMinimo
            // 
            this.txtMinimo.Location = new System.Drawing.Point(876, 111);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(218, 20);
            this.txtMinimo.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "MINIMO";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(876, 72);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(218, 20);
            this.txtMaximo.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(674, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "MAXIMO";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(228, 194);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(218, 20);
            this.txtCantidad.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "CANTIDAD";
            // 
            // cboxArticulo
            // 
            this.cboxArticulo.FormattingEnabled = true;
            this.cboxArticulo.Location = new System.Drawing.Point(229, 151);
            this.cboxArticulo.Name = "cboxArticulo";
            this.cboxArticulo.Size = new System.Drawing.Size(398, 21);
            this.cboxArticulo.TabIndex = 47;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(818, 209);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 63);
            this.btnAgregar.TabIndex = 46;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // comboxSucursal
            // 
            this.comboxSucursal.FormattingEnabled = true;
            this.comboxSucursal.Location = new System.Drawing.Point(228, 110);
            this.comboxSucursal.Name = "comboxSucursal";
            this.comboxSucursal.Size = new System.Drawing.Size(398, 21);
            this.comboxSucursal.TabIndex = 44;
            // 
            // cboxEmpresa
            // 
            this.cboxEmpresa.FormattingEnabled = true;
            this.cboxEmpresa.Location = new System.Drawing.Point(228, 72);
            this.cboxEmpresa.Name = "cboxEmpresa";
            this.cboxEmpresa.Size = new System.Drawing.Size(398, 21);
            this.cboxEmpresa.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "ARTICULO";
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(1100, 209);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(135, 63);
            this.btnAnular.TabIndex = 34;
            this.btnAnular.Text = "ANULAR";
            this.btnAnular.UseVisualStyleBackColor = true;
            // 
            // btnActualiszar
            // 
            this.btnActualiszar.Location = new System.Drawing.Point(959, 209);
            this.btnActualiszar.Name = "btnActualiszar";
            this.btnActualiszar.Size = new System.Drawing.Size(135, 63);
            this.btnActualiszar.TabIndex = 33;
            this.btnActualiszar.Text = "ACTUALIZAR ";
            this.btnActualiszar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(467, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(159, 23);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "BUSCAR ESTANTE";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNumeroEstante
            // 
            this.txtNumeroEstante.Location = new System.Drawing.Point(229, 36);
            this.txtNumeroEstante.Name = "txtNumeroEstante";
            this.txtNumeroEstante.Size = new System.Drawing.Size(218, 20);
            this.txtNumeroEstante.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "EMPRESA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "NUMERO DE INVENTARIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "SUCURSAL";
            // 
            // dgvFactura
            // 
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Location = new System.Drawing.Point(12, 295);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.RowHeadersWidth = 51;
            this.dgvFactura.Size = new System.Drawing.Size(1240, 347);
            this.dgvFactura.TabIndex = 33;
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 654);
            this.Controls.Add(this.pnlGeneralFacturaDetalleEditar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventario";
            this.Text = "frmClienteAgregar";
            this.pnlGeneralFacturaDetalleEditar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGeneralFacturaDetalleEditar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCaducidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxArticulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox comboxSucursal;
        private System.Windows.Forms.ComboBox cboxEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnActualiszar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNumeroEstante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvFactura;
    }
}