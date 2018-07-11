Imports BL
Public Class EliminarPlato
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim platoManager As New ManejadorPlato
        Session("ListaPlatos") = platoManager.listarPlatos()
    End Sub

    Protected Sub btnEliminarPlato_Click(sender As Object, e As EventArgs) Handles btnEliminarPlato.Click
        Dim platoManager As New ManejadorPlato
        platoManager.eliminarPlato(txtCodigo.Text)
        Session("ListaPlatos") = platoManager.listarPlatos()
    End Sub
End Class