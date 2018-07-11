Public Class TOAdminListaPedido
    Private numeroOrden As Integer
    Public Property IDOrden() As Integer
        Get
            Return numeroOrden
        End Get
        Set(ByVal value As Integer)
            numeroOrden = value
        End Set
    End Property

    Private nombreUsuario As String
    Public Property Cliente() As String
        Get
            Return nombreUsuario
        End Get
        Set(ByVal value As String)
            nombreUsuario = value
        End Set
    End Property

    Private fecha_Inicio As String
    Public Property FechaInicio() As String
        Get
            Return fecha_Inicio
        End Get
        Set(ByVal value As String)
            fecha_Inicio = value
        End Set
    End Property

    Private fech_Fin As String
    Public Property FechaFin() As String
        Get
            Return fech_Fin
        End Get
        Set(ByVal value As String)
            fech_Fin = value
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

    Sub New()
    End Sub

    Sub New(cliente As String, fechaInicio As String, fechaFin As String, estado As String)
        Me.Cliente = cliente
        Me.FechaInicio = fechaInicio
        Me.FechaFin = fechaFin
        Me.Estado = estado
    End Sub
End Class
