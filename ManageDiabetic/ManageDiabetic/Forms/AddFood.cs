/* AddFood.cs
 * By Steven Avila
*/
using ManageDiabetic.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageDiabetic
{
    public partial class AddFood : Form
    {
        public Food foodAdded { get; set; }

        public AddFood()
        {
            InitializeComponent();
        }

        private bool FormFieldsEmptyCheck(string name, string brand)
        {
            bool errorSet = false;
            ep_AddFood.Clear();
            if (string.IsNullOrEmpty(name))
            {
                ep_AddFood.SetError(uxName, "Name is empty!");
                errorSet = true;
            }
            if (string.IsNullOrEmpty(brand))
            {
                ep_AddFood.SetError(uxBrand, "Brand is entered!");
                errorSet = true;
            }
            return errorSet;
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void uxAdd_Click(object sender, EventArgs e)
        {
            string name = uxName.Text.Trim();
            string brand = uxBrand.Text.Trim();

            if (!FormFieldsEmptyCheck(name, brand))
            {
                foodAdded = new Food(name, brand, Decimal.ToSingle(uxCarbs.Value));
                DatabaseManagement.InsertFoodType(foodAdded);
                ep_AddFood.Clear();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
