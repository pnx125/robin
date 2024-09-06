using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Ticket
{
    public class DataAccess
    {

        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["TicketBookingDB"].ConnectionString;

        public DataTable GetTickets()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Tickets", conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public void AddTicket(string @event, DateTime date, decimal price, int available)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Tickets (Event, Date, Price, Available) VALUES (@Event, @Date, @Price, @Available)", conn))
                {
                    cmd.Parameters.AddWithValue("@Event", @event);
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Available", available);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Parameters: It uses SQL parameters to avoid SQL injection attacks and ensures data integrity.
        public void UpdateTicket(int ticketId, string @event, DateTime date, decimal price, int available)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE Tickets SET Event = @Event, Date = @Date, Price = @Price, Available = @Available WHERE TicketId = @TicketId", conn))
                {
                    cmd.Parameters.AddWithValue("@Event", @event);
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Available", available);
                    cmd.Parameters.AddWithValue("@TicketId", ticketId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteTicket(int ticketId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Tickets WHERE TicketId = @TicketId", conn))
                {
                    cmd.Parameters.AddWithValue("@TicketId", ticketId);
                    cmd.ExecuteNonQuery();
                }
            }
        }



    }
}