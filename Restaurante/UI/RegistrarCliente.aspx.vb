Imports BL
Public Class RegistrarCliente
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtCorreo.Enabled = False
    End Sub

    Protected Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim nombreCompleto As String = txtNombre.Text.Trim()
        Dim nombreUsuario As String = txtNombreUsuario.Text.Trim()
        Dim correo As String = txtCorreo.Text.Trim()
        Dim direccion As String = txtDireccion.Text.Trim()
        Dim contrasenna As String = txtContrasenna.Text.Trim()

        'Dim cliente As New Cliente(nombreCompleto, correo, nombreUsuario, contrasenna, True, direccion)
        Dim cliente As New Cliente()
        'cliente.agregarCliente()
        cliente.actualizarDatosCliente(nombreUsuario, direccion, nombreCompleto, contrasenna)
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim nombreUsuario As String = txtNombreUsuario.Text.Trim()
            Dim cliente As New Cliente()
            cliente.habilitarCliente(nombreUsuario)
            Label1.Text = "Operacion terminada"
        Catch r As Exception
            Label1.Text = r.Message
        End Try

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim nombreUsuario As String = txtNombreUsuario.Text.Trim()
            Dim cliente As New Cliente()
            cliente.deshabilitarCliente(nombreUsuario)
            Label1.Text = "Operacion terminada"
        Catch r As Exception
            Label1.Text = r.Message
        End Try
    End Sub
End Class