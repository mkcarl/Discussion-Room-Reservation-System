using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace IOOP_assignment
{
    public partial class FormRequest : Form
    {
        public FormRequest()
        {
            InitializeComponent();
        }

        private void FormRequest_Load(object sender, EventArgs e)
        {
            Student mainUser; 
            if (Program.LoginRole == "Student")
            {
                mainUser = Program.StudentUser; 
            }
            else
            {
                mainUser = Program.LibrarianUser; 
            }

            string sqlQuery = $"SELECT TOP 1 rv.ReservationID, rv.Pax ,RoomName, Min(TimeSlot) AS 'Starting Time', ApprovalStatus, count(*) AS Hours, rv.LibrarianReviewed FROM Reservation rv INNER JOIN [Reservation-Room] ON rv.ReservationID = [Reservation-Room].ReservationID INNER JOIN Room ON [Reservation-Room].RoomID = Room.RoomID LEFT JOIN Librarian ON rv.LibrarianReviewed = Librarian.LibrarianID WHERE rv.StudentRegistered = '{mainUser.StudentID}' GROUP BY rv.ReservationID, RoomName, ApprovalStatus, rv.Pax, rv.LibrarianReviewed ORDER BY [Starting Time] DESC;";
            // this query chooses the reservation of the current user, where it chooses the latest reservation based on time

            SqlDataReader dr = Controller.Query(sqlQuery);
            dr.Read();
            if (dr.HasRows)
            {
                string statusMessage = "";
                switch (dr["ApprovalStatus"].ToString())
                {
                    case "Pending":
                        statusMessage = "Your reservation is currently peding for approval from a librarian. Thank you for your patience.";
                        break;
                    case "Cancel":
                        statusMessage = "Your reservation have been cancelled.";
                        break;
                    case "Approve":
                        statusMessage = "Congratulations, your request is approved. Please proceed to use the discussion room at the designated time.";
                        break;
                    case "Reject":
                        statusMessage = $"Sorry, your request was rejected by Librarian {dr["LibrarianReviewed"].ToString()}. Please approach us in person for more detail.";
                        break;
                }
                DateTime dtime = (DateTime)dr["Starting Time"];
                txtRoomTypeRequest.Text = dr["RoomName"].ToString();
                txtStatusRequest.Text = dr["ApprovalStatus"].ToString();
                txtDateRequest.Text = dtime.ToString("dd MMMM yyyy");
                txtTimeRequest.Text = dtime.ToString("hh:mm tt");
                txtDetailsRequest.Text = $"Invoice no. : {dr["ReservationID"].ToString()}" +
                    $"{Environment.NewLine}Pax : {dr["Pax"].ToString()}" +
                    $"{Environment.NewLine}Duration : {dr["Hours"].ToString()} hour(s)" +
                    $"{Environment.NewLine}Details : " +
                    $"{Environment.NewLine}{statusMessage}";
            }
            else
            {
                MessageBox.Show("Sorry, you have not made any reservation. Please do so in the Room Reservation function.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtStatusRequest_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDateRequest_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
