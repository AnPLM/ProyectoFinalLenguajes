Public Class TOCliente

    Public Property Nombre As String
    Public Property Apellidos As String
    Public Property Edad As Integer
    Public Property Direccion As String
    Public Property NombreUsuario As String
    Public Property Contrasenna As String
    Public Property EstadoCuenta As Boolean
    Sub New()

    End Sub

    Sub New(nombre As String, apellidos As String, edad As Integer, direccion As String, nombreUsuario As String, contrasenna As String, estadoCuenta As Boolean)
        Me.Nombre = nombre
        Me.Apellidos = apellidos
        Me.Edad = edad
        Me.Direccion = direccion
        Me.NombreUsuario = nombreUsuario
        Me.Contrasenna = contrasenna
        Me.EstadoCuenta = estadoCuenta
    End Sub



End Class
