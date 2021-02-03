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
    public partial class Add_User_Form : Form
    {
        public Add_User_Form()
        {
            InitializeComponent();
        }

        private void txtStudentIDUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowPassUser_Click(object sender, EventArgs e)
        {

        }

        private void btnUserBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            formStudentHomepage f2 = new formStudentHomepage();
            f2.Show();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            formStudentHomepage f1 = new formStudentHomepage();
            f1.Show();
        }

        private void txtPassUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkShowPassUser_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPassUser.Checked)
            {
                txtPassUser.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassUser.UseSystemPasswordChar = true;
            }
        }

        private void Add_User_Form_Load(object sender, EventArgs e)
        {
            txtPassUser.UseSystemPasswordChar = true;
        }
    }
}
