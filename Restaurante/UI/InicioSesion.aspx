<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterRestaurante.Master" CodeBehind="InicioSesion.aspx.vb" Inherits="UI.InicioSesion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="encabezado" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
    <div class="col-sm-4" style="background-color: lavender;"></div>
    <div class="col-sm-4" style="background-color: #B03A2E">
        <h1>Inicio Sesion</h1>

        <form id="form1" runat="server" class="form-group-lg">
            <div>
                <asp:Label ID="lblNombreUsuario" runat="server" Text="Nombre Usuario" Width="150"></asp:Label>
                <asp:TextBox ID="txtNombreUsuario" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblContrasenna" runat="server" Text="Contrasenna" Width="150"></asp:Label>
                <asp:TextBox ID="txtContrasenna" TextMode="Password" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnInicioSesion" runat="server" Text="Iniciar Sesion" />
                <br />
                <br />
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </div>
        </form>
    </div>
    <div class="col-sm-4" style="background-color: lavender;"></div>
</asp:Content>
