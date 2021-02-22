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
using System.Globalization;

namespace IOOP_assignment
{
    public partial class FormModify : Form
    {
        Student mainUser;

        SqlDataReader oldReservation; 

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

        private void FormModify_Load(object sender, EventArgs e)
        {
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

            SqlDataReader dr = Controller.Query($"SELECT TOP 1 rv.ReservationID, rv.Pax ,RoomName, Min(TimeSlot) AS 'Starting Time', ApprovalStatus, count(*) AS Hours, rv.LibrarianReviewed FROM Reservation rv INNER JOIN [Reservation-Room] ON rv.ReservationID = [Reservation-Room].ReservationID INNER JOIN Room ON [Reservation-Room].RoomID = Room.RoomID LEFT JOIN Librarian ON rv.LibrarianReviewed = Librarian.LibrarianID WHERE rv.StudentRegistered = '{mainUser.StudentID}' and ApprovalStatus = 'Pending' OR ApprovalStatus = 'Approve' GROUP BY rv.ReservationID, RoomName, ApprovalStatus, rv.Pax, rv.LibrarianReviewed ORDER BY [Starting Time] DESC");

            //SqlDataReader dr = Controller.Query($"SELECT TOP 1 rv.ReservationID, rv.Pax ,RoomName, Min(TimeSlot) AS 'Starting Time', count(*) AS Hours, rv.LibrarianReviewed FROM Reservation rv INNER JOIN [Reservation-Room] ON rv.ReservationID = [Reservation-Room].ReservationID INNER JOIN Room ON [Reservation-Room].RoomID = Room.RoomID LEFT JOIN Librarian ON rv.LibrarianReviewed = Librarian.LibrarianID WHERE rv.StudentRegistered = 100001 GROUP BY rv.ReservationID, RoomName, ApprovalStatus, rv.Pax, rv.LibrarianReviewed ORDER BY [Starting Time] DESC");

            dr.Read();
            if (dr.HasRows)
            {
                DateTime dtime = (DateTime)dr["Starting Time"];
                lblNoPeopleCurrentModify.Text = "Number of People: "+dr["Pax"].ToString();
                lblDateCurrentModify.Text = "Date: "+dtime.ToString("dd MMMM yyyy");
                lblTimeCurrentModify.Text = "Time: "+dtime.ToString("hh:mm tt");
                lblRoomCurrentModify.Text = "Room Name: "+dr["RoomName"].ToString();
            }

            else
            {
                MessageBox.Show("No Reservations found.");
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mthCalendarNewModify_DateChanged(object sender, DateRangeEventArgs e)
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

            string roomtype = "";
            if (radAmberNewModify.Enabled)
            {
                roomtype = "Amber";
            }

            else if (radBlackThornNewModify.Enabled)
            {
                roomtype = "BlackThorn";
            }

            else if (radCedarNewModify.Enabled)
            {
                roomtype = "Cedar";
            }

            else if (radDaphneNewModify.Enabled)
            {
                roomtype = "Daphne";
            }
            
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();

            //dateselected
            DateTime dt = DateTime.Parse(mthCalendarNewModify.SelectionStart.ToString());
            
            SqlDataReader dr = Controller.Query($"Select distinct TimeSlot from Room where TimeSlot > '{dt.ToString("yyyy-MM-dd")}' and TimeSlot < '{dt.AddDays(1).ToString("yyyy-MM-dd")}' and BookStatus = 'Free' and RoomName Like '{roomtype}%'");

            //SqlDataReader currentReservationID = Controller.Query($"select top 1 rv.ReservationID from Reservation rv inner join [Reservation-Room] rr on rr.ReservationID = rv.ReservationID inner join Room rm on rm.RoomID = rr.RoomID where rv.StudentRegistered = '{mainUser.StudentID}', group by rv.ReservationID;");

            //currentReservationID.Read();


            //string currentID= currentReservationID["ReservationID"].ToString();

            //SqlDataReader duration = Controller.Query($"Select [Reservation-Room].ReservationID, [Reservation-Room].RoomID count(*) as Duration from Reservation-Room INNER JOIN [Reservation] on [Rerservation-Room].ReservationID = [Room].ReservationID where Reservation.StudentRegistered = '{mainUser.StudentID}'");

            {
                SqlDataReader currentbooking = Controller.Query($"Select rr.ReservationID, rv.StudentRegistered, rm.RoomName, rv.LibrarianReviewed, COUNT(rr.ReservationID) as Duration from [Reservation-Room] rr inner join Reservation rv on rr.ReservationID = rv.ReservationID inner join Room rm on rm.RoomID = rr.RoomID where StudentRegistered = '{mainUser.StudentID}' group by rr.ReservationID, rv.StudentRegistered, rm.RoomName, rv.LibrarianReviewed");

                currentbooking.Read();
                int currentduration = (int)currentbooking["Duration"];


                if (dr.HasRows)
                {
                    List<DateTime> timeslots;
                    timeslots = (from IDataRecord r in dr select (DateTime)r["TimeSlot"]).ToList();
                    comboTimeNewModify.Items.Clear();

                    foreach (DateTime time in timeslots)
                    {
                        comboTimeNewModify.Items.Add(time.ToString("hh:mm tt"));

                    }
                    for (int i = 0; i < currentduration; i++)
                    {
                        comboTimeNewModify.Items.RemoveAt(comboTimeNewModify.Items.Count - 1);
                    }
                }
               
            }
        }

        private void btnConfirmModification_Click(object sender, EventArgs e)
        {
            string roomchoice = ""; 
            if (radAmberNewModify.Checked) {roomchoice = "Amber";}
            else if (radBlackThornNewModify.Checked)
            {roomchoice = "BlackThorn";}
            else if (radCedarNewModify.Checked){roomchoice = "Cedar";}
            else {roomchoice = "Daphne";}


            string datetime = $"{mthCalendarNewModify.SelectionStart.ToString("yyyy-MM-dd")} {comboTimeNewModify.SelectedItem.ToString()}";
            DateTime newtime = DateTime.ParseExact(datetime, "yyyy-MM-dd h:mm tt", CultureInfo.InvariantCulture);
            // https://stackoverflow.com/a/28672247



            // query the latest reservation of the student (that is pending, and after today)
            // delete records from rr
            // change status in rm from booked to free
            // change status in respective room from free to booked 
            // create new reservation BUT with current reservation id 

            oldReservation = Controller.Query($"select top 1 rv.ReservationID, rv.ApprovalStatus, rv.Pax, MIN(rm.TimeSlot) as 'StartingTime' from Reservation rv inner join [Reservation-Room] rr on rr.ReservationID = rv.ReservationID inner join Room rm on rm.RoomID = rr.RoomID where rv.StudentRegistered = {mainUser.StudentID} and rv.ApprovalStatus = 'Pending' group by rv.Pax, rv.ReservationID, rv.ApprovalStatus order by StartingTime Desc; ");
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
            SqlDataReader drNewRooms = Controller.Query($"SELECT TOP {oldRooms.Count} * FROM Room WHERE TimeSlot >= '{newtime.ToString("yyyy-MM-dd hh:mm:ss tt")}' and BookStatus = 'Free' and RoomName LIKE '{roomchoice}%'");
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
            MessageBox.Show("Your request have been modified.", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            Student mainUser;

            if (Program.LoginRole == "Student")
            {
                mainUser = Program.StudentUser;
            }
            else
            {
                mainUser = Program.LibrarianUser;
            }

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();

           
            oldReservation = Controller.Query($"select top 1 rv.ReservationID, rv.ApprovalStatus, rv.Pax, MIN(rm.TimeSlot) as 'StartingTime' from Reservation rv inner join [Reservation-Room] rr on rr.ReservationID = rv.ReservationID inner join Room rm on rm.RoomID = rr.RoomID where rv.StudentRegistered = {mainUser.StudentID} and rv.ApprovalStatus = 'Pending' or rv.ApprovalStatus = 'Approve' group by rv.Pax, rv.ReservationID, rv.ApprovalStatus order by StartingTime Desc; ");
            oldReservation.Read();
            string currentReservationID = oldReservation["ReservationID"].ToString();
            string approvalstatus = ($"Update Reservation set ApprovalStatus = 'Cancel' where ReservationID = '{currentReservationID}'");

            List<string> currentRooms;
            SqlDataReader currentBooking = Controller.Query($"SELECT * FROM [Reservation-Room] WHERE ReservationID = '{currentReservationID}'");
            currentRooms = (from IDataRecord r in currentBooking select (string)r["RoomID"]).ToList();
            // https://stackoverflow.com/a/1370592

            string sqlDeleteCurrentReservationID = $"DELETE FROM [Reservation-Room] WHERE ReservationID = '{currentReservationID}'";

            // delete old records
            SqlCommand cmdDeleteOld = new SqlCommand(sqlDeleteCurrentReservationID, conn);
            cmdDeleteOld.ExecuteNonQuery();

            SqlCommand cmdChangeApproval = new SqlCommand(approvalstatus, conn);
            cmdChangeApproval.ExecuteNonQuery();


            // change all old room to free 
            foreach (string room in currentRooms)
            {
               string sqlBookedToFree = ($"UPDATE Room SET BookStatus = 'Free' WHERE RoomID = '{room}'");
               SqlCommand cmd = new SqlCommand(sqlBookedToFree, conn);
               cmd.ExecuteNonQuery();

            }

            MessageBox.Show("Your booking have been successfully cancelled.");
            conn.Close();
            this.Close();
            }

        }
    }
