using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IOOP_assignment
{
    class Student
    {
        private string studentID;
        private string password;
        private string surname;
        private string givenName; 
        private string email;
        private Form mainForm;

        public Student(string studentID, string password, string surname, string givenName, string email)
        {
            this.studentID = studentID;
            this.password = password;
            this.email = email;
            this.Surname = surname;
            this.GivenName = givenName;
        }

        public void FetchInfo()
        {
            // update the class info from the database
            SqlDataReader dr = Controller.Query($"SELECT * FROM Student WHERE StudentID = '{this.studentID}';");
            dr.Read();
            this.email = dr["EmailAddress"].ToString();
            this.password = dr["Password"].ToString();
            this.Surname = dr["Surname"].ToString();
            this.GivenName = dr["GivenName"].ToString();
        }

        public void UpdateInfo(string password, string surname, string givenName, string email)
        {
            if (password.Trim() == "" || surname.Trim() == "" || givenName.Trim() == "" || email.Trim() == "")
            {
                throw new Exception("Input fields cannot be empty");
            }
            // update the database with the corresponding info
            this.password = password.Trim();
            this.email = email.Trim();
            this.Surname = surname.Trim();
            this.GivenName = givenName.Trim();

            string sqlUpdateStudentInfo = "UPDATE Student SET Surname = @sname, GivenName = @gname, EmailAddress = @email, Password = @pw WHERE StudentID = @sid; ";
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmdUpdateStudentInfo = new SqlCommand(sqlUpdateStudentInfo, conn);
            // use of parameters to prevent sql injection 
            cmdUpdateStudentInfo.Parameters.AddWithValue("@sname", this.surname);
            cmdUpdateStudentInfo.Parameters.AddWithValue("@gname", this.givenName);
            cmdUpdateStudentInfo.Parameters.AddWithValue("@email", this.email);
            cmdUpdateStudentInfo.Parameters.AddWithValue("@sid", int.Parse(this.studentID));
            cmdUpdateStudentInfo.Parameters.AddWithValue("@pw", this.password);
            cmdUpdateStudentInfo.ExecuteNonQuery(); 
            conn.Close();

        }

        public string StudentID { get => studentID; set => studentID = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public Form MainForm { get => mainForm; set => mainForm = value; }
        public string Surname { get => surname; set => surname = value; }
        public string GivenName { get => givenName; set => givenName = value; }
    }
}
