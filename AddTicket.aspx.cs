using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ticket
{
    public partial class AddTicket : System.Web.UI.Page
    {
        private DataAccess dataAccess = new DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnSave_Click(object sender, EventArgs e)
        {
            string sEevents = txtEvent.Text;
            DateTime date = DateTime.Parse(txtDate.Text);
            decimal price = decimal.Parse(txtPrice.Text);
            int available = int.Parse(txtAvailable.Text);

            dataAccess.AddTicket(sEevents, date, price, available);
            Response.Redirect("TicketList.aspx");
        }

    }
}