
namespace WindowsFormsProyecto2
{
    partial class frmFacturaDetalleEditar
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
            this.pnlGeneralArticulo = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboxArticulo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroLinea = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualiszar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvFacturaDetalle = new System.Windows.Forms.DataGridView();
            this.txtNumeroFatura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlGeneralArticulo.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGeneralArticulo
            // 
            this.pnlGeneralArticulo.Controls.Add(this.panel3);
            this.pnlGeneralArticulo.Controls.Add(this.dgvFacturaDetalle);
            this.pnlGeneralArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneralArticulo.Location = new System.Drawing.Point(0, 0);
            this.pnlGeneralArticulo.Name = "pnlGeneralArticulo";
            this.pnlGeneralArticulo.Size = new System.Drawing.Size(1264, 654);
            this.pnlGeneralArticulo.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.txtNumeroFatura);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtDescuento);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtCantidad);
            this.panel3.Controls.Add(this.cboxArticulo);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtNumeroLinea);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnActualiszar);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtPrecio);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1240, 277);
            this.panel3.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "DESCUENTO";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(751, 110);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(159, 20);
            this.txtDescuento.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "CANTIDAD";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(225, 143);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(218, 20);
            this.txtCantidad.TabIndex = 39;
            // 
            // cboxArticulo
            // 
            this.cboxArticulo.FormattingEnabled = true;
            this.cboxArticulo.Location = new System.Drawing.Point(225, 107);
            this.cboxArticulo.Name = "cboxArticulo";
            this.cboxArticulo.Size = new System.Drawing.Size(339, 21);
            this.cboxArticulo.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "ARTICULO";
            // 
            // txtNumeroLinea
            // 
            this.txtNumeroLinea.Location = new System.Drawing.Point(225, 66);
            this.txtNumeroLinea.Name = "txtNumeroLinea";
            this.txtNumeroLinea.Size = new System.Drawing.Size(339, 20);
            this.txtNumeroLinea.TabIndex = 36;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(182, 196);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 63);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.Text = "ANULAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualiszar
            // 
            this.btnActualiszar.Location = new System.Drawing.Point(27, 196);
            this.btnActualiszar.Name = "btnActualiszar";
            this.btnActualiszar.Size = new System.Drawing.Size(136, 63);
            this.btnActualiszar.TabIndex = 33;
            this.btnActualiszar.Text = "ACTUALIZAR ";
            this.btnActualiszar.UseVisualStyleBackColor = true;
            this.btnActualiszar.Click += new System.EventHandler(this.btnActualiszar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(617, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "PRECIO";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(751, 72);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(159, 20);
            this.txtPrecio.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "NUMERO DE LINEA";
            // 
            // dgvFacturaDetalle
            // 
            this.dgvFacturaDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturaDetalle.Location = new System.Drawing.Point(12, 295);
            this.dgvFacturaDetalle.Name = "dgvFacturaDetalle";
            this.dgvFacturaDetalle.Size = new System.Drawing.Size(1240, 330);
            this.dgvFacturaDetalle.TabIndex = 35;
            this.dgvFacturaDetalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacturaDetalle_CellClick);
            // 
            // txtNumeroFatura
            // 
            this.txtNumeroFatura.Location = new System.Drawing.Point(225, 21);
            this.txtNumeroFatura.Name = "txtNumeroFatura";
            this.txtNumeroFatura.Size = new System.Drawing.Size(218, 20);
            this.txtNumeroFatura.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "NUMERO DE FACTURA";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(449, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(115, 23);
            this.btnBuscar.TabIndex = 45;
            this.btnBuscar.Text = "BUSCAR DETALLE";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmFacturaDetalleEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 654);
            this.Controls.Add(this.pnlGeneralArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacturaDetalleEditar";
            this.Text = "frmFacturaDetalleEditar";
            this.Load += new System.EventHandler(this.frmFacturaDetalleEditar_Load);
            this.pnlGeneralArticulo.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGeneralArticulo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cboxArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroLinea;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualiszar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvFacturaDetalle;
        private System.Windows.Forms.TextBox txtNumeroFatura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
    }
}