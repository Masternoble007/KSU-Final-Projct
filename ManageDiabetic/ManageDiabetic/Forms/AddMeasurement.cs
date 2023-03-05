/* AddMeasurement.cs
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
using ManageDiabetic.Forms;

namespace ManageDiabetic.Forms
{
    public partial class AddMeasurement : Form
    {
        public static List<InsulinType> insulinTypes;
        public static List<Food> foods;
        private List<Meal> meals;

        public AddMeasurement()
        {
            InitializeComponent();

            meals = new List<Meal>();
            insulinTypes = DatabaseManagement.LoadInsulinTypes();
            foods = DatabaseManagement.LoadFoodTypes();

            combo_Food.DataSource = foods;
            Init_Date();
            Init_Time();
            Init_combo_InsulinType();
        }

        private void bn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bn_Add_Click(object sender, EventArgs e)
        {
            if (!CheckForErrors())
            {

                int rowId = DatabaseManagement.InsertDateTime(dtp_Date.Value.Date, dtp_Time.Value);
                bool showSuccessInfo = false;
                if (cb_EnableMeasurement.Checked.Equals(true))
                {
                    DatabaseManagement.InsertMeasurement(rowId, Decimal.ToSingle(num_BGValue.Value));
                    showSuccessInfo = true;
                }
                if (cb_EnableInsulin.Checked.Equals(true))
                {
                    DatabaseManagement.InsertInsulinMeasurement(rowId, Decimal.ToInt32(num_InsulinAmount.Value), (InsulinType)combo_InsulinType.SelectedItem);
                    showSuccessInfo = true;
                }
                if (cb_EnableFood.Checked.Equals(true))
                {
                    foreach (Meal meal in meals)
                    {
                        DatabaseManagement.InsertMeal(rowId, meal);
                    }
                    showSuccessInfo = true;
                }
                if (showSuccessInfo)
                {
                    MessageBox.Show("Operation Completed", "Addition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool CheckForErrors()
        {
            ep_AddMeasurement.Clear();
            bool ErrorSet = false;
            if (cb_EnableMeasurement.Checked == true && num_BGValue.Value.Equals(0))
            {
                ep_AddMeasurement.SetError(num_BGValue, "Enter a value.");
                ErrorSet = true;
            }
            if (cb_EnableInsulin.Checked == true && num_InsulinAmount.Value.Equals(0))
            {
                ep_AddMeasurement.SetError(num_InsulinAmount, "Enter an amount.");
                ErrorSet = true;
            }
            if (cb_EnableFood.Checked == true && lv_Meals.Items.Count <= 0)
            {
                ep_AddMeasurement.SetError(cb_EnableFood, "You haven't added any food");
                ErrorSet = true;
            }
            return ErrorSet;
        }

        private void bn_RemoveMeal_Click(object sender, EventArgs e)
        {
            if (lv_Meals.SelectedIndices.Count != 0)
            {
                ListViewItem item = lv_Meals.SelectedItems[0];
                String food = item.SubItems[0].Text;
                String brand = item.SubItems[1].Text;
                float carbs = float.Parse(item.SubItems[2].Text);
                Food tmp = new Food(food, brand, carbs);
                for (int i = 0; i < meals.Count(); i++)
                {
                    if (meals[i].food.Equals(tmp))
                    {
                        meals.RemoveAt(i);
                        break;
                    }
                }
                lv_Meals.Items.Remove(lv_Meals.SelectedItems[0]);
            }
        }

        private void bn_AddMeal_Click(object sender, EventArgs e)
        {
            ep_AddMeasurement.Clear();
            if (combo_Food.SelectedIndex != -1)
            {
                if (num_MealAmount.Value.Equals(0))
                {
                    ep_AddMeasurement.SetError(num_MealAmount, "Enter a value.");
                }
                else
                {
                    Food tmp = (Food)combo_Food.SelectedItem;
                    if (meals.Any(item => item.food.Equals(tmp)))
                    {
                        MessageBox.Show("The food already exist in the list. If you want to change the amount, remove it first and add it again.");
                    }
                    else
                    {

                        meals.Add(new Meal(tmp, Decimal.ToInt32(num_MealAmount.Value)));

                        ListViewItem viewItem = new ListViewItem(tmp.ToArray());
                        viewItem.SubItems.Add(num_MealAmount.Value.ToString());
                        lv_Meals.Items.Add(viewItem);
                    }

                }

            }
        }

        private void bn_AddNewFood_Click(object sender, EventArgs e)
        {
            AddFood addFood = new AddFood();
            if (addFood.ShowDialog() == DialogResult.OK)
            {
                foods.Add(addFood.foodAdded);
                combo_Food.DataSource = null;
                combo_Food.DataSource = foods;
            }
        }

        private void cb_EnableFood_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_EnableFood.Checked == true)
            {
                combo_Food.Enabled = true;
                num_MealAmount.Enabled = true;
                bn_AddNewFood.Enabled = true;
                bn_AddMeal.Enabled = true;
                bn_RemoveMeal.Enabled = true;
            }
            else
            {
                combo_Food.Enabled = false;
                num_MealAmount.Enabled = false;
                bn_AddNewFood.Enabled = false;
                bn_AddMeal.Enabled = false;
                bn_RemoveMeal.Enabled = false;
            }
        }

        private void bn_AddNewInsulin_Click(object sender, EventArgs e)
        {
            AddNewInsulin addNewInsulin = new AddNewInsulin();
            if (addNewInsulin.ShowDialog() == DialogResult.OK)
            {
                combo_InsulinType.DataSource = null;
                Init_combo_InsulinType();
            }
        }

        private void Init_combo_InsulinType()
        {
            combo_InsulinType.DataSource = insulinTypes;
        }

        private void Init_Date()
        {
            dtp_Date.Format = DateTimePickerFormat.Custom;
            dtp_Date.CustomFormat = "MM dd yyyy";
            dtp_Date.Value = DateTime.Now;
        }
        private void Init_Time()
        {
            dtp_Time.Format = DateTimePickerFormat.Custom;
            dtp_Time.CustomFormat = "HH:mm";
            dtp_Time.Value = DateTime.Now;
            dtp_Time.ShowUpDown = true;
        }

        private void cb_EnableMeasurement_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_EnableMeasurement.Checked == true)
            {
                num_BGValue.Enabled = true;
            }
            else
            {
                num_BGValue.Enabled = false;
            }
        }

        private void cb_EnableInsulin_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_EnableInsulin.Checked == true)
            {
                combo_InsulinType.Enabled = true;
                num_InsulinAmount.Enabled = true;
                bn_AddNewInsulin.Enabled = true;
            }
            else
            {
                combo_InsulinType.Enabled = false;
                num_InsulinAmount.Enabled = false;
                bn_AddNewInsulin.Enabled = false;
            }
        }

        private void lb_Amount_Click(object sender, EventArgs e)
        {

        }
    }
}
