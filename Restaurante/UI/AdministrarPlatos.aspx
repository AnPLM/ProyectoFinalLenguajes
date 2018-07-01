﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AdministrarPlatos.aspx.vb" Inherits="UI.AdministrarPlatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Administrar Platos</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
    <link rel="stylesheet" href="Estilos/EstilosPlatos.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server" class="form-group-lg">
 
    <div class=" panel panel-default col-sm-12" style="background-color:firebrick">
        
        <div class="row">
        <div class="container col-sm-3 margin-up-panel margin-botton-panel margin-left"  style="background-color:#f7f7f7">
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
                <label style="font-size:1.5vw; color:black" for="usr">Habilitar:</label>
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
                 <asp:GridView ID="GridView1" runat="server" CssClass="table-editable"></asp:GridView>
             </div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
       </div>
    </div>       
    </form>
</body>
</html>
