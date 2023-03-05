
namespace ManageDiabetic
{
    partial class AddFood
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
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Brand = new System.Windows.Forms.Label();
            this.label_Carbs = new System.Windows.Forms.Label();
            this.uxName = new System.Windows.Forms.TextBox();
            this.uxBrand = new System.Windows.Forms.TextBox();
            this.uxCarbs = new System.Windows.Forms.NumericUpDown();
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxAdd = new System.Windows.Forms.Button();
            this.ep_AddFood = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uxCarbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_AddFood)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(24, 24);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(48, 16);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name:";
            // 
            // label_Brand
            // 
            this.label_Brand.AutoSize = true;
            this.label_Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Brand.Location = new System.Drawing.Point(24, 74);
            this.label_Brand.Name = "label_Brand";
            this.label_Brand.Size = new System.Drawing.Size(47, 16);
            this.label_Brand.TabIndex = 1;
            this.label_Brand.Text = "Brand:";
            // 
            // label_Carbs
            // 
            this.label_Carbs.AutoSize = true;
            this.label_Carbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Carbs.Location = new System.Drawing.Point(24, 118);
            this.label_Carbs.Name = "label_Carbs";
            this.label_Carbs.Size = new System.Drawing.Size(47, 16);
            this.label_Carbs.TabIndex = 2;
            this.label_Carbs.Text = "Carbs:";
            // 
            // uxName
            // 
            this.uxName.Location = new System.Drawing.Point(88, 24);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(154, 20);
            this.uxName.TabIndex = 3;
            // 
            // uxBrand
            // 
            this.uxBrand.Location = new System.Drawing.Point(88, 74);
            this.uxBrand.Name = "uxBrand";
            this.uxBrand.Size = new System.Drawing.Size(154, 20);
            this.uxBrand.TabIndex = 4;
            // 
            // uxCarbs
            // 
            this.uxCarbs.DecimalPlaces = 2;
            this.uxCarbs.Location = new System.Drawing.Point(88, 118);
            this.uxCarbs.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.uxCarbs.Name = "uxCarbs";
            this.uxCarbs.Size = new System.Drawing.Size(154, 20);
            this.uxCarbs.TabIndex = 5;
            // 
            // uxCancel
            // 
            this.uxCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCancel.Location = new System.Drawing.Point(27, 173);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 38);
            this.uxCancel.TabIndex = 6;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // uxAdd
            // 
            this.uxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAdd.Location = new System.Drawing.Point(167, 173);
            this.uxAdd.Name = "uxAdd";
            this.uxAdd.Size = new System.Drawing.Size(75, 38);
            this.uxAdd.TabIndex = 7;
            this.uxAdd.Text = "Add";
            this.uxAdd.UseVisualStyleBackColor = true;
            this.uxAdd.Click += new System.EventHandler(this.uxAdd_Click);
            // 
            // ep_AddFood
            // 
            this.ep_AddFood.ContainerControl = this;
            // 
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(282, 242);
            this.Controls.Add(this.uxAdd);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxCarbs);
            this.Controls.Add(this.uxBrand);
            this.Controls.Add(this.uxName);
            this.Controls.Add(this.label_Carbs);
            this.Controls.Add(this.label_Brand);
            this.Controls.Add(this.label_Name);
            this.Name = "AddFood";
            this.Text = "Add Food Information";
            ((System.ComponentModel.ISupportInitialize)(this.uxCarbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_AddFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Brand;
        private System.Windows.Forms.Label label_Carbs;
        private System.Windows.Forms.TextBox uxName;
        private System.Windows.Forms.TextBox uxBrand;
        private System.Windows.Forms.NumericUpDown uxCarbs;
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.Button uxAdd;
        private System.Windows.Forms.ErrorProvider ep_AddFood;
    }
}