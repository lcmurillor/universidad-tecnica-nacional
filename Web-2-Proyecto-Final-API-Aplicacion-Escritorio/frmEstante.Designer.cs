
namespace WindowsFormsProyecto2
{
    partial class frmEstante
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.cboxSeccion = new System.Windows.Forms.ComboBox();
            this.cboxBodega = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnActualiszar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNumeroEstante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvEstante = new System.Windows.Forms.DataGridView();
            this.pnlGeneralFacturaDetalleEditar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstante)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGeneralFacturaDetalleEditar
            // 
            this.pnlGeneralFacturaDetalleEditar.Controls.Add(this.panel3);
            this.pnlGeneralFacturaDetalleEditar.Controls.Add(this.dgvEstante);
            this.pnlGeneralFacturaDetalleEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneralFacturaDetalleEditar.Location = new System.Drawing.Point(0, 0);
            this.pnlGeneralFacturaDetalleEditar.Name = "pnlGeneralFacturaDetalleEditar";
            this.pnlGeneralFacturaDetalleEditar.Size = new System.Drawing.Size(1264, 654);
            this.pnlGeneralFacturaDetalleEditar.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnAgregar);
            this.panel3.Controls.Add(this.txtDescripcion);
            this.panel3.Controls.Add(this.cboxSeccion);
            this.panel3.Controls.Add(this.cboxBodega);
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
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(228, 151);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(398, 96);
            this.txtDescripcion.TabIndex = 45;
            this.txtDescripcion.Text = "";
            // 
            // cboxSeccion
            // 
            this.cboxSeccion.FormattingEnabled = true;
            this.cboxSeccion.Location = new System.Drawing.Point(228, 110);
            this.cboxSeccion.Name = "cboxSeccion";
            this.cboxSeccion.Size = new System.Drawing.Size(398, 21);
            this.cboxSeccion.TabIndex = 44;
            // 
            // cboxBodega
            // 
            this.cboxBodega.FormattingEnabled = true;
            this.cboxBodega.Location = new System.Drawing.Point(228, 72);
            this.cboxBodega.Name = "cboxBodega";
            this.cboxBodega.Size = new System.Drawing.Size(398, 21);
            this.cboxBodega.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "DESCRIPCION";
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
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "BODEGA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "NUMERO DE ESTANTE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "SECCION";
            // 
            // dgvEstante
            // 
            this.dgvEstante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstante.Location = new System.Drawing.Point(12, 295);
            this.dgvEstante.Name = "dgvEstante";
            this.dgvEstante.RowHeadersWidth = 51;
            this.dgvEstante.Size = new System.Drawing.Size(1240, 347);
            this.dgvEstante.TabIndex = 33;
            this.dgvEstante.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstante_CellClick);
            // 
            // frmEstante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 654);
            this.Controls.Add(this.pnlGeneralFacturaDetalleEditar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstante";
            this.Text = "frmEstante";
            this.Load += new System.EventHandler(this.frmEstante_Load);
            this.pnlGeneralFacturaDetalleEditar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGeneralFacturaDetalleEditar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboxSeccion;
        private System.Windows.Forms.ComboBox cboxBodega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnActualiszar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNumeroEstante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvEstante;
        private System.Windows.Forms.RichTextBox txtDescripcion;
    }
}