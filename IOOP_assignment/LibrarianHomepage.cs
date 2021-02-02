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

        private void formLibrarianHomepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_LHomepage_Click(object sender, EventArgs e)
        {
            DialogResult logoutConfirm = MessageBox.Show("Logout?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (logoutConfirm == DialogResult.Yes)
            {
                formLogin login = new formLogin();
                login.Show();
                this.Hide();
            }
        }
    }
}
