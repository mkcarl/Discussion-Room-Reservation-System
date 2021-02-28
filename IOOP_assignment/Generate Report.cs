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
using System.Net.Mail;
using CrystalDecisions.Shared;
using System.Globalization;

namespace IOOP_assignment
{
    public partial class Form_Generate_Report : Form
    {
        SqlConnection conn;
        SqlDataAdapter sda;
        ReportDocument rdDaily;
        ReportDocument rdMonthly;
        int selectedMonth;
        Librarian mainUser; 

        public Form_Generate_Report()
        {
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf;Integrated Security=True;Connect Timeout=30");

            InitializeComponent();
        }

        private void Generate_Report_Load(object sender, EventArgs e)
        {
            mainUser = Program.LibrarianUser;
            DateTime selectedDay = mthCalendar.SelectionStart;
            Reload_Report_Daily(selectedDay, selectedDay.AddDays(1));
            lblYear.Text = DateTime.Now.Year.ToString();
        }

        private void Reload_Report_Daily(DateTime start, DateTime end)
        {
            // https://www.youtube.com/watch?v=iSNIOPeCiuw&ab_channel=codefactory2016
            // https://www.youtube.com/watch?v=HwfI6gUz2e4&ab_channel=SwiftLearn
            rdDaily = new ReportDocument();

            sda = new SqlDataAdapter($"select rr.ReservationID, rm.RoomName, MIN(rm.TimeSlot) as StartingTime, rv.ApprovalStatus ,rv.StudentRegistered, COUNT(rr.ReservationID) as Duration, rv.LibrarianReviewed as LibrarianID from [Reservation-Room] rr inner join Reservation rv on rr.ReservationID = rv.ReservationID inner join Room rm on rm.RoomID = rr.RoomID where rm.TimeSlot >= '{start.ToString("yyyy-MM-dd")}' and rm.TimeSlot < '{end.ToString("yyyy-MM-dd")}' group by rr.ReservationID, rv.StudentRegistered, rm.RoomName, rv.LibrarianReviewed, rv.ApprovalStatus; ", conn);

            DataSet dst = new DataSet();
            sda.Fill(dst, "Reporting");

            rdDaily.Load($"{Environment.CurrentDirectory}\\..\\..\\DailyReport.rpt");
            rdDaily.SetDataSource(dst);
            rdDaily.SetParameterValue("targetdate", start);
            rdDaily.SetParameterValue("librarian", $"{mainUser.Surname} {mainUser.GivenName} ({mainUser.LibrarianID})");
            crvDaily.ReportSource = rdDaily;
        }

        private void Reload_Report_Monthly(DateTime start, DateTime end)
        {
            rdMonthly = new ReportDocument();

            sda = new SqlDataAdapter($"select rr.ReservationID, rm.RoomName, MIN(rm.TimeSlot) as StartingTime, rv.ApprovalStatus ,rv.StudentRegistered, COUNT(rr.ReservationID) as Duration, rv.LibrarianReviewed as LibrarianID from [Reservation-Room] rr inner join Reservation rv on rr.ReservationID = rv.ReservationID inner join Room rm on rm.RoomID = rr.RoomID where rm.TimeSlot >= '{start.ToString("yyyy-MM-dd")}' and rm.TimeSlot < '{end.ToString("yyyy-MM-dd")}' group by rr.ReservationID, rv.StudentRegistered, rm.RoomName, rv.LibrarianReviewed, rv.ApprovalStatus; ", conn);

            DataSet dst = new DataSet();
            sda.Fill(dst, "Reporting");

            rdMonthly.Load($"{Environment.CurrentDirectory}\\..\\..\\MonthlyReport.rpt");
            rdMonthly.SetDataSource(dst);
            rdMonthly.SetParameterValue("targetdate", start);
            rdMonthly.SetParameterValue("librarian", $"{mainUser.Surname} {mainUser.GivenName} ({mainUser.LibrarianID})");
            crvMonthly.ReportSource = rdMonthly;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string reportDir = $@"{Environment.CurrentDirectory}\Reports";
            string filename = $"Report-{mthCalendar.SelectionStart.ToString("ddMMMMyyyy")}";
            rdDaily.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, $"{reportDir}\\{filename}.pdf");
            MessageBox.Show($"Report is saved to location {reportDir}\\{filename}");
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            string filename = $"Report-{mthCalendar.SelectionStart.ToString("ddMMMMyyyy")}";
            Attachment report = new Attachment(rdDaily.ExportToStream(ExportFormatType.PortableDocFormat), $"{filename}.pdf"); //https://www.aspsnippets.com/Articles/Export-Crystal-Report-to-PDF-and-send-as-Email-Attachment-in-ASPNet.aspx
            mainUser.SendEmail("no.reply", "", report);
            MessageBox.Show($"Report is sent to: {mainUser.Email}");

        }

        private void btnLeftArrow_Click(object sender, EventArgs e)
        {
            lblYear.Text = (int.Parse(lblYear.Text) - 1).ToString();
        }

        private void btnRightArrow_Click(object sender, EventArgs e)
        {
            lblYear.Text = (int.Parse(lblYear.Text) + 1).ToString();
        }

        private void btnJan_Click(object sender, EventArgs e)
        {
            selectedMonth = 1;
            DateTime targetMonth = DateTime.ParseExact($"{lblYear.Text}-{selectedMonth.ToString("00")}-01 00:00", "yyyy-MM-dd hh:mm", CultureInfo.InvariantCulture);
            Reload_Report_Monthly(targetMonth, targetMonth.AddMonths(1));
        }

