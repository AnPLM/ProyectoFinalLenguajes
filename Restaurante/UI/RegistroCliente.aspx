<!--%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterRestaurante.Master" CodeBehind="RegistroCliente.aspx.vb" Inherits="UI.RegistroCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="encabezado" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-sm-4" style="background-color:lavender;"></div>
            <div class="col-sm-4" style="background-color: #B03A2E">
                <div class="form-group">
                    <br />
                    <asp:Label ID="lblNombreCompleto" style="font-size: medium; color: beige" width="150px" runat="server" Text="Nombre Completo"></asp:Label>
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblNombreUsuario" style="font-size: medium; color: beige" width="150px" runat="server" Text="Nombre Usuario"></asp:Label>
                    <asp:TextBox ID="txtNombreUsuario" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblCorreo" style="font-size: medium; color: beige" width="150px" runat="server" Text="Correo"></asp:Label>
                    <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblDireccion" style="font-size: medium; color: beige" width="150px" runat="server" Text="Dirección"></asp:Label>
                    <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblContrasenna" style="font-size: medium; color: beige" width="150px" runat="server" Text="Contraseña"></asp:Label>
                    <asp:TextBox ID="txtContrasenna" runat="server"></asp:TextBox>
                </div>
                <div  class="margin-up-panel text-center">
                <asp:Button ID="Button1" runat="server" Text="Button" />
                <br />
                <asp:Button type="submit" class="btn btn-success btn-responsive margin-botton-panel" ID="btnRegistrar" runat="server" Text="Registrar" />
                    </div>
            </div>
            <div class="col-sm-4" style="background-color:lavender"></div>
        </div>
    </form>
</asp:Content>
