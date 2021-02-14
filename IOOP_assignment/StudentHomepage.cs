using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_assignment
{
    public partial class formStudentHomepage : Form
    {

        public formStudentHomepage()
        {
            InitializeComponent();
        }

        private void btnReserveRoom_SHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReserve frmReserve = new FormReserve();
            frmReserve.FormClosed += FormReserve_Closed;
            frmReserve.Show();
        }

        private void FormReserve_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnModifyReservation_SHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormModify frmMod = new FormModify();
            frmMod.FormClosed += FormModify_Closed;
            frmMod.Show();
        }

        private void FormModify_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnRequestStatus_SHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRequest frmReq = new FormRequest();
            frmReq.FormClosed += FormRequest_Closed;
            frmReq.Show();
        }

        private void FormRequest_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnLogout_SHomepage_Click(object sender, EventArgs e)
        {
            this.Close();

            //DialogResult logoutConfirm = MessageBox.Show("Logout?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (logoutConfirm == DialogResult.Yes)
            //{
            //}
        }

        private void lblWelcome_SHomepage_Click(object sender, EventArgs e)
        {

        }

        private void pbxProfilePic_SHomepage_Click(object sender, EventArgs e)

        {
            this.Hide();
            Add_User_Form f1 = new Add_User_Form();
            f1.FormClosed += f1_Closed;
            f1.Show();
        }

        private void f1_Closed(object senser, FormClosedEventArgs e)
        {
            this.Show();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDay_SHomepage.Text = DateTime.Now.DayOfWeek.ToString();
            lblDate_SHomepage.Text = DateTime.Now.ToString("dd MMMM yyy"); // https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1
            lblTime_SHomepage.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void formStudentHomepage_Load(object sender, EventArgs e)
        {
            // load the time when form loads 
            lblDay_SHomepage.Text = DateTime.Now.DayOfWeek.ToString();
            lblDate_SHomepage.Text = DateTime.Now.ToString("dd MMMM yyy"); // https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1
            lblTime_SHomepage.Text = DateTime.Now.ToString("hh:mm tt");

            // load the students name when form load 
            string studentSurname;
            if (Program.StudentUser.Surname == null)
            {
                studentSurname = Program.StudentUser.Surname;
            }
            else
            {
                studentSurname = "Student";
            }
            lblWelcome_SHomepage.Text = "Welcome " + studentSurname;

        }
    }   
}
