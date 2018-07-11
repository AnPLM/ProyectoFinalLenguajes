Public Class TOListaPedidos

    Public Sub New(identificador_orden As String, codigo_plato As Integer, cantidad As Integer)
        orden = identificador_orden
        plato = codigo_plato
        Me.cantidad = cantidad
    End Sub

    Public Sub New()
    End Sub

    Private orden As Integer
    Public Property Identificador_Orden() As Integer
        Get
            Return orden
        End Get
        Set(ByVal value As Integer)
            orden = value
        End Set
    End Property

    Private plato As String
    Public Property Codigo_Plato() As String
        Get
            Return plato
        End Get
        Set(ByVal value As String)
            plato = value
        End Set
    End Property

    Private cantidad As Integer
    Public Property Cantidad_Plato() As Integer
        Get
            Return cantidad
        End Get
        Set(ByVal value As Integer)
            cantidad = value
        End Set
    End Property

End Class
