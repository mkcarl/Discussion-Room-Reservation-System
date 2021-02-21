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
        DailyReport rpt;
        public Form_Generate_Report()
        {
            InitializeComponent();
        }

        private void Generate_Report_Load(object sender, EventArgs e)
        {
            dsLibrary ds = new dsLibrary();
            dsLibraryTableAdapters.ReservationTableAdapter datRV = new dsLibraryTableAdapters.ReservationTableAdapter();
            datRV.Fill(ds.Reservation);
            rpt = new DailyReport();
            rpt.SetDataSource(ds);
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
