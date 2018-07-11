<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterRestaurante.Master" CodeBehind="InicioSesion.aspx.vb" Inherits="UI.InicioSesion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="encabezado" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
    <div class="col-sm-4" style="background-color: lavender;"></div>
    <div class="col-sm-4" style="background-color: #B03A2E">
        <h1 style="color:beige" class="text-center">Inicio Sesión</h1>

        <form id="form1" runat="server" class="form-group-lg">
            <div>
                <asp:TextBox ID="txtNombreUsuario"  placeholder="Nombre Usuario" CssClass="form-control" runat="server"></asp:TextBox>
                <br />
                <asp:TextBox ID="txtContrasenna"  placeholder="Contraseña" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>
                <br />
                <div class="text-center">
                <asp:Button ID="btnInicioSesion" Cssclass="btn btn-success text-center margin-botton-panel" runat="server" Text="Iniciar Sesión" />
                </div>
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </div>
        </form>
    </div>
    <div class="col-sm-4" style="background-color: lavender;"></div>
</asp:Content>
