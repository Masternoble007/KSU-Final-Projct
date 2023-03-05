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
    public partial class InsulinDoseCalculator : Form
    {
        /// <summary>
        /// Form's method in loading the form and A1c display.
        /// </summary>
        public InsulinDoseCalculator()
        {
            InitializeComponent();
            A1cDisplay();
        }

        /// <summary>
        /// Gives a display on what the A1c would roughly be with information given
        /// </summary>
        private void A1cDisplay()
        {
            float avg = DatabaseManagement.AvgBGMeasurement();
            double a1cToString = (avg + 46.7) / 28.7;
            lb_A1c.Text = Math.Round(a1cToString, 2).ToString();
        }

        /// <summary>
        /// Just a disclaimer on the forms usage.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_Disclaimer_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// To calculate the information that was given and gives a rough amound of insulin to give
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckForErrors((float)num_ratio.Value, (float)num_bg.Value))
            {
                float mealDose = (float)(num_carbs.Value * num_ratio.Value);
                float bgDose = (float)(((num_bg.Value - 120) * num_ratio.Value)/100);
                float totalDose = mealDose + bgDose;
                this.label_numDosage.Text = totalDose.ToString();
            }     
        }

        /// <summary>
        /// To check for errors that may occur in the form
        /// </summary>
        /// <param name="ratio">Insulin ratio of the person</param>
        /// <param name="bg">Blood sugar of the person</param>
        /// <returns></returns>
        private bool CheckForErrors(float ratio, float bg)
        {
            ep_InsulinDoseCalc.Clear();
            bool errorSet = false;
            if (ratio == 0 || ratio < 0.5)
            {
                ep_InsulinDoseCalc.SetError(num_ratio, "Please bring the ratio up at least 0.5");
                errorSet = true;

            }
            if (bg == 0 || bg <= 40)
            {
                ep_InsulinDoseCalc.SetError(num_bg, "Please enter a valid blood sugar number, or get to a hospital or eat something RIGHT NOW! Why on this application anyway?!");
                errorSet = true;
            }
            return errorSet;
        }
    }
}
