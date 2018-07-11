Imports BL
Public Class AdministrarPedidos_Admin
    Inherits System.Web.UI.Page

    Protected Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            Dim cliente As String = txtCliente.Text.Trim()
            Dim estado As String = txtEstado.Text.Trim()
            Dim fechaInicio As String = txtFechaInicio.Text.Trim()
            Dim fechaFin As String = txtFechaFin.Text.Trim()
            Dim adminBL As New AdminListaPedido()

            Dim lista As New List(Of AtributosDetallePedido)

            Dim nullCliente As Boolean = (cliente.CompareTo("") = 0)
            Dim nullEstado As Boolean = (estado.CompareTo("") = 0)
            Dim nullFechaInicio As Boolean = (fechaInicio.CompareTo("") = 0)
            Dim nullFechaFin As Boolean = (fechaFin.CompareTo("") = 0)

            ''Todos
            If nullCliente <> True And nullEstado <> True And nullFechaFin <> True And nullFechaInicio <> True Then
                lista = adminBL.seleccionarPorClienteFechaEstado(fechaInicio, fechaFin, cliente, estado)
                grdPedidos.DataSource = lista
                grdPedidos.DataBind()
                ViewState("DatosGrid") = lista
                btnEditarEstados.Enabled = True
            End If

            ''Por cliente
            If nullCliente <> True And nullEstado And nullFechaFin And nullFechaInicio Then
                lista = adminBL.seleccionarPorCliente(cliente)
                grdPedidos.DataSource = lista
                grdPedidos.DataBind()
                ViewState("DatosGrid") = lista
                btnEditarEstados.Enabled = True
            End If

            ''Por fecha
            If nullCliente And nullEstado And nullFechaInicio <> True And nullFechaFin <> True Then
                lista = adminBL.seleccionarPorFecha(fechaInicio, fechaFin)
                grdPedidos.DataSource = lista
                grdPedidos.DataBind()
                ViewState("DatosGrid") = lista
                btnEditarEstados.Enabled = True
            End If

            ''Por estado
            If nullCliente And nullEstado <> True And nullFechaInicio And nullFechaFin Then
                lista = adminBL.seleccionarPorEstado(estado)
                grdPedidos.DataSource = lista
                grdPedidos.DataBind()
                ViewState("DatosGrid") = lista
                btnEditarEstados.Enabled = True
            End If

            ''Por Fecha y Cliente
            If nullCliente <> True And nullEstado And nullFechaInicio <> True And nullFechaFin <> True Then
                lista = adminBL.seleccionarPorClienteFecha(cliente, fechaInicio, fechaFin)
                grdPedidos.DataSource = lista
                grdPedidos.DataBind()
                ViewState("DatosGrid") = lista
                btnEditarEstados.Enabled = True
            End If

            ''Por Cliente y estado
            If nullCliente <> True And nullEstado <> True And nullFechaInicio And nullFechaFin Then
                lista = adminBL.seleccionarPorClienteEstado(cliente, estado)
                grdPedidos.DataSource = lista
                grdPedidos.DataBind()
                ViewState("DatosGrid") = lista
                btnEditarEstados.Enabled = True
            End If

            ''Por fecha y estado
            If nullCliente And nullEstado <> True And nullFechaInicio <> True And nullFechaFin <> True Then
                lista = adminBL.seleccionarPorFechaEstado(estado, fechaInicio, fechaFin)
                grdPedidos.DataSource = lista
                grdPedidos.DataBind()
                ViewState("DatosGrid") = lista
                btnEditarEstados.Enabled = True
            End If
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblNombreUsuario.Visible = False
        lblNuevoEstado.Visible = False
        txtNuevoEstado.Visible = False
        txtUsuario.Visible = False
        btnCambiarEstado.Visible = False
        btnEditarEstados.Enabled = False
    End Sub
End Class