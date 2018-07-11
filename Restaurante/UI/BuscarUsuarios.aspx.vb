Imports BL
Public Class BuscarUsuarios
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Usuario") Is Nothing Then
            Response.Redirect("InicioSesion.aspx")
        End If
        Dim array As New ArrayList()
        Session("Usuario") = array
    End Sub

    Protected Sub btnRegistrarUsuario_Click(sender As Object, e As EventArgs) Handles btnRegistrarUsuario.Click
        Dim manejadoUsuario As New ManejadorUsuario
        Dim array As New ArrayList()
        Dim usuario = manejadoUsuario.buscarUsuario(txtNombre.Text)
        If usuario.TipoUsuario <> "" Then
            array.Add(manejadoUsuario.buscarUsuario(txtNombre.Text))
            Session("Usuario") = array
        End If
    End Sub
End Class