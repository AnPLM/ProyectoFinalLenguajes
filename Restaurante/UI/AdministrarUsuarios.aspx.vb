Public Class AdministrarUsuarios
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Response.Redirect("RegistroUsuarios.aspx")
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Response.Redirect("BuscarUsuarios.aspx")
    End Sub

    Protected Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Response.Redirect("ModificarUsuarios.aspx")
    End Sub

    Protected Sub btnElimiar_Click(sender As Object, e As EventArgs) Handles btnElimiar.Click
        Response.Redirect("EliminarUsuarios.aspx")
    End Sub
End Class