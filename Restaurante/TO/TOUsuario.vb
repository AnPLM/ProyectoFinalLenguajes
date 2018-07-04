Public Class TOUsuario
    Public Property NombreUsuario As String
    Public Property Contrasenna As String
    Public Property Tipo As String
    Public Property Habilitado As Boolean

    Sub New()

    End Sub

    Sub New(nombreUsuario As String, contrasenna As String, tipo As String, habilitado As Boolean)
        Me.NombreUsuario = nombreUsuario
        Me.Contrasenna = contrasenna
        Me.Tipo = tipo
        Me.Habilitado = habilitado
    End Sub
End Class
