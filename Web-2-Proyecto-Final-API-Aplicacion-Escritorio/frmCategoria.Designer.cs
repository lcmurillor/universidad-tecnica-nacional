
namespace WindowsFormsProyecto2
{
    partial class frmCategoria
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
            this.pnlGeneralCategoria = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnActualiszar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNumeroCategoria = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.pnlGeneralCategoria.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGeneralCategoria
            // 
            this.pnlGeneralCategoria.Controls.Add(this.panel3);
            this.pnlGeneralCategoria.Controls.Add(this.dgvCategoria);
            this.pnlGeneralCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneralCategoria.Location = new System.Drawing.Point(0, 0);
            this.pnlGeneralCategoria.Name = "pnlGeneralCategoria";
            this.pnlGeneralCategoria.Size = new System.Drawing.Size(1264, 654);
            this.pnlGeneralCategoria.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnAgregar);
            this.panel3.Controls.Add(this.txtDescripcion);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnAnular);
            this.panel3.Controls.Add(this.btnActualiszar);
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.txtNumeroCategoria);
            this.panel3.Controls.Add(this.label8);
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
            this.txtDescripcion.Location = new System.Drawing.Point(228, 84);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(398, 96);
            this.txtDescripcion.TabIndex = 45;
            this.txtDescripcion.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 87);
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
            this.btnBuscar.Text = "BUSCAR CATEGORIA";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNumeroCategoria
            // 
            this.txtNumeroCategoria.Location = new System.Drawing.Point(229, 36);
            this.txtNumeroCategoria.Name = "txtNumeroCategoria";
            this.txtNumeroCategoria.Size = new System.Drawing.Size(218, 20);
            this.txtNumeroCategoria.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "NUMERO DE CATEGORIA";
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(12, 295);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.RowHeadersWidth = 51;
            this.dgvCategoria.Size = new System.Drawing.Size(1240, 347);
            this.dgvCategoria.TabIndex = 33;
            this.dgvCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellClick);
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 654);
            this.Controls.Add(this.pnlGeneralCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategoria";
            this.Text = "frmCategoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            this.pnlGeneralCategoria.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGeneralCategoria;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnActualiszar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNumeroCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvCategoria;
    }
}