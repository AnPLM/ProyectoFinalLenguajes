<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterRestaurante.Master" CodeBehind="HabilitarDeshabilitarCliente.aspx.vb" Inherits="UI.HabilitarDeshabilitarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="encabezado" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
    <form id="form1" runat="server" class="form-group-lg">
     <%Dim lista As List(Of BL.ClienteSerializable) = (Session("Cliente")) %>
     <div class="container col-sm-8 col-md-offset-2"  style="background-color:firebrick">
          <div class="container col-md-4 col-sm-offset-4"  style="background-color:firebrick">
                <h2 style="color:beige" class="text-center">Habilitar / Deshabilitar Usuarios</h2>
               <asp:TextBox ID="txtNombre" CssClass="form-control" placeholder="Nombre del Usuario" runat="server"></asp:TextBox>
               <div class="text-center margin-up-button">
                <asp:Button ID="btnRegistrarUsuario" Cssclass="btn btn-success text-center" runat="server" Text="Buscar Usuario" />  
                   <br />
                   <br />
                   <asp:Label ID="lblError" runat="server" Text="" style="color:beige"></asp:Label>
         </div>
          </div>
          <div class="container col-sm-8 col-sm-offset-2 margin-up-panel margin-botton-panel"  style="background-color:#f7f7f7">
                <h3 class="margin-up-panel text-center" style="color:beige">Usuario Encontrado</h3>

               <table class="table table-bordered table-responsive-md table-striped text-center" id="tablaPlatos">
                <thead>
                    <tr>
                        <th class="text-center">Nombre Usuario</th>
                        <th class="text-center">Nombre</th>
                        <th class="text-center">Correo</th>
                        <th class="text-center">Direccion</th>
                        <th class="text-center">Habilitado</th>
                    </tr>
                </thead>
                   <%For Each x As BL.ClienteSerializable In lista%>
                <tr>
                    <td class="col1" contenteditable="true"><%=x.NombreUsuario%></td>
                    <td class="col2" contenteditable="true"><%=x.Nombre%></td>
                    <td class="col2" contenteditable="true"><%=x.Correo%></td>
                    <td class="col2" contenteditable="true"><%=x.Direccion%></td>
                     <td>
                         <div class="form-check">
                             <%If x.Habilitado = False Then %>
                                <input type="checkbox" class="form-check-input" id="checkHabilitados" onclick="return false;"/>
                             <%Else %> 
                               <input type="checkbox" class="form-check-input" id="checkDeshabilitados" checked="" onclick="return false;"/>
                             <%End If %>
                         </div>
                    </td>
                </tr>  
                   <%Next %>
              </table>
           </div>
         
         <br />
         <asp:Button ID="btnRegresar" Cssclass="btn btn-success text-center" runat="server" Text="Regresar" />
         <asp:Button ID="btnHabilitar" Cssclass="btn btn-success text-center" runat="server" Text="Habilitar Cliente" />  
         <asp:Button ID="btnDeshabilitar" Cssclass="btn btn-success text-center" runat="server" Text="Deshabilitar Cliente" />  
     </div>
         </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pie" runat="server">
</asp:Content>
