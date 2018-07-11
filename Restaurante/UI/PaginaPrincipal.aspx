<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterRestaurante.Master" CodeBehind="PaginaPrincipal.aspx.vb" Inherits="UI.PaginaPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="encabezado" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
    <form id="form1" runat="server" class="form-group-lg">
        <div class="container col-sm-8 col-md-offset-2"  style="background-color:firebrick">
                <div class="container col-md-4 col-sm-offset-4"  style="background-color:firebrick">
                <h1 class="text-center" style="color:beige">Bienvenido</h1>
                    <asp:Button ID="btnAdministrarMenu" Cssclass="btn btn-success text-center margin-up-button btn-block" runat="server" Text="Administrar Menu" />  
                    <asp:Button ID="btnAdministrarUsuarios" Cssclass="btn btn-success text-center margin-up-button btn-block" runat="server" Text="Administrar Usuarios" />  
                    <asp:Button ID="btnAdministrarPedidos" Cssclass="btn btn-success text-center margin-up-button margin-botton-panel btn-block" runat="server" Text="Administrar Pedidos" />  
            </div>
        </div>
   </form>   
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pie" runat="server">
</asp:Content>
