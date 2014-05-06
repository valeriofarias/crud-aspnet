<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="Interface.View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <label>Nome: <%= this.groups.Name %></label>
        <br />
        <label>Tipo: <%= this.groups.Type %></label>
    </form>
</body>
</html>
