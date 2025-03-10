Public Class Formulario
    Private capacitacion As Capacitacion
    Private empresa As Empresa
    Private profesor As Profesor
    Private curso As Curso
    Private estudiantes As New List(Of Estudiante)
    Private Sub Formulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        curso = New Curso(nombreCap.Text, empresa, estudiantes)
        capacitacion = New Capacitacion(nombreCap.Text, curso)
    End Sub

    Private Sub BtnDefinir1_Click(sender As Object, e As EventArgs) Handles btnDefinir1.Click
        profesor = New Profesor(txtProNombre.Text, txtProCedula.Text, txtProMateria.Text, txtProAnios.Text, txtProTitulo.Text, txtProSalario.Text)
        empresa = New Empresa(txtEmpNombre.Text, txtEmpDireccion.Text, txtEmpCorreo.Text, txtEmpId.Text, profesor)
        btnDefinir1.Enabled() = False
    End Sub

    Private Sub BtnDefinir2_Click(sender As Object, e As EventArgs) Handles btnDefinir2.Click
        Dim estu As New Estudiante(txtEstuNombre.Text, txtEstuCedula.Text, txtEstuId.Text, txtEstuPromedio.Text, txtEstuNota.Text, txtEstuCarrera.Text)
        estudiantes.Add(estu)
        actualizarLista()
    End Sub

    Private Sub BtnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        generarEmpresa()
        generarProfesor()
    End Sub

    Private Sub generarEmpresa()
        txtEmpNombre.Text = "Empresa.inc"
        txtEmpDireccion.Text = "Cuidad Norte 123"
        txtEmpCorreo.Text = "empresa@correo.com"
        txtEmpId.Text = "3456"
    End Sub

    Private Sub generarProfesor()
        txtProNombre.Text = "Profesor"
        txtProCedula.Text = CInt(Rnd() * 100)
        txtProMateria.Text = nombreCap.Text
        txtProAnios.Text = "20"
        txtProTitulo.Text = "Doc. Sistemas"
        txtProSalario.Text = "356000"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGnerarEstudiante.Click
        txtEstuNombre.Text = "Estudiante"
        txtEstuCedula.Text = CInt(Rnd() * 100)
        txtEstuId.Text = CInt(Rnd() * 100)
        txtEstuPromedio.Text = Rnd() * 100
        txtEstuNota.Text = CInt(Rnd() * 100)
        txtEstuCarrera.Text = nombreCap.Text
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        BtnDefinir2_Click(sender, e)
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim estudiante As New Estudiante(txtEstuNombre.Text, txtEstuCedula.Text, txtEstuId.Text, txtEstuPromedio.Text, txtEstuNota.Text, txtEstuCarrera.Text)
        Dim i As Integer = 0
        Dim j As Integer
        For Each estu As Estudiante In estudiantes
            If (estu.gsCedula.Equals(estudiante.gsCedula)) Then
                j = i
            End If
            i += 1
        Next
        estudiantes.Item(j) = estudiante
        actualizarLista()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim estudiante As New Estudiante(txtEstuNombre.Text, txtEstuCedula.Text, txtEstuId.Text, txtEstuPromedio.Text, txtEstuNota.Text, txtEstuCarrera.Text)
        Dim i As Integer = 0
        Dim j As Integer
        For Each estu As Estudiante In estudiantes
            If (estu.gsCedula.Equals(estudiante.gsCedula)) Then
                j = i
            End If
            i += 1
        Next
        estudiantes.RemoveAt(j)
        actualizarLista()
    End Sub

    Public Sub actualizarLista()
        list.Rows.Clear()
        For Each estu As Estudiante In estudiantes
            list.Rows.Add(estu.gsNombre, estu.gsCedula, estu.gsId, estu.gsPromedio, estu.gsNota, estu.gsCarrera)
        Next
        curso.gsEstudantes = estudiantes
    End Sub
End Class
