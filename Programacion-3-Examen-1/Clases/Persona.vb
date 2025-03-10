Public Class Persona
    Public nombre As String
    Public cedula As Long

    Property gsNombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Property gsCedula As Long
        Get
            Return cedula
        End Get
        Set(value As Long)
            cedula = value
        End Set
    End Property
End Class
