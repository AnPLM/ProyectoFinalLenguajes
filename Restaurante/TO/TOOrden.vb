Public Class TOOrden

    Public Property Nombre_Usuario As String
    Public Property Fecha As DateTime
    Public Property Estado As String
    Public Property Identificador As Int32

    Sub New()

    End Sub

    Sub New(Nombre As String, fecha As DateTime, Estado As String, identificador As Int32)
        Me.Nombre_Usuario = Nombre
        Me.Fecha = fecha
        Me.Estado = Estado
        Me.Identificador = identificador
    End Sub
End Class
