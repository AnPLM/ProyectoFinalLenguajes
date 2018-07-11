Imports BL
Public Class AdministrarPedidos_Admin
    Inherits System.Web.UI.Page

    Protected Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim cliente As String = txtCliente.Text.Trim()
        Dim estado As String = txtEstado.Text.Trim()
        Dim fechaInicio As String = txtFechaInicio.Text.Trim()
        Dim fechaFin As String = txtFechaFin.Text.Trim()
        Dim adminBL As New AdminListaPedido()

        Dim nullCliente As Boolean = (cliente.CompareTo("") = 0)
        Dim nullEstado As Boolean = (estado.CompareTo("") = 0)
        Dim nullFechaInicio As Boolean = (fechaInicio.CompareTo("") = 0)
        Dim nullFechaFin As Boolean = (fechaFin.CompareTo("") = 0)

        ''Todos
        If nullCliente <> True And nullEstado <> True And nullFechaFin <> True And nullFechaInicio <> True Then
            GridView1.DataSource = adminBL.seleccionarPorClienteFechaEstado(fechaInicio, fechaFin, cliente, estado)
            GridView1.DataBind()
        End If

        ''Por cliente
        If nullCliente <> True And nullEstado And nullFechaFin And nullFechaInicio Then
            GridView1.DataSource = adminBL.seleccionarPorCliente(cliente)
            GridView1.DataBind()
        End If

        ''Por fecha
        If nullCliente And nullEstado And nullFechaInicio <> True And nullFechaFin <> True Then
            GridView1.DataSource = adminBL.seleccionarPorFecha(fechaInicio, fechaFin)
            GridView1.DataBind()
        End If

        ''Por estado
        If nullCliente And nullEstado <> True And nullFechaInicio And nullFechaFin Then
            GridView1.DataSource = adminBL.seleccionarPorEstado(estado)
            GridView1.DataBind()
        End If

        ''Por Fecha y Cliente
        If nullCliente <> True And nullEstado And nullFechaInicio <> True And nullFechaFin <> True Then
            GridView1.DataSource = adminBL.seleccionarPorClienteFecha(cliente, fechaInicio, fechaFin)
            GridView1.DataBind()
        End If

        ''Por Cliente y estado
        If nullCliente <> True And nullEstado <> True And nullFechaInicio And nullFechaFin Then
            GridView1.DataSource = adminBL.seleccionarPorClienteEstado(cliente, estado)
            GridView1.DataBind()
        End If

        ''Por fecha y estado
        If nullCliente And nullEstado <> True And nullFechaInicio <> True And nullFechaFin <> True Then
            GridView1.DataSource = adminBL.seleccionarPorFechaEstado(estado, fechaInicio, fechaFin)
            GridView1.DataBind()
        End If
    End Sub
End Class