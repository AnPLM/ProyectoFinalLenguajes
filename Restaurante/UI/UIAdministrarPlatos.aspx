<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UIAdministrarPlatos.aspx.vb" Inherits="UI.UIAdministrarPlatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Administrar Platos</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
    <link rel="stylesheet" href="Estilos/EstilosPlatos.css" />
</head>
<body>
    <form id="form1" runat="server" class="form-group-lg" action="">
 
    <div class=" panel panel-default col-sm-12 margin-up-panel" style="background-color:firebrick">
        
        <div class="row">
        <div class="container col-sm-3 margin-up-panel margin-botton-panel margin-left"  style="background-color:#f7f7f7">
            <h1 class="margin-up-panel text-center">Registrar Plato</h1>
            <div class="margin-up-panel form-group">
                <input  placeholder="Nombre" type="text" class="form-control" id="nombre"/>
            </div>
            <div class="margin-up-panel form-group">
                <input  placeholder="Descripcion" type="text" class="form-control" id="descripcion"/>
            </div>
            <div class="margin-up-panel form-group">
                <input placeholder="Precio" type="text" class="form-control" id="Precio"/>
            </div>
            <div class="margin-up-panel">
                <input type="file" class="form-control-file" id="Fotografía"/>
            </div>
             <div class="margin-up-panel">
                 <label style="font-size:1.5vw; color:black" for="usr">Habilitar:</label>
                 <br />
                <label class="switch">
                <input type="checkbox"/>
                <span class="slider round"></span>
            </label>
                 <button type="submit" class="btn btn-success  btn-responsive center-block margin-botton-panel">Registrar</button>
            </div>
         </div>
             <div class="container col-sm-8 margin-up-panel margin-botton-panel margin-left"  style="background-color:#f7f7f7">
                 <h1 class="margin-up-panel text-center">Lista Platos</h1>
             </div>
       </div>
         

    </div>       
    </form>
</body>
</html>
