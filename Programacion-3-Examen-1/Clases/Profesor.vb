Public Class Profesor
    Inherits Persona

    Private materia As String
    Private aniosExperiecia As Integer
    Private titulo As String
    Private salario As Double

    Public Sub New(nombre As String, cedula As Long, materia As String, anios As Integer, titulo As String, salario As Double)
        MyBase.nombre = nombre
        MyBase.cedula = cedula
        Me.materia = materia
        Me.aniosExperiecia = anios
        Me.titulo = titulo
        Me.salario = salario
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

    Property gsMateria As String
        Get
            Return materia
        End Get
        Set(value As String)
            materia = value
        End Set
    End Property

    Property gsAniosExperecia As Integer
        Get
            Return aniosExperiecia
        End Get
        Set(value As Integer)
            aniosExperiecia = value
        End Set
    End Property

    Property gsTitulo As String
        Get
            Return titulo
        End Get
        Set(value As String)
            titulo = value
        End Set
    End Property

    Property gsSlario As Double
        Get
            Return salario
        End Get
        Set(value As Double)
            salario = value
        End Set
    End Property
End Class
