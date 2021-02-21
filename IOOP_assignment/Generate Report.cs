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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string reportDir = $@"{Environment.CurrentDirectory}\Reports";
            string filename = $"Report-{mthCalendar.SelectionStart.ToString("ddMMMMyyyy")}";
            rd.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, $"{reportDir}\\{filename}.pdf");
            MessageBox.Show($"Report is saved to location {reportDir}\\{filename}");
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            string filename = $"Report-{mthCalendar.SelectionStart.ToString("ddMMMMyyyy")}";
            Attachment report = new Attachment(rd.ExportToStream(ExportFormatType.PortableDocFormat), $"{filename}.pdf");
            sendEmail("munkye29@gmail.com", "no.reply", "", report);
     
        }

        private void sendEmail(string receiverEmail, string subject, string body, Attachment report)
        {
            //https://stackoverflow.com/a/10784907
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("HJK.LDRRS@gmail.com");
            mail.To.Add(receiverEmail);
            mail.Subject = (subject);
            mail.Body = (body);

            System.Net.Mail.Attachment attachment;
            attachment = report;
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("HJK.LDRRS@gmail.com", "ioop2006");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}
