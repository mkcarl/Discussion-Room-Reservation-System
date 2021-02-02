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
    public partial class formStudentHomepage : Form
    {
        public formStudentHomepage()
        {
            InitializeComponent();
        }

        private void btnReserveRoom_SHomepage_Click(object sender, EventArgs e)
        {
            FormReserve frmReserve = new FormReserve();
            frmReserve.Show();
        }

        private void btnModifyReservation_SHomepage_Click(object sender, EventArgs e)
        {
            FormModify frmMod = new FormModify();
            frmMod.Show();
        }

        private void btnRequestStatus_SHomepage_Click(object sender, EventArgs e)
        {
            FormRequest frmReq = new FormRequest();
            frmReq.Show();
        }

        private void btnLogout_SHomepage_Click(object sender, EventArgs e)
        {
            DialogResult reply;
            reply = MessageBox.Show("Do you want to logout the application?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (reply == DialogResult.Yes) 
            {
                MessageBox.Show("See You Again!");
                Application.Exit();
                
            }
        }
    }
}
