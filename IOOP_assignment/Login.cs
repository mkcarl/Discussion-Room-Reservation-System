using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;


namespace IOOP_assignment
{
    public partial class formLogin : Form
    {

        public formLogin()
        {
            InitializeComponent();
        }

        private void txtStudentID_Login_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtStudentID_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*pseudocode

           if input is number or backspace, accept input,
           else reject, then tell that you only can insert numbers

            */


            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))) // if the input is not number or a control like backspace
            {
                showErrorHint("Only accept number inputs", txtStudentID_Login); // show the hint 
                e.Handled = true; // stop the input
            }
            else if (txtStudentID_Login.Text.Length>=6) // if the input is more than 6 characters
            {
                if (!char.IsControl(e.KeyChar)) { 
                    e.Handled = true;
                    showErrorHint("Student ID is only 6 characters long.", txtStudentID_Login);
                }
                
            }
        }

        // TODO: move showHint() to Controller class. 
        private void showErrorHint(string message, Control control)
        {
            SystemSounds.Asterisk.Play(); // https://stackoverflow.com/a/72488
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.Show(message, control, 150, -30, 500);

            // https://stackoverflow.com/questions/14695357/show-tooltip-on-textbox-entry
        }

        private void btnLogin_Login_Click(object sender, EventArgs e)
        {
            /* Pseudocode
             * if credentials correct, 
             *      if role is librarian,
             *          open librarian homepage; 
             *      else 
             *          open student homepage; 
             * else 
             *      show messagebox error
             */

            string sqlLogin= "SELECT * FROM Student WHERE StudentID = @studentid AND Password = @pwd;";

            // TODO: move showHint() to Controller class. 
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmdLoginRole = new SqlCommand(sqlLogin, conn);

            cmdLoginRole.Parameters.AddWithValue("@studentid", txtStudentID_Login.Text.ToString());
            cmdLoginRole.Parameters.AddWithValue("@pwd", txtPassword_Login.Text.ToString());

            SqlDataReader dr = cmdLoginRole.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                if (dr["Role"].ToString() == "Librarian")
                {
                    formLibrarianHomepage LHome;
                    LHome = new formLibrarianHomepage();
                    LHome.FormClosing += LHome_Closing;
                    LHome.Show();
                    // MessageBox.Show("Librarian login");
                }
                else if (dr["Role"].ToString() == "Student")
                {
                    formStudentHomepage SHome;
                    SHome = new formStudentHomepage();
                    SHome.Show();
                    SHome.FormClosing += SHome_Closing; 
                    // MessageBox.Show("Student login");
                }
                else { } // just in case there is any vulnerability, they are not able to access the homepage. 
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please check the StudentID or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();


        }

        // when the homepage is closed, Login form will appear
        private void LHome_Closing(object sender, FormClosingEventArgs e)
        {
            DialogResult logout = MessageBox.Show("Do you want exit the program?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (logout == DialogResult.No)
            {
                this.Show();
            }
            else if (logout == DialogResult.Yes)
            {
                this.Close();
                //Application.Exit();
            }
            else if (logout == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private void SHome_Closing(object sender, FormClosingEventArgs e)
        {
            DialogResult logout = MessageBox.Show("Do you want exit the program?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (logout == DialogResult.No)
            {
                this.Show();
            }
            else if (logout == DialogResult.Yes)
            {
                this.Close();
                //Application.Exit();
            }
            else if (logout == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnRegister_Login_Click(object sender, EventArgs e)
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

            cmdRegister.Parameters.AddWithValue("@studentid", txtStudentID_Login.Text.ToString());
            cmdRegister.Parameters.AddWithValue("@pwd", txtPassword_Login.Text.ToString());

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
