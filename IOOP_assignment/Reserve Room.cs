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
    public partial class FormReserve : Form
    {
        string roomname = "";
        string roomtype = "";

        public FormReserve()
        {
            InitializeComponent();
        }

        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboPeopleReserve_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(comboPeopleReserve.SelectedItem.ToString()) > 8)
            {
                radAmberReseve.Enabled = true;
                radBlackThornReserve.Enabled = false;
                radCedarReserve.Enabled = false;
                radDaphneReserve.Enabled = false;
            }

            else if ((int.Parse(comboPeopleReserve.SelectedItem.ToString()) <= 8) && (int.Parse(comboPeopleReserve.SelectedItem.ToString()) >= 4))
            {
                radAmberReseve.Enabled = true;
                radBlackThornReserve.Enabled = true;
                radCedarReserve.Enabled = false;
                radDaphneReserve.Enabled = false;
            }
            else if ((int.Parse(comboPeopleReserve.SelectedItem.ToString()) < 4) && (int.Parse(comboPeopleReserve.SelectedItem.ToString()) >= 2))
            {
                radAmberReseve.Enabled = true;
                radBlackThornReserve.Enabled = true;
                radCedarReserve.Enabled = true;
                radDaphneReserve.Enabled = true;
            }
            else if ((int.Parse(comboPeopleReserve.SelectedItem.ToString()) < 2) && (int.Parse(comboPeopleReserve.SelectedItem.ToString()) >= 0))
            {
                radAmberReseve.Enabled = false;
                radBlackThornReserve.Enabled = true;
                radCedarReserve.Enabled = true;
                radDaphneReserve.Enabled = true;
            }
        }
        private void monthCalendarReserve_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendarReserve.MinDate = DateTime.Now.AddDays(2);
            monthCalendarReserve.MaxDate = DateTime.Now.AddDays(7);
            //DateTime dt = DateTime.Parse(monthCalendarReserve.SelectionStart.ToString());
            

            //if (radAmberReseve.Checked == true)
            //{
            //    string roomtype = "Amber";
            //    SqlDataReader dr = Controller.Query($"Select distinct TimeSlot from Room where TimeSlot > '{dt.ToString("yyyy-MM-dd")}' and TimeSlot < '{dt.AddDays(1).ToString("yyyy-MM-dd")}' and BookStatus = 'Free' and RoomName Like '{roomtype}%'");

            //    if (dr.HasRows)
            //    {
            //        List<DateTime> timeslots;
            //        timeslots = (from IDataRecord r in dr select (DateTime)r["TimeSlot"]).ToList();
            //        comboTimeReserve.Items.Clear();

            //        foreach (DateTime time in timeslots)
            //        {

            //            comboTimeReserve.Items.Add(time.ToString("hh:mm tt"));
            //        }

            //    }

            //}
            //else if (radBlackThornReserve.Checked == true)
            //{
            //    string roomtype = "BlackThorn";
            //    SqlDataReader dr = Controller.Query($"Select distinct TimeSlot from Room where TimeSlot > '{dt.ToString("yyyy-MM-dd")}' and TimeSlot < '{dt.AddDays(1).ToString("yyyy-MM-dd")}' and BookStatus = 'Free' and RoomName Like '{roomtype}%'");

            //    dr.Read();

            //    if (dr.HasRows)
            //    {
            //        List<DateTime> timeslots;
            //        timeslots = (from IDataRecord r in dr select (DateTime)r["TimeSlot"]).ToList();
            //        comboTimeReserve.Items.Clear();

            //        foreach (DateTime time in timeslots)
            //        {
            //            comboTimeReserve.Items.Add(time.ToString("hh:mm tt"));
            //        }
            //        for (int i = 0; i < int.Parse(comboDurationReserve.SelectedItem.ToString())-1; i++)
            //        {
            //            comboTimeReserve.Items.RemoveAt(comboTimeReserve.Items.Count-1);
            //        }


            //    }
            //}
            //else if (radCedarReserve.Enabled == true)
            //{
            //    string roomtype = "Cedar";
            //    SqlDataReader dr = Controller.Query($"Select distinct TimeSlot from Room where TimeSlot > '{dt.ToString("yyyy-MM-dd")}' and TimeSlot < '{dt.AddDays(1).ToString("yyyy-MM-dd")}' and BookStatus = 'Free' and RoomName Like '{roomtype}%'");

            //    if (dr.HasRows)
            //    {
            //        List<DateTime> timeslots;
            //        timeslots = (from IDataRecord r in dr select (DateTime)r["TimeSlot"]).ToList();
            //        comboTimeReserve.Items.Clear();

            //        foreach (DateTime time in timeslots)
            //        {

            //            comboTimeReserve.Items.Add(time.ToString("hh:mm tt"));
            //        }

            //    }
            //}
            //else if (radDaphneReserve.Enabled == true)
            //{
            //    string roomtype = "Daphne";
            //    SqlDataReader dr = Controller.Query($"Select distinct TimeSlot from Room where TimeSlot > '{dt.ToString("yyyy-MM-dd")}' and TimeSlot < '{dt.AddDays(1).ToString("yyyy-MM-dd")}' and BookStatus = 'Free' and RoomName Like '{roomtype}%'");

            //    if (dr.HasRows)
            //    {
            //        List<DateTime> timeslots;
            //        timeslots = (from IDataRecord r in dr select (DateTime)r["TimeSlot"]).ToList();
            //        comboTimeReserve.Items.Clear();

            //        foreach (DateTime time in timeslots)
            //        {

            //            comboTimeReserve.Items.Add(time.ToString("hh:mm tt"));
            //        }

            //    }
            //}


        }

        private void FormReserve_Load(object sender, EventArgs e)
        {
            monthCalendarReserve.MinDate = DateTime.Now.AddDays(2);
            monthCalendarReserve.MaxDate = DateTime.Now.AddDays(7);
        }

        string timeSlot = string.Empty;
        private void comboDurationReserve_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var reserveDuration = new BindingList<KeyValuePair<string, string>>();

            //reserveDuration.Add(new KeyValuePair<string, string>("0", "1 hour"));
            //reserveDuration.Add(new KeyValuePair<string, string>("1", "2 hours"));
            //reserveDuration.Add(new KeyValuePair<string, string>("2", "3 hours"));
            //reserveDuration.Add(new KeyValuePair<string, string>("3", "4 hours"));
            //reserveDuration.Add(new KeyValuePair<string, string>("4", "5 hours"));
            //reserveDuration.Add(new KeyValuePair<string, string>("5", "6 hours"));

            //comboDurationReserve.DataSource = reserveDuration;
            //comboDurationReserve.ValueMember = "Key";
            //comboDurationReserve.DisplayMember = "Value";
            //comboDurationReserve.SelectedIndex = 0;

            //comboDurationReserve.SelectedIndex = comboDurationReserve.FindString(timeSlot, reserveDuration);
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

            dr.Read();

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


            }
        }

        
        private void btnConfirmReservation_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf;Integrated Security=True;Connect Timeout=30");


            conn.Open();

            string query = ("INSERT INTO Reservation-Room (RoomName) VALUES (@BookStatus)");

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@BookStatus", roomname);
            SqlDataReader reader = cmd.ExecuteReader();

            MessageBox.Show("Your room reservation is complete");

            conn.Close();
        }

        private void radAmberReseve_CheckedChanged(object sender, EventArgs e)
        {
            roomname = "Amber";
        }

        private void radBlackThornReserve_CheckedChanged(object sender, EventArgs e)
        {
            roomname = "Black Thorn";
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
