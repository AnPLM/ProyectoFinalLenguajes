Imports BL
Public Class AdministrarMenu
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim plato As New Plato()
        Session("ListaPlatos") = plato.listarPlatos()
        'GridView1.DataSource = plato.listarPlatos()
        'GridView1.DataBind()
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim plato As New Plato
        plato.Codigo = txtCodigo.Text
        plato.buscarPlato()
        Session("Nombre") = plato.Nombre
        Session("Descripcion") = plato.Descripcion
        Session("Precio") = plato.Precio
        'Label1.Text = plato.Nombre + " " + plato.Descripcion + " " + plato.Precio.ToString()

    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim plato As New Plato
        plato.Codigo = txtCodigo.Text
        plato.eliminarPlato()
        Session("ListaPlatos") = plato.listarPlatos()
    End Sub


    Protected Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim plato As New Plato
        plato.Codigo = txtCodigo.Text
        plato.Nombre = txtNombre.Text
        plato.Descripcion = txtDescripcion.Text
        plato.Precio = Double.Parse(txtPrecio.Text)
        plato.Fotografia = fotografia.FileName
        Label1.Text = Server.MapPath("./Imagenes").ToString
        'fotografia.SaveAs(Server.MapPath("../Imagenes/").ToString + fotografia.FileName)

        If checkHabilitado.Checked Then
            plato.Habilitado = 1
        Else
            plato.Habilitado = 0
        End If
        plato.agregarPlato()
        Session("ListaPlatos") = plato.listarPlatos()
        'GridView1.DataSource = plato.listarPlatos()
        'GridView1.DataBind()
    End Sub


    Protected Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim plato As New Plato
        plato.Codigo = txtCodigo.Text
        If txtNombre.Text <> "" Then
            plato.Nombre = txtNombre.Text
        End If
        If txtDescripcion.Text <> "" Then
            plato.Descripcion = txtDescripcion.Text
        End If
        If txtPrecio.Text <> "" Then
            plato.Precio = Double.Parse(txtPrecio.Text)
        End If
        plato.Fotografia = "Hey"
        If checkHabilitado.Checked Then
            plato.Habilitado = 1
        Else
            plato.Habilitado = 0
        End If
        plato.modificarPlato()
        Session("ListaPlatos") = plato.listarPlatos()
    End Sub

    'Protected Sub btnEliminar2_Click(sender As Object, e As EventArgs) Handles btnEliminar2.Click
    '    Dim elminar = Session("Hola")

    'End Sub
End Class