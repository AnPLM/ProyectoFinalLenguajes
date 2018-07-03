<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RegistrarCliente.aspx.vb" Inherits="UI.RegistrarCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {}
    </style>
</head>
<body>
    <h1>Registrar un cliente</h1>
    <form id="form1" runat="server">
        <div style="background-color:black">
            <div class="form-group">
                <br />
                <asp:Label ID="lblNombreCompleto" Style="font-size: medium; color: beige" Width="150px" runat="server" Text="Nombre Completo" ForeColor="Black"></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombreUsuario" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:Label ID="lblNombreUsuario" Style="font-size: medium; color: beige" Width="150px" runat="server" Text="Nombre Usuario"></asp:Label>
                <asp:TextBox ID="txtNombreUsuario" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvNombreUsuario" runat="server" ControlToValidate="txtNombreUsuario" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:Label ID="lblCorreo" Style="font-size: medium; color: beige" Width="150px" runat="server" Text="Correo"></asp:Label>
                <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvCorreo" runat="server" ControlToValidate="txtCorreo" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revCorreo" runat="server" ControlToValidate="txtCorreo" ErrorMessage="Formato de correo incorrecto" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </div>
            <div class="form-group">
                <asp:Label ID="lblDireccion" Style="font-size: medium; color: beige" Width="150px" runat="server" Text="Dirección"></asp:Label>
                <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="txtDireccion" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:Label ID="lblContrasenna" Style="font-size: medium; color: beige" Width="150px" runat="server" Text="Contraseña"></asp:Label>
                <asp:TextBox ID="txtContrasenna" textmode="Password" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvContrasenna" runat="server" ControlToValidate="txtContrasenna" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
            </div>
            <div class="margin-up-panel text-center">
                <br />
                <asp:Button type="submit" class="btn btn-success btn-responsive margin-botton-panel" ID="btnRegistrar" runat="server" Text="Registrar" CausesValidation="False" />
                <asp:Button ID="Button1" runat="server" Text="Habilitar Cliente" CssClass="auto-style1" Width="164px" CausesValidation="False" />
                <br />
                <br />
                <asp:Button ID="Button2" runat="server" Text="Deshabiliar Cliente" Width="164px" CausesValidation="False" />
            </div>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Prueba de que aqui esta el label" BackColor="White"></asp:Label>
            </div>
    </form>
</body>
</html>
