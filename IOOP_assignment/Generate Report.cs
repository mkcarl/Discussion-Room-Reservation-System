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
        DailyReport rpt;
        public Form_Generate_Report()
        {
            InitializeComponent();
        }

        private void Generate_Report_Load(object sender, EventArgs e)
        {
            //dsLibrary ds = new dsLibrary();
            //dsLibraryTableAdapters.ReservationTableAdapter datRV = new dsLibraryTableAdapters.ReservationTableAdapter();
            //datRV.Fill(ds.Reservation);
            //rpt = new DailyReport();
            //rpt.SetDataSource(ds);
            //crvDaily.ReportSource = rpt; 
            ReportDocument rpt = new ReportDocument();
            
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf;Integrated Security=True;Connect Timeout=30");
            sda = new SqlDataAdapter("select rr.ReservationID, rm.RoomName, MIN(rm.TimeSlot) as StartingTime, rv.ApprovalStatus ,rv.StudentRegistered, COUNT(rr.ReservationID) as Duration, rv.LibrarianReviewed as LibrarianID from [Reservation-Room] rr inner join Reservation rv on rr.ReservationID = rv.ReservationID inner join Room rm on rm.RoomID = rr.RoomID group by rr.ReservationID, rv.StudentRegistered, rm.RoomName, rv.LibrarianReviewed, rv.ApprovalStatus; ", conn);

            DataSet dst = new DataSet();
            sda.Fill(dst, "Reporting");
            rpt.Load(@"D:\Documents - HDD\VS2019 Files\Projects\IOOP_assignment\IOOP_assignment\DailyReport.rpt");
            rpt.SetDataSource(dst);
            crvDaily.ReportSource = rpt;

            
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
    }
}
