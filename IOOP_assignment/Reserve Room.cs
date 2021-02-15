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
    public partial class FormReserve : Form
    {
        public FormReserve()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboPeopleReserve_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(comboPeopleReserve.SelectedItem.ToString()) > 8)
            {
                radAmberReseve.Enabled = true;
                radBlackThornReserve.Enabled = false;
                radCedarReserve.Enabled = false;
                radDaphneReserve.Enabled = false;
            }

            else if ((int.Parse(comboPeopleReserve.SelectedItem.ToString()) < 8) && (int.Parse(comboPeopleReserve.SelectedItem.ToString()) > 4))
            {
                radAmberReseve.Enabled = true;
                radBlackThornReserve.Enabled = true;
                radCedarReserve.Enabled = false;
                radDaphneReserve.Enabled = false;
            }
            else if ((int.Parse(comboPeopleReserve.SelectedItem.ToString()) < 4) && (int.Parse(comboPeopleReserve.SelectedItem.ToString()) > 2))
            {
                radAmberReseve.Enabled = true;
                radBlackThornReserve.Enabled = true;
                radCedarReserve.Enabled = true;
                radDaphneReserve.Enabled = false;
            }
            else if ((int.Parse(comboPeopleReserve.SelectedItem.ToString()) < 2) && (int.Parse(comboPeopleReserve.SelectedItem.ToString()) > 0))
            {
                radAmberReseve.Enabled = false;
                radBlackThornReserve.Enabled = true;
                radCedarReserve.Enabled = true;
                radDaphneReserve.Enabled = true;
            }
        }

        private void monthCalendarReserve_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendarReserve.MinDate = DateTime.Now.AddDays(2);
            monthCalendarReserve.MaxDate = DateTime.Now.AddDays(7);

        }

        private void FormReserve_Load(object sender, EventArgs e)
        {
            

        }
    }
}
