Imports BL
Public Class AdministrarMenu
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim plato As New Plato()
        GridView1.DataSource = plato.listarPlatos()
        GridView1.DataBind()
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim plato As New Plato
        plato.Nombre = txtNombre.Text
        plato.buscarPlato()
        Session("Nombre") = plato.Nombre
        Session("Descripcion") = plato.Descripcion
        Session("Precio") = plato.Precio
        Label1.Text = plato.Nombre + " " + plato.Descripcion + " " + plato.Precio.ToString()
    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub


    Protected Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim plato As New Plato
        plato.Nombre = txtNombre.Text
        plato.Descripcion = txtDescripcion.Text
        plato.Precio = Double.Parse(txtPrecio.Text)
        plato.Fotografia = "hola"
        'plato.Fotografia = fotografia.PostedFile.FileName
        If checkHabilitado.Checked Then
            plato.Habilitado = 1
        Else
            plato.Habilitado = 0
        End If
        plato.agregarPlato()
    End Sub
End Class