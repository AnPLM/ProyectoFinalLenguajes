<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterRestaurante.Master" CodeBehind="PruebaLogin.aspx.vb" Inherits="UI.PruebaLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="encabezado" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
    <form class="form-group-lg" action="">
    <div class=" panel panel-default col-md-4 col-md-offset-4" style="background-color:firebrick">
         <div class="form-group">
             <label style="font-size:2vw" for="email">Dirección Email:</label>
             <input type="email" class="form-control" id="email" required/>
         </div>
         <div class="form-group">
             <label style="font-size:2vw" for="contrasenna">Contraseña:</label>
             <input type="password" class="form-control" id="pwd" required=""/>
         </div>
        
             <button type="submit" class="btn btn-default  btn-responsive center-block">Ingresar</button>
       
     </div>
       
</form> 
</asp:Content>

 




