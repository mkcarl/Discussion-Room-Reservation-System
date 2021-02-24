﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace IOOP_assignment
{
    public partial class Form_Pending_Student_Requests : Form
    {
        Librarian mainUser;
        public Form_Pending_Student_Requests()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Pending_Student_Requests_Load(object sender, EventArgs e)
        {
            dgvUpdate();

            if (Program.LoginRole == "Librarian")
            {
                mainUser = Program.LibrarianUser;
            }
        }

        private void dgvUpdate()
        {
            string query = "select rr.ReservationID, rv.StudentRegistered, MIN(rm.TimeSlot) as 'Start time',count(rm.TimeSlot) as 'Hours Booked',rm.RoomName as 'Room Name', rv.Pax, rv.ApprovalStatus from[Reservation-Room] rr inner join[Room] rm on rr.RoomID = rm.RoomID inner join Reservation rv on rv.ReservationID = rr.ReservationID WHERE rv.ApprovalStatus = 'Pending' group by rr.ReservationID, rv.StudentRegistered, rm.RoomName, rv.Pax, rv.ApprovalStatus;";
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);
            dgvStudentRequests.ReadOnly = true;
            dgvStudentRequests.DataSource = ds.Tables[0];
        }


        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvStudentRequests.CurrentRow != null)
            {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();

            string selectedID = dgvStudentRequests.CurrentRow.Cells["ReservationID"].Value.ToString();

            string queryRoom = $"SELECT * FROM [Reservation-Room] WHERE ReservationID = '{selectedID}'";

            List<string> rooms;
            SqlDataReader drOldRooms = Controller.Query(queryRoom);
            rooms = (from IDataRecord r in drOldRooms select (string)r["RoomID"]).ToList();

            string query = $"UPDATE Reservation SET ApprovalStatus = 'Approve', LibrarianReviewed = '{mainUser.LibrarianID}' WHERE ApprovalStatus = 'Pending'AND ReservationID = '{selectedID}'";
            SqlCommand cmd = new SqlCommand(query, conn);

            if(dgvStudentRequests.CurrentRow.Cells["StudentRegistered"].Value.ToString() == mainUser.StudentID)
            {
                MessageBox.Show("Librarians cannot approve or reject their own reservations.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show($"Are you sure you want to aprove the reservation for the ReservationID: {selectedID} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                }
            }
                dgvUpdate();
                conn.Close();

            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvStudentRequests.CurrentRow != null)
            {
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();

                string selectedID = dgvStudentRequests.CurrentRow.Cells["ReservationID"].Value.ToString();

                string queryRoom = $"SELECT * FROM [Reservation-Room] WHERE ReservationID = '{selectedID}'";

                List<string> rooms;
                SqlDataReader drOldRooms = Controller.Query(queryRoom);
                rooms = (from IDataRecord r in drOldRooms select (string)r["RoomID"]).ToList();

                string query = $"UPDATE Reservation SET ApprovalStatus = 'Reject', LibrarianReviewed = '{mainUser.LibrarianID}' WHERE ApprovalStatus = 'Pending'AND ReservationID = '{selectedID}'";

                SqlCommand cmd = new SqlCommand(query, conn);

                foreach (string room in rooms)
                {
                    string updateRoomFree = $"UPDATE Room SET BookStatus = 'Free' WHERE RoomID = '{room}'";

                    SqlCommand cmdUpdateRoomFree = new SqlCommand(updateRoomFree, conn);
                    cmdUpdateRoomFree.ExecuteNonQuery();
                }

                if (dgvStudentRequests.CurrentRow.Cells["StudentRegistered"].Value.ToString() == mainUser.StudentID)
                {
                    MessageBox.Show("Librarians cannot approve or reject their own reservations.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (MessageBox.Show($"Are you sure you want to reject the reservation for the ReservationID: {selectedID} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                    }
                    dgvUpdate();    
                    conn.Close();
                }
            }
        }
    }
}
