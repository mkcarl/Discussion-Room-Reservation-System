using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IOOP_assignment
{
    public partial class FormModify : Form
    {
        

        public FormModify()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormModify_Load(object sender, EventArgs e)
        {
            mthCalendarNewModify.MinDate = DateTime.Now.AddDays(2);
            mthCalendarNewModify.MaxDate = DateTime.Now.AddDays(7);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mthCalendarNewModify_DateChanged(object sender, DateRangeEventArgs e)
        {

            
        }

        private void btnConfirmModification_Click(object sender, EventArgs e)
        {
            
        }

        private void lblCurrentTitleModify_Click(object sender, EventArgs e)
        {
            
        }

        private void lblDateCurrentModify_Click(object sender, EventArgs e)
        {
            
        }

        private void lblTimeCurrentModify_Click(object sender, EventArgs e)
        {
          
        }

        private void lblNoPeopleCurrentModify_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\library_discussion_room.mdf=;Integrated Security = True; Connect Timeout = 30");

            //con.Open();

            //SqlCommand cmd = new SqlCommand("SELECT Pax FROM Reservation where StudentRegistered = @StudentID", con);
            //SqlDataReader dr = cmd.ExecuteReader();
            ////cmd.Parameters.AddWithValue("@StudentID", 100003);
            SqlDataReader dr = Controller.Query("SELECT Pax FROM Reservation where StudentRegistered = 100003");
            dr.Read();

            if (dr.HasRows)
            {
                lblNoPeopleCurrentModify.Text = dr["Pax"].ToString();
               
            }
          

            //con.Close();


        }

        private void radAmberNewModify_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void comboPeopleNewModify_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int.Parse(comboPeopleNewModify.SelectedItem.ToString()) >= 2) && (int.Parse(comboPeopleNewModify.SelectedItem.ToString())<4))
            {
                radDaphneNewModify.Enabled = true;
                radCedarNewModify.Enabled = true;
                radBlackThornNewModify.Enabled = true;
                radAmberNewModify.Enabled = true;
            }

            else if ((int.Parse(comboPeopleNewModify.SelectedItem.ToString()) >= 2) && (int.Parse(comboPeopleNewModify.SelectedItem.ToString()) <8))
            {
                radDaphneNewModify.Enabled = false;
                radCedarNewModify.Enabled = true;
                radBlackThornNewModify.Enabled = true;
                radAmberNewModify.Enabled = true;
            }

            else if ((int.Parse(comboPeopleNewModify.SelectedItem.ToString()) >= 2) && (int.Parse(comboPeopleNewModify.SelectedItem.ToString()) < 10))
            {
                radDaphneNewModify.Enabled = false;
                radCedarNewModify.Enabled = false;
                radBlackThornNewModify.Enabled = true;
                radAmberNewModify.Enabled = true;
            }
            
            else if ((int.Parse(comboPeopleNewModify.SelectedItem.ToString()) >= 2))
            {
                radDaphneNewModify.Enabled = false;
                radCedarNewModify.Enabled = false;
                radBlackThornNewModify.Enabled = false;
                radAmberNewModify.Enabled = true;
            }
        }

        private void comboTimeNewModify_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnResetModify_Click(object sender, EventArgs e)
        {
            


        }
    }
}
