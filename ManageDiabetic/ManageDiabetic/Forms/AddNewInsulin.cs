/* AddNewInsulin.cs
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
    public partial class AddNewInsulin : Form
    {
        public AddNewInsulin()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string insulinName = tb_Name.Text.Trim();
            string insulinManur = tb_Manufacturer.Text.Trim();
            
            if (!CheckIfFormFieldsEmpty(insulinName, insulinManur))
            {
                InsulinType tmp = new InsulinType(insulinName.ToUpper(), insulinManur.ToUpper());
                
                if (AddMeasurement.insulinTypes.Contains(tmp))
                {
                    MessageBox.Show("This insulin is already on the list.", "It already exists.", MessageBoxButtons.OK);
                }
                else
                {
                    ep_AddNewInsulin.Clear();
                    AddMeasurement.insulinTypes.Add(tmp);
                    DatabaseManagement.InsertInsulinType(tmp);
                    this.DialogResult = DialogResult.OK;
                    
                }
            }
            
        }

        private bool CheckIfFormFieldsEmpty(string name, string brand)
        {
            ep_AddNewInsulin.Clear();
            bool errorSet = false;
            if (String.IsNullOrEmpty(name))
            {
                ep_AddNewInsulin.SetError(tb_Name, "Name for insulin is empty!");
                errorSet = true;

            }
            if (String.IsNullOrEmpty(brand))
            {
                ep_AddNewInsulin.SetError(tb_Manufacturer, "Name for insulin maker empty!");
                errorSet = true;
            }
            return errorSet;
        }
    }
}
