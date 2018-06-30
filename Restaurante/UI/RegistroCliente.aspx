<%@ Page Title="Registrar Cliente" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterRestaurante.Master"
    CodeBehind="RegistroCliente.aspx.vb" Inherits="UI.RegistroCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="encabezado" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
    <form class="form-group-lg" action="">
        <div class="row">
            <div class="col-sm-4" style="background-color:lavender;"></div>
            <div class="col-sm-4" style="background-color: #B03A2E">
                <div class="form-group">
                    <br />
                    <label style="font-size: medium; color: beige" for="txtNombreCompleto">Nombre Completo</label>
                    <input type="text" class="form-control" id="txtNombreCompleto" required />
                </div>
                <div class="form-group">
                    <label style="font-size: medium; color: beige" for="txtNombreUsuario">Nombre Usuario</label>
                    <input type="email" class="form-control" id="txtNombreUsuario" required />
                </div>
                <br />
                <button type="submit" class="btn btn-default  btn-responsive center-block">Guardar</button>
            </div>
            <div class="col-sm-4" style="background-color:lavender;"></div>
        </div>
    </form>
</asp:Content>
