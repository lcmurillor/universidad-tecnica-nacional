<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario
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
        Me.nombreCap = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmpNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmpDireccion = New System.Windows.Forms.TextBox()
        Me.txtProMateria = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmpId = New System.Windows.Forms.TextBox()
        Me.txtProAnios = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtProTitulo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtProSalario = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtProNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProCedula = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnDefinir1 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtEstuCedula = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtEstuNombre = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtEstuCarrera = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtEstuNota = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtEstuPromedio = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtEstuId = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtEmpCorreo = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnDefinir2 = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.list = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Promedio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Carrera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGnerarEstudiante = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nombreCap
        '
        Me.nombreCap.AutoSize = True
        Me.nombreCap.Location = New System.Drawing.Point(12, 29)
        Me.nombreCap.Name = "nombreCap"
        Me.nombreCap.Size = New System.Drawing.Size(115, 13)
        Me.nombreCap.TabIndex = 0
        Me.nombreCap.Text = "Ingeniería en Sistemas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Capacitación"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(315, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Profesor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Empresa"
        '
        'txtEmpNombre
        '
        Me.txtEmpNombre.Location = New System.Drawing.Point(81, 35)
        Me.txtEmpNombre.Name = "txtEmpNombre"
        Me.txtEmpNombre.Size = New System.Drawing.Size(206, 20)
        Me.txtEmpNombre.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Dirección"
        '
        'txtEmpDireccion
        '
        Me.txtEmpDireccion.Location = New System.Drawing.Point(80, 61)
        Me.txtEmpDireccion.Name = "txtEmpDireccion"
        Me.txtEmpDireccion.Size = New System.Drawing.Size(207, 20)
        Me.txtEmpDireccion.TabIndex = 8
        '
        'txtProMateria
        '
        Me.txtProMateria.Location = New System.Drawing.Point(423, 83)
        Me.txtProMateria.Name = "txtProMateria"
        Me.txtProMateria.Size = New System.Drawing.Size(207, 20)
        Me.txtProMateria.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(315, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Materia"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Id"
        '
        'txtEmpId
        '
        Me.txtEmpId.Location = New System.Drawing.Point(80, 113)
        Me.txtEmpId.Name = "txtEmpId"
        Me.txtEmpId.Size = New System.Drawing.Size(207, 20)
        Me.txtEmpId.TabIndex = 9
        '
        'txtProAnios
        '
        Me.txtProAnios.Location = New System.Drawing.Point(423, 109)
        Me.txtProAnios.Name = "txtProAnios"
        Me.txtProAnios.Size = New System.Drawing.Size(207, 20)
        Me.txtProAnios.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(315, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Años de Experencia"
        '
        'txtProTitulo
        '
        Me.txtProTitulo.Location = New System.Drawing.Point(423, 135)
        Me.txtProTitulo.Name = "txtProTitulo"
        Me.txtProTitulo.Size = New System.Drawing.Size(207, 20)
        Me.txtProTitulo.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(315, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Titulo"
        '
        'txtProSalario
        '
        Me.txtProSalario.Location = New System.Drawing.Point(423, 161)
        Me.txtProSalario.Name = "txtProSalario"
        Me.txtProSalario.Size = New System.Drawing.Size(207, 20)
        Me.txtProSalario.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(315, 164)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Salario"
        '
        'txtProNombre
        '
        Me.txtProNombre.Location = New System.Drawing.Point(423, 31)
        Me.txtProNombre.Name = "txtProNombre"
        Me.txtProNombre.Size = New System.Drawing.Size(207, 20)
        Me.txtProNombre.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(315, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Nombre"
        '
        'txtProCedula
        '
        Me.txtProCedula.Location = New System.Drawing.Point(423, 57)
        Me.txtProCedula.Name = "txtProCedula"
        Me.txtProCedula.Size = New System.Drawing.Size(207, 20)
        Me.txtProCedula.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(315, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Cedula"
        '
        'btnDefinir1
        '
        Me.btnDefinir1.Location = New System.Drawing.Point(15, 203)
        Me.btnDefinir1.Name = "btnDefinir1"
        Me.btnDefinir1.Size = New System.Drawing.Size(147, 23)
        Me.btnDefinir1.TabIndex = 23
        Me.btnDefinir1.Text = "Definir"
        Me.btnDefinir1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 155)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(243, 26)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Nota: Es necesario definir la empresa y el profesor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para crear el curso necesari" &
    "o para la capacitatión."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Estudiante"
        '
        'txtEstuCedula
        '
        Me.txtEstuCedula.Location = New System.Drawing.Point(81, 65)
        Me.txtEstuCedula.Name = "txtEstuCedula"
        Me.txtEstuCedula.Size = New System.Drawing.Size(207, 20)
        Me.txtEstuCedula.TabIndex = 37
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 68)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Cedula"
        '
        'txtEstuNombre
        '
        Me.txtEstuNombre.Location = New System.Drawing.Point(81, 39)
        Me.txtEstuNombre.Name = "txtEstuNombre"
        Me.txtEstuNombre.Size = New System.Drawing.Size(207, 20)
        Me.txtEstuNombre.TabIndex = 35
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 42)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 13)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Nombre"
        '
        'txtEstuCarrera
        '
        Me.txtEstuCarrera.Location = New System.Drawing.Point(81, 169)
        Me.txtEstuCarrera.Name = "txtEstuCarrera"
        Me.txtEstuCarrera.Size = New System.Drawing.Size(207, 20)
        Me.txtEstuCarrera.TabIndex = 33
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 172)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 13)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Carrera"
        '
        'txtEstuNota
        '
        Me.txtEstuNota.Location = New System.Drawing.Point(81, 143)
        Me.txtEstuNota.Name = "txtEstuNota"
        Me.txtEstuNota.Size = New System.Drawing.Size(207, 20)
        Me.txtEstuNota.TabIndex = 31
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 146)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 13)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Nota"
        '
        'txtEstuPromedio
        '
        Me.txtEstuPromedio.Location = New System.Drawing.Point(81, 117)
        Me.txtEstuPromedio.Name = "txtEstuPromedio"
        Me.txtEstuPromedio.Size = New System.Drawing.Size(207, 20)
        Me.txtEstuPromedio.TabIndex = 29
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(12, 120)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 13)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "Promedio"
        '
        'txtEstuId
        '
        Me.txtEstuId.Location = New System.Drawing.Point(81, 91)
        Me.txtEstuId.Name = "txtEstuId"
        Me.txtEstuId.Size = New System.Drawing.Size(207, 20)
        Me.txtEstuId.TabIndex = 27
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(12, 94)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(16, 13)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "Id"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.txtEmpCorreo)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.btnDefinir1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtEmpNombre)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtEmpDireccion)
        Me.Panel1.Controls.Add(Me.txtEmpId)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtProMateria)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtProAnios)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtProTitulo)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtProCedula)
        Me.Panel1.Controls.Add(Me.txtProSalario)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtProNombre)
        Me.Panel1.Location = New System.Drawing.Point(15, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 243)
        Me.Panel1.TabIndex = 38
        '
        'txtEmpCorreo
        '
        Me.txtEmpCorreo.Location = New System.Drawing.Point(80, 87)
        Me.txtEmpCorreo.Name = "txtEmpCorreo"
        Me.txtEmpCorreo.Size = New System.Drawing.Size(207, 20)
        Me.txtEmpCorreo.TabIndex = 25
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(13, 90)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(38, 13)
        Me.Label25.TabIndex = 26
        Me.Label25.Text = "Correo"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.txtEstuCedula)
        Me.Panel2.Controls.Add(Me.btnDefinir2)
        Me.Panel2.Controls.Add(Me.txtEstuId)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.txtEstuNombre)
        Me.Panel2.Controls.Add(Me.txtEstuPromedio)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.txtEstuCarrera)
        Me.Panel2.Controls.Add(Me.txtEstuNota)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Location = New System.Drawing.Point(15, 311)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(307, 298)
        Me.Panel2.TabIndex = 39
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(12, 208)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(243, 39)
        Me.Label22.TabIndex = 25
        Me.Label22.Text = "Nota: Es necesario definir El estudiante para crear" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "el curso necesario para la c" &
    "apacitatión." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Este primer estudiante es obligatorio."
        '
        'btnDefinir2
        '
        Me.btnDefinir2.Location = New System.Drawing.Point(11, 263)
        Me.btnDefinir2.Name = "btnDefinir2"
        Me.btnDefinir2.Size = New System.Drawing.Size(151, 23)
        Me.btnDefinir2.TabIndex = 42
        Me.btnDefinir2.Text = "Definir"
        Me.btnDefinir2.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(676, 29)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(102, 13)
        Me.Label21.TabIndex = 41
        Me.Label21.Text = "Lista de Estudiantes"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(84, 68)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(151, 23)
        Me.btnAgregar.TabIndex = 43
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(84, 120)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(151, 23)
        Me.btnActualizar.TabIndex = 44
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(84, 168)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(151, 23)
        Me.btnEliminar.TabIndex = 45
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.btnActualizar)
        Me.Panel3.Controls.Add(Me.btnEliminar)
        Me.Panel3.Controls.Add(Me.btnAgregar)
        Me.Panel3.Location = New System.Drawing.Point(333, 311)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(331, 215)
        Me.Panel3.TabIndex = 46
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(3, 13)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(316, 39)
        Me.Label23.TabIndex = 46
        Me.Label23.Text = "Nota: Las opciones indicadas dentro de este panel solo requieren" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "completar la in" &
    "formación requerida dentro del panal ""Estudiante""." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Al menos la Cedula para elim" &
    "inar o actualizar." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(336, 541)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(280, 26)
        Me.Label24.TabIndex = 47
        Me.Label24.Text = "Opción de desarrolador: Genera automáticamente toda la " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "información requerida pa" &
    "ra pruebas."
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(339, 574)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerar.TabIndex = 48
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'list
        '
        Me.list.BackgroundColor = System.Drawing.Color.Silver
        Me.list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Cedula, Me.Id, Me.Promedio, Me.Nota, Me.Carrera})
        Me.list.Location = New System.Drawing.Point(679, 54)
        Me.list.Name = "list"
        Me.list.Size = New System.Drawing.Size(643, 472)
        Me.list.TabIndex = 50
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Cedula
        '
        Me.Cedula.HeaderText = "Cedula"
        Me.Cedula.Name = "Cedula"
        Me.Cedula.ReadOnly = True
        '
        'Id
        '
        Me.Id.HeaderText = "id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'Promedio
        '
        Me.Promedio.HeaderText = "Promedio"
        Me.Promedio.Name = "Promedio"
        Me.Promedio.ReadOnly = True
        '
        'Nota
        '
        Me.Nota.HeaderText = "Nota"
        Me.Nota.Name = "Nota"
        Me.Nota.ReadOnly = True
        '
        'Carrera
        '
        Me.Carrera.HeaderText = "Carrera"
        Me.Carrera.Name = "Carrera"
        Me.Carrera.ReadOnly = True
        '
        'btnGnerarEstudiante
        '
        Me.btnGnerarEstudiante.Location = New System.Drawing.Point(495, 574)
        Me.btnGnerarEstudiante.Name = "btnGnerarEstudiante"
        Me.btnGnerarEstudiante.Size = New System.Drawing.Size(121, 23)
        Me.btnGnerarEstudiante.TabIndex = 51
        Me.btnGnerarEstudiante.Text = "Generar Estudiante"
        Me.btnGnerarEstudiante.UseVisualStyleBackColor = True
        '
        'Formulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1341, 623)
        Me.Controls.Add(Me.btnGnerarEstudiante)
        Me.Controls.Add(Me.list)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nombreCap)
        Me.Name = "Formulario"
        Me.Text = "Formulario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nombreCap As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmpNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmpDireccion As TextBox
    Friend WithEvents txtProMateria As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmpId As TextBox
    Friend WithEvents txtProAnios As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtProTitulo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtProSalario As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtProNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProCedula As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnDefinir1 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtEstuCedula As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtEstuNombre As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtEstuCarrera As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtEstuNota As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtEstuPromedio As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtEstuId As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents btnDefinir2 As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents btnGenerar As Button
    Friend WithEvents txtEmpCorreo As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents list As DataGridView
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Cedula As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Promedio As DataGridViewTextBoxColumn
    Friend WithEvents Nota As DataGridViewTextBoxColumn
    Friend WithEvents Carrera As DataGridViewTextBoxColumn
    Friend WithEvents btnGnerarEstudiante As Button
End Class
