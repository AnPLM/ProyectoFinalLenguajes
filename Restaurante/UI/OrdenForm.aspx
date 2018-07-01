<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="OrdenForm.aspx.vb" Inherits="UI.OrdenForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 86px;
        }
        #TextArea2 {
            height: 85px;
            margin-top: 0px;
        }
        #TextArea3 {
            height: 84px;
        }
        #TextArea4 {
            height: 89px;
        }
        #TextArea5 {
            height: 87px;
        }
        #TextArea6 {
            height: 90px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>Form de ordenes</h3>
    </div>
    </form>
    <p>
        <textarea id="TextArea1" cols="20" name="S1"></textarea>&nbsp;&nbsp;&nbsp;
        <textarea id="TextArea2" cols="20" name="S2"></textarea>&nbsp;&nbsp;&nbsp;
        <textarea id="TextArea3" cols="20" name="S3"></textarea>&nbsp;&nbsp;
    </p>
    <p>
        &nbsp;</p>
    <p>
&nbsp;<textarea id="TextArea4" cols="20" name="S4"></textarea>&nbsp;&nbsp;&nbsp;
        <textarea id="TextArea5" cols="20" name="S5"></textarea>&nbsp;&nbsp;&nbsp;
        <textarea id="TextArea6" cols="20" name="S6"></textarea></p>
</body>
</html>
