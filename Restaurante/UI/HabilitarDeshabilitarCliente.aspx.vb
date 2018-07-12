Imports BL
Public Class HabilitarDeshabilitarUsuario
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Usuario") Is Nothing Then
            Response.Redirect("InicioSesion.aspx")
        End If
        'Dim array As New ArrayList()
        Dim array As New List(Of ClienteSerializable)
        Session("Cliente") = array
        btnHabilitar.Visible = False
        btnDeshabilitar.Visible = False
    End Sub

    Protected Sub btnRegistrarUsuario_Click(sender As Object, e As EventArgs) Handles btnRegistrarUsuario.Click
        lblError.Text = ""
        Dim clienteBL As New ClienteSerializable()
        'Dim array As New ArrayList()
        Dim array As New List(Of ClienteSerializable)
        Dim cliente = clienteBL.buscarCliente(txtNombre.Text.Trim())
        If cliente.Nombre Is Nothing Then
            lblError.Text = "No se encontro el cliente"
        Else
            If clienteBL.NombreUsuario <> "" Then
                array.Add(clienteBL.buscarCliente(txtNombre.Text.Trim()))
                Session("Cliente") = array
                ViewState("Cliente") = array
                If clienteBL.Habilitado Then
                    btnDeshabilitar.Visible = True
                Else
                    btnHabilitar.Visible = True
                End If
            End If
        End If

    End Sub

    Protected Sub btnHabilitar_Click(sender As Object, e As EventArgs) Handles btnHabilitar.Click
        Dim cliente As New ClienteSerializable()
        Dim lista As List(Of ClienteSerializable) = ViewState("Cliente")
        For Each d As ClienteSerializable In lista
            cliente.habilitarCliente(d.NombreUsuario)
        Next
    End Sub

    Protected Sub btnDeshabilitar_Click(sender As Object, e As EventArgs) Handles btnDeshabilitar.Click
        Dim cliente As New ClienteSerializable()
        Dim lista As List(Of ClienteSerializable) = ViewState("Cliente")
        For Each d As ClienteSerializable In lista
            cliente.deshabilitarCliente(d.NombreUsuario)
        Next
    End Sub

    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Response.Redirect("PaginaPrincipal.aspx")
    End Sub
End Class