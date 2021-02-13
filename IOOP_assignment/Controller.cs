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

    }
}
