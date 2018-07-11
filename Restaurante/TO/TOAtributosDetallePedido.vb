Public Class TOAtributosDetallePedido
    Private nombre_Usuario As String
    Public Property NombreUsuario() As String
        Get
            Return nombre_Usuario
        End Get
        Set(ByVal value As String)
            nombre_Usuario = value
        End Set
    End Property

    Private codigo_Plato As String
    Public Property CodigoPlato() As String
        Get
            Return codigo_Plato
        End Get
        Set(ByVal value As String)
            codigo_Plato = value
        End Set
    End Property

    Private nombre_Plato As String
    Public Property NombrePlato() As String
        Get
            Return nombre_Plato
        End Get
        Set(ByVal value As String)
            nombre_Plato = value
        End Set
    End Property

    Private cantidad_Plato As Integer
    Public Property Cantidad() As Integer
        Get
            Return cantidad_Plato
        End Get
        Set(ByVal value As Integer)
            cantidad_Plato = value
        End Set
    End Property

    Private estado_Orden As String
    Public Property Estado() As String
        Get
            Return estado_Orden
        End Get
        Set(ByVal value As String)
            estado_Orden = value
        End Set
    End Property

    Private fecha_Orden As String
    Public Property Fecha() As String
        Get
            Return fecha_Orden
        End Get
        Set(ByVal value As String)
            fecha_Orden = value
        End Set
    End Property

    Sub New(nombreUsuario As String, codigoPlato As String,
            nombrePlato As String, cantidad As Integer,
            estado As String, fecha As String)
        Me.NombreUsuario = nombreUsuario
        Me.CodigoPlato = codigoPlato
        Me.NombrePlato = nombrePlato
        Me.Cantidad = cantidad
        Me.Estado = estado
        Me.Fecha = fecha
    End Sub

    Sub New()
    End Sub
End Class
