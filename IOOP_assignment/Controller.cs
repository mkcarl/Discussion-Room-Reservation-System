using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_assignment
{
    class Controller
    {
        public static void ShowErrorHint(string message, Control control)
        {
            SystemSounds.Asterisk.Play(); // https://stackoverflow.com/a/72488
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.Show(message, control, 150, -30, 500);

            // https://stackoverflow.com/questions/14695357/show-tooltip-on-textbox-entry
        }

        public static SqlDataReader QueryLoginCredential(string studentID, string passsword)
        {
            string sqlLogin = "SELECT * FROM Student WHERE StudentID = @studentid AND Password = @pwd;";

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmdLoginRole = new SqlCommand(sqlLogin, conn);

            cmdLoginRole.Parameters.AddWithValue("@studentid", studentID);
            cmdLoginRole.Parameters.AddWithValue("@pwd", passsword);

            SqlDataReader dr = cmdLoginRole.ExecuteReader();
            return dr;
        }

        public static SqlDataReader Query(string sqlQuery)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmdLoginRole = new SqlCommand(sqlQuery, conn);
            SqlDataReader dr = cmdLoginRole.ExecuteReader();
            return dr;
        }

        public static void RegisterAccount(string studentID, string password)
        {
            /*
             * if studentID not in database, 
             *      insert 
             *      
             * else, 
             *      message box say already exist
             *     
             */

            string sqlRegister = "INSERT INTO Student (StudentID, Password) VALUES (@studentid, @pwd)";

            // TODO: move showHint() to Controller class. 
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmdRegister = new SqlCommand(sqlRegister, conn);

            cmdRegister.Parameters.AddWithValue("@studentid", studentID);
            cmdRegister.Parameters.AddWithValue("@pwd", password);

            try
            {
                cmdRegister.ExecuteNonQuery();
                MessageBox.Show("Successfully registered. You may proceed to log in now.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Student ID already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void GenerateRooms(DateTime targetDay)
        {
            string[] rooms = { "Amber", "BlackThorn", "Cedar", "Daphne"};
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();

            // last number 
            int counter;
            try
            {
                SqlDataReader dr = Query("SELECT TOP 1 RoomID FROM Room ORDER BY RoomID DESC;");
                dr.Read();
                counter = int.Parse(dr["RoomID"].ToString().Substring(2)); // basically selecting the last row and extract the number from it 
            }
            catch (InvalidOperationException)
            {
                counter = 0;
            }

            foreach (string roomType in rooms)
            {
                int roomCount = 0;
                switch (roomType) 
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

                
                for (int roomNum = 1; roomNum <= roomCount; roomNum++)
                {
                    DateTime timeSlot = new DateTime(targetDay.Year, targetDay.Month, targetDay.Day, 8, 0, 0);
                    for (int i = 0; i < 12; i++)
                    {
                        counter++;
                        string roomID = "RM" + counter.ToString("000000");
                        string roomName = roomType + roomNum.ToString();
                        SqlCommand cmdCreateRoom = new SqlCommand(
                            "INSERT INTO Room (RoomID, Capacity, TimeSlot, RoomName) VALUES (@rid, @cap, @time, @rname)"
                            , conn);
                        cmdCreateRoom.Parameters.AddWithValue("@rid", roomID);
                        cmdCreateRoom.Parameters.AddWithValue("@time", timeSlot);
                        cmdCreateRoom.Parameters.AddWithValue("@rname", roomName);
                        switch (roomType) // differnt capacity depending on the room type
                        {
                            case "Amber":
                                cmdCreateRoom.Parameters.AddWithValue("@cap", 10);
                                break;
                            case "BlackThorn":
                                cmdCreateRoom.Parameters.AddWithValue("@cap", 8);
                                break;
                            case "Cedar":
                                cmdCreateRoom.Parameters.AddWithValue("@cap", 4);
                                break;
                            case "Daphne":
                                cmdCreateRoom.Parameters.AddWithValue("@cap", 2);
                                break;
                        }
                        cmdCreateRoom.ExecuteNonQuery();
                        timeSlot = timeSlot.AddHours(1);
                    }
                }
            }
            conn.Close();
            //SqlCommand cmdCreateRoom = new SqlCommand("INSERT INTO Room (RoomID, Capacity, TimeSlot, RoomName) VALUES ('RM001', 10, @time, 'Amber1')", conn);
            //cmdCreateRoom.Parameters.AddWithValue("@time", DateTime.Now.ToString());
            //cmdCreateRoom.ExecuteNonQuery(); 

            /*
             counter = last row of the table, if null, counter = 0
             for every roomtype in [Amber, B, C, D]: 
                if roomtype == amber: 
                    repeat 5 times :
                        timeslot = 8am 
                        repeat 12 times : 
                            counter += 1 ;
                            roomID = "RM" + counter; 
                            insert (roomID, 10, timeslot, AmberN); 
                            timeslot += 1hr ;
             */
        }
    }
}