        private void btnFeb_Click(object sender, EventArgs e)
        {
            selectedMonth = 2;
            DateTime targetMonth = DateTime.ParseExact($"{lblYear.Text}-{selectedMonth.ToString("00")}-01 00:00", "yyyy-MM-dd hh:mm", CultureInfo.InvariantCulture);
            Reload_Report_Monthly(targetMonth, targetMonth.AddMonths(1));
        }

        private void btnMar_Click(object sender, EventArgs e)
        {
            selectedMonth = 3;
            DateTime targetMonth = DateTime.ParseExact($"{lblYear.Text}-{selectedMonth.ToString("00")}-01 00:00", "yyyy-MM-dd hh:mm", CultureInfo.InvariantCulture);
            Reload_Report_Monthly(targetMonth, targetMonth.AddMonths(1));
        }

        private void btnApr_Click(object sender, EventArgs e)
        {
            selectedMonth = 4;
            DateTime targetMonth = DateTime.ParseExact($"{lblYear.Text}-{selectedMonth.ToString("00")}-01 00:00", "yyyy-MM-dd hh:mm", CultureInfo.InvariantCulture);
            Reload_Report_Monthly(targetMonth, targetMonth.AddMonths(1));
        }

        private void btnMay_Click(object sender, EventArgs e)
        {
            selectedMonth = 5;
            DateTime targetMonth = DateTime.ParseExact($"{lblYear.Text}-{selectedMonth.ToString("00")}-01 00:00", "yyyy-MM-dd hh:mm", CultureInfo.InvariantCulture);
            Reload_Report_Monthly(targetMonth, targetMonth.AddMonths(1));
        }

        private void btnJun_Click(object sender, EventArgs e)
        {
            selectedMonth = 6;
            DateTime targetMonth = DateTime.ParseExact($"{lblYear.Text}-{selectedMonth.ToString("00")}-01 00:00", "yyyy-MM-dd hh:mm", CultureInfo.InvariantCulture);
            Reload_Report_Monthly(targetMonth, targetMonth.AddMonths(1));
        }

        private void btnJul_Click(object sender, EventArgs e)
        {
            selectedMonth = 7;
            DateTime targetMonth = DateTime.ParseExact($"{lblYear.Text}-{selectedMonth.ToString("00")}-01 00:00", "yyyy-MM-dd hh:mm", CultureInfo.InvariantCulture);
            Reload_Report_Monthly(targetMonth, targetMonth.AddMonths(1));
        }

        private void btnAug_Click(object sender, EventArgs e)
        {
            selectedMonth = 8;
            DateTime targetMonth = DateTime.ParseExact($"{lblYear.Text}-{selectedMonth.ToString("00")}-01 00:00", "yyyy-MM-dd hh:mm", CultureInfo.InvariantCulture);
            Reload_Report_Monthly(targetMonth, targetMonth.AddMonths(1));
        }

        private void btnSep_Click(object sender, EventArgs e)
        {
            selectedMonth = 9;
            DateTime targetMonth = DateTime.ParseExact($"{lblYear.Text}-{selectedMonth.ToString("00")}-01 00:00", "yyyy-MM-dd hh:mm", CultureInfo.InvariantCulture);
            Reload_Report_Monthly(targetMonth, targetMonth.AddMonths(1));
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            selectedMonth = 10;
            DateTime targetMonth = DateTime.ParseExact($"{lblYear.Text}-{selectedMonth.ToString("00")}-01 00:00", "yyyy-MM-dd hh:mm", CultureInfo.InvariantCulture);
            Reload_Report_Monthly(targetMonth, targetMonth.AddMonths(1));
        }

        private void btnNov_Click(object sender, EventArgs e)
        {
            selectedMonth = 11;
            DateTime targetMonth = DateTime.ParseExact($"{lblYear.Text}-{selectedMonth.ToString("00")}-01 00:00", "yyyy-MM-dd hh:mm", CultureInfo.InvariantCulture);
            Reload_Report_Monthly(targetMonth, targetMonth.AddMonths(1));
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            selectedMonth = 12;
            DateTime targetMonth = DateTime.ParseExact($"{lblYear.Text}-{selectedMonth.ToString("00")}-01 00:00", "yyyy-MM-dd hh:mm", CultureInfo.InvariantCulture);
            Reload_Report_Monthly(targetMonth, targetMonth.AddMonths(1));
        }

        private void btnSaveMonthly_Click(object sender, EventArgs e)
        {
            string reportDir = $@"{Environment.CurrentDirectory}\Reports";
            DateTime targetMonth = DateTime.ParseExact($"{lblYear.Text}-{selectedMonth.ToString("00")}-01 00:00", "yyyy-MM-dd hh:mm", CultureInfo.InvariantCulture);
            string filename = $"Report-{targetMonth.ToString("MMMMyyyy")}";
            rdMonthly.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, $"{reportDir}\\{filename}.pdf");
            MessageBox.Show($"Report is saved to location {reportDir}\\{filename}");
        }

        private void btnEmailMonthly_Click(object sender, EventArgs e)
        {
            string filename = $"Report-{mthCalendar.SelectionStart.ToString("MMMMyyyy")}";
            Attachment report = new Attachment(rdMonthly.ExportToStream(ExportFormatType.PortableDocFormat), $"{filename}.pdf"); //https://www.aspsnippets.com/Articles/Export-Crystal-Report-to-PDF-and-send-as-Email-Attachment-in-ASPNet.aspx
            mainUser.SendEmail("no.reply", "", report);
            MessageBox.Show($"Report is sent to: {mainUser.Email}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime selectedDay = mthCalendar.SelectionStart;
            Reload_Report_Daily(selectedDay, selectedDay.AddDays(1));
        }
    }
}
