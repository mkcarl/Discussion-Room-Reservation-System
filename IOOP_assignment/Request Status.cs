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
            string sqlQuery = $"select Reservation.ReservationID ,  RoomName, Min(TimeSlot) as 'Starting Time', ApprovalStatus, count(*) as Hours from Reservation inner join [Reservation-Room] on Reservation.ReservationID = [Reservation-Room].ReservationID inner join Room on [Reservation-Room].RoomID = Room.RoomID where Reservation.StudentRegistered = '{mainUser.StudentID}' group by Reservation.ReservationID, RoomName, ApprovalStatus;";
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
