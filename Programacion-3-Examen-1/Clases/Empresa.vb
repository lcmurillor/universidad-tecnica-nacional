Public Class Empresa
    Private nombre As String
    Private dirrecion As String
    Private correo As String
    Private id As Integer
    Private profesores As New List(Of Profesor)


    Public Sub New(nombre As String, dirrecion As String, correo As String, id As Integer, profesor As Profesor)
        Me.nombre = nombre
        Me.dirrecion = dirrecion
        Me.correo = correo
        Me.id = id
        Me.profesores.Add(profesor)
    End Sub

    Property gsNombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Property gsDirrecion As String
        Get
            Return dirrecion
        End Get
        Set(value As String)
            dirrecion = value
        End Set
    End Property

    Property gsCorreo As String
        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
        End Set
    End Property
    Property gsId As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Property gsProfesores As List(Of Profesor)
        Get
            Return profesores
        End Get
        Set(value As List(Of Profesor))
            profesores = value
        End Set
    End Property

End Class
