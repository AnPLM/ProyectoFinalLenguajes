<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterRestaurante.Master" CodeBehind="ModificarUsuarios.aspx.vb" Inherits="UI.ModificarUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="encabezado" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
     <form id="form1" runat="server" class="form-group-lg">
     <%Dim lista As ArrayList = Session("Usuario") %>
     <div class="container col-sm-8 col-md-offset-2"  style="background-color:firebrick">
          <div class="container col-md-4 col-sm-offset-4"  style="background-color:firebrick">
             <h3 style="color:beige" class="text-center">Modificar Usuarios</h3>
                              
            <div class="panel panel-default col-sm-12" style="background-color:firebrick">
                <asp:Button type="submit" Cssclass="btn btn-success btn-block inputBoton margin-up-button margin-botton-panel" ID="btnModificarNombre" runat="server" Text="Modificar Nombre Usuario" />
                <asp:Button type="submit" Cssclass="btn btn-success btn-block inputBoton margin-botton-panel" ID="btnModificarContrasenna" runat="server" Text="Modificar Contraseña" />
                <asp:Button type="submit" Cssclass="btn btn-success btn-block inputBoton margin-botton-panel" ID="btnHabilitar" runat="server" Text="Habilitar/Deshabilitar" />
                <asp:Button ID="Regresar" Cssclass="btn btn-primary btn-block inputBoton margin-botton-panel" runat="server" Text="Regresar" />

            </div>
          </div>
          <div class="container col-sm-8 col-sm-offset-2 margin-up-panel margin-botton-panel"  style="background-color:#f7f7f7">
                <h3 class="margin-up-panel text-center" style="color:black">Datos de Usuarios</h3>

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
