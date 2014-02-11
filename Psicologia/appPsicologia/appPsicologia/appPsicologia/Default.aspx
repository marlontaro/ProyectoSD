<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="appPsicologia._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="DNI:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" 
                    onclick="btnBuscar_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="ALUMNO:"></asp:Label>
            </td>            
            <td>
                <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            </td>            
            <td>
            </td>            
        </tr>
    </table>
    
    </div>
    </form>
</body>
</html>
