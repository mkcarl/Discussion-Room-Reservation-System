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
using System.Text.RegularExpressions;

namespace IOOP_assignment
{
    public partial class Add_User_Form : Form
    {
        Student mainUser; 
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
            Regex emailRegx = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
            // https://stackoverflow.com/a/33278949
            if (emailRegx.IsMatch(txtEmailUser.Text.Trim()))
            {
                try {
                    mainUser.UpdateInfo(txtPassUser.Text.ToString(), txtSurnameUser.Text.ToString(), txtGivenUser.Text.ToString(), txtEmailUser.Text.ToString());
                    MessageBox.Show("Changes saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Text field cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Please use a valid email address format.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

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
            if (Program.LoginRole == "Librarian")
            {
                mainUser = Program.LibrarianUser;
                txtLibrarianIDUser.Text = Program.LibrarianUser.LibrarianID;
                lblTypeUser.ForeColor = Color.Red; 
            }
            else
            {
                lblLibrarianIDUser.Hide();
                txtLibrarianIDUser.Hide();
                mainUser = Program.StudentUser;
                lblTypeUser.ForeColor = Color.Green;

            }

            mainUser.FetchInfo();

            lblTypeUser.Text = Program.LoginRole;
            txtSurnameUser.Text = mainUser.Surname;
            txtGivenUser.Text = mainUser.GivenName;
            txtStudentIDUser.Text = mainUser.StudentID;
            txtEmailUser.Text = mainUser.Email;
            txtPassUser.Text = mainUser.Password;

            if (txtSurnameUser.Text == "" || txtGivenUser.Text == "" || txtEmailUser.Text == "")
            {
                MessageBox.Show("Your information is not complete, please fill in the info and save changes. Note : Surname and Given Name cannot be changed once set.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (!(txtSurnameUser.Text == "" || txtGivenUser.Text == "" || txtEmailUser.Text == ""))
            {
                txtSurnameUser.Enabled = false;
                txtGivenUser.Enabled = false;
                txtLibrarianIDUser.Enabled = false;
            }
        }

        private void lblTypeUser_Click(object sender, EventArgs e)
        {
           
        }

        private void lblTypeUser_MouseClick(object sender, MouseEventArgs e)
        {
            // register as librarian 
            // stealth 100
            // need to ctrl click to activate
            if (Control.ModifierKeys == Keys.Control && lblTypeUser.Text == "Student") //https://stackoverflow.com/a/17840012
            {
                formLibrarianRegistration frm = new formLibrarianRegistration();
                frm.ShowDialog();
                this.Close();
            }  

        }
    }
}
