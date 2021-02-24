using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

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

        public bool MakeNewReservation(DateTime startDate, string startTime, int pax, int duration, string roomtype)
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

            int roomCount = 0;
            switch (roomtype)
            {
                case "Amber":
                    roomCount = 5;
                    break;
                case "BlackThorn":
                    roomCount = 4;
                    break;
                case "Cedar":
                    roomCount = 6;
                    break;
                case "Daphne":
                    roomCount = 5;
                    break;
            }
            bool hasEnoughRoom = false;
            List<string> rooms = new List<string> ();
            for (int i = 1; i <= roomCount; i++)
            {
                // get all rooms 
                DateTime selectedTime = DateTime.ParseExact($"{startDate.ToString("yyyy-MM-dd")} {startTime}", "yyyy-MM-dd h:mm tt", CultureInfo.InvariantCulture);
                string begin = selectedTime.ToString("yyyy-MM-dd hh:mm tt");
                string end= selectedTime.AddHours(duration).ToString("yyyy-MM-dd hh:mm tt"); ;

                string queryRoom = $"SELECT TOP {duration} RoomID FROM Room WHERE RoomName = '{roomtype}{i}' AND TimeSlot >= '{begin}' AND TimeSlot < '{end}' AND BookStatus = 'Free'";
                SqlDataReader drOldRooms = Controller.Query(queryRoom);
                rooms = (from IDataRecord r in drOldRooms select (string)r["RoomID"]).ToList();

                if(rooms.Count < duration) //if all the selected room is less than the number of hours, redo the thing
                {
                    continue;
                }
                hasEnoughRoom = true; 
                break;
            }
            if (hasEnoughRoom)
            {
                //create a reservation with latest reservation ID
                string createReservation = $"INSERT INTO Reservation (ReservationID, ApprovalStatus,Comments,Pax,StudentRegistered) VALUES ('RV{counter.ToString("000000")}','Pending','',{pax},{this.StudentID})";
                SqlCommand cmdCreateReservation = new SqlCommand(createReservation, conn);
                cmdCreateReservation.ExecuteNonQuery();

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
            }
            conn.Close();
            return hasEnoughRoom;
        }

        public void CancelCurrentReservation()
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlDataReader oldReservation;
            oldReservation = Controller.Query($"select top 1 rv.ReservationID, rv.ApprovalStatus, rv.Pax, MIN(rm.TimeSlot) as 'StartingTime' from Reservation rv inner join [Reservation-Room] rr on rr.ReservationID = rv.ReservationID inner join Room rm on rm.RoomID = rr.RoomID where rv.StudentRegistered = {this.StudentID} and rv.ApprovalStatus = 'Pending' or rv.ApprovalStatus = 'Approve' group by rv.Pax, rv.ReservationID, rv.ApprovalStatus order by rv.ReservationID Desc; ");
            oldReservation.Read();
            string currentReservationID = oldReservation["ReservationID"].ToString();

            List<string> currentRooms;
            SqlDataReader currentBooking = Controller.Query($"SELECT * FROM [Reservation-Room] WHERE ReservationID = '{currentReservationID}'");
            currentRooms = (from IDataRecord r in currentBooking select (string)r["RoomID"]).ToList();
            // https://stackoverflow.com/a/1370592

            //// delete old records
            //string sqlDeleteCurrentReservationID = $"DELETE FROM [Reservation-Room] WHERE ReservationID = '{currentReservationID}'";
            //SqlCommand cmdDeleteOld = new SqlCommand(sqlDeleteCurrentReservationID, conn);
            //cmdDeleteOld.ExecuteNonQuery();

            // update reservation status to 'Cancel' 
            string approvalstatus = ($"Update Reservation set ApprovalStatus = 'Cancel' where ReservationID = '{currentReservationID}'");
            SqlCommand cmdChangeApproval = new SqlCommand(approvalstatus, conn);
            cmdChangeApproval.ExecuteNonQuery();

            // change all old room to free 
            foreach (string room in currentRooms)
            {
                string sqlBookedToFree = ($"UPDATE Room SET BookStatus = 'Free' WHERE RoomID = '{room}'");
                SqlCommand cmd = new SqlCommand(sqlBookedToFree, conn);
                cmd.ExecuteNonQuery();

            }
            conn.Close();
        }

        public void ModifyReservation(DateTime newTime, string roomchoice)
        {
            // query the latest reservation of the student (that is pending, and after today)
            // delete records from rr
            // change status in rm from booked to free
            // change status in respective room from free to booked 
            // create new reservation BUT with current reservation id 
            SqlDataReader oldReservation;
            oldReservation = Controller.Query($"select top 1 rv.ReservationID, rv.ApprovalStatus, rv.Pax, MIN(rm.TimeSlot) as 'StartingTime' from Reservation rv inner join [Reservation-Room] rr on rr.ReservationID = rv.ReservationID inner join Room rm on rm.RoomID = rr.RoomID where rv.StudentRegistered = {this.StudentID} and rv.ApprovalStatus = 'Pending' group by rv.Pax, rv.ReservationID, rv.ApprovalStatus order by rv.ReservationID Desc; ");
            oldReservation.Read();
            string currentReservationID = oldReservation["ReservationID"].ToString();
            string sqlDeleteOld = $"DELETE FROM [Reservation-Room] WHERE ReservationID = '{currentReservationID}'";

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();

            // get all the old rooms
            List<string> oldRooms;
            SqlDataReader drOldRooms = Controller.Query($"SELECT * FROM [Reservation-Room] WHERE ReservationID = '{currentReservationID}'");
            oldRooms = (from IDataRecord r in drOldRooms select (string)r["RoomID"]).ToList();
            // https://stackoverflow.com/a/1370592

            // delete old records
            SqlCommand cmdDeleteOld = new SqlCommand(sqlDeleteOld, conn);
            cmdDeleteOld.ExecuteNonQuery();


            // change all old room to free 
            foreach (string room in oldRooms)
            {
                string sqlBookedToFree = $"UPDATE Room SET BookStatus = 'Free' WHERE RoomID = '{room}'";
                SqlCommand cmd = new SqlCommand(sqlBookedToFree, conn);
                cmd.ExecuteNonQuery();
            }
            // change status for respective room 
            // find the first n, with starting time of (user input)

            // get all the new rooms
            List<string> newRooms;
            SqlDataReader drNewRooms = Controller.Query($"SELECT TOP {oldRooms.Count} * FROM Room WHERE TimeSlot >= '{newTime.ToString("yyyy-MM-dd hh:mm:ss tt")}' and BookStatus = 'Free' and RoomName LIKE '{roomchoice}%'");
            newRooms = (from IDataRecord r in drNewRooms select (string)r["RoomID"]).ToList();
            // change all new room to Booked
            foreach (string room in newRooms)
            {
                string sqlBookedToFree = $"UPDATE Room SET BookStatus = 'Booked' WHERE RoomID = '{room}'";
                SqlCommand cmd = new SqlCommand(sqlBookedToFree, conn);
                cmd.ExecuteNonQuery();
            }
            // create new reservation-room pair 
            foreach (string room in newRooms)
            {
                string sqlInsertReservationRoom = $"INSERT INTO [Reservation-Room] (ReservationID, RoomID) VALUES ('{currentReservationID}', '{room}')";
                SqlCommand cmd = new SqlCommand(sqlInsertReservationRoom, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public string StudentID { get => studentID; set => studentID = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public Form MainForm { get => mainForm; set => mainForm = value; }
        public string Surname { get => surname; set => surname = value; }
        public string GivenName { get => givenName; set => givenName = value; }
    }
}
