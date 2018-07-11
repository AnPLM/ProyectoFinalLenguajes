Imports BL
Public Class InicioSesion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnInicioSesion_Click(sender As Object, e As EventArgs) Handles btnInicioSesion.Click
        Dim nombreUsuario As String = txtNombreUsuario.Text.Trim()
        Dim contrasenna As String = txtContrasenna.Text.Trim()

        Dim manejadorUsuario As ManejadorUsuario = New ManejadorUsuario()

        Dim usuario As New Usuario()
        usuario = manejadorUsuario.autenticar(nombreUsuario, contrasenna)

        If usuario Is Nothing Then
            lblMensaje.Text = "null"
        Else
            If usuario.TipoUsuario = "ADMINISTRADOR" Then
                Session("Usuario") = nombreUsuario
                Response.Redirect("PaginaPrincipal.aspx")
            End If
            lblMensaje.Text = usuario.NombreUsuario & " " & usuario.TipoUsuario
        End If

    End Sub

    'Protected Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
    '    Response.Redirect("RegistroUsuarios.aspx")
    'End Sub
End Class