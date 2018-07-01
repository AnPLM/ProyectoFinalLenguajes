<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterRestaurante.Master" CodeBehind="AdministrarMenu.aspx.vb" Inherits="UI.AdministrarMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="encabezado" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
        <form id="form1" runat="server" class="form-group-lg">
 
    <div class=" panel panel-default col-sm-12" style="background-color:firebrick">
        
        <div class="row">
        <div class="container col-sm-3 margin-up-panel margin-botton-panel margin-left" style="background-color:#f7f7f7">
            <h1 class="margin-up-panel text-center">Registrar Plato</h1>
            <div class="margin-up-panel form-group">
                <asp:TextBox ID="txtNombre" type="text" class="form-control" placeholder="Nombre" runat="server" required=""></asp:TextBox>
            </div>
            <div class="margin-up-panel form-group">
                <asp:TextBox ID="txtDescripcion" type="text" class="form-control" placeholder="Descripción" runat="server"></asp:TextBox>
            </div>
            <div class="margin-up-panel form-group">
                <asp:TextBox ID="txtPrecio" type="text" class="form-control" placeholder="Precio" runat="server"></asp:TextBox>
            </div>
            <div class="margin-up-panel">
                <input type="file" name="fotografia" class="form-control-file" id="fotografia"/>
            </div>
            <div class="margin-up-panel">
                <p style="font-size:1.5vw; color:black">Habilitar</p>
                
                <asp:CheckBox type="checkbox" ID="checkHabilitado" runat="server"  class="margin-left" />
            <div class="margin-up-panel text-center">
                <asp:Button type="submit" class="btn btn-success btn-responsive margin-botton-panel" ID="btnRegistrar" runat="server" Text="Registrar" />
                <asp:Button type="submit" class="btn btn-success btn-responsive margin-botton-panel" OnClientClick="myFunction()" ID="btnBuscar" runat="server" Text="Buscar" />
                <asp:Button type="submit" class="btn btn-danger btn-responsive margin-botton-panel" ID="btnEliminar" runat="server" Text="Eliminar" />
                   
            </div>  
            </div>
         </div>
             <div class="container col-sm-8 margin-up-panel margin-botton-panel margin-left"  style="background-color:#f7f7f7">
                 <h1 class="margin-up-panel text-center">Lista Platos</h1>
                 <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered bs-table"></asp:GridView>
                 <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
             </div>
            
       </div>
    </div>       
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pie" runat="server">
</asp:Content>



