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
    public partial class FormReserve : Form
    {
        string roomname = "";
        string roomtype = "";
        Student mainUser;

        public FormReserve()
        {
            InitializeComponent();
        }

        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConfirmReservation.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboPeopleReserve_SelectedIndexChanged(object sender, EventArgs e)
        {
            // deselect all radio button 
            radAmberReseve.Checked = false;
            radBlackThornReserve.Checked = false;
            radCedarReserve.Checked = false;
            radDaphneReserve.Checked = false;

            if (int.Parse(comboPeopleReserve.SelectedItem.ToString()) > 8)
            {
                radAmberReseve.Enabled = true;
                radBlackThornReserve.Enabled = false;
                radCedarReserve.Enabled = false;
                radDaphneReserve.Enabled = false;
            }

            else if ((int.Parse(comboPeopleReserve.SelectedItem.ToString()) <= 8) && (int.Parse(comboPeopleReserve.SelectedItem.ToString()) > 4))
            {
                radAmberReseve.Enabled = true;
                radBlackThornReserve.Enabled = true;
                radCedarReserve.Enabled = false;
                radDaphneReserve.Enabled = false;
            }
            else if ((int.Parse(comboPeopleReserve.SelectedItem.ToString()) <= 4) && (int.Parse(comboPeopleReserve.SelectedItem.ToString()) > 2))
            {
                radAmberReseve.Enabled = true;
                radBlackThornReserve.Enabled = true;
                radCedarReserve.Enabled = true;
                radDaphneReserve.Enabled = false;
            }
            else if ((int.Parse(comboPeopleReserve.SelectedItem.ToString()) <= 2) && (int.Parse(comboPeopleReserve.SelectedItem.ToString()) > 0))
            {
                radAmberReseve.Enabled = true;
                radBlackThornReserve.Enabled = true;
                radCedarReserve.Enabled = true;
                radDaphneReserve.Enabled = true;
            }
            comboDurationReserve.Enabled = true;
        }
        private void monthCalendarReserve_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendarReserve.MinDate = DateTime.Now.AddDays(2);
            monthCalendarReserve.MaxDate = DateTime.Now.AddDays(7);
            comboPeopleReserve.Enabled = true; 

        }

        private void FormReserve_Load(object sender, EventArgs e)
        {
            
            if (Program.LoginRole == "Student")
            {
                mainUser = Program.StudentUser;
            }
            else
            {
                mainUser = Program.LibrarianUser;
            }
            monthCalendarReserve.MinDate = DateTime.Now.AddDays(2);
            monthCalendarReserve.MaxDate = DateTime.Now.AddDays(7);
            comboDurationReserve.Enabled = false;
            comboTimeReserve.Enabled = false;
            btnConfirmReservation.Enabled = false;
            comboPeopleReserve.Enabled = false;
            radAmberReseve.Enabled = false;
            radBlackThornReserve.Enabled = false;
            radCedarReserve.Enabled = false;
            radDaphneReserve.Enabled = false;

            // determine if they can make a reservation 
            SqlDataReader dr = Controller.Query($"SELECT TOP 1 rv.ReservationID, rv.Pax ,RoomName, Min(TimeSlot) AS 'Starting Time', ApprovalStatus, count(*) AS Hours, rv.LibrarianReviewed FROM Reservation rv INNER JOIN [Reservation-Room] ON rv.ReservationID = [Reservation-Room].ReservationID INNER JOIN Room ON [Reservation-Room].RoomID = Room.RoomID LEFT JOIN Librarian ON rv.LibrarianReviewed = Librarian.LibrarianID WHERE rv.StudentRegistered = '{mainUser.StudentID}' GROUP BY rv.ReservationID, RoomName, ApprovalStatus, rv.Pax, rv.LibrarianReviewed ORDER BY rv.ReservationID DESC");
            dr.Read();
            if (dr.HasRows)
            {
                if (((string)dr["ApprovalStatus"] == "Approve" && DateTime.Now <= (DateTime)dr["Starting Time"]) || (string)dr["ApprovalStatus"] == "Pending")
                {
                    MessageBox.Show("A reservation has already been made.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }


        }

        string timeSlot = string.Empty;
        private void comboDurationReserve_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radAmberReseve.Checked)
            {
                roomtype = "Amber";
            }
            else if (radBlackThornReserve.Checked)
            {
                roomtype = "BlackThorn";
            }
            else if (radCedarReserve.Checked)
            {
                roomtype = "Cedar";
            }
            else if (radDaphneReserve.Checked)
            {
                roomtype = "Daphne";
            }


            DateTime dt = DateTime.Parse(monthCalendarReserve.SelectionStart.ToString());
            SqlDataReader dr = Controller.Query($"Select distinct TimeSlot from Room where TimeSlot > '{dt.ToString("yyyy-MM-dd")}' and TimeSlot < '{dt.AddDays(1).ToString("yyyy-MM-dd")}' and BookStatus = 'Free' and RoomName Like '{roomtype}%'");

            if (dr.HasRows)
            {
                List<DateTime> timeslots;
                timeslots = (from IDataRecord r in dr select (DateTime)r["TimeSlot"]).ToList();
                comboTimeReserve.Items.Clear();

                foreach (DateTime time in timeslots)
                {
                    comboTimeReserve.Items.Add(time.ToString("hh:mm tt"));
                }
                for (int i = 0; i < int.Parse(comboDurationReserve.SelectedItem.ToString()) - 1; i++)
                {
                    comboTimeReserve.Items.RemoveAt(comboTimeReserve.Items.Count - 1);
                }
            comboTimeReserve.Enabled = true;
            }
        }

        
        private void btnConfirmReservation_Click(object sender, EventArgs e)
        {
            DateTime date = monthCalendarReserve.SelectionStart;
            string time = comboTimeReserve.SelectedItem.ToString();
            int pax = int.Parse(comboPeopleReserve.SelectedItem.ToString());
            int duration = int.Parse(comboDurationReserve.SelectedItem.ToString()); 

            bool reservationMade = mainUser.MakeNewReservation(date , time, pax, duration, roomname);
            if (reservationMade)
            {
                MessageBox.Show("Your room reservation is complete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Sorry, please choose another timeslot or room as your current choice is fully booked.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void radAmberReseve_CheckedChanged(object sender, EventArgs e)
        {
            roomname = "Amber";
        }

        private void radBlackThornReserve_CheckedChanged(object sender, EventArgs e)
        {
            roomname = "BlackThorn";
        }

        private void radCedarReserve_CheckedChanged(object sender, EventArgs e)
        {
            roomname = "Cedar";
        }

        private void radDaphneReserve_CheckedChanged(object sender, EventArgs e)
        {
            roomname = "Daphne";
        }
    }
}
