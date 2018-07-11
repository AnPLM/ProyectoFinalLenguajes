<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterRestaurante.Master" CodeBehind="BuscarPlato.aspx.vb" Inherits="UI.BuscarPlato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="encabezado" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">

     <form id="form1" runat="server" class="form-group-lg">
     <%Dim lista As List(Of BL.Plato) = Session("ListaPlatos") %>
     <div class="container col-sm-8 col-md-offset-2"  style="background-color:firebrick">
          <div class="container col-md-4 col-sm-offset-4"  style="background-color:firebrick">
                <h2 style="color:beige" class="text-center">Buscar Platos</h2>
               <asp:TextBox ID="txtNombre" CssClass="form-control" placeholder="Nombre del Plato" runat="server"></asp:TextBox>
               <div class="text-center margin-up-button">
                <asp:Button ID="btnBuscarPlato" Cssclass="btn btn-success text-center" runat="server" Text="Buscar Plato" />  
                </div>
          </div>
          <div class="container col-sm-8 col-sm-offset-2 margin-up-panel margin-botton-panel"  style="background-color:#f7f7f7">
                <h3 class="margin-up-panel text-center" style="color:beige">Plato Encontrado</h3>

               <table class="table table-bordered table-responsive-md table-striped text-center" id="tablaPlatos">
                <thead>
                    <tr>
                        <th id="thCodigo" class="text-center">Código</th>
                        <th class="text-center">Nombre</th>
                        <th class="text-center">Descripción</th>
                        <th class="text-center">Precio</th>
                        <th class="text-center">Fotografía</th>
                        <th class="text-center">Habilitado</th>
                    </tr>
                </thead>
               
                <%For Each x As BL.Plato In lista%>
                <tr>
                    <td class="col1" contenteditable="true"><%=x.Codigo%></td>
                    <td class="col2" contenteditable="true"><%=x.Nombre%></td>
                    <td class="col3" contenteditable="true"><%=x.Descripcion%></td>
                    <td class="col4" contenteditable="true"><%=x.Precio%></td>
                    <td>
                        <% Dim imgUrl As String = "/Imagenes/" + x.Fotografia %>
                         <img src='"'+ <%= imgUrl %> + '"' class="img-rounded" alt="Cinque Terre" width="100" height="50"/>
                    </td>
                     <td>
                         <div class="form-check">
                             <%If x.Habilitado = 0 Then %>
                                <input type="checkbox" class="form-check-input" id="checkHabilitados" onclick="return false;"/>
                             <%Else %> 
                               <input type="checkbox" class="form-check-input" id="checkDeshabilitados" checked="" onclick="return false;"/>
                             <%End If %>
                         </div>
                    </td>
                </tr>  
                <%Next%>
            </table>
            </div>
         <//div>
         </form>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pie" runat="server">
</asp:Content>
