
namespace WindowsFormsProyecto2
{
    partial class frmFacturaEditar
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
            this.pnlGeneralFacturaEditar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbtnContado = new System.Windows.Forms.RadioButton();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtNumeroFacura = new System.Windows.Forms.TextBox();
            this.rbtnCredito = new System.Windows.Forms.RadioButton();
            this.cboxCliente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxEmpleado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.cboxEmpresa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxSucursal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualiszar = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.pnlGeneralFacturaEditar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGeneralFacturaEditar
            // 
            this.pnlGeneralFacturaEditar.Controls.Add(this.panel3);
            this.pnlGeneralFacturaEditar.Controls.Add(this.dgvFactura);
            this.pnlGeneralFacturaEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneralFacturaEditar.Location = new System.Drawing.Point(0, 0);
            this.pnlGeneralFacturaEditar.Name = "pnlGeneralFacturaEditar";
            this.pnlGeneralFacturaEditar.Size = new System.Drawing.Size(1264, 654);
            this.pnlGeneralFacturaEditar.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnAnular);
            this.panel3.Controls.Add(this.btnActualiszar);
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.cboxSucursal);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cboxEmpresa);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.rbtnContado);
            this.panel3.Controls.Add(this.txtFecha);
            this.panel3.Controls.Add(this.txtNumeroFacura);
            this.panel3.Controls.Add(this.rbtnCredito);
            this.panel3.Controls.Add(this.cboxCliente);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cboxEmpleado);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1240, 242);
            this.panel3.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(617, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "TIPO DE FACTURA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(617, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "FECHA";
            // 
            // rbtnContado
            // 
            this.rbtnContado.AutoSize = true;
            this.rbtnContado.Checked = true;
            this.rbtnContado.Location = new System.Drawing.Point(751, 115);
            this.rbtnContado.Name = "rbtnContado";
            this.rbtnContado.Size = new System.Drawing.Size(78, 17);
            this.rbtnContado.TabIndex = 21;
            this.rbtnContado.TabStop = true;
            this.rbtnContado.Text = "CONTADO";
            this.rbtnContado.UseVisualStyleBackColor = true;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(751, 72);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(159, 20);
            this.txtFecha.TabIndex = 24;
            // 
            // txtNumeroFacura
            // 
            this.txtNumeroFacura.Location = new System.Drawing.Point(162, 36);
            this.txtNumeroFacura.Name = "txtNumeroFacura";
            this.txtNumeroFacura.Size = new System.Drawing.Size(218, 20);
            this.txtNumeroFacura.TabIndex = 27;
            // 
            // rbtnCredito
            // 
            this.rbtnCredito.AutoSize = true;
            this.rbtnCredito.Location = new System.Drawing.Point(836, 115);
            this.rbtnCredito.Name = "rbtnCredito";
            this.rbtnCredito.Size = new System.Drawing.Size(74, 17);
            this.rbtnCredito.TabIndex = 22;
            this.rbtnCredito.Text = "DREDITO";
            this.rbtnCredito.UseVisualStyleBackColor = true;
            // 
            // cboxCliente
            // 
            this.cboxCliente.FormattingEnabled = true;
            this.cboxCliente.Location = new System.Drawing.Point(161, 72);
            this.cboxCliente.Name = "cboxCliente";
            this.cboxCliente.Size = new System.Drawing.Size(407, 21);
            this.cboxCliente.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "CLIENTE";
            // 
            // cboxEmpleado
            // 
            this.cboxEmpleado.FormattingEnabled = true;
            this.cboxEmpleado.Location = new System.Drawing.Point(161, 114);
            this.cboxEmpleado.Name = "cboxEmpleado";
            this.cboxEmpleado.Size = new System.Drawing.Size(407, 21);
            this.cboxEmpleado.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "NUMERO DE FACTURA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "EMPLEADO";
            // 
            // dgvFactura
            // 
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Location = new System.Drawing.Point(12, 260);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.Size = new System.Drawing.Size(1240, 312);
            this.dgvFactura.TabIndex = 31;
            // 
            // cboxEmpresa
            // 
            this.cboxEmpresa.FormattingEnabled = true;
            this.cboxEmpresa.Location = new System.Drawing.Point(161, 156);
            this.cboxEmpresa.Name = "cboxEmpresa";
            this.cboxEmpresa.Size = new System.Drawing.Size(407, 21);
            this.cboxEmpresa.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "EMPRESA";
            // 
            // cboxSucursal
            // 
            this.cboxSucursal.FormattingEnabled = true;
            this.cboxSucursal.Location = new System.Drawing.Point(161, 196);
            this.cboxSucursal.Name = "cboxSucursal";
            this.cboxSucursal.Size = new System.Drawing.Size(407, 21);
            this.cboxSucursal.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "SUCURSAL";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(400, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(168, 23);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnActualiszar
            // 
            this.btnActualiszar.Location = new System.Drawing.Point(620, 154);
            this.btnActualiszar.Name = "btnActualiszar";
            this.btnActualiszar.Size = new System.Drawing.Size(136, 63);
            this.btnActualiszar.TabIndex = 33;
            this.btnActualiszar.Text = "ACTUALIZAR ";
            this.btnActualiszar.UseVisualStyleBackColor = true;
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(775, 154);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(135, 63);
            this.btnAnular.TabIndex = 34;
            this.btnAnular.Text = "ANULAR";
            this.btnAnular.UseVisualStyleBackColor = true;
            // 
            // frmFacturaEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 654);
            this.Controls.Add(this.pnlGeneralFacturaEditar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacturaEditar";
            this.Text = "frmBuscarFatura";
            this.pnlGeneralFacturaEditar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGeneralFacturaEditar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbtnContado;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtNumeroFacura;
        private System.Windows.Forms.RadioButton rbtnCredito;
        private System.Windows.Forms.ComboBox cboxCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxEmpleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.ComboBox cboxSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnActualiszar;
        private System.Windows.Forms.Button btnBuscar;
    }
}