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
using CrystalDecisions.CrystalReports.Engine;

namespace IOOP_assignment
{
    public partial class Form_Generate_Report : Form
    {
        SqlConnection conn;
        SqlDataAdapter sda;
        ReportDocument rd; 

        public Form_Generate_Report()
        {
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf;Integrated Security=True;Connect Timeout=30");

            InitializeComponent();
        }

        private void Generate_Report_Load(object sender, EventArgs e)
        {
            Reload_Report();
        }
        
        private void Reload_Report()
        {
            DateTime selectedDay = mthCalendar.SelectionStart;


            rd = new ReportDocument();

            sda = new SqlDataAdapter($"select rr.ReservationID, rm.RoomName, MIN(rm.TimeSlot) as StartingTime, rv.ApprovalStatus ,rv.StudentRegistered, COUNT(rr.ReservationID) as Duration, rv.LibrarianReviewed as LibrarianID from [Reservation-Room] rr inner join Reservation rv on rr.ReservationID = rv.ReservationID inner join Room rm on rm.RoomID = rr.RoomID where rm.TimeSlot >= '{selectedDay.ToString("yyyy-MM-dd")}' and rm.TimeSlot < '{selectedDay.AddDays(1).ToString("yyyy-MM-dd")}' group by rr.ReservationID, rv.StudentRegistered, rm.RoomName, rv.LibrarianReviewed, rv.ApprovalStatus; ", conn);

            DataSet dst = new DataSet();
            sda.Fill(dst, "Reporting");

            rd.Load($"{Environment.CurrentDirectory}\\..\\..\\DailyReport.rpt");
            rd.SetDataSource(dst);
            crvDaily.ReportSource = rd;


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLeftArrow_Click(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void mthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            Reload_Report();
        }
    }
}
