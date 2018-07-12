Public Class TOOrden

    Public Property Nombre_Usuario As String
    Public Property Fecha As String
    Public Property Estado As String
    Public Property Identificador As Int32

    Sub New()

    End Sub

    Sub New(Nombre As String, fecha As String, Estado As String, identificador As Int32)
        Me.Nombre_Usuario = Nombre
        Me.Fecha = fecha
        Me.Estado = Estado
        Me.Identificador = identificador
    End Sub

    Sub New(estado As String, identificador As Int32)
        Me.Estado = estado
        Me.Identificador = identificador
    End Sub
End Class
