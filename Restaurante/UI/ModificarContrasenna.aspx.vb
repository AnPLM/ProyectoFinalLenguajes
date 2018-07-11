Imports BL
Public Class ModificarContrasenna
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnModificarContrasenna_Click(sender As Object, e As EventArgs) Handles btnModificarContrasenna.Click
        If txtNombreUsuario.Text <> "" And txtContrasenna.Text <> "" Then
            Dim usuario As New ManejadorUsuario()
            usuario.modificarContrasenna(txtNombreUsuario.Text, txtContrasenna.Text)
            Response.Redirect("ModificarUsuarios.aspx")
        End If
    End Sub
End Class