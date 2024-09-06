<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TicketList.aspx.cs" Inherits="Ticket.TicketList" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ticket List</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvTickets" runat="server" AutoGenerateColumns="False" OnRowCommand="gvTickets_RowCommand" OnRowDeleting="gvTickets_RowDeleting" >
                <Columns>
                    <asp:BoundField DataField="TicketId" HeaderText="ID" ReadOnly="True" />
                    <asp:BoundField DataField="Event" HeaderText="Event" />
                    <asp:BoundField DataField="Date" HeaderText="Date" />
                    <asp:BoundField DataField="Price" HeaderText="Price" />
                    <asp:BoundField DataField="Available" HeaderText="Available" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="btnEdit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("TicketId") %>' Text="Edit" />
                            <asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" CommandArgument='<%# Eval("TicketId") %>' Text="Delete" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:Button ID="btnAdd" runat="server" Text="Add Ticket" OnClick="btnAdd_Click" />
        </div>
    </form>
</body>
</html>