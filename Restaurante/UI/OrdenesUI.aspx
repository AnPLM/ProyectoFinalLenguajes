<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="OrdenesUI.aspx.vb" Inherits="UI.OrdenesUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DataPager ID="DataPager1" runat="server">
            <Fields>
                <asp:NextPreviousPagerField ButtonType="Button" />
            </Fields>
        </asp:DataPager>
    </form>
</body>
</html>
