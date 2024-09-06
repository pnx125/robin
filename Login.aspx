
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Ticket.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>

    <script type="text/javascript">
        function validateLogin() {
            var username = document.getElementById("txtUsername").value;
            var password = document.getElementById("txtPassword").value;
            if (username === "" || password === "") {
                alert("Username and Password are required.");
                return false;
            }
            return true;
        }
    </script>

</head>
<body>
    <form id="form1" runat="server" onsubmit="return validateLogin()">
        <div>
            <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>
