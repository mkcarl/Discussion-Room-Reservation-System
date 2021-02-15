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
            comboPeopleReserve.ToString.Text();

            if (comboPeopleReserve < 8)
            {

            }
            
        }

        private void monthCalendarReserve_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendarReserve.MinDate = DateTime.Now.AddDays(2);
            monthCalendarReserve.MaxDate = DateTime.Now.AddDays(7);

        }
    }
}
