<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterRestaurante.Master" CodeBehind="OrderUI.aspx.vb" Inherits="UI.OrderUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="encabezado" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
    <div class="text-center">
    <form id="ordenes" runat="server" class="form-group-lg">
    <%      Dim list As ArrayList = Session("ListaOrdenes") %>
        <%Dim orden As BL.ManejadorOrdenes = Session("ordenes") %>
    <div class="conatiner col-sm-8 margin-up-panel margin-botton-panel margin-left" style="background-color:#00ff21">
        <h1 class="margin-up-panel text-center">Lista Ordenes</h1>
        <div id="table" class="table-editable table-responsive">
            <span class="table-add float-right mb-3 mr-2"><a href="#!" class="text-succes"><i class="fade fa-plus fa-2x" aria-hidden="true"></i></a></span>
            <table class="table table-bordered table-responsive-md table-stripped text-center">
               <!--caption>Lista Ordenes</!--caption-->
                <thead>
                 <tr>
                    <th class="text-center">Usuario</th>
                    <th class="text-center">Fecha</th>
                    <th class="text-center">Estado</th>
                    <th class="text-center">Num Orden</th>
                </tr>
               </thead>
                <%Dim count = 0 %>
                
                <%For Each o As BL.BLOrden In list %>
                <%count = +1 %>
                <tr>
                    <td class="col1" contenteditable="true"><%=o.nombreUsuario %></td>

                    <td class="col1" contenteditable="true"><%=o.Fecha %></td>
                  
                    <td class="col1" contenteditable="true"><%=o.Estado %></td>
                    
                    <td class="col1" contenteditable="true"><%=o.Identificador %></td>
                    <%Dim orde As BL.BLOrden = o %>
                    <td class="col1" contenteditable="true"> <asp:Button type="submit"
                         Cssclass="btn btn-success btn-responsive margin-botton-panel" 
                        ID="btnEntregar" OnClick="btnEntregar_Click" runat="server"
                         Text="Entregar"/> <%Session("des") = o %> <%Session("ide") =
o.Identificador %>  </td>
                    <!-- <% 'dim i As String = "ide" + count'%>-->
                </tr>            
                <%Next %>
            </table>
            <br/>
            <br/>
            <div class="text-center">
            <asp:Button type="submit"
                         color="" Cssclass="btn btn-success btn-responsive margin-botton-panel" ID="btnDeshacer"
                         OnClick="btnDeshacer_Click" runat="server" Text="Deshacer" />
                </div>
        </div>
    </div>  
</form>
        </div>
</asp:Content>




<asp:Content ID="Content3" ContentPlaceHolderID="pie" runat="server">
</asp:Content>
