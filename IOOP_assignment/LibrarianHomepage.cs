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

        private void btnReserveRoom_LHomepage_Click(object sender, EventArgs e)
        {
            FormReserve frmReserve = new FormReserve();
            frmReserve.Show();
        }

        private void btnModifyReservation_LHomepage_Click(object sender, EventArgs e)
        {
            FormModify frmMod = new FormModify();
            frmMod.Show();
        }

        private void btnRequestStatus_LHomepage_Click(object sender, EventArgs e)
        {
            FormRequest frmReq = new FormRequest();
            frmReq.Show();
        }

        private void btnStudentRequest_LHomepage_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGenerateReport_LHomepage_Click(object sender, EventArgs e)
        {
            
        }
    }
}
