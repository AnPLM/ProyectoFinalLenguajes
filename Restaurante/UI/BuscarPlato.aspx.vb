Imports BL
Public Class BuscarPlato
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Usuario") Is Nothing Then
            Response.Redirect("InicioSesion.aspx")
        End If
        Session("ListaPlatos") = New List(Of Plato)
    End Sub

    Protected Sub btnBuscarPlato_Click(sender As Object, e As EventArgs) Handles btnBuscarPlato.Click
        Dim platoManager As New ManejadorPlato
        Session("ListaPlatos") = platoManager.buscarPlatoAdmin(txtNombre.Text)
    End Sub

    Protected Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Response.Redirect("OpcionesMenuPlatos.aspx")
    End Sub
End Class