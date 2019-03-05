<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DBinfo.aspx.cs" Inherits="ASPPracticas.DBinfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form action ="Receiver.aspx" method ="post" id="form1" runat="server">

        <div>

            <asp:TextBox ID ="text" runat="server"></asp:TextBox><br />
            <asp:TextBox ID ="text2" runat="server"></asp:TextBox><br />
            <asp:Button ID ="button" runat ="server" Text ="Submit" Width="144px" />

        </div>
        
    </form>
</body>
</html>
