<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterRestaurante.Master" CodeBehind="RegistroUsuarios.aspx.vb" Inherits="UI.RegistroUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="encabezado" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">

        <div class="panel panel-default col-md-4 col-md-offset-4 margin-up" style="background-color:firebrick"">
        <h1 class="text-center" style="color:beige;">Registrar Usuarios</h1>

        <form id="form1" runat="server" class="form-group-lg">
            <div>
                <asp:TextBox ID="txtNombreUsuario"  placeholder="Nombre Usuario" CssClass="form-control" runat="server"></asp:TextBox>
                <br />
                <asp:TextBox ID="txtContrasenna"  placeholder="Contraseña" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>
                <br/>
                <asp:CheckBox ID="checkHabilitado" runat="server" Text="Habilitar Usuario" CssClass="margin-left" Checked="true" ForeColor="#FFFFCC" Font-Size="Medium" />
                
                <p style="font-size:1.5vw; color:beige" class="text-center">Tipo de Usuario</p>
                <div class="text-center">
                <asp:RadioButton id="radioAdministrador" GroupName="RegularMenu" Text="Administrador"  ForeColor="#FFFFCC" runat="server" Font-Size="Medium" Checked="true"/>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RadioButton id="radioCocinero" GroupName="RegularMenu" Text="Cocinero"  ForeColor="#FFFFCC" runat="server" Font-Size="Medium"/>
               </div>
                <div class="text-center margin-up-button">
                <asp:Button ID="btnRegistrarUsuario" Cssclass="btn btn-primary text-center" runat="server" Text="Registrar Usuario" />  
                </div>
                <br />
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </div>
        </form>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pie" runat="server">
</asp:Content>
