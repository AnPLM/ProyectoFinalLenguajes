Imports System.Collections.Generic
Imports BL
Public Class OrdenesUI
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'ManejadorOrdenes ordenes = New ManejadorOrdenes()
        Dim ordenes As New ManejadorOrdenes()
        Dim orden As New BLOrden()
        Dim list = ordenes.listaOrdenes
        'ListView1.DataSource = ordenes.listaOrdenes
        'ListView1.DataBind()
        'ListView1.
        'RepeaterOrdenes.DataSource = ordenes.listaOrdenes()
        'RepeaterOrdenes.DataBind()
    End Sub


End Class