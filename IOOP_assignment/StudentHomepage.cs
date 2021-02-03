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

        private void pbxProfilePic_SHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_User_Form f1 = new Add_User_Form();
            f1.Show();
        }
    }
}
