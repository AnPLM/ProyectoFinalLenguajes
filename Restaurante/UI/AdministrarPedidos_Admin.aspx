<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterRestaurante.Master" CodeBehind="AdministrarPedidos_Admin.aspx.vb" Inherits="UI.AdministrarPedidos_Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="encabezado" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
    <div class="col-sm-3" style="background-color: lavender;"></div>
    <div class="col-sm-6" style="background-color: #B03A2E;" align="center"> 
        <h1 style="color:beige">Pedidos Clientes</h1>
        <br />
        <br />
        <form id="mostrarPedidos" runat="server" class="form-group-lg">
            <asp:label runat="server" text="Nombre Usuario Cliente" width="170px" id="lblCliente" style="color:beige"></asp:label>
            <asp:textbox runat="server" CssClass="form-control" width="200px" ID="txtCliente"></asp:textbox>
            <br />
            <br />
            <asp:label runat="server" text="Digite el estado" width="170px" id="lblEstado" style="color:beige"></asp:label>
            <asp:textbox runat="server" CssClass="form-control" id="txtEstado" width="200px"></asp:textbox>
            <br />
            <br />
            <asp:label runat="server" text="Desde" width="170px" id="lblFechaInicio" style="color:beige"></asp:label>
            <asp:textbox type="date" CssClass="form-control" runat="server" id="txtFechaInicio" width="200px" value=""></asp:textbox>
            <br />
            <br />
            <asp:label runat="server" text="Hasta" width="170px" id="lblFechaFin" style="color:beige"></asp:label>
            <asp:textbox type="date" CssClass="form-control" runat="server" id="txtFechaFin" width="200px" value=""></asp:textbox>
            <br />
            <br />
            <asp:button runat="server" Cssclass="btn btn-success text-center margin-botton-panel" text="Consultar" id="btnConsultar" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" style="color:beige"></asp:Label>
            <br />
        <br />
            <asp:GridView ID="grdPedidos" runat="server" CssClass="table table-bordered bs-table" ForeColor="Beige">
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="btnEditarEstados" Cssclass="btn btn-success text-center margin-botton-panel" runat="server" Text="Cambiar Estados" />
            <br />
            <br />
            <asp:Label ID="lblNumeroORden" runat="server" Text="Nombre de Orden" width="170px" style="color:beige"></asp:Label>
            <asp:TextBox ID="txtOrden" CssClass="form-control" runat="server" width="200px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblNuevoEstado" runat="server" Text="Nuevo valor del estado" width="170px" style="color:beige"></asp:Label>
            <asp:TextBox ID="txtNuevoEstado" CssClass="form-control" runat="server" width="200px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCambiarEstado" Cssclass="btn btn-success text-center margin-botton-panel" runat="server" Text="Cambiar Estado" />
        </form>
    </div>
    <div class="col-sm-3" style="background-color: lavender;"></div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pie" runat="server">
</asp:Content>
