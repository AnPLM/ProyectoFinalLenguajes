Imports BL
Public Class OrderUI
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ordenes As New ManejadorOrdenes()
        Session("ListaOrdenes") = ordenes.listaOrdenes
    End Sub

End Class