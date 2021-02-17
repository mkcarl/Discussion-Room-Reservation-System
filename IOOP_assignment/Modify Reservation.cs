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
    public partial class FormModify : Form
    {
        

        public FormModify()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormModify_Load(object sender, EventArgs e)
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

            mthCalendarNewModify.MinDate = DateTime.Now.AddDays(2);
            mthCalendarNewModify.MaxDate = DateTime.Now.AddDays(7);

            //string sqlQuery = $"select Reservation.ReservationID ,  RoomName, Min(TimeSlot) as 'Starting Time', Pax, count(*) as Hours from Reservation inner join [Reservation-Room] on Reservation.ReservationID = [Reservation-Room].ReservationID inner join Room on [Reservation-Room].RoomID = Room.RoomID where Reservation.StudentRegistered = '{mainUser.StudentID}' group by Reservation.ReservationID, RoomName";

            SqlDataReader dr = Controller.Query($"SELECT TOP 1 rv.ReservationID, rv.Pax ,RoomName, Min(TimeSlot) AS 'Starting Time', ApprovalStatus, count(*) AS Hours, rv.LibrarianReviewed FROM Reservation rv INNER JOIN [Reservation-Room] ON rv.ReservationID = [Reservation-Room].ReservationID INNER JOIN Room ON [Reservation-Room].RoomID = Room.RoomID LEFT JOIN Librarian ON rv.LibrarianReviewed = Librarian.LibrarianID WHERE rv.StudentRegistered = '{mainUser.StudentID}' GROUP BY rv.ReservationID, RoomName, ApprovalStatus, rv.Pax, rv.LibrarianReviewed ORDER BY [Starting Time] DESC");

            //SqlDataReader dr = Controller.Query($"SELECT TOP 1 rv.ReservationID, rv.Pax ,RoomName, Min(TimeSlot) AS 'Starting Time', count(*) AS Hours, rv.LibrarianReviewed FROM Reservation rv INNER JOIN [Reservation-Room] ON rv.ReservationID = [Reservation-Room].ReservationID INNER JOIN Room ON [Reservation-Room].RoomID = Room.RoomID LEFT JOIN Librarian ON rv.LibrarianReviewed = Librarian.LibrarianID WHERE rv.StudentRegistered = 100001 GROUP BY rv.ReservationID, RoomName, ApprovalStatus, rv.Pax, rv.LibrarianReviewed ORDER BY [Starting Time] DESC");

            dr.Read();
            if (dr.HasRows)
            {
                DateTime dtime = (DateTime)dr["Starting Time"];
                lblNoPeopleCurrentModify.Text = dr["Pax"].ToString();
                lblDateCurrentModify.Text = dtime.ToString("dd MMMM yyyy");
                lblTimeCurrentModify.Text = dtime.ToString("hh:mm tt");
                lblRoomCurrentModify.Text = dr["RoomName"].ToString();
            }

            else
            {
                MessageBox.Show("No Reservations found.");

            }


            //SqlDataReader dr = Controller.Query($"SELECT*FROM Reservation where StudentRegistered = '{mainUser.StudentID}'");
            //dr.Read();

            //if (dr.HasRows)
            //{
            //    lblNoPeopleCurrentModify.Text = dr["Pax"].ToString();

            //}

            //SqlDataReader dr2 = Controller.Query($"SELECT* FROM Room");
            //dr2.Read();

            //if (dr2.HasRows)
            //{
            //    lblDateCurrentModify.Text = dr2["TimeSlot"].ToString();

            //}

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mthCalendarNewModify_DateChanged(object sender, DateRangeEventArgs e)
        {

            
        }

        private void btnConfirmModification_Click(object sender, EventArgs e)
        {
            Student mainUser;
            string timeslot;
            if (Program.LoginRole == "Student")
            {
                mainUser = Program.StudentUser;
            }
            else
            {
                mainUser = Program.LibrarianUser;
            }

            //string query = "UPDATE Reservation SET Pax = '" + comboPeopleNewModify.ToString();

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();

            timeslot = ("mthCalendarNewModify.SelectionRange.ToString()" + "comboTimeNewModify.SelectedItem.ToString()");


            if (radAmberNewModify.Enabled == true)
            {
                string updatereservation = ($"UPDATE Reservation SET Pax = '{comboPeopleNewModify.SelectedItem.ToString()}', ApprovalStatus = 'Pending', Comments = 'Still pending' WHERE StudentRegistered = {mainUser.StudentID}");
                //string updateroom = ($"UPDATE Room SET BookStatus = 'Booked' WHERE TimeSlot = '{timeslot}' AND Capacity = '10' AND BookStatus = 'Free'");
                string target = ($"Select ReservationID From Reservation where StudentRegistered = {mainUser.StudentID}");
                string delete = ($"DELETE FROM [Reservation-Room] WHERE ReservationID = {target}");

                //string query3 = ($"DELETE FROM Reservation-Room WHERE ReservationID = [ReservationID].StudentRegistered );


                SqlCommand cmd = new SqlCommand(updatereservation,conn);
                cmd.ExecuteNonQuery();
                //SqlCommand cmd2 = new SqlCommand(updateroom, conn);
               // cmd2.ExecuteNonQuery();
                SqlCommand cmd3 = new SqlCommand(target, conn);
                cmd3.ExecuteNonQuery();
                SqlCommand cmd4 = new SqlCommand(delete, conn);
                cmd4.ExecuteNonQuery();

                MessageBox.Show("Successfully Updated");







            }

            else if (radBlackThornNewModify.Enabled == true)
            {
                string query = ($"UPDATE  Reservation SET Pax = '{comboPeopleNewModify.SelectedItem.ToString()}' WHERE StudentRegistered = {mainUser.StudentID}, ApprovalStatus = 'Pending'");
                string query2 = ($"UPDATE Room SET BookStatus = 'Booked' WHERE TimeSlot = '{comboTimeNewModify.SelectedItem.ToString()}' AND Capacity = '10' AND BookStatus = 'Free'");


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                cmd2.ExecuteNonQuery();



            }

            else if (radCedarNewModify.Enabled == true)
            {
                string query = ($"UPDATE  Reservation SET Pax = '{comboPeopleNewModify.SelectedItem.ToString()}', ApprovalStatus = 'Pending', Comments = 'Still pending' WHERE StudentRegistered = {mainUser.StudentID}");
                string query2 = ($"UPDATE Room SET BookStatus = 'Booked' WHERE TimeSlot = '{comboTimeNewModify.SelectedItem.ToString()}' AND Capacity = '10' AND BookStatus = 'Free'");

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                cmd2.ExecuteNonQuery();
            }

            else if (radDaphneNewModify.Enabled == true)
            {
                string query = ($"UPDATE  Reservation SET Pax = '{comboPeopleNewModify.SelectedItem.ToString()}', ApprovalStatus = 'Pending', Comments = 'Still pending' WHERE StudentRegistered = {mainUser.StudentID}");
                string query2 = ($"UPDATE Room SET BookStatus = 'Booked' WHERE TimeSlot = '{comboTimeNewModify.SelectedItem.ToString()}' AND Capacity = '10' AND BookStatus = 'Free'");

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                cmd2.ExecuteNonQuery();
            }

        }

        private void lblCurrentTitleModify_Click(object sender, EventArgs e)
        {
            
        }

        private void lblDateCurrentModify_Click(object sender, EventArgs e)
        {
            
        }

        private void lblTimeCurrentModify_Click(object sender, EventArgs e)
        {
          
        }

        private void lblNoPeopleCurrentModify_Click(object sender, EventArgs e)
        {
            
        }

        private void radAmberNewModify_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void comboPeopleNewModify_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int.Parse(comboPeopleNewModify.SelectedItem.ToString()) >= 2) && (int.Parse(comboPeopleNewModify.SelectedItem.ToString())<3))
            {
                radDaphneNewModify.Enabled = true;
                radCedarNewModify.Enabled = true;
                radBlackThornNewModify.Enabled = true;
                radAmberNewModify.Enabled = true;
            }

            else if ((int.Parse(comboPeopleNewModify.SelectedItem.ToString()) >= 2) && (int.Parse(comboPeopleNewModify.SelectedItem.ToString()) <5))
            {
                radDaphneNewModify.Enabled = false;
                radCedarNewModify.Enabled = true;
                radBlackThornNewModify.Enabled = true;
                radAmberNewModify.Enabled = true;
            }

            else if ((int.Parse(comboPeopleNewModify.SelectedItem.ToString()) >= 2) && (int.Parse(comboPeopleNewModify.SelectedItem.ToString()) < 9))
            {
                radDaphneNewModify.Enabled = false;
                radCedarNewModify.Enabled = false;
                radBlackThornNewModify.Enabled = true;
                radAmberNewModify.Enabled = true;
            }
            
            else if ((int.Parse(comboPeopleNewModify.SelectedItem.ToString()) >= 2))
            {
                radDaphneNewModify.Enabled = false;
                radCedarNewModify.Enabled = false;
                radBlackThornNewModify.Enabled = false;
                radAmberNewModify.Enabled = true;
            }
        }

        private void comboTimeNewModify_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnResetModify_Click(object sender, EventArgs e)
        {
            


        }
    }
}
