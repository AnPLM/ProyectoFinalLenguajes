Imports BL
Public Class ModificarUsuarios
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim manejador = New ManejadorUsuario
        Dim array As New ArrayList()
        Session("Usuario") = manejador.listarUsuarios()
    End Sub

    Protected Sub btnModificarNombre_Click(sender As Object, e As EventArgs) Handles btnModificarNombre.Click
        Response.Redirect("ModificarNombre.aspx")
    End Sub

    Protected Sub btnModificarContrasenna_Click(sender As Object, e As EventArgs) Handles btnModificarContrasenna.Click
        Response.Redirect("ModificarContrasenna.aspx")
    End Sub
End Class