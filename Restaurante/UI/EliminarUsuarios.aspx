﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterRestaurante.Master" CodeBehind="EliminarUsuarios.aspx.vb" Inherits="UI.EliminarUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="encabezado" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
     <form id="form1" runat="server" class="form-group-lg">
     <%Dim lista As ArrayList = Session("Usuarios") %>
     <div class="container col-sm-8 col-md-offset-2"  style="background-color:firebrick">
          <div class="container col-md-4 col-sm-offset-4"  style="background-color:firebrick">
                <h3 style="color:beige" class="text-center">Eliminar Usuarios</h3>
               <asp:TextBox ID="txtNombre" CssClass="form-control" placeholder="Nombre del Usuario" runat="server"></asp:TextBox>
               <div class="text-center margin-up-button">
                <asp:Button ID="btnRegistrarUsuario" Cssclass="btn btn-success text-center" runat="server" Text="Eliminar Usuario" />
                   <br/>
                   <br/>  
                <asp:Button ID="Regresar" Cssclass="btn btn-primary text-center" runat="server" Text="Regresar" />  

         </div>
          </div>
          <div class="container col-sm-8 col-sm-offset-2 margin-up-panel margin-botton-panel"  style="background-color:#f7f7f7">
                <h2 class="margin-up-panel text-center" style="color:beige">Lista de Usuarios</h2>

               <table class="table table-bordered table-responsive-md table-striped text-center" id="tablaUsuarios">
                <thead>
                    <tr>
                        <th class="text-center">Nombre Usuario</th>
                        <th class="text-center">Tipo</th>
                        <th class="text-center">Habilitado</th>
                    </tr>
                </thead>
                   <%For Each x As BL.Usuario In lista%>
                <tr>
                    <td class="col1" contenteditable="true"><%=x.NombreUsuario%></td>
                    <td class="col2" contenteditable="true"><%=x.TipoUsuario%></td>
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
     </div>
         </form>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pie" runat="server">
</asp:Content>
