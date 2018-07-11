<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterRestaurante.Master" CodeBehind="AdministrarPedidos_Admin.aspx.vb" Inherits="UI.AdministrarPedidos_Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="encabezado" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
    <div class="col-sm-3" style="background-color: lavender;"></div>
    <div class="col-sm-6" style="background-color: lavender;" align="center"> 
        <h1>Pedidos Clientes</h1>
        <br />
        <br />
        <form id="mostrarPedidos" runat="server" class="form-group-lg">
            <asp:label runat="server" text="Nombre Usuario Cliente" width="170px" id="lblCliente"></asp:label>
            <asp:textbox runat="server" width="200px" ID="txtCliente"></asp:textbox>
            <br />
            <br />
            <br />
            <asp:label runat="server" text="Digite el estado" width="170px" id="lblEstado"></asp:label>
            <asp:textbox runat="server" id="txtEstado" width="200px"></asp:textbox>
            <br />
            <br />
            <asp:label runat="server" text="Desde" width="170px" id="lblFechaInicio"></asp:label>
            <asp:textbox type="date" runat="server" id="txtFechaInicio" width="200px" value=""></asp:textbox>
            <br />
            <br />
            <asp:label runat="server" text="Hasta" width="170px" id="lblFechaFin"></asp:label>
            <asp:textbox type="date" runat="server" id="txtFechaFin" width="200px" value=""></asp:textbox>
            <br />
            <br />
            <asp:button runat="server" text="Consultar" id="btnConsultar" />
            <br />
            <br />
            <br />
        <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </form>

        <br />
    </div>
    <div class="col-sm-3" style="background-color: lavender;"></div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pie" runat="server">
</asp:Content>
