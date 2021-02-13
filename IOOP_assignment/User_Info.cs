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

namespace IOOP_assignment
{
    public partial class Add_User_Form : Form
    {
        public Add_User_Form()
        {
            InitializeComponent();
        }


        private void btnUserBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            //insert update database codes before this line
            this.Close();
        }

        private void checkShowPassUser_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPassUser.Checked)
            {
                txtPassUser.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassUser.UseSystemPasswordChar = true;
            }
        }

        private void Add_User_Form_Load(object sender, EventArgs e)

        {
            // if login role not librarian, hide librarianID field 


            //query first row 
            string sqlquery = "SELECT TOP 1 * FROM Student";
            //create the connection 
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf; Integrated Security=True;Connect Timeout=30");

            //opening the connection
            conn.Open();

            //command
            SqlCommand cmdquery = new SqlCommand(sqlquery, conn);

            //defining the table to be used by C#
            SqlDataReader table1;



            //execute 
            table1 = cmdquery.ExecuteReader();

            //read the table
            table1.Read();


            txtStudentIDUser.Text = table1["StudentID"].ToString();
            txtPassUser.Text = table1["Password"].ToString();
            txtEmailUser.Text = table1["EmailAddress"].ToString();
            txtGivenUser.Text = table1["GivenName"].ToString();
            txtSurnameUser.Text = table1["Surname"].ToString();
           
            

            
            

        }
    }
}
