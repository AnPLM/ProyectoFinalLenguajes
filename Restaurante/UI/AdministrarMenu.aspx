<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterRestaurante.Master" CodeBehind="AdministrarMenu.aspx.vb" Inherits="UI.AdministrarMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="encabezado" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
        <form id="form1" runat="server" class="form-group-lg">
 <%Dim lista As ArrayList = Session("ListaPlatos") %>
    <div class=" panel panel-default col-sm-12" style="background-color:firebrick">
        
        <div class="row">
        <div class="container col-sm-3 margin-up-panel margin-botton-panel margin-left" style="background-color:#f7f7f7;opacity: 0,8;">
            <h1 class="margin-up-panel text-center"  style="opacity: 0,9">Registrar Plato</h1>
            <div class="margin-up-panel form-group">
                <asp:TextBox ID="txtCodigo" CssClass="form-control" placeholder="Codigo" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="requiereCodigo" runat="server" ErrorMessage="Favor ingresar código" ControlToValidate="txtCodigo"></asp:RequiredFieldValidator>
            </div>
            <div class="margin-up-panel form-group">
                <asp:TextBox ID="txtNombre" CssClass="form-control" placeholder="Nombre" runat="server"></asp:TextBox>
            </div>
            <div class="margin-up-panel form-group">
                <asp:TextBox ID="txtDescripcion" CssClass="form-control" placeholder="Descripción" runat="server"></asp:TextBox>
            </div>
            <div class="margin-up-panel form-group">
                <asp:TextBox ID="txtPrecio" Cssclass="form-control" placeholder="Precio" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="expresionRegularPrecio" runat="server" ErrorMessage="Debe ingrsar un monto numérico" ControlToValidate="txtPrecio" ValidationExpression="^[0-9]*"></asp:RegularExpressionValidator>
            </div>
            <div class="margin-up-panel">
                <asp:FileUpload ID="fotografia" runat="server" />
            </div>
            <div class="margin-up-panel">
                <p style="font-size:1.5vw; color:black">Habilitar</p>
                <asp:CheckBox type="checkbox" ID="checkHabilitado" runat="server"  CssClass="margin-left" />
            <div class="margin-up-panel text-center">
                <asp:Button type="submit" Cssclass="btn btn-success btn-responsive margin-botton-panel" ID="btnRegistrar" runat="server" Text="Registrar" />
                <asp:Button type="submit" Cssclass="btn btn-success btn-responsive margin-botton-panel" OnClientClick="myFunction()" ID="btnBuscar" runat="server" Text="Buscar" />
                <asp:Button type="submit" Cssclass="btn btn-success btn-responsive margin-botton-panel" ID="btnEditar" runat="server" Text="Editar" />
                <asp:Button type="submit" Cssclass="btn btn-danger btn-responsive margin-botton-panel" ID="btnEliminar" runat="server" Text="Eliminar" />   
            </div>  
            </div>
         </div>
             <div class="container col-sm-8 margin-up-panel margin-botton-panel margin-left"  style="background-color:#f7f7f7">
                 <h1 class="margin-up-panel text-center">Lista Platos</h1>
                         <div id="table" class="table-editable">
            <span class="table-add float-right mb-3 mr-2"><a href="#!" class="text-success"><i class="fa fa-plus fa-2x" aria-hidden="true"></i></a></span>
            <table class="table table-bordered table-responsive-md table-striped text-center">

                <thead>
                    <tr>
                        <th class="text-center">Código</th>
                        <th class="text-center">Nombre</th>
                        <th class="text-center">Descripción</th>
                        <th class="text-center">Precio</th>
                        <th class="text-center">Fotografía</th>
                        <th class="text-center">Habilitado</th>
                        <th class="text-center">Remover</th>
                        <th class="text-center">Modificar</th>
                    </tr>
                </thead>
               
                <%For Each x As BL.Plato In lista%>
                <tr>
                    <td class="col1" contenteditable="true"><%=x.Codigo%></td>
                    <td class="col2" contenteditable="true"><%=x.Nombre%></td>
                    <td class="col3" contenteditable="true"><%=x.Descripcion%></td>
                    <td class="col4" contenteditable="true"><%=x.Precio%></td>
                    <td>
                         <img src="pizzapepperoni0.jpg" class="img-rounded" alt="Cinque Terre" width="100" height="50"/>
                    </td>
                     <td>
                         <div class="form-check">
                            <input type="checkbox" class="form-check-input" id="exampleCheck1"/> 
                         </div>
                    </td>
                    <td>
                        <asp:Button ID="btnElminar" CssClass="btn btn-danger" runat="server" Text="Elminar" />
                       
                    </td>
                     <td>
                         <input type="submit" class="btn btn-info" value="Modificar"/>
                    </td>
                </tr>  
                <%Next%>
            </table>
        </div>

             </div>
   
       </div>
    </div>       
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pie" runat="server">
</asp:Content>



