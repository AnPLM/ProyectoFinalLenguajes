<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterRestaurante.Master" CodeBehind="PruebaLogin.aspx.vb" Inherits="UI.PruebaLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="encabezado" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
     <form class="form-group-lg" action="">
  <div class="form-group">
    <label for="email">Dirección Email:</label>
    <input type="email" class="form-control" id="email"/>
  </div>
  <div class="form-group">
    <label for="contrasenna">Contraseña:</label>
    <input type="password" class="form-control" id="pwd">
  </div>
  <button type="submit" class="btn btn-default">Submit</button>
</form> 
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="pie" runat="server">
    <button type="button" class="btn btn-default">Default</button>
    <button type="button" class="btn btn-primary">Primary</button>
</asp:Content>




