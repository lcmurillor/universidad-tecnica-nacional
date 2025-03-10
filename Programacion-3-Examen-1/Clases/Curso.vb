Public Class Curso
    Private nombre As String
    Private profesor As Profesor
    Private estudiantes As New List(Of Estudiante)
    Private empresa As Empresa

    Public Sub New(nombre As String, profesor As Profesor, estudiantes As List(Of Estudiante))
        Me.nombre = nombre
        Me.profesor = profesor
        Me.estudiantes = Me.estudiantes
    End Sub

    Public Sub New(nombre As String, empresa As Empresa, estudiantes As List(Of Estudiante))
        Me.nombre = nombre
        Me.empresa = empresa
        Me.estudiantes = Me.estudiantes
    End Sub

    Property gsNombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Property gsProfesor As Profesor
        Get
            Return profesor
        End Get
        Set(value As Profesor)
            profesor = value
        End Set
    End Property

    Property gsEstudantes As List(Of Estudiante)
        Get
            Return estudiantes
        End Get
        Set(value As List(Of Estudiante))
            estudiantes = value
        End Set
    End Property
    Property gsEmpresa As Empresa
        Get
            Return empresa
        End Get
        Set(value As Empresa)
            empresa = value
        End Set
    End Property
End Class
