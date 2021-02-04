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

        private void txtStudentIDUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowPassUser_Click(object sender, EventArgs e)
        {

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

        private void txtPassUser_TextChanged(object sender, EventArgs e)
        {

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
            //string sqllogin = "SELECT * from Student WHERE StudentID = @studentid AND Password = PrintControllerWithStatusDialog;";

            //SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf; Integrated Security=True;Connect Timeout=30");

            //conn.Open();
            //SqlCommand cmdLoginRole = new SqlCommand(sqllogin, conn);

            //cmdLoginRole.Parameters.AddWithValue("@studentid", txtStudentIDUser.Text.ToString());
            //cmdLoginRole.Parameters.AddWithValue("@pwd", txtPassUser.Text.ToString());

            txtPassUser.Text = 

        }
    }
}
