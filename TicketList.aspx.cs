using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ticket
{
    public partial class TicketList : System.Web.UI.Page
    {
        private DataAccess dataAccess = new DataAccess();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindTicketData();
            }
        }

        private void BindTicketData()
        {
            DataTable dt = dataAccess.GetTickets();
            gvTickets.DataSource = dt;
            gvTickets.DataBind();
        }

        protected void gvTickets_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                int ticketId = Convert.ToInt32(e.CommandArgument);
                // Redirect to Edit page
                Response.Redirect($"EditTicket.aspx?id={ticketId}");
            }
            else if (e.CommandName == "Delete")
            {
                int ticketId = Convert.ToInt32(e.CommandArgument);
                dataAccess.DeleteTicket(ticketId);
                BindTicketData();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddTicket.aspx");
        }



        protected void gvTickets_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}