<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterRestaurante.Master" CodeBehind="OrdenUI.aspx.vb" Inherits="UI.OrdenUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="encabezado" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
<form id="ordenes" runat="server" class="form-group-lg">
    <%      Dim list As ArrayList = Session("ListaOrdenes") %>
    <div class="conatiner col-lg-1 col-sm-8 margin-up-panel margin-botton-panel margin-left" style="background-color:#00ff21">
        <h1 class="margin-up-panel text-center">Lista Ordenes</h1>
        <div id="table" class="table-editable table-responsive">

        </div>
    </div>
     

</form>
</asp:Content>




<asp:Content ID="Content3" ContentPlaceHolderID="pie" runat="server">
</asp:Content>
