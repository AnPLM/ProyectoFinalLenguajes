<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterRestaurante.Master" CodeBehind="PaginaPrincipal.aspx.vb" Inherits="UI.PaginaPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="encabezado" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
    <form id="form1" runat="server" class="form-group-lg">
        <div class="container col-sm-8 col-md-offset-2"  style="background-color:firebrick">
            <div class="container col-md-4 col-sm-offset-4" style="background-color: firebrick">
                <h1 class="text-center" style="color: beige">Bienvenido</h1>
                <asp:Button ID="btnAdministrarMenu" CssClass="btn btn-success text-center margin-up-button btn-block" runat="server" Text="Administrar Menu" />
                <asp:Button ID="btnAdministrarUsuarios" CssClass="btn btn-success text-center margin-up-button btn-block" runat="server" Text="Administrar Usuarios" />
                <asp:Button ID="btnAdministrarClientes" CssClass="btn btn-success text-center margin-up-button margin-botton-panel btn-block" runat="server" Text="Administrar Clientes" />
                <asp:Button ID="btnAdministrarPedidos" CssClass="btn btn-success text-center margin-up-button margin-botton-panel btn-block" runat="server" Text="Administrar Pedidos" />
                <asp:Button ID="Regresar" CssClass="btn btn-primary text-center margin-up-button btn-block" runat="server" Text="Cerrar Sesion" />
                <br />
            </div>
        </div>
        <br />
        <div class="text-center">
        </div>
    </form>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pie" runat="server">
</asp:Content>
