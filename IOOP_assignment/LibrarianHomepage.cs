using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_assignment
{
    public partial class formLibrarianHomepage : Form
    {
        Librarian mainUser; 
        public formLibrarianHomepage()
        {
            InitializeComponent();
        }

        private void btnLogout_LHomepage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnReserveRoom_LHomepage_Click(object sender, EventArgs e)
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

        private void btnModifyReservation_LHomepage_Click(object sender, EventArgs e)
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

        private void btnRequestStatus_LHomepage_Click(object sender, EventArgs e)
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

        private void btnStudentRequest_LHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Pending_Student_Requests frmPendingStuReq = new Form_Pending_Student_Requests();
            frmPendingStuReq.FormClosed += Form_Pending_Student_Requests_Closed;
            frmPendingStuReq.Show();
        }

        private void Form_Pending_Student_Requests_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnGenerateReport_LHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Generate_Report frmGenReport = new Form_Generate_Report();
            frmGenReport.FormClosed += Form_Generate_Report;
            frmGenReport.Show();
        }

        private void Form_Generate_Report(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }


        private void pbxProfilePic_LHomepage_Click(object sender, EventArgs e)
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
            lblDay_LHomepage.Text = DateTime.Now.DayOfWeek.ToString();
            lblDate_LHomepage.Text = DateTime.Now.ToString("dd MMMM yyy"); // https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1
            lblTime_LHomepage.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void formLibrarianHomepage_Load(object sender, EventArgs e)
        {
            mainUser = Program.LibrarianUser;

            // load the time when form loads 
            lblDay_LHomepage.Text = DateTime.Now.DayOfWeek.ToString();
            lblDate_LHomepage.Text = DateTime.Now.ToString("dd MMMM yyy"); // https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1
            lblTime_LHomepage.Text = DateTime.Now.ToString("hh:mm tt");

            // load the student's surname in when form load
            string librarianSurname;
            if (Program.LibrarianUser.Surname != "")
            {
                librarianSurname = Program.LibrarianUser.Surname;
            }
            else
            {
                librarianSurname = "Librarian";
            }
            lblWelcome_LHomepage.Text = "Welcome " + librarianSurname;

            // determine if they can make a reservation 
            SqlDataReader dr = Controller.Query($"SELECT TOP 1 rv.ReservationID, rv.Pax ,RoomName, Min(TimeSlot) AS 'Starting Time', ApprovalStatus, count(*) AS Hours, rv.LibrarianReviewed FROM Reservation rv INNER JOIN [Reservation-Room] ON rv.ReservationID = [Reservation-Room].ReservationID INNER JOIN Room ON [Reservation-Room].RoomID = Room.RoomID LEFT JOIN Librarian ON rv.LibrarianReviewed = Librarian.LibrarianID WHERE rv.StudentRegistered = '{mainUser.StudentID}' GROUP BY rv.ReservationID, RoomName, ApprovalStatus, rv.Pax, rv.LibrarianReviewed ORDER BY rv.ReservationID DESC");
            dr.Read(); 
            if (((string)dr["ApprovalStatus"]=="Approve"&&(DateTime)dr["Starting Time"] <= DateTime.Now) || (string)dr["ApprovalStatus"] == "Pending")
            {
                btnReserveRoom_LHomepage.Enabled = false;
            }
        }
    }
}
