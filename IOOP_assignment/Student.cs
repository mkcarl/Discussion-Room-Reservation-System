using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

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

        public void MakeNewReservation(DateTime startDate, string startTime, int pax, int duration, string roomtype)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();

            int counter;
            try
            {
                SqlDataReader dr = Controller.Query("SELECT TOP 1 ReservationID FROM Reservation ORDER BY ReservationID DESC;");
                dr.Read();
                counter = int.Parse(dr["ReservationID"].ToString().Substring(2)); // basically selecting the last row and extract the number from it 
                counter++;
            }
            catch (InvalidOperationException)
            {
                counter = 0;
            }

            //create a reservation with latest reservation ID
            string createReservation = $"INSERT INTO Reservation (ReservationID, ApprovalStatus,Comments,Pax,StudentRegistered) VALUES ('RV{counter.ToString("000000")}','Pending','',{pax},{this.StudentID})";
            SqlCommand cmdCreateReservation = new SqlCommand(createReservation, conn);
            cmdCreateReservation.ExecuteNonQuery();

            // get all rooms 
            string alterTime = $"{startDate.ToString("yyyy-MM-dd")} {startTime}";
            string queryRoom = $"SELECT TOP {duration} RoomID FROM Room WHERE RoomName LIKE '{roomtype}%' AND TimeSlot >= '{alterTime}' AND BookStatus = 'Free'";
            List<string> rooms;
            SqlDataReader drOldRooms = Controller.Query(queryRoom);
            rooms = (from IDataRecord r in drOldRooms select (string)r["RoomID"]).ToList();

            //set room status that are selected from free to booked
            foreach (string room in rooms)
            {
                string roomUpdate = ($"UPDATE Room SET BookStatus = 'Booked' WHERE RoomID = '{room}'");
                SqlCommand cmdRoomUpdate = new SqlCommand(roomUpdate, conn);
                cmdRoomUpdate.ExecuteNonQuery();
            }

            //create an entry in reservation room table to signify which reservation is taking which room
            foreach (string room in rooms)
            {
                string reservationEntry = $"INSERT INTO [Reservation-Room] (ReservationID,RoomID) VALUES ('RV{counter.ToString("000000")}','{room}')";
                SqlCommand cmdReservationEntry = new SqlCommand(reservationEntry, conn);
                cmdReservationEntry.ExecuteNonQuery();
            }
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
