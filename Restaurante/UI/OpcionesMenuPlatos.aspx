<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterRestaurante.Master" CodeBehind="OpcionesMenuPlatos.aspx.vb" Inherits="UI.OpcionesMenuPlatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="encabezado" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">

     <form id="form1" runat="server" class="form-group-lg">
        <div class="panel panel-default col-md-4 col-md-offset-4" style="background-color:firebrick">
            <h2 class="text-center" style="color:beige">Administrar Platos</h2>
            <div class="panel panel-default col-sm-6 col-sm-offset-3 margin-up" style="background-color:firebrick">
            <asp:Button type="submit" Cssclass="btn btn-success btn-block inputBoton margin-up-button margin-botton-panel" ID="btnAgregar" runat="server" Text="Agregar" />
            <asp:Button type="submit" Cssclass="btn btn-success btn-block inputBoton margin-botton-panel" ID="btnBuscar" runat="server" Text="Buscar" />
            <asp:Button type="submit" Cssclass="btn btn-success  btn-block margin-botton-panel" ID="btnModificar" runat="server" Text="Modificar" />
            <asp:Button type="submit" Cssclass="btn btn-success  btn-block margin-botton-panel" ID="btnElimiar" runat="server" Text="Eliminar" />
            </div>
        </div>
    </form>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pie" runat="server">
</asp:Content>
