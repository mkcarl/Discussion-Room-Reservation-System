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
    public partial class Form_Generate_Report : Form
    {
        public Form_Generate_Report()
        {
            InitializeComponent();
        }

        private void Generate_Report_Load(object sender, EventArgs e)
        {
            dsMonthlyReport ds = new dsMonthlyReport();
            dsMonthlyReportTableAdapters.ReservationTableAdapter datC = new dsMonthlyReportTableAdapters.ReservationTableAdapter();
            datC.Fill(ds.Reservation);
            MonthlyReport rpt = new MonthlyReport();
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
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
