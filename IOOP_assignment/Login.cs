using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace IOOP_assignment
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void txtStudentID_Login_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtStudentID_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*pseudocode

           if input is number or backspace, accept input,
           else reject, then tell that you only can insert numbers

            */


            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))) // if the input is not number or a control like backspace
            {
                showErrorHint("Only accept number inputs", txtStudentID_Login); // show the hint 
                e.Handled = true; // stop the input
            }
            else if (txtStudentID_Login.Text.Length>=6) // if the input is more than 6 characters
            {
                if (!char.IsControl(e.KeyChar)) { 
                    e.Handled = true;
                    showErrorHint("Student ID is only 6 characters long.", txtStudentID_Login);
                }
                
            }
        }

        // TODO: move showHint() to Controller class. 
        private void showErrorHint(string message, Control control)
        {
            SystemSounds.Asterisk.Play();
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.Show(message, control, 150, -30, 500);

            // https://stackoverflow.com/questions/14695357/show-tooltip-on-textbox-entry
        }
    }
}
