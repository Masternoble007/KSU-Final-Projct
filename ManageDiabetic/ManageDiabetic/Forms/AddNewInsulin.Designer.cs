
namespace ManageDiabetic.Forms
{
    partial class AddNewInsulin
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
            this.label_InsulinName = new System.Windows.Forms.Label();
            this.label_Manufacturer = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.ep_AddNewInsulin = new System.Windows.Forms.ErrorProvider(this.components);
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Manufacturer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ep_AddNewInsulin)).BeginInit();
            this.SuspendLayout();
            // 
            // label_InsulinName
            // 
            this.label_InsulinName.AutoSize = true;
            this.label_InsulinName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InsulinName.Location = new System.Drawing.Point(12, 22);
            this.label_InsulinName.Name = "label_InsulinName";
            this.label_InsulinName.Size = new System.Drawing.Size(91, 16);
            this.label_InsulinName.TabIndex = 0;
            this.label_InsulinName.Text = "Insulin Name: ";
            // 
            // label_Manufacturer
            // 
            this.label_Manufacturer.AutoSize = true;
            this.label_Manufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Manufacturer.Location = new System.Drawing.Point(12, 61);
            this.label_Manufacturer.Name = "label_Manufacturer";
            this.label_Manufacturer.Size = new System.Drawing.Size(128, 16);
            this.label_Manufacturer.TabIndex = 1;
            this.label_Manufacturer.Text = "Insulin Manufacturer:";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.Location = new System.Drawing.Point(15, 110);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 46);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(264, 110);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 46);
            this.button_Add.TabIndex = 3;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button2_Click);
            // 
            // ep_AddNewInsulin
            // 
            this.ep_AddNewInsulin.ContainerControl = this;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(159, 22);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(180, 20);
            this.tb_Name.TabIndex = 4;
            // 
            // tb_Manufacturer
            // 
            this.tb_Manufacturer.Location = new System.Drawing.Point(159, 61);
            this.tb_Manufacturer.Name = "tb_Manufacturer";
            this.tb_Manufacturer.Size = new System.Drawing.Size(180, 20);
            this.tb_Manufacturer.TabIndex = 5;
            // 
            // AddNewInsulin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(351, 179);
            this.Controls.Add(this.tb_Manufacturer);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.label_Manufacturer);
            this.Controls.Add(this.label_InsulinName);
            this.Name = "AddNewInsulin";
            this.Text = "Add New Insulin";
            ((System.ComponentModel.ISupportInitialize)(this.ep_AddNewInsulin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_InsulinName;
        private System.Windows.Forms.Label label_Manufacturer;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ErrorProvider ep_AddNewInsulin;
        private System.Windows.Forms.TextBox tb_Manufacturer;
        private System.Windows.Forms.TextBox tb_Name;
    }
}