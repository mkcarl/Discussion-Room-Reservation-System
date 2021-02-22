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
            /*
             select the rows where 
            student id = the student , 
            date >= today , 
            order by reservation id, then take the last reservation
             */
            string sqlQuery = $"SELECT TOP 1 rv.ReservationID, rv.Pax ,RoomName, Min(TimeSlot) AS 'Starting Time', ApprovalStatus, count(*) AS Hours, rv.LibrarianReviewed FROM Reservation rv INNER JOIN [Reservation-Room] ON rv.ReservationID = [Reservation-Room].ReservationID INNER JOIN Room ON [Reservation-Room].RoomID = Room.RoomID LEFT JOIN Librarian ON rv.LibrarianReviewed = Librarian.LibrarianID WHERE rv.StudentRegistered = '{mainUser.StudentID}' GROUP BY rv.ReservationID, RoomName, ApprovalStatus, rv.Pax, rv.LibrarianReviewed ORDER BY [Starting Time] DESC;";
            SqlDataReader dr = Controller.Query(sqlQuery);
            dr.Read();
            if (dr.HasRows)
            {
                DateTime dtime = (DateTime)dr["Starting Time"];
                txtRoomTypeRequest.Text = dr["RoomName"].ToString();
                txtStatusRequest.Text = dr["ApprovalStatus"].ToString();
                txtDateRequest.Text = dtime.ToString("dd MMMM yyyy");
                txtTimeRequest.Text = dtime.ToString("hh:mm tt");
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
