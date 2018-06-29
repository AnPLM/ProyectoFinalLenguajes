Public Class TOListaPedidos

    Public Sub New(nombre_usuario As String, identificador_plato As Integer)
        nombre = nombre_usuario
        plato = identificador_plato
    End Sub

    Public Sub New()
    End Sub

    Private nombre As String
    Public Property Nombre_Usuario() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property

    Private plato As String
    Public Property Identificador_Plato() As Integer
        Get
            Return plato
        End Get
        Set(ByVal value As Integer)
            plato = value
        End Set
    End Property


End Class
