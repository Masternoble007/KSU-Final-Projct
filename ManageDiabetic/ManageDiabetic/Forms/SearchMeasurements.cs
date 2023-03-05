/* SearchMeasurements.cs
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
using ManageDiabetic.Classes;

namespace ManageDiabetic.Forms
{
    public partial class SearchMeasurements : Form
    {
        /// <summary>
        /// A list of measurements by time
        /// </summary>
        private List<TimeMeasurement> timeMeasurements;

        /// <summary>
        /// The classes method
        /// </summary>
        public SearchMeasurements()
        {
            InitializeComponent();
            timeMeasurements = new List<TimeMeasurement>();
            Init_Date();
        }

        /// <summary>
        /// Initializes the date
        /// </summary>
        private void Init_Date()
        {
            dtp_Date.Format = DateTimePickerFormat.Custom;
            dtp_Date.CustomFormat = "MM dd yyyy";
            dtp_Date.Value = DateTime.Now;
        }

        /// <summary>
        /// The search button takes what date you have chosen and looks for data on that date.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bn_Search_Click(object sender, EventArgs e)
        {
            DateTime date = dtp_Date.Value;
            timeMeasurements = DatabaseManagement.MeasurementsOnDate(date);
            DisplayMeasurements();
        }

        /// <summary>
        /// Closes the form to let you head back to the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Displays the measurements to the list view.
        /// </summary>
        private void DisplayMeasurements()
        {
            lv_Measurements.Items.Clear();
            dvg_Meals.Rows.Clear();

            foreach (TimeMeasurement tmp in timeMeasurements)
            {
                ListViewItem listViewItem = new ListViewItem(tmp.time.ToString("HH:mm"));
                listViewItem.SubItems.Add(tmp.measurement == 0 ? "/" : tmp.measurement.ToString());
                listViewItem.SubItems.Add(tmp.insulinAdded.Amount == 0 ? "/" : tmp.insulinAdded.Amount.ToString());
                listViewItem.SubItems.Add(tmp.insulinAdded.Insulin.Name);
                listViewItem.SubItems.Add(tmp.insulinAdded.Insulin.Brand);

                lv_Measurements.Items.Add(listViewItem);
            }
        }

        /// <summary>
 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lv_Measurements_SelectedIndexChanged(object sender, EventArgs e)
        {
            dvg_Meals.Rows.Clear();
            DataGridViewRow emptyRow = dvg_Meals.Rows[0];
            if (lv_Measurements.SelectedIndices.Count == 1)
            {
                string time = lv_Measurements.SelectedItems[0].Text;

                TimeMeasurement tmp = timeMeasurements.Find(item => item.matchTime(time));
                foreach (Meal meal in tmp.meals)
                {
                    DataGridViewRow rowToAdd = (DataGridViewRow)emptyRow.Clone();
                    rowToAdd.Cells[0].Value = meal.food.Name;
                    rowToAdd.Cells[1].Value = meal.food.Brand;
                    rowToAdd.Cells[2].Value = meal.food.Carbs;
                    rowToAdd.Cells[3].Value = meal.amount;
                    dvg_Meals.Rows.Add(rowToAdd);
                }
            }
        }
    }
}
