﻿Imports BL
Public Class AdministrarMenu
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Usuario") Is Nothing Then
            Response.Redirect("InicioSesion.aspx")
        End If
        Dim platoManager As New ManejadorPlato
        Session("ListaPlatos") = platoManager.listarPlatos()
    End Sub


    'Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
    '    Dim platoManager As New ManejadorPlato
    '    platoManager.eliminarPlato(txtCodigo.Text)
    '    Session("ListaPlatos") = platoManager.listarPlatos()
    'End Sub


    Protected Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            Dim platoManager As New ManejadorPlato
            Dim habilitado = 0
            If checkHabilitado.Checked Then
                habilitado = 1
            Else
                habilitado = 0
            End If
            'fotografia.SaveAs(Server.MapPath("../Fotos/").ToString() + fotografia.FileName)
            platoManager.agregarPlato(txtCodigo.Text, txtNombre.Text, txtDescripcion.Text, Double.Parse(txtPrecio.Text), fotografia.FileName, habilitado)
            Session("ListaPlatos") = platoManager.listarPlatos()
        Catch ex As Exception

        End Try
    End Sub


    Protected Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim platoManager As New ManejadorPlato
        Dim codigo As String = ""
        Dim nombre As String = ""
        Dim descripcion As String = ""
        Dim precio As Double
        Dim fotografiaC As String = ""
        Dim habilitado As Integer = 5
        If txtCodigo.Text <> "" Then
            codigo = txtCodigo.Text
        End If
        If txtNombre.Text <> "" Then
            nombre = txtNombre.Text
        End If
        If txtDescripcion.Text <> "" Then
            descripcion = txtDescripcion.Text
        End If
        If txtPrecio.Text <> "" Then
            precio = Double.Parse(txtPrecio.Text)
        End If
        If fotografia.FileName <> "" Then
            fotografiaC = fotografia.FileName
        End If
        If checkHabilitado.Checked Then
            habilitado = 1
        Else
            habilitado = 0
        End If
        platoManager.modificarPlato(codigo, nombre, descripcion, precio, fotografiaC, habilitado)
        Session("ListaPlatos") = platoManager.listarPlatos()
    End Sub

    Protected Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Response.Redirect("OpcionesMenuPlatos.aspx")
    End Sub
End Class