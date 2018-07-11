Public Class PaginaPrincipal
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnAdministrarMenu_Click(sender As Object, e As EventArgs) Handles btnAdministrarMenu.Click
        Response.Redirect("OpcionesMenuPlatos.aspx")
    End Sub

    Protected Sub btnAdministrarUsuarios_Click(sender As Object, e As EventArgs) Handles btnAdministrarUsuarios.Click
        Response.Redirect("AdministrarUsuarios.aspx")
    End Sub

    Protected Sub btnAdministrarPedidos_Click(sender As Object, e As EventArgs) Handles btnAdministrarPedidos.Click
        Response.Redirect("AdministrarPedidos_Admin.aspx")
    End Sub
End Class