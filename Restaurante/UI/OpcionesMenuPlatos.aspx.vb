﻿Public Class OpcionesMenuPlatos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Usuario") Is Nothing Then
            Response.Redirect("InicioSesion.aspx")
        End If
    End Sub

    Protected Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Response.Redirect("AdministrarMenu.aspx")
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Response.Redirect("BuscarPlato.aspx")
    End Sub

    Protected Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Response.Redirect("AdministrarMenu.aspx")
    End Sub

    Protected Sub btnElimiar_Click(sender As Object, e As EventArgs) Handles btnElimiar.Click
        Response.Redirect("EliminarPlato.aspx")
    End Sub

    Protected Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Response.Redirect("PaginaPrincipal.aspx")
    End Sub
End Class