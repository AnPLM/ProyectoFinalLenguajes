Imports BL
Public Class BuscarPlato
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("ListaPlatos") = New List(Of Plato)
    End Sub

    Protected Sub btnBuscarPlato_Click(sender As Object, e As EventArgs) Handles btnBuscarPlato.Click
        Dim platoManager As New ManejadorPlato
        Session("ListaPlatos") = platoManager.buscarPlatoAdmin(txtNombre.Text)
    End Sub
End Class