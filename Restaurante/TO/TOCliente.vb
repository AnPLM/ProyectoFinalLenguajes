Public Class TOCliente

    Public Property Nombre As String
    Public Property Correo As String
    Public Property NombreUsuario As String
    Public Property Contrasenna As String
    Public Property Habilitado As Boolean
    Public Property Direccion As String

    Sub New()

    End Sub

    Sub New(nombre As String, correo As String, nombreUsuario As String, contrasenna As String, habilitado As Boolean, direccion As String)
        Me.Nombre = nombre
        Me.Correo = correo
        Me.NombreUsuario = nombreUsuario
        Me.Contrasenna = contrasenna
        Me.Habilitado = habilitado
        Me.Direccion = direccion
    End Sub

    Sub New(correo As String, contrasenna As String)
        Me.Correo = Nombre
        Me.Contrasenna = contrasenna
    End Sub



End Class
