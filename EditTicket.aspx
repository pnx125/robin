<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditTicket.aspx.cs" Inherits="Ticket.EditTicket" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Ticket</title>

    <script type="text/javascript">
        function validateEditTicket() {
            var event = document.getElementById("txtEvent").value;
            var date = document.getElementById("txtDate").value;
            var price = document.getElementById("txtPrice").value;
            var available = document.getElementById("txtAvailable").value;
            if (event === "" && date === "" && price === "" && available === "") {
                alert("All fields are required.");
                return false;
            }
            if (event === "") {
                alert("Event fields is required.");
                document.getElementById("txtEvent").focus();
                return false;
            }

            if (date === "") {
                alert("Date field is required.");
                document.getElementById("txtDate").focus();
                return false;
            }

            if (price === "") {
                alert("Price fields is required.");
                document.getElementById("txtPrice").focus();
                return false;
            }
            if (available === "") {
                alert("Available field is required.");
                document.getElementById("txtAvailable").focus();
                return false;
            }


            if (isNaN(price) || price <= 0) {
                alert("Price must be a positive number.");
                document.getElementById("txtPrice").focus();
                return false;
            }

            if (isNaN(available) || available < 0) {
                alert("Available tickets must be a non-negative number.");
                document.getElementById("txtAvailable").focus();
                return false;
            }

            return true;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server" onsubmit="return validateEditTicket()">
        <div>
            <asp:Label ID="lblEvent" runat="server" Text="Event:"></asp:Label>
            <asp:TextBox ID="txtEvent" runat="server"></asp:TextBox>
            <asp:Label ID="lblDate" runat="server" Text="Date:"></asp:Label>
            <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
            <asp:Label ID="lblPrice" runat="server" Text="Price:"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            <asp:Label ID="lblAvailable" runat="server" Text="Available:"></asp:Label>
            <asp:TextBox ID="txtAvailable" runat="server"></asp:TextBox>
            <asp:Button ID="btnSave" runat="server" Text="Save Changes" OnClick="btnSave_Click" />
        </div>
    </form>
</body>
</html>