<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="OrdenesUI.aspx.vb" Inherits="UI.OrdenesUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:ListView ID="ListView1" runat="server" DataSourceID="ObjectDataSource1">
        </asp:ListView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="eliminar" InsertMethod="insertar" SelectMethod="lista" TypeName="BL.ManejadorOrdenes" UpdateMethod="actualizar">
            <DeleteParameters>
                <asp:Parameter Name="identificador" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="nombreUsuario" Type="String" />
                <asp:Parameter Name="Fecha" Type="DateTime" />
                <asp:Parameter Name="Estado" Type="String" />
                <asp:Parameter Name="Identificador" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="nombreUsuario" Type="String" />
                <asp:Parameter Name="Fecha" Type="DateTime" />
                <asp:Parameter Name="Estado" Type="String" />
                <asp:Parameter Name="Identificador" Type="Int32" />
            </UpdateParameters>
        </asp:ObjectDataSource>
    </form>
</body>
</html>
