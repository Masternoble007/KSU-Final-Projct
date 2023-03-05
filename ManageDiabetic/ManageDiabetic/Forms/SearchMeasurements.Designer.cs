
namespace ManageDiabetic.Forms
{
    partial class SearchMeasurements
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
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.bn_Search = new System.Windows.Forms.Button();
            this.bn_Close = new System.Windows.Forms.Button();
            this.lv_Measurements = new System.Windows.Forms.ListView();
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BGValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InsulinAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InsulinName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InsulinBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dvg_Meals = new System.Windows.Forms.DataGridView();
            this.col_FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FoodBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FoodCarbs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MealAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Meals)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_Date
            // 
            this.dtp_Date.Location = new System.Drawing.Point(12, 12);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(200, 20);
            this.dtp_Date.TabIndex = 0;
            // 
            // bn_Search
            // 
            this.bn_Search.Location = new System.Drawing.Point(12, 38);
            this.bn_Search.Name = "bn_Search";
            this.bn_Search.Size = new System.Drawing.Size(75, 41);
            this.bn_Search.TabIndex = 1;
            this.bn_Search.Text = "Search";
            this.bn_Search.UseVisualStyleBackColor = true;
            this.bn_Search.Click += new System.EventHandler(this.bn_Search_Click);
            // 
            // bn_Close
            // 
            this.bn_Close.Location = new System.Drawing.Point(12, 397);
            this.bn_Close.Name = "bn_Close";
            this.bn_Close.Size = new System.Drawing.Size(75, 41);
            this.bn_Close.TabIndex = 2;
            this.bn_Close.Text = "Close";
            this.bn_Close.UseVisualStyleBackColor = true;
            this.bn_Close.Click += new System.EventHandler(this.bn_Close_Click);
            // 
            // lv_Measurements
            // 
            this.lv_Measurements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.BGValue,
            this.InsulinAmount,
            this.InsulinName,
            this.InsulinBrand});
            this.lv_Measurements.FullRowSelect = true;
            this.lv_Measurements.GridLines = true;
            this.lv_Measurements.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_Measurements.HideSelection = false;
            this.lv_Measurements.Location = new System.Drawing.Point(230, 12);
            this.lv_Measurements.MultiSelect = false;
            this.lv_Measurements.Name = "lv_Measurements";
            this.lv_Measurements.Size = new System.Drawing.Size(558, 251);
            this.lv_Measurements.TabIndex = 3;
            this.lv_Measurements.UseCompatibleStateImageBehavior = false;
            this.lv_Measurements.View = System.Windows.Forms.View.Details;
            this.lv_Measurements.SelectedIndexChanged += new System.EventHandler(this.lv_Measurements_SelectedIndexChanged);
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 110;
            // 
            // BGValue
            // 
            this.BGValue.Text = "Blood Sugar Value";
            this.BGValue.Width = 100;
            // 
            // InsulinAmount
            // 
            this.InsulinAmount.Text = "Insulin Amount";
            this.InsulinAmount.Width = 100;
            // 
            // InsulinName
            // 
            this.InsulinName.Text = "Insulin Name";
            this.InsulinName.Width = 124;
            // 
            // InsulinBrand
            // 
            this.InsulinBrand.Text = "Insulin Brand";
            this.InsulinBrand.Width = 124;
            // 
            // dvg_Meals
            // 
            this.dvg_Meals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_Meals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_FoodName,
            this.col_FoodBrand,
            this.col_FoodCarbs,
            this.col_MealAmount});
            this.dvg_Meals.Location = new System.Drawing.Point(230, 281);
            this.dvg_Meals.Name = "dvg_Meals";
            this.dvg_Meals.Size = new System.Drawing.Size(558, 150);
            this.dvg_Meals.TabIndex = 4;
            // 
            // col_FoodName
            // 
            this.col_FoodName.HeaderText = "Name";
            this.col_FoodName.Name = "col_FoodName";
            // 
            // col_FoodBrand
            // 
            this.col_FoodBrand.HeaderText = "Brand";
            this.col_FoodBrand.Name = "col_FoodBrand";
            // 
            // col_FoodCarbs
            // 
            this.col_FoodCarbs.HeaderText = "Carbohydrates";
            this.col_FoodCarbs.Name = "col_FoodCarbs";
            // 
            // col_MealAmount
            // 
            this.col_MealAmount.HeaderText = "Amount for Meal (grams)";
            this.col_MealAmount.Name = "col_MealAmount";
            // 
            // SearchMeasurements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dvg_Meals);
            this.Controls.Add(this.lv_Measurements);
            this.Controls.Add(this.bn_Close);
            this.Controls.Add(this.bn_Search);
            this.Controls.Add(this.dtp_Date);
            this.Name = "SearchMeasurements";
            this.Text = "Search Measurement";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Meals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Button bn_Search;
        private System.Windows.Forms.Button bn_Close;
        private System.Windows.Forms.ListView lv_Measurements;
        private System.Windows.Forms.DataGridView dvg_Meals;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader BGValue;
        private System.Windows.Forms.ColumnHeader InsulinAmount;
        private System.Windows.Forms.ColumnHeader InsulinName;
        private System.Windows.Forms.ColumnHeader InsulinBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FoodBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FoodCarbs;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MealAmount;
    }
}