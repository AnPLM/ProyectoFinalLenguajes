Public Class AdministrarPedidos_Admin
    Inherits System.Web.UI.Page

    Protected Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim cliente As String = txtCliente.Text.Trim()
        Dim estado As String = txtEstado.Text.Trim()
        Dim fechaInicio As String = txtFechaInicio.Text.Trim()
        Dim fechaFin As String = txtFechaFin.Text.Trim()


    End Sub
End Class