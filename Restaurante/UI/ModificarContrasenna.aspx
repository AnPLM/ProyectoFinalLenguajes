<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterRestaurante.Master" CodeBehind="ModificarContrasenna.aspx.vb" Inherits="UI.ModificarContrasenna" %>
<asp:Content ID="Content1" ContentPlaceHolderID="encabezado" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">

     <form id="form1" runat="server" class="form-group-lg">
     <div class="container col-sm-8 col-md-offset-2"  style="background-color:firebrick">
            <div class="text-center">
             <h3 style="color:beige" class="text-center">Modificar Contraseña</h3>
                              
            <div class="panel panel-default col-md-6 col-md-offset-3" style="background-color:firebrick">
                <asp:TextBox ID="txtNombreUsuario"  placeholder="Nombre Usuario Actual" CssClass="form-control margin-botton-panel margin-up-button" runat="server"></asp:TextBox>
                <asp:TextBox ID="txtContrasenna"  placeholder="Contraseña Nueva" CssClass="form-control margin-botton-panel" TextMode="Password" runat="server"></asp:TextBox>
                <asp:Button type="submit" Cssclass="btn btn-success btn-block inputBoton margin-botton-panel" ID="btnModificarContrasenna" runat="server" Text="Modificar" />
            </div>
          </div>      
     </div>
  </form>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pie" runat="server">
</asp:Content>
