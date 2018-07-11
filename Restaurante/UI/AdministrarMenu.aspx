<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterRestaurante.Master" CodeBehind="AdministrarMenu.aspx.vb" Inherits="UI.AdministrarMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="encabezado" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
       
 <form id="form1" runat="server" class="form-group-lg">
 <%Dim lista As ArrayList = Session("ListaPlatos") %>
    <div class=" panel panel-default col-sm-12" style="background-color:firebrick">
        
        <div class="row">
        <div class="container col-sm-3 margin-up-panel margin-botton-panel margin-left" style="background-color:#f7f7f7;opacity: 0,8;">
            <h3 class="margin-up-button text-center"  style="opacity: 0,9">Registrar Plato</h3>
            <div class=" form-group">
                <asp:TextBox ID="txtCodigo" CssClass="form-control" placeholder="Codigo" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="requiereCodigoRegistro" runat="server" ErrorMessage="Favor ingresar código" ControlToValidate="txtCodigo" validationgroup="Registrar"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtNombre" CssClass="form-control" placeholder="Nombre" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="requiereNombreRegistro" runat="server" ErrorMessage="Favor ingresar nombre" ControlToValidate="txtNombre" validationgroup="Registrar"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtDescripcion" CssClass="form-control" placeholder="Descripción" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="requiereDescripcionRegistro" runat="server" ErrorMessage="Favor ingresar descripcion" ControlToValidate="txtDescripcion" validationgroup="Registrar"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group text-center">
                <asp:TextBox ID="txtPrecio" Cssclass="form-control" placeholder="Precio" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="expresionRegularPrecio" runat="server" ErrorMessage="Debe ingrsar un monto numérico" ControlToValidate="txtPrecio" ValidationExpression="^[0-9]*"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="requierePrecioRegistro" runat="server" ErrorMessage="Favor ingresar Precio" ControlToValidate="txtPrecio" validationgroup="Registrar"></asp:RequiredFieldValidator>  
            </div>
            <div class="text-center">
                <asp:FileUpload ID="fotografia" runat="server" />
            </div>
            <div class="margin-up-panel">
                <p style="font-size:1.5vw; color:black">Habilitar</p>
                <asp:CheckBox ID="checkHabilitado" runat="server"  CssClass="margin-left" Font-Size="Medium" />
            <div class="margin-up-button text-center">
                <asp:Button type="submit" Cssclass="btn btn-success margin-botton-panel" ID="btnRegistrar" runat="server"  validationgroup="Registrar" Text="Registrar" />
                <asp:Button type="submit" Cssclass="btn btn-success margin-botton-panel " ID="btnEditar" runat="server" Text="Editar" />
               
            </div>  
            </div>
         </div>
             <div class="container col-sm-8 margin-up-panel margin-botton-panel margin-left"  style="background-color:#f7f7f7">
              <h3 class="margin-up-panel text-center">Lista Platos</h3>

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

       </div>
    </div>       
  </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pie" runat="server">
</asp:Content>



