<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Interface.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <table>
        <% foreach (Core.Groups group in this.listGroups) { %>
        <tr>
            <td><strong>Nome:</strong></td>
            <td><% Response.Write(group.Name); %></td>
        </tr>
        <% } %>
    </table>
</body>
</html>
