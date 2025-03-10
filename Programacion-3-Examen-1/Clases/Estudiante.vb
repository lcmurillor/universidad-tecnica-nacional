Public Class Estudiante
    Inherits Persona

    Private id As Integer
    Private promedio As Double
    Private nota As Integer
    Private carrera As String

    Public Sub New(nombre As String, cedula As Long, id As Integer, promedio As Double, nota As Integer, carrera As String)
        MyBase.nombre = nombre
        MyBase.cedula = cedula
        Me.id = id
        Me.promedio = promedio
        Me.nota = nota
        Me.carrera = carrera
    End Sub

    Overloads Property gsNombre As String
        Get
            Return MyBase.nombre
        End Get
        Set(value As String)
            MyBase.nombre = value
        End Set
    End Property

    Overloads Property gsCedula As Long
        Get
            Return MyBase.cedula
        End Get
        Set(value As Long)
            MyBase.cedula = value
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
    Property gsPromedio As Double
        Get
            Return promedio
        End Get
        Set(value As Double)
            promedio = value
        End Set
    End Property
    Property gsNota As Integer
        Get
            Return nota
        End Get
        Set(value As Integer)
            nota = value
        End Set
    End Property
    Property gsCarrera As String
        Get
            Return carrera
        End Get
        Set(value As String)
            carrera = value
        End Set
    End Property

End Class
