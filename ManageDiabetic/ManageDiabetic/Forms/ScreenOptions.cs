/* ScreenOptions.cs
 * By Steven Avila
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageDiabetic.Forms;

namespace ManageDiabetic
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void bt_NewMeasurement_Click(object sender, EventArgs e)
        {
            AddMeasurement am = new AddMeasurement();
            am.Show();
        }

        private void bt_SearchMeasurement_Click(object sender, EventArgs e)
        {
            SearchMeasurements sm = new SearchMeasurements();
            sm.Show();
        }

        private void bt_CalculateInsulin_Click(object sender, EventArgs e)
        {
            InsulinDoseCalculator idc = new InsulinDoseCalculator();
            idc.Show();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
