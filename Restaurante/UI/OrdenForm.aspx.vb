Imports BL
Public Class OrdenForm
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim orden As New BLOrden
        Dim listOrden As New ManejadorOrdenes
        Dim list As New ArrayList
        list = listOrden.listaOrdenes()
        GridView1.DataSource = list
        GridView1.DataBind()


        'ListOrdenes.Columns.Add("5")


        'For Each i As BLOrden In list

        'Dim lista As ListViewItem = New ListViewItem(5)
        'lista.DataItem.Add(i.nombreUsuario)
        'lista.DataItem.Add(i.Estado)
        'lista.DataItem.Add(i.Identificador)
        'ListOrdenes.Items.Add(lista)
        'Next i
        'ListOrdenes.DataSource = listOrden.listaOrdenes()
        'ListOrdenes.ItemTemplate = orden
        'ListOrdenes.DataBind()

    End Sub



    Protected Sub AdRotator_AdCreated(sender As Object, e As AdCreatedEventArgs) Handles AdRotator.AdCreated

    End Sub
End Class