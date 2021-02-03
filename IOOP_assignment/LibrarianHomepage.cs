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

        private void pbxProfilePic_LHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_User_Form f1 = new Add_User_Form();
            f1.FormClosed += f1_Closed;
            f1.Show();
        }
        private void f1_Closed(object senser, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
