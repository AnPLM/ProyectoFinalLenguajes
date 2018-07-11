Imports BL
Public Class OrderUI
    Inherits System.Web.UI.Page
    Private orden As New ManejadorOrdenes()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("ListaOrdenes") = orden.listaOrdenes
        Session("orden") = orden
    End Sub

    Protected Sub btnEntregar_Click(sender As Object, e As EventArgs)
        Dim ide = Session("ide")
        orden.eliminar(ide)
        Response.Redirect("OrderUI.aspx")
    End Sub

    Protected Sub btnDeshacer_Click(sender As Object, e As EventArgs)
        Dim o As BLOrden = Session("des")
        orden.insertar(o.nombreUsuario, o.Fecha, o.Estado, o.Identificador)
        Response.Redirect("OrderUI.aspx")
    End Sub
End Class