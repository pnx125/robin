using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ticket
{
    public partial class EditTicket : System.Web.UI.Page
    {
        private DataAccess dataAccess = new DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int ticketId = int.Parse(Request.QueryString["id"]);
                // Load ticket details from database
                // Populate fields with ticket data
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int ticketid = int.Parse(Request.QueryString["id"]);
            string sEvent = txtEvent.Text;
            DateTime date = DateTime.Parse(txtDate.Text);
            decimal price = decimal.Parse(txtPrice.Text);
            int available = int.Parse(txtAvailable.Text);

            // update ticket in database
            dataAccess.UpdateTicket(ticketid, sEvent, date, price, available);
            Response.Redirect("ticketlist.aspx");
        }
    }
}