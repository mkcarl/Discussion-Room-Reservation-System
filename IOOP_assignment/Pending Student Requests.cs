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
using System.Configuration;

namespace IOOP_assignment
{
    public partial class Form_Pending_Student_Requests : Form
    {
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
            //Controller.Query("SELECT ");


            //string query = ("SELECT [Reservation-Room].ReservationID,[Reservation-Room].RoomID,Room.RoomName,Room.TimeSlot,Room.BookStatus FROM [Reservation-Room] INNER JOIN Room ON Room.RoomID=[Reservation-Room].RoomID FROM Room INNER JOIN ");
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();

            string query = "UPDATE Reservation SET Approval Status = 'Approved' WHERE Approval Status = 'Pending'";

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            conn.Close();
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();

            string query = "UPDATE Reservation SET Approval Status = 'Reject' WHERE Approval Status = 'Pending'";

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            conn.Close();
        }
    }
}
