
namespace ManageDiabetic.Forms
{
    partial class AddMeasurement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gb_TimeDate = new System.Windows.Forms.GroupBox();
            this.dtp_Time = new System.Windows.Forms.DateTimePicker();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lb_Time = new System.Windows.Forms.Label();
            this.lb_Date = new System.Windows.Forms.Label();
            this.gb_BGMeasurement = new System.Windows.Forms.GroupBox();
            this.num_BGValue = new System.Windows.Forms.NumericUpDown();
            this.lb_BGValue = new System.Windows.Forms.Label();
            this.cb_EnableMeasurement = new System.Windows.Forms.CheckBox();
            this.gb_Insulin = new System.Windows.Forms.GroupBox();
            this.bn_AddNewInsulin = new System.Windows.Forms.Button();
            this.combo_InsulinType = new System.Windows.Forms.ComboBox();
            this.num_InsulinAmount = new System.Windows.Forms.NumericUpDown();
            this.lb_InsulinAmount = new System.Windows.Forms.Label();
            this.lb_InsulinType = new System.Windows.Forms.Label();
            this.cb_EnableInsulin = new System.Windows.Forms.CheckBox();
            this.gb_Food = new System.Windows.Forms.GroupBox();
            this.lv_Meals = new System.Windows.Forms.ListView();
            this.col_Food = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Carbs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bn_AddMeal = new System.Windows.Forms.Button();
            this.bn_RemoveMeal = new System.Windows.Forms.Button();
            this.num_MealAmount = new System.Windows.Forms.NumericUpDown();
            this.combo_Food = new System.Windows.Forms.ComboBox();
            this.bn_AddNewFood = new System.Windows.Forms.Button();
            this.lb_Amount = new System.Windows.Forms.Label();
            this.lb_Food = new System.Windows.Forms.Label();
            this.cb_EnableFood = new System.Windows.Forms.CheckBox();
            this.bn_Add = new System.Windows.Forms.Button();
            this.bn_Cancel = new System.Windows.Forms.Button();
            this.ep_AddMeasurement = new System.Windows.Forms.ErrorProvider(this.components);
            this.gb_TimeDate.SuspendLayout();
            this.gb_BGMeasurement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_BGValue)).BeginInit();
            this.gb_Insulin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_InsulinAmount)).BeginInit();
            this.gb_Food.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_MealAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_AddMeasurement)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_TimeDate
            // 
            this.gb_TimeDate.Controls.Add(this.dtp_Time);
            this.gb_TimeDate.Controls.Add(this.dtp_Date);
            this.gb_TimeDate.Controls.Add(this.lb_Time);
            this.gb_TimeDate.Controls.Add(this.lb_Date);
            this.gb_TimeDate.Location = new System.Drawing.Point(539, 12);
            this.gb_TimeDate.Name = "gb_TimeDate";
            this.gb_TimeDate.Size = new System.Drawing.Size(249, 88);
            this.gb_TimeDate.TabIndex = 0;
            this.gb_TimeDate.TabStop = false;
            this.gb_TimeDate.Text = "Time and Date";
            // 
            // dtp_Time
            // 
            this.dtp_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_Time.Location = new System.Drawing.Point(53, 54);
            this.dtp_Time.Name = "dtp_Time";
            this.dtp_Time.Size = new System.Drawing.Size(170, 20);
            this.dtp_Time.TabIndex = 3;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(53, 29);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(170, 20);
            this.dtp_Date.TabIndex = 2;
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Time.Location = new System.Drawing.Point(7, 54);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(41, 15);
            this.lb_Time.TabIndex = 1;
            this.lb_Time.Text = "Time: ";
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Date.Location = new System.Drawing.Point(7, 29);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(39, 15);
            this.lb_Date.TabIndex = 0;
            this.lb_Date.Text = "Date: ";
            // 
            // gb_BGMeasurement
            // 
            this.gb_BGMeasurement.Controls.Add(this.num_BGValue);
            this.gb_BGMeasurement.Controls.Add(this.lb_BGValue);
            this.gb_BGMeasurement.Controls.Add(this.cb_EnableMeasurement);
            this.gb_BGMeasurement.Location = new System.Drawing.Point(539, 106);
            this.gb_BGMeasurement.Name = "gb_BGMeasurement";
            this.gb_BGMeasurement.Size = new System.Drawing.Size(249, 94);
            this.gb_BGMeasurement.TabIndex = 1;
            this.gb_BGMeasurement.TabStop = false;
            this.gb_BGMeasurement.Text = "Blood Sugar Measurement";
            // 
            // num_BGValue
            // 
            this.num_BGValue.Location = new System.Drawing.Point(75, 61);
            this.num_BGValue.Name = "num_BGValue";
            this.num_BGValue.Size = new System.Drawing.Size(120, 20);
            this.num_BGValue.TabIndex = 2;
            // 
            // lb_BGValue
            // 
            this.lb_BGValue.AutoSize = true;
            this.lb_BGValue.Location = new System.Drawing.Point(10, 61);
            this.lb_BGValue.Name = "lb_BGValue";
            this.lb_BGValue.Size = new System.Drawing.Size(58, 13);
            this.lb_BGValue.TabIndex = 1;
            this.lb_BGValue.Text = "BG Value: ";
            // 
            // cb_EnableMeasurement
            // 
            this.cb_EnableMeasurement.AutoSize = true;
            this.cb_EnableMeasurement.Location = new System.Drawing.Point(10, 20);
            this.cb_EnableMeasurement.Name = "cb_EnableMeasurement";
            this.cb_EnableMeasurement.Size = new System.Drawing.Size(131, 17);
            this.cb_EnableMeasurement.TabIndex = 0;
            this.cb_EnableMeasurement.Text = "Blood Glucose Value?";
            this.cb_EnableMeasurement.UseVisualStyleBackColor = true;
            this.cb_EnableMeasurement.CheckedChanged += new System.EventHandler(this.cb_EnableMeasurement_CheckedChanged);
            // 
            // gb_Insulin
            // 
            this.gb_Insulin.Controls.Add(this.bn_AddNewInsulin);
            this.gb_Insulin.Controls.Add(this.combo_InsulinType);
            this.gb_Insulin.Controls.Add(this.num_InsulinAmount);
            this.gb_Insulin.Controls.Add(this.lb_InsulinAmount);
            this.gb_Insulin.Controls.Add(this.lb_InsulinType);
            this.gb_Insulin.Controls.Add(this.cb_EnableInsulin);
            this.gb_Insulin.Location = new System.Drawing.Point(539, 206);
            this.gb_Insulin.Name = "gb_Insulin";
            this.gb_Insulin.Size = new System.Drawing.Size(249, 158);
            this.gb_Insulin.TabIndex = 1;
            this.gb_Insulin.TabStop = false;
            this.gb_Insulin.Text = "Insulin";
            // 
            // bn_AddNewInsulin
            // 
            this.bn_AddNewInsulin.Location = new System.Drawing.Point(122, 109);
            this.bn_AddNewInsulin.Name = "bn_AddNewInsulin";
            this.bn_AddNewInsulin.Size = new System.Drawing.Size(94, 43);
            this.bn_AddNewInsulin.TabIndex = 6;
            this.bn_AddNewInsulin.Text = "Add New Insulin";
            this.bn_AddNewInsulin.UseVisualStyleBackColor = true;
            this.bn_AddNewInsulin.Click += new System.EventHandler(this.bn_AddNewInsulin_Click);
            // 
            // combo_InsulinType
            // 
            this.combo_InsulinType.FormattingEnabled = true;
            this.combo_InsulinType.Location = new System.Drawing.Point(95, 49);
            this.combo_InsulinType.Name = "combo_InsulinType";
            this.combo_InsulinType.Size = new System.Drawing.Size(121, 21);
            this.combo_InsulinType.TabIndex = 5;
            // 
            // num_InsulinAmount
            // 
            this.num_InsulinAmount.Location = new System.Drawing.Point(96, 82);
            this.num_InsulinAmount.Name = "num_InsulinAmount";
            this.num_InsulinAmount.Size = new System.Drawing.Size(120, 20);
            this.num_InsulinAmount.TabIndex = 4;
            // 
            // lb_InsulinAmount
            // 
            this.lb_InsulinAmount.AutoSize = true;
            this.lb_InsulinAmount.Location = new System.Drawing.Point(7, 82);
            this.lb_InsulinAmount.Name = "lb_InsulinAmount";
            this.lb_InsulinAmount.Size = new System.Drawing.Size(82, 13);
            this.lb_InsulinAmount.TabIndex = 3;
            this.lb_InsulinAmount.Text = "Insulin Amount: ";
            // 
            // lb_InsulinType
            // 
            this.lb_InsulinType.AutoSize = true;
            this.lb_InsulinType.Location = new System.Drawing.Point(7, 52);
            this.lb_InsulinType.Name = "lb_InsulinType";
            this.lb_InsulinType.Size = new System.Drawing.Size(67, 13);
            this.lb_InsulinType.TabIndex = 2;
            this.lb_InsulinType.Text = "Insulin Type:";
            // 
            // cb_EnableInsulin
            // 
            this.cb_EnableInsulin.AutoSize = true;
            this.cb_EnableInsulin.Location = new System.Drawing.Point(6, 19);
            this.cb_EnableInsulin.Name = "cb_EnableInsulin";
            this.cb_EnableInsulin.Size = new System.Drawing.Size(117, 17);
            this.cb_EnableInsulin.TabIndex = 1;
            this.cb_EnableInsulin.Text = "Insulin Information?";
            this.cb_EnableInsulin.UseVisualStyleBackColor = true;
            this.cb_EnableInsulin.CheckedChanged += new System.EventHandler(this.cb_EnableInsulin_CheckedChanged);
            // 
            // gb_Food
            // 
            this.gb_Food.Controls.Add(this.lv_Meals);
            this.gb_Food.Controls.Add(this.bn_AddMeal);
            this.gb_Food.Controls.Add(this.bn_RemoveMeal);
            this.gb_Food.Controls.Add(this.num_MealAmount);
            this.gb_Food.Controls.Add(this.combo_Food);
            this.gb_Food.Controls.Add(this.bn_AddNewFood);
            this.gb_Food.Controls.Add(this.lb_Amount);
            this.gb_Food.Controls.Add(this.lb_Food);
            this.gb_Food.Controls.Add(this.cb_EnableFood);
            this.gb_Food.Location = new System.Drawing.Point(12, 12);
            this.gb_Food.Name = "gb_Food";
            this.gb_Food.Size = new System.Drawing.Size(511, 352);
            this.gb_Food.TabIndex = 1;
            this.gb_Food.TabStop = false;
            this.gb_Food.Text = "Food";
            // 
            // lv_Meals
            // 
            this.lv_Meals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Food,
            this.col_Brand,
            this.col_Carbs,
            this.col_Amount});
            this.lv_Meals.GridLines = true;
            this.lv_Meals.HideSelection = false;
            this.lv_Meals.Location = new System.Drawing.Point(6, 143);
            this.lv_Meals.Name = "lv_Meals";
            this.lv_Meals.Size = new System.Drawing.Size(500, 203);
            this.lv_Meals.TabIndex = 12;
            this.lv_Meals.UseCompatibleStateImageBehavior = false;
            this.lv_Meals.View = System.Windows.Forms.View.Details;
            // 
            // col_Food
            // 
            this.col_Food.Text = "Food";
            this.col_Food.Width = 150;
            // 
            // col_Brand
            // 
            this.col_Brand.Text = "Brand";
            this.col_Brand.Width = 150;
            // 
            // col_Carbs
            // 
            this.col_Carbs.Text = "Carbs";
            this.col_Carbs.Width = 100;
            // 
            // col_Amount
            // 
            this.col_Amount.Text = "Amount";
            this.col_Amount.Width = 100;
            // 
            // bn_AddMeal
            // 
            this.bn_AddMeal.Location = new System.Drawing.Point(196, 94);
            this.bn_AddMeal.Name = "bn_AddMeal";
            this.bn_AddMeal.Size = new System.Drawing.Size(75, 37);
            this.bn_AddMeal.TabIndex = 11;
            this.bn_AddMeal.Text = "Add";
            this.bn_AddMeal.UseVisualStyleBackColor = true;
            this.bn_AddMeal.Click += new System.EventHandler(this.bn_AddMeal_Click);
            // 
            // bn_RemoveMeal
            // 
            this.bn_RemoveMeal.Location = new System.Drawing.Point(19, 94);
            this.bn_RemoveMeal.Name = "bn_RemoveMeal";
            this.bn_RemoveMeal.Size = new System.Drawing.Size(75, 37);
            this.bn_RemoveMeal.TabIndex = 10;
            this.bn_RemoveMeal.Text = "Remove";
            this.bn_RemoveMeal.UseVisualStyleBackColor = true;
            this.bn_RemoveMeal.Click += new System.EventHandler(this.bn_RemoveMeal_Click);
            // 
            // num_MealAmount
            // 
            this.num_MealAmount.Location = new System.Drawing.Point(151, 68);
            this.num_MealAmount.Name = "num_MealAmount";
            this.num_MealAmount.Size = new System.Drawing.Size(120, 20);
            this.num_MealAmount.TabIndex = 9;
            // 
            // combo_Food
            // 
            this.combo_Food.FormattingEnabled = true;
            this.combo_Food.Location = new System.Drawing.Point(151, 41);
            this.combo_Food.Name = "combo_Food";
            this.combo_Food.Size = new System.Drawing.Size(121, 21);
            this.combo_Food.TabIndex = 8;
            // 
            // bn_AddNewFood
            // 
            this.bn_AddNewFood.Location = new System.Drawing.Point(411, 16);
            this.bn_AddNewFood.Name = "bn_AddNewFood";
            this.bn_AddNewFood.Size = new System.Drawing.Size(94, 43);
            this.bn_AddNewFood.TabIndex = 7;
            this.bn_AddNewFood.Text = "Add New Food";
            this.bn_AddNewFood.UseVisualStyleBackColor = true;
            this.bn_AddNewFood.Click += new System.EventHandler(this.bn_AddNewFood_Click);
            // 
            // lb_Amount
            // 
            this.lb_Amount.AutoSize = true;
            this.lb_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Amount.Location = new System.Drawing.Point(16, 73);
            this.lb_Amount.Name = "lb_Amount";
            this.lb_Amount.Size = new System.Drawing.Size(52, 15);
            this.lb_Amount.TabIndex = 3;
            this.lb_Amount.Text = "Amount:";
            this.lb_Amount.Click += new System.EventHandler(this.lb_Amount_Click);
            // 
            // lb_Food
            // 
            this.lb_Food.AutoSize = true;
            this.lb_Food.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Food.Location = new System.Drawing.Point(16, 47);
            this.lb_Food.Name = "lb_Food";
            this.lb_Food.Size = new System.Drawing.Size(41, 15);
            this.lb_Food.TabIndex = 2;
            this.lb_Food.Text = "Food: ";
            // 
            // cb_EnableFood
            // 
            this.cb_EnableFood.AutoSize = true;
            this.cb_EnableFood.Location = new System.Drawing.Point(19, 19);
            this.cb_EnableFood.Name = "cb_EnableFood";
            this.cb_EnableFood.Size = new System.Drawing.Size(111, 17);
            this.cb_EnableFood.TabIndex = 1;
            this.cb_EnableFood.Text = "Food Information?";
            this.cb_EnableFood.UseVisualStyleBackColor = true;
            this.cb_EnableFood.CheckedChanged += new System.EventHandler(this.cb_EnableFood_CheckedChanged);
            // 
            // bn_Add
            // 
            this.bn_Add.Location = new System.Drawing.Point(713, 390);
            this.bn_Add.Name = "bn_Add";
            this.bn_Add.Size = new System.Drawing.Size(75, 43);
            this.bn_Add.TabIndex = 2;
            this.bn_Add.Text = "Add";
            this.bn_Add.UseVisualStyleBackColor = true;
            this.bn_Add.Click += new System.EventHandler(this.bn_Add_Click);
            // 
            // bn_Cancel
            // 
            this.bn_Cancel.Location = new System.Drawing.Point(539, 390);
            this.bn_Cancel.Name = "bn_Cancel";
            this.bn_Cancel.Size = new System.Drawing.Size(75, 43);
            this.bn_Cancel.TabIndex = 3;
            this.bn_Cancel.Text = "Cancel";
            this.bn_Cancel.UseVisualStyleBackColor = true;
            this.bn_Cancel.Click += new System.EventHandler(this.bn_Cancel_Click);
            // 
            // ep_AddMeasurement
            // 
            this.ep_AddMeasurement.ContainerControl = this;
            // 
            // AddMeasurement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bn_Cancel);
            this.Controls.Add(this.bn_Add);
            this.Controls.Add(this.gb_Insulin);
            this.Controls.Add(this.gb_Food);
            this.Controls.Add(this.gb_BGMeasurement);
            this.Controls.Add(this.gb_TimeDate);
            this.Name = "AddMeasurement";
            this.Text = "AddMeasurement";
            this.gb_TimeDate.ResumeLayout(false);
            this.gb_TimeDate.PerformLayout();
            this.gb_BGMeasurement.ResumeLayout(false);
            this.gb_BGMeasurement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_BGValue)).EndInit();
            this.gb_Insulin.ResumeLayout(false);
            this.gb_Insulin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_InsulinAmount)).EndInit();
            this.gb_Food.ResumeLayout(false);
            this.gb_Food.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_MealAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_AddMeasurement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_TimeDate;
        private System.Windows.Forms.GroupBox gb_BGMeasurement;
        private System.Windows.Forms.GroupBox gb_Insulin;
        private System.Windows.Forms.GroupBox gb_Food;
        private System.Windows.Forms.DateTimePicker dtp_Time;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.NumericUpDown num_BGValue;
        private System.Windows.Forms.Label lb_BGValue;
        private System.Windows.Forms.CheckBox cb_EnableMeasurement;
        private System.Windows.Forms.Button bn_AddNewInsulin;
        private System.Windows.Forms.ComboBox combo_InsulinType;
        private System.Windows.Forms.NumericUpDown num_InsulinAmount;
        private System.Windows.Forms.Label lb_InsulinAmount;
        private System.Windows.Forms.Label lb_InsulinType;
        private System.Windows.Forms.CheckBox cb_EnableInsulin;
        private System.Windows.Forms.Button bn_Add;
        private System.Windows.Forms.Button bn_Cancel;
        private System.Windows.Forms.ErrorProvider ep_AddMeasurement;
        private System.Windows.Forms.NumericUpDown num_MealAmount;
        private System.Windows.Forms.ComboBox combo_Food;
        private System.Windows.Forms.Button bn_AddNewFood;
        private System.Windows.Forms.Label lb_Amount;
        private System.Windows.Forms.Label lb_Food;
        private System.Windows.Forms.CheckBox cb_EnableFood;
        private System.Windows.Forms.ListView lv_Meals;
        private System.Windows.Forms.ColumnHeader col_Food;
        private System.Windows.Forms.ColumnHeader col_Brand;
        private System.Windows.Forms.ColumnHeader col_Carbs;
        private System.Windows.Forms.ColumnHeader col_Amount;
        private System.Windows.Forms.Button bn_AddMeal;
        private System.Windows.Forms.Button bn_RemoveMeal;
    }
}