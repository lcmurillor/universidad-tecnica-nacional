Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarRegistro()
    End Sub

    Private Sub CargarRegistro()
        Try
            Using tabla As New Examen.ExamenEntities
                Dim registro = (From l In tabla.ListaAirbnb Select l).ToList
                If registro.Count > 0 Then
                    Me.DataGridView.DataSource = registro
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub Insertar_Click(sender As Object, e As EventArgs) Handles Insertar.Click
        Try
            Using tabla As New Examen.ExamenEntities
                Dim registro As New Examen.ListaAirbnb With {.IdLocal = Me.IdLocal.Text, .DescripcionCabina = Me.DescripcionCabina.Text, .IdDueno = Me.IdDueno.Text,
                    .NombreDueno = Me.NombreDueno.Text, .TipoCuarto = Me.TipoCuarto.Text, .Moneda = Me.Moneda.Text, .Precio = Me.Precio.Text,
                    .NochesMinimas = Me.NochesMinimas.Text, .NumeroReviews = Me.NumeroReviews.Text, .ReviewsPorMes = Me.ReviewsPorMes.Text, .habitables365 = Me.habitables365.Text,
                    .Ciudad = Me.Ciudad.Text, .Estado = Me.Estado.Text, .Pais = Me.Pais.Text}
                tabla.ListaAirbnb.Add(registro)
                tabla.SaveChanges()
            End Using
        Catch ex As Exception
            MsgBox(ex)
        End Try
        CargarRegistro()
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Try
            Using tabla As New Examen.ExamenEntities
                Dim registo = (From l In tabla.ListaAirbnb Where l.IdLocal = Me.IdLocal.Text Select l).SingleOrDefault
                tabla.ListaAirbnb.Remove(registo)
                tabla.SaveChanges()
            End Using
        Catch ex As Exception
            MsgBox(ex)
        End Try
        CargarRegistro()
    End Sub

    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        Try
            Using tabla As New Examen.ExamenEntities
                Dim registro = (From l In tabla.ListaAirbnb Where l.IdLocal = Me.IdLocal.Text Select l).SingleOrDefault
                registro.IdLocal = Me.IdLocal.Text
                registro.DescripcionCabina = Me.DescripcionCabina.Text
                registro.IdDueno = Me.IdDueno.Text
                registro.NombreDueno = Me.NombreDueno.Text
                registro.TipoCuarto = Me.TipoCuarto.Text
                registro.Moneda = Me.Moneda.Text
                registro.Precio = Me.Precio.Text
                registro.NochesMinimas = Me.NochesMinimas.Text
                registro.NumeroReviews = Me.NumeroReviews.Text
                registro.ReviewsPorMes = Me.ReviewsPorMes.Text
                registro.habitables365 = Me.habitables365.Text
                registro.Ciudad = Me.Ciudad.Text
                registro.Estado = Me.Estado.Text
                registro.Pais = Me.Pais.Text
                tabla.SaveChanges()
            End Using
        Catch ex As Exception
            MsgBox(ex)
        End Try
        CargarRegistro()
    End Sub
End Class
