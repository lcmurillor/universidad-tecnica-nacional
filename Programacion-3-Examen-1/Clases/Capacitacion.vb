Public Class Capacitacion
    Private nombre As String
    Private curso As Curso

    Public Sub New(nombre As String, curso As Curso)
        Me.nombre = nombre
        Me.curso = curso
    End Sub

    Property gsNombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Property gsCurso As Curso
        Get
            Return curso
        End Get
        Set(value As Curso)
            curso = value
        End Set
    End Property

End Class
