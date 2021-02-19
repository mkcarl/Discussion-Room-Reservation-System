using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_assignment
{
    public partial class formLibrarianRegistration : Form
    {
        public formLibrarianRegistration()
        {
            InitializeComponent();
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPasscode.Text == "verysecretcode")
            {
                SqlDataReader drLastLibrarianID = Controller.Query("SELECT TOP 1 LibrarianID FROM Librarian ORDER BY LibrarianID DESC");
                drLastLibrarianID.Read();
                int lastLibrarianID = int.Parse(drLastLibrarianID["LibrarianID"].ToString().Substring(2));
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf;Integrated Security=True;Connect Timeout=30");

                SqlCommand cmdRegisterLibrarian = new SqlCommand($"INSERT INTO Librarian (StudentID, LibrarianID) VALUES ({Program.StudentUser.StudentID}, 'LB{(lastLibrarianID + 1).ToString("000")}')", conn);
                SqlCommand cmdUpdateStudent = new SqlCommand($"UPDATE Student SET Role = 'Librarian' WHERE StudentID = {Program.StudentUser.StudentID}", conn);
                conn.Open();
                cmdRegisterLibrarian.ExecuteNonQuery();
                cmdUpdateStudent.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Registration is successful. Please log out and log in again to ensure all librarian features are present.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
