<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterRestaurante.Master" CodeBehind="OrderUI.aspx.vb" Inherits="UI.OrderUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="encabezado" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
    <form id="ordenes" runat="server" class="form-group-lg">
    <%      Dim list As ArrayList = Session("ListaOrdenes") %>
    <div class="conatiner col-lg-1 col-sm-8 margin-up-panel margin-botton-panel margin-left" style="background-color:#00ff21">
        <h1 class="margin-up-panel text-center">Lista Ordenes</h1>
        <div id="table" class="table-editable table-responsive">
            <span class="table-add float-right mb-3 mr-2"><a href="#!" class="text-succes"><i class="fade fa-plus fa-2x" aria-hidden="true"></i></a></span>
            <table class="table table-bordered table-responsive-md table-stripped text-center">
               <thead>
                 <tr>
                    <th class="text-center">Usuario</th>
                    <th class="text-center">Fecha</th>
                    <th class="text-center">Estado</th>
                    <th class="text-center">Num Orden</th>
                </tr>
               </thead>
                <%For Each o As BL.BLOrden In list %>
                <tr>
                    <td class="col1" contenteditable="true"><%=o.nombreUsuario %></td>
                    <td class="col1" contenteditable="true"><%=o.Fecha %></td>
                    <td class="col1" contenteditable="true"><%=o.Estado %></td>
                    <td class="col1" contenteditable="true"><%=o.Identificador %></td>
                </tr>
                <%Next %>
            </table>
        </div>
    </div>
     

</form>
</asp:Content>




<asp:Content ID="Content3" ContentPlaceHolderID="pie" runat="server">
</asp:Content>
