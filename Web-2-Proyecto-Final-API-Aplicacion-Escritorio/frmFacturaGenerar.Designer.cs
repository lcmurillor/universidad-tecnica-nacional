
namespace WindowsFormsProyecto2
{
    partial class frmFacturaGenerar
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
            this.pnlGenerarFactura = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbtnContado = new System.Windows.Forms.RadioButton();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtNumeroFacura = new System.Windows.Forms.TextBox();
            this.rbtnCredito = new System.Windows.Forms.RadioButton();
            this.cboxCliente = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxArticulo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.txtDescuento = new System.Windows.Forms.NumericUpDown();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtDescuento2 = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlGenerarFactura.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGenerarFactura
            // 
            this.pnlGenerarFactura.Controls.Add(this.panel3);
            this.pnlGenerarFactura.Controls.Add(this.panel1);
            this.pnlGenerarFactura.Controls.Add(this.dgvFactura);
            this.pnlGenerarFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGenerarFactura.Location = new System.Drawing.Point(0, 0);
            this.pnlGenerarFactura.Name = "pnlGenerarFactura";
            this.pnlGenerarFactura.Size = new System.Drawing.Size(1264, 654);
            this.pnlGenerarFactura.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtCantidad);
            this.panel3.Controls.Add(this.txtDescuento);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.btnAgregar);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.rbtnContado);
            this.panel3.Controls.Add(this.txtFecha);
            this.panel3.Controls.Add(this.txtNumeroFacura);
            this.panel3.Controls.Add(this.rbtnCredito);
            this.panel3.Controls.Add(this.cboxCliente);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cboxArticulo);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1240, 171);
            this.panel3.TabIndex = 30;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(584, 85);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 57);
            this.btnAgregar.TabIndex = 47;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(398, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "CANTIDAD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(923, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "TIPO DE FACTURA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1087, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "FECHA";
            // 
            // rbtnContado
            // 
            this.rbtnContado.AutoSize = true;
            this.rbtnContado.Checked = true;
            this.rbtnContado.Location = new System.Drawing.Point(1051, 44);
            this.rbtnContado.Name = "rbtnContado";
            this.rbtnContado.Size = new System.Drawing.Size(78, 17);
            this.rbtnContado.TabIndex = 21;
            this.rbtnContado.TabStop = true;
            this.rbtnContado.Text = "CONTADO";
            this.rbtnContado.UseVisualStyleBackColor = true;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(1135, 3);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 24;
            // 
            // txtNumeroFacura
            // 
            this.txtNumeroFacura.Location = new System.Drawing.Point(727, 43);
            this.txtNumeroFacura.Name = "txtNumeroFacura";
            this.txtNumeroFacura.ReadOnly = true;
            this.txtNumeroFacura.Size = new System.Drawing.Size(170, 20);
            this.txtNumeroFacura.TabIndex = 27;
            // 
            // rbtnCredito
            // 
            this.rbtnCredito.AutoSize = true;
            this.rbtnCredito.Location = new System.Drawing.Point(1136, 44);
            this.rbtnCredito.Name = "rbtnCredito";
            this.rbtnCredito.Size = new System.Drawing.Size(74, 17);
            this.rbtnCredito.TabIndex = 22;
            this.rbtnCredito.Text = "DREDITO";
            this.rbtnCredito.UseVisualStyleBackColor = true;
            // 
            // cboxCliente
            // 
            this.cboxCliente.FormattingEnabled = true;
            this.cboxCliente.Location = new System.Drawing.Point(161, 43);
            this.cboxCliente.Name = "cboxCliente";
            this.cboxCliente.Size = new System.Drawing.Size(407, 21);
            this.cboxCliente.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "DESCUENTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "CLIENTE";
            // 
            // cboxArticulo
            // 
            this.cboxArticulo.FormattingEnabled = true;
            this.cboxArticulo.Location = new System.Drawing.Point(161, 85);
            this.cboxArticulo.Name = "cboxArticulo";
            this.cboxArticulo.Size = new System.Drawing.Size(407, 21);
            this.cboxArticulo.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(593, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "NUMERO DE FACTURA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "ARTICULO";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtDescuento2);
            this.panel1.Controls.Add(this.txtIva);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSubtotal);
            this.panel1.Location = new System.Drawing.Point(942, 507);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 135);
            this.panel1.TabIndex = 13;
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(97, 43);
            this.txtIva.Name = "txtIva";
            this.txtIva.ReadOnly = true;
            this.txtIva.Size = new System.Drawing.Size(190, 20);
            this.txtIva.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SUBTOTAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "IVA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "DESCUENTO";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(97, 95);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(190, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "TOTAL";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(97, 17);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(190, 20);
            this.txtSubtotal.TabIndex = 5;
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Location = new System.Drawing.Point(12, 189);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.Size = new System.Drawing.Size(1240, 312);
            this.dgvFactura.TabIndex = 0;
            this.dgvFactura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_CellClick);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtDescuento.Location = new System.Drawing.Point(161, 123);
            this.txtDescuento.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.txtDescuento.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(140, 20);
            this.txtDescuento.TabIndex = 48;
            this.txtDescuento.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(466, 122);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(102, 20);
            this.txtCantidad.TabIndex = 49;
            // 
            // txtDescuento2
            // 
            this.txtDescuento2.Location = new System.Drawing.Point(97, 69);
            this.txtDescuento2.Name = "txtDescuento2";
            this.txtDescuento2.ReadOnly = true;
            this.txtDescuento2.Size = new System.Drawing.Size(190, 20);
            this.txtDescuento2.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(926, 88);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(291, 57);
            this.btnGuardar.TabIndex = 47;
            this.btnGuardar.Text = "FINALIZAR FACTURA";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmFacturaGenerar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 654);
            this.Controls.Add(this.pnlGenerarFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacturaGenerar";
            this.Text = "frmGenerarFactura";
            this.Load += new System.EventHandler(this.frmFacturaGenerar_Load);
            this.pnlGenerarFactura.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGenerarFactura;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxArticulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxCliente;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtnContado;
        private System.Windows.Forms.RadioButton rbtnCredito;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNumeroFacura;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.NumericUpDown txtDescuento;
        private System.Windows.Forms.TextBox txtDescuento2;
        private System.Windows.Forms.Button btnGuardar;
    }
}