Imports BL
Public Class ModificarNombre
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Usuario") Is Nothing Then
            Response.Redirect("InicioSesion.aspx")
        End If
    End Sub

    Protected Sub btnHabilitar_Click(sender As Object, e As EventArgs) Handles btnHabilitar.Click
        If txtNombreUsuario.Text <> "" And txtNuevoNombre.Text <> "" Then
            Dim usuario As New ManejadorUsuario()
            usuario.modificarNombre(txtNombreUsuario.Text, txtNuevoNombre.Text)
            Response.Redirect("ModificarUsuarios.aspx")
        End If
    End Sub

    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Response.Redirect("ModificarUsuarios.aspx")
    End Sub
End Class