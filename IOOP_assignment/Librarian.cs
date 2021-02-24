﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_assignment
{
    class Librarian : Student
    {
        private string librarianID;

        public Librarian(string studentID, string password, string surname, string givenName, string email):base(studentID, password, surname, givenName, email) // inheriting from the base class
        {
            this.librarianID = this.GetLibrarianID();
        }

        public string LibrarianID { get => librarianID; set => librarianID = value; }

        private string GetLibrarianID()
        {
            SqlDataReader dr = Controller.Query("SELECT * FROM Librarian WHERE StudentID=" + this.StudentID);

            if (dr.HasRows)
            {
                dr.Read();
                return dr["LibrarianID"].ToString();
            }
            else
            {
                return "Unknown";
            }

        }

        public void ApproveReservation(string reservationID, string studentID)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();


            string queryRoom = $"SELECT * FROM [Reservation-Room] WHERE ReservationID = '{reservationID}'";

            List<string> rooms;
            SqlDataReader drOldRooms = Controller.Query(queryRoom);
            rooms = (from IDataRecord r in drOldRooms select (string)r["RoomID"]).ToList();

            string query = $"UPDATE Reservation SET ApprovalStatus = 'Approve', LibrarianReviewed = '{this.LibrarianID}' WHERE ApprovalStatus = 'Pending'AND ReservationID = '{reservationID}'";
            SqlCommand cmd = new SqlCommand(query, conn);

            if (studentID == this.StudentID)
            {
                MessageBox.Show("Librarians cannot approve or reject their own reservations.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show($"Are you sure you want to aprove the reservation for the ReservationID: {reservationID} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                }
            }
            conn.Close();
        }

        public void RejectReservation(string reservationID, string studentID)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();


            string queryRoom = $"SELECT * FROM [Reservation-Room] WHERE ReservationID = '{reservationID}'";

            List<string> rooms;
            SqlDataReader drOldRooms = Controller.Query(queryRoom);
            rooms = (from IDataRecord r in drOldRooms select (string)r["RoomID"]).ToList();

            string query = $"UPDATE Reservation SET ApprovalStatus = 'Approve', LibrarianReviewed = '{this.LibrarianID}' WHERE ApprovalStatus = 'Pending'AND ReservationID = '{reservationID}'";
            SqlCommand cmd = new SqlCommand(query, conn);

            if (studentID == this.StudentID)
            {
                MessageBox.Show("Librarians cannot approve or reject their own reservations.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show($"Are you sure you want to aprove the reservation for the ReservationID: {reservationID} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                }
            }
            conn.Close();
        }
    }
}
