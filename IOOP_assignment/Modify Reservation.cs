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
        string approvalStatus; 

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

            SqlDataReader dr = Controller.Query($"SELECT TOP 1 rv.ReservationID, rv.Pax ,RoomName, Min(TimeSlot) AS 'Starting Time', ApprovalStatus, count(*) AS Hours, rv.LibrarianReviewed FROM Reservation rv INNER JOIN [Reservation-Room] ON rv.ReservationID = [Reservation-Room].ReservationID INNER JOIN Room ON [Reservation-Room].RoomID = Room.RoomID LEFT JOIN Librarian ON rv.LibrarianReviewed = Librarian.LibrarianID WHERE rv.StudentRegistered = '{mainUser.StudentID}' GROUP BY rv.ReservationID, RoomName, ApprovalStatus, rv.Pax, rv.LibrarianReviewed ORDER BY rv.ReservationID DESC");

            dr.Read();

            if (dr.HasRows && dr["ApprovalStatus"].ToString() != "Cancel" && dr["ApprovalStatus"].ToString() != "Reject")
            {
                DateTime dtime = (DateTime)dr["Starting Time"];
                lblNoPeopleCurrentModify.Text = "Number of People: " + dr["Pax"].ToString();
                lblDateCurrentModify.Text = "Date: " + dtime.ToString("dd MMMM yyyy");
                lblTimeCurrentModify.Text = "Time: " + dtime.ToString("hh:mm tt");
                lblRoomCurrentModify.Text = "Room Name: " + dr["RoomName"].ToString();
                comboPeopleNewModify.Enabled = false;
                comboTimeNewModify.Enabled = false;
                radAmberNewModify.Enabled = false;
                radBlackThornNewModify.Enabled = false;
                radCedarNewModify.Enabled = false;
                radDaphneNewModify.Enabled = false;
                btnConfirmModification.Enabled = false;
                if (dr["ApprovalStatus"].ToString() == "Approve" ? mthCalendarNewModify.Enabled = false : mthCalendarNewModify.Enabled = true) ;
            }
            else
            {
                MessageBox.Show("No Reservations found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                comboPeopleNewModify.Enabled = true; 
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


            mainUser.ModifyReservation(newtime, roomchoice);
            
            MessageBox.Show("Your request have been modified.", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        private void comboPeopleNewModify_SelectedIndexChanged(object sender, EventArgs e)
        {
            // deselect all radio button 
            radAmberNewModify.Checked = false;
            radBlackThornNewModify.Checked = false;
            radCedarNewModify.Checked = false;
            radDaphneNewModify.Checked = false;

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
            btnConfirmModification.Enabled = true;
        }

        private void btnResetModify_Click(object sender, EventArgs e)
        {
            mainUser.CancelCurrentReservation(); 
            MessageBox.Show("Your booking have been successfully cancelled.");
            this.Close();
            }

        private void radAmberNewModify_CheckedChanged(object sender, EventArgs e)
        {
            comboTimeNewModify.Enabled = true; 
        }

        private void radBlackThornNewModify_CheckedChanged(object sender, EventArgs e)
        {
            comboTimeNewModify.Enabled = true;

        }

        private void radCedarNewModify_CheckedChanged(object sender, EventArgs e)
        {
            comboTimeNewModify.Enabled = true;

        }

        private void radDaphneNewModify_CheckedChanged(object sender, EventArgs e)
        {
            comboTimeNewModify.Enabled = true;

        }
    }
    }
