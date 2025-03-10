
namespace WindowsFormsProyecto2
{
    partial class frmEmpleado
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
            this.pnlGeneralEmpleado = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPersona = new System.Windows.Forms.TextBox();
            this.cboxPuesto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxEmpresa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboxSucursal = new System.Windows.Forms.ComboBox();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnActualiszar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNumeroEmpleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.pnlGeneralEmpleado.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGeneralEmpleado
            // 
            this.pnlGeneralEmpleado.Controls.Add(this.panel3);
            this.pnlGeneralEmpleado.Controls.Add(this.dgvEmpleado);
            this.pnlGeneralEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneralEmpleado.Location = new System.Drawing.Point(0, 0);
            this.pnlGeneralEmpleado.Name = "pnlGeneralEmpleado";
            this.pnlGeneralEmpleado.Size = new System.Drawing.Size(1264, 654);
            this.pnlGeneralEmpleado.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtPersona);
            this.panel3.Controls.Add(this.cboxPuesto);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cboxEmpresa);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnAgregar);
            this.panel3.Controls.Add(this.cboxSucursal);
            this.panel3.Controls.Add(this.btnAnular);
            this.panel3.Controls.Add(this.btnActualiszar);
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.txtNumeroEmpleado);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1240, 277);
            this.panel3.TabIndex = 34;
            // 
            // txtPersona
            // 
            this.txtPersona.Location = new System.Drawing.Point(228, 152);
            this.txtPersona.Name = "txtPersona";
            this.txtPersona.Size = new System.Drawing.Size(398, 20);
            this.txtPersona.TabIndex = 57;
            // 
            // cboxPuesto
            // 
            this.cboxPuesto.FormattingEnabled = true;
            this.cboxPuesto.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "CAJERO",
            "PROVEDIRIA"});
            this.cboxPuesto.Location = new System.Drawing.Point(228, 191);
            this.cboxPuesto.Name = "cboxPuesto";
            this.cboxPuesto.Size = new System.Drawing.Size(398, 21);
            this.cboxPuesto.TabIndex = 56;
            this.cboxPuesto.Text = "ADMINISTRADOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "CEDULA PERSONA";
            // 
            // cboxEmpresa
            // 
            this.cboxEmpresa.FormattingEnabled = true;
            this.cboxEmpresa.Location = new System.Drawing.Point(229, 112);
            this.cboxEmpresa.Name = "cboxEmpresa";
            this.cboxEmpresa.Size = new System.Drawing.Size(398, 21);
            this.cboxEmpresa.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "PUESTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "EMPRESA";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(818, 209);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 63);
            this.btnAgregar.TabIndex = 46;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboxSucursal
            // 
            this.cboxSucursal.FormattingEnabled = true;
            this.cboxSucursal.Location = new System.Drawing.Point(228, 72);
            this.cboxSucursal.Name = "cboxSucursal";
            this.cboxSucursal.Size = new System.Drawing.Size(398, 21);
            this.cboxSucursal.TabIndex = 37;
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(1100, 209);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(135, 63);
            this.btnAnular.TabIndex = 34;
            this.btnAnular.Text = "ANULAR";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnActualiszar
            // 
            this.btnActualiszar.Location = new System.Drawing.Point(959, 209);
            this.btnActualiszar.Name = "btnActualiszar";
            this.btnActualiszar.Size = new System.Drawing.Size(135, 63);
            this.btnActualiszar.TabIndex = 33;
            this.btnActualiszar.Text = "ACTUALIZAR ";
            this.btnActualiszar.UseVisualStyleBackColor = true;
            this.btnActualiszar.Click += new System.EventHandler(this.btnActualiszar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(467, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(159, 23);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "BUSCAR EMPELADO";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNumeroEmpleado
            // 
            this.txtNumeroEmpleado.Location = new System.Drawing.Point(229, 36);
            this.txtNumeroEmpleado.Name = "txtNumeroEmpleado";
            this.txtNumeroEmpleado.Size = new System.Drawing.Size(218, 20);
            this.txtNumeroEmpleado.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "SUCURSAL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "NUMERO DE EMPLEADO";
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Location = new System.Drawing.Point(12, 295);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.RowHeadersWidth = 51;
            this.dgvEmpleado.Size = new System.Drawing.Size(1240, 347);
            this.dgvEmpleado.TabIndex = 33;
            this.dgvEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleado_CellClick);
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 654);
            this.Controls.Add(this.pnlGeneralEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpleado";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            this.pnlGeneralEmpleado.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGeneralEmpleado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboxSucursal;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnActualiszar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNumeroEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxEmpresa;
        private System.Windows.Forms.ComboBox cboxPuesto;
        private System.Windows.Forms.TextBox txtPersona;
    }
}