using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketVendorMachine
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;

        
        public Form1()
        {
            InitializeComponent();
        }
        
        //Load data for the Trip field
        private void loadTrip()
        {
            string s = "select distinct FromLoc, DestLoc from Trip where AvailableSeat > 0";
            cm = new SqlCommand(s, conn);
            data = new SqlDataAdapter(cm);
            tb = new DataTable();
            data.Fill(tb);
            grdTrip.DataSource = tb;
        }

        //Load data for the Time field
        private void loadTime(String tripFromLoc, String tripDestLoc)
        {
            string s = "select DepartTime from Trip where FromLoc = '" + tripFromLoc + "' and DestLoc = '" + tripDestLoc + "'";
            cm = new SqlCommand(s, conn);
            data = new SqlDataAdapter(cm);
            tb = new DataTable();
            data.Fill(tb);
            grdTime.DataSource = tb;
        }

        //Load data for the Seat field
        private void loadSeat(String tripFromLoc, String tripDestLoc, String tripDepartTime)
        {
            string s = "select SeatNumber from Seat inner join Trip on Trip.ID = Seat.TripID " +
                "where FromLoc = '" + tripFromLoc + "' and DestLoc = '" + tripDestLoc + "' and DepartTime = '" + TimeSpan.Parse(tripDepartTime) + "' and isOccupied = 0";
            cm = new SqlCommand(s, conn);
            data = new SqlDataAdapter(cm);
            tb = new DataTable();
            data.Fill(tb);
            grdSeat.DataSource = tb;
        }

        //Take Action when the form is loading
        private void Form1_Load(object sender, EventArgs e)
        {
            //Initiating the connection to the database
            string s = "initial catalog = TicketVendorMachine; data source = CERBEROSE; integrated security = true";
            conn = new SqlConnection(s);
            conn.Open();
            loadTrip();
            grpTimeSeat.Visible = false;
            btnNext1.Enabled = false;
            btnNext2.Visible = false;
            btnBack1.Visible = false;
            btnNext2.Enabled = false;
        }

        //Take Action when the user click on the trip table
        private void grdTrip_Click(object sender, EventArgs e)
        {
            btnNext1.Enabled = true;
            String tripFromLoc = grdTrip.CurrentRow.Cells[0].Value.ToString();
            String tripDestLoc = grdTrip.CurrentRow.Cells[1].Value.ToString();
            loadTime(tripFromLoc, tripDestLoc);
        }

        //Take Action when the user click on the time table
        private void grdTime_Click(object sender, EventArgs e)
        {
            String tripFromLoc = grdTrip.CurrentRow.Cells[0].Value.ToString();
            String tripDestLoc = grdTrip.CurrentRow.Cells[1].Value.ToString();
            String tripDepartTime = grdTime.CurrentRow.Cells[0].Value.ToString();
            loadSeat(tripFromLoc, tripDestLoc, tripDepartTime);
        }

        //Take Action when the user click on the next button
        private void btnNext1_Click(object sender, EventArgs e)
        {
            grpTimeSeat.Visible = true;
            tripGrp.Visible = false;
            btnNext2.Visible = true;
            btnNext1.Visible = false;
            btnBack1.Visible = true;
        }

        //Take Action when the user click on the back button
        private void backBtn1_Click(object sender, EventArgs e)
        {
            grpTimeSeat.Visible = false;
            tripGrp.Visible = true;
            btnNext2.Visible = false;
            btnNext1.Visible = true;
            btnBack1.Visible = false;
            grdSeat.DataSource = null;
            grdTime.DataSource = null;
        }

        //Take Action when the user click on the next button
        private void btnNext2_Click(object sender, EventArgs e)
        {
            String fromLoc = grdTrip.CurrentRow.Cells[0].Value.ToString();
            String destLoc = grdTrip.CurrentRow.Cells[1].Value.ToString();
            String time = grdTime.CurrentRow.Cells[0].Value.ToString();
            String seat = grdSeat.CurrentRow.Cells[0].Value.ToString();

            //Show up the confirmation box
            if (MessageBox.Show(
                "From: " + fromLoc + "\n" +
                "Destination: " + destLoc + "\n" +
                "Depart Time: " + time + "\n" +
                "Seat: " + seat + "\n" +
                "Proceed to Checkout?"
            , "Adding", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Ticket Added", "Success");

                //Get the current ID for the ticket
                string s = "select * from Ticket";
                cm = new SqlCommand(s, conn);
                data = new SqlDataAdapter(cm);
                tb = new DataTable();
                data.Fill(tb);
                int id = tb.Rows.Count + 1;

                //Get the Trip ID for the ticket
                s = "select ID from Trip where DestLoc = '" + destLoc + "' and FromLoc = '" + fromLoc +"' and DepartTime = '" + TimeSpan.Parse(time) + "'";
                cm = new SqlCommand(s, conn);
                data = new SqlDataAdapter(cm);
                tb = new DataTable();
                data.Fill(tb);

                String tripId = tb.Rows[0][0].ToString();

                s = "insert into Ticket\n" +
                " values ('" + id + "', '" + tripId + "', '"+ seat +"')\n";
                cm = new SqlCommand(s, conn);
                cm.ExecuteNonQuery();
            }

        }

        //Activate the next button when the user complete all their input
        private void grdSeat_Click(object sender, EventArgs e)
        {
            btnNext2.Enabled = true;
        }
    }
}
