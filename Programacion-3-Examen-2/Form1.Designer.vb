<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.Insertar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IdLocal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DescripcionCabina = New System.Windows.Forms.TextBox()
        Me.IdDueno = New System.Windows.Forms.TextBox()
        Me.NombreDueno = New System.Windows.Forms.TextBox()
        Me.TipoCuarto = New System.Windows.Forms.TextBox()
        Me.Moneda = New System.Windows.Forms.TextBox()
        Me.Precio = New System.Windows.Forms.TextBox()
        Me.Pais = New System.Windows.Forms.TextBox()
        Me.Estado = New System.Windows.Forms.TextBox()
        Me.Ciudad = New System.Windows.Forms.TextBox()
        Me.habitables365 = New System.Windows.Forms.TextBox()
        Me.ReviewsPorMes = New System.Windows.Forms.TextBox()
        Me.NumeroReviews = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.NochesMinimas = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Actualizar = New System.Windows.Forms.Button()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView
        '
        Me.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView.Location = New System.Drawing.Point(0, 269)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(1175, 219)
        Me.DataGridView.TabIndex = 0
        '
        'Insertar
        '
        Me.Insertar.Location = New System.Drawing.Point(710, 9)
        Me.Insertar.Name = "Insertar"
        Me.Insertar.Size = New System.Drawing.Size(75, 23)
        Me.Insertar.TabIndex = 1
        Me.Insertar.Text = "Insertar"
        Me.Insertar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "IdLocal"
        '
        'IdLocal
        '
        Me.IdLocal.Location = New System.Drawing.Point(141, 6)
        Me.IdLocal.Name = "IdLocal"
        Me.IdLocal.Size = New System.Drawing.Size(151, 20)
        Me.IdLocal.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "DescripcionCabina"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "IdDueno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "NombreDueno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "TipoCuarto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Moneda"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Precio"
        '
        'DescripcionCabina
        '
        Me.DescripcionCabina.Location = New System.Drawing.Point(141, 38)
        Me.DescripcionCabina.Name = "DescripcionCabina"
        Me.DescripcionCabina.Size = New System.Drawing.Size(151, 20)
        Me.DescripcionCabina.TabIndex = 10
        '
        'IdDueno
        '
        Me.IdDueno.Location = New System.Drawing.Point(141, 70)
        Me.IdDueno.Name = "IdDueno"
        Me.IdDueno.Size = New System.Drawing.Size(151, 20)
        Me.IdDueno.TabIndex = 11
        '
        'NombreDueno
        '
        Me.NombreDueno.Location = New System.Drawing.Point(141, 102)
        Me.NombreDueno.Name = "NombreDueno"
        Me.NombreDueno.Size = New System.Drawing.Size(151, 20)
        Me.NombreDueno.TabIndex = 12
        '
        'TipoCuarto
        '
        Me.TipoCuarto.Location = New System.Drawing.Point(141, 139)
        Me.TipoCuarto.Name = "TipoCuarto"
        Me.TipoCuarto.Size = New System.Drawing.Size(151, 20)
        Me.TipoCuarto.TabIndex = 13
        '
        'Moneda
        '
        Me.Moneda.Location = New System.Drawing.Point(141, 174)
        Me.Moneda.Name = "Moneda"
        Me.Moneda.Size = New System.Drawing.Size(151, 20)
        Me.Moneda.TabIndex = 14
        '
        'Precio
        '
        Me.Precio.Location = New System.Drawing.Point(141, 212)
        Me.Precio.Name = "Precio"
        Me.Precio.Size = New System.Drawing.Size(151, 20)
        Me.Precio.TabIndex = 15
        '
        'Pais
        '
        Me.Pais.Location = New System.Drawing.Point(458, 212)
        Me.Pais.Name = "Pais"
        Me.Pais.Size = New System.Drawing.Size(151, 20)
        Me.Pais.TabIndex = 29
        '
        'Estado
        '
        Me.Estado.Location = New System.Drawing.Point(458, 174)
        Me.Estado.Name = "Estado"
        Me.Estado.Size = New System.Drawing.Size(151, 20)
        Me.Estado.TabIndex = 28
        '
        'Ciudad
        '
        Me.Ciudad.Location = New System.Drawing.Point(458, 139)
        Me.Ciudad.Name = "Ciudad"
        Me.Ciudad.Size = New System.Drawing.Size(151, 20)
        Me.Ciudad.TabIndex = 27
        '
        'habitables365
        '
        Me.habitables365.Location = New System.Drawing.Point(458, 102)
        Me.habitables365.Name = "habitables365"
        Me.habitables365.Size = New System.Drawing.Size(151, 20)
        Me.habitables365.TabIndex = 26
        '
        'ReviewsPorMes
        '
        Me.ReviewsPorMes.Location = New System.Drawing.Point(458, 70)
        Me.ReviewsPorMes.Name = "ReviewsPorMes"
        Me.ReviewsPorMes.Size = New System.Drawing.Size(151, 20)
        Me.ReviewsPorMes.TabIndex = 25
        '
        'NumeroReviews
        '
        Me.NumeroReviews.Location = New System.Drawing.Point(458, 38)
        Me.NumeroReviews.Name = "NumeroReviews"
        Me.NumeroReviews.Size = New System.Drawing.Size(151, 20)
        Me.NumeroReviews.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(344, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Pais"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(344, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Estado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(344, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Ciudad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(344, 105)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "habitables365"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(344, 73)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "ReviewsPorMes"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(344, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "NumeroReviews"
        '
        'NochesMinimas
        '
        Me.NochesMinimas.Location = New System.Drawing.Point(458, 6)
        Me.NochesMinimas.Name = "NochesMinimas"
        Me.NochesMinimas.Size = New System.Drawing.Size(151, 20)
        Me.NochesMinimas.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(344, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "NochesMinimas"
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(710, 63)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Eliminar.TabIndex = 30
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Actualizar
        '
        Me.Actualizar.Location = New System.Drawing.Point(710, 132)
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Size = New System.Drawing.Size(75, 23)
        Me.Actualizar.TabIndex = 31
        Me.Actualizar.Text = "Actualizar"
        Me.Actualizar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1175, 488)
        Me.Controls.Add(Me.Actualizar)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Pais)
        Me.Controls.Add(Me.Estado)
        Me.Controls.Add(Me.Ciudad)
        Me.Controls.Add(Me.habitables365)
        Me.Controls.Add(Me.ReviewsPorMes)
        Me.Controls.Add(Me.NumeroReviews)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.NochesMinimas)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Precio)
        Me.Controls.Add(Me.Moneda)
        Me.Controls.Add(Me.TipoCuarto)
        Me.Controls.Add(Me.NombreDueno)
        Me.Controls.Add(Me.IdDueno)
        Me.Controls.Add(Me.DescripcionCabina)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IdLocal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Insertar)
        Me.Controls.Add(Me.DataGridView)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents Insertar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents IdLocal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DescripcionCabina As TextBox
    Friend WithEvents IdDueno As TextBox
    Friend WithEvents NombreDueno As TextBox
    Friend WithEvents TipoCuarto As TextBox
    Friend WithEvents Moneda As TextBox
    Friend WithEvents Precio As TextBox
    Friend WithEvents Pais As TextBox
    Friend WithEvents Estado As TextBox
    Friend WithEvents Ciudad As TextBox
    Friend WithEvents habitables365 As TextBox
    Friend WithEvents ReviewsPorMes As TextBox
    Friend WithEvents NumeroReviews As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents NochesMinimas As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Eliminar As Button
    Friend WithEvents Actualizar As Button
End Class
