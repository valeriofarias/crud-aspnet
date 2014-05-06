<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Interface.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <input type="hidden" name="id" value="<% Response.Write(this.groups.Id); %>" />
        <input type="text" name="name" placeholder="Nome" value="<% Response.Write(this.groups.Name); %>" />
        <input type="text" name="type" placeholder="Tipo" value="<% Response.Write(this.groups.Type); %>" />
        <input type="submit" value="Enviar" />
    </form>
</body>
</html>
