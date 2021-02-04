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
    public partial class formLibrarianHomepage : Form
    {
        public formLibrarianHomepage()
        {
            InitializeComponent();
        }

        private void btnLogout_LHomepage_Click(object sender, EventArgs e)
        {
            this.Close();

        private void btnReserveRoom_LHomepage_Click(object sender, EventArgs e)
        {
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
            Form_Generate_Report frmGenReport = new Form_Generate_Report();
            frmGenReport.FormClosed += Form_Generate_Report;
            frmGenReport.Show();
        }

        private void Form_Generate_Report(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        }
    }
}
