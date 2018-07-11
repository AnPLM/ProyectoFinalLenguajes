Imports System.Collections.Generic
Imports System.Web.UI.WebControls
Imports BL
Public Class OrdenUI2
    Inherits System.Web.UI.Page
    Dim man As New ManejadorOrdenes
    Public Property btn As New Button
    ' Dim table As New Table
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim list As New List(Of BLOrden)
        'For Each b As BLOrden In man.listaOrdenes
        '   list.Add(b)
        'Next
        createTable()
        'table.
    End Sub

    Public Sub createTable()
        table.Attributes.Add("class", "table table-bordered table-responsive-md table-stripped text-center")
        For Each orden As BLOrden In man.listaActiva
            Dim row As New TableRow
            Dim cellFecha As New TableCell
            cellFecha.Text = orden.Fecha
            cellFecha.Attributes.Add("class", "col1")
            cellFecha.Attributes.Add("contenteditable", "true")
            row.Cells.Add(cellFecha)
            Dim cellNombre As New TableCell
            cellNombre.Text = orden.nombreUsuario
            cellNombre.Attributes.Add("class", "col1")
            cellNombre.Attributes.Add("contenteditable", "true")
            row.Cells.Add(cellNombre)
            Dim cellEstado As New TableCell
            cellEstado.Text = orden.Estado
            cellEstado.Attributes.Add("class", "col1")
            cellEstado.Attributes.Add("contenteditable", "true")
            row.Cells.Add(cellEstado)
            Dim cellIde As New TableCell
            cellIde.Text = orden.Identificador
            cellIde.Attributes.Add("class", "true")
            cellIde.Attributes.Add("contenteditable", "true")
            row.Cells.Add(cellIde)
            Dim celBtn As New TableCell
            Dim btn As New Button
            btn.Text = "Entregar"
            btn.ID = orden.Identificador
            btn.Attributes.Add("id", orden.Identificador)
            btn.Attributes.Add("OnClick", "event_click")
            celBtn.Controls.Add(btn)
            row.Cells.Add(celBtn)
            table.Rows.Add(row)
            'WebControls.Table.Rows.Add(row)
        Next
    End Sub

    Public Event Click As EventHandler



    Protected Event event_click(ByVal sender As Object, ByVal e As System.EventArgs)

    Sub ss()
        'event_c
    End Sub

    'Dim id = btn.ID
    '    man.eliminar(id)


    '    Protected Sub Click Handles btn.click()


    'Protected Sub btn_Click(sender As Object, e As EventArgs)

    'End Sub

    'Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    'End Sub
End Class