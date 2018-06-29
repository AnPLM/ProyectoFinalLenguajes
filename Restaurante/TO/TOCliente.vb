Public Class TOCliente

    Public Property Nombre As String
    Public Property Correo As String
    Public Property NombreUsuario As String
    Public Property Contrasenna As String
    Public Property Habilitado As Integer
    Public Property Direccion As String

    Sub New()

    End Sub

    Sub New(nombre As String, correo As String, nombreUsuario As String, contrasenna As String, habilitado As Integer, direccion As String)
        Me.Nombre = nombre
        Me.Correo = correo
        Me.NombreUsuario = nombreUsuario
        Me.Contrasenna = contrasenna
        Me.Habilitado = habilitado
        Me.Direccion = direccion
    End Sub



End Class
