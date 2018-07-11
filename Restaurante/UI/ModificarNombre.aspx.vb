Imports BL
Public Class ModificarNombre
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnHabilitar_Click(sender As Object, e As EventArgs) Handles btnHabilitar.Click
        If txtNombreUsuario.Text <> "" And txtNuevoNombre.Text <> "" Then
            Dim usuario As New ManejadorUsuario()
            usuario.modificarNombre(txtNombreUsuario.Text, txtNuevoNombre.Text)
            Response.Redirect("ModificarUsuarios.aspx")
        End If
    End Sub
End Class