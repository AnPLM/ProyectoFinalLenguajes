Imports BL
Public Class RegistroUsuarios
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Usuario") Is Nothing Then
            Response.Redirect("InicioSesion.aspx")
        End If
    End Sub


    Protected Sub btnRegistrarUsuario_Click(sender As Object, e As EventArgs) Handles btnRegistrarUsuario.Click
        If (txtNombreUsuario.Text <> "" And txtContrasenna.Text <> "") Then
            Dim tipo As String
            Dim habilitado As Boolean = False
            If (radioAdministrador.Checked) Then
                tipo = "ADMINISTRADOR"
            Else
                tipo = "COCINERO"
            End If
            If (checkHabilitado.Checked) Then
                habilitado = True
            End If
            Dim usuario As New ManejadorUsuario
            usuario.agregarUsuario(txtNombreUsuario.Text, txtContrasenna.Text, tipo, habilitado)
            Response.Write("Usuario Registrado Correctamente")
            Response.Redirect("AdministrarUsuarios.aspx")
        End If
    End Sub
End Class