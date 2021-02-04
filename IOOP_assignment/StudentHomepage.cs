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
            frmReserve.FormClosed += FormReserve_Closed;
            frmReserve.Show();
        }

        private void FormReserve_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnModifyReservation_SHomepage_Click(object sender, EventArgs e)
        {
            FormModify frmMod= new FormModify();
            frmMod.FormClosed += FormModify_Closed;
            frmMod.Show();
        }

        private void FormModify_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnRequestStatus_SHomepage_Click(object sender, EventArgs e)
        {
            FormRequest frmReq = new FormRequest();
            frmReq.FormClosed += FormRequest_Closed;
            frmReq.Show();
        }
        
        private void FormRequest_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnLogout_SHomepage_Click(object sender, EventArgs e)
        {
            DialogResult reply;
            reply = MessageBox.Show("Do you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (reply == DialogResult.Yes)
            {
                formLogin frmLogin = new formLogin();
                this.Hide();
                frmLogin.Show();
            }
        }

        private void pbxProfilePic_SHomepage_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_SHomepage_Click(object sender, EventArgs e)
        {

        }
    }
}
