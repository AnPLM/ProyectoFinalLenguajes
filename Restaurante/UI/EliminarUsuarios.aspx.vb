﻿Imports BL
Public Class EliminarUsuarios
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim manejador As New ManejadorUsuario()
        Session("Usuarios") = manejador.listarUsuarios()
    End Sub

    Protected Sub btnRegistrarUsuario_Click(sender As Object, e As EventArgs) Handles btnRegistrarUsuario.Click
        Dim manejador As New ManejadorUsuario()
        If (txtNombre.Text <> "") Then
            manejador.eliminarUsuario(txtNombre.Text)
            Session("Usuarios") = manejador.listarUsuarios()
        End If

    End Sub
End Class