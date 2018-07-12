Imports BL
Public Class EliminarUsuarios
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Usuario") Is Nothing Then
            Response.Redirect("InicioSesion.aspx")
        End If
        Dim manejador As New ManejadorUsuario()
        Session("Usuarios") = manejador.listarUsuarios()
    End Sub

    Protected Sub btnRegistrarUsuario_Click(sender As Object, e As EventArgs) Handles btnRegistrarUsuario.Click
        Dim manejador As New ManejadorUsuario()
        If (txtNombre.Text <> "") Then
            manejador.eliminarUsuario(txtNombre.Text)
            Session("Usuarios") = manejador.listarUsuarios()
        End If

    End Sub

    Protected Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Response.Redirect("AdministrarUsuarios.aspx")
    End Sub
End Class