
namespace ManageDiabetic
{
    partial class OptionsForm
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
            this.bt_NewMeasurement = new System.Windows.Forms.Button();
            this.bt_SearchMeasurement = new System.Windows.Forms.Button();
            this.bt_CalculateInsulin = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_NewMeasurement
            // 
            this.bt_NewMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_NewMeasurement.Location = new System.Drawing.Point(12, 12);
            this.bt_NewMeasurement.Name = "bt_NewMeasurement";
            this.bt_NewMeasurement.Size = new System.Drawing.Size(167, 53);
            this.bt_NewMeasurement.TabIndex = 0;
            this.bt_NewMeasurement.Text = "Add New Measurement";
            this.bt_NewMeasurement.UseVisualStyleBackColor = true;
            this.bt_NewMeasurement.Click += new System.EventHandler(this.bt_NewMeasurement_Click);
            // 
            // bt_SearchMeasurement
            // 
            this.bt_SearchMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SearchMeasurement.Location = new System.Drawing.Point(211, 12);
            this.bt_SearchMeasurement.Name = "bt_SearchMeasurement";
            this.bt_SearchMeasurement.Size = new System.Drawing.Size(167, 53);
            this.bt_SearchMeasurement.TabIndex = 1;
            this.bt_SearchMeasurement.Text = "Search Measurements";
            this.bt_SearchMeasurement.UseVisualStyleBackColor = true;
            this.bt_SearchMeasurement.Click += new System.EventHandler(this.bt_SearchMeasurement_Click);
            // 
            // bt_CalculateInsulin
            // 
            this.bt_CalculateInsulin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CalculateInsulin.Location = new System.Drawing.Point(12, 126);
            this.bt_CalculateInsulin.Name = "bt_CalculateInsulin";
            this.bt_CalculateInsulin.Size = new System.Drawing.Size(167, 53);
            this.bt_CalculateInsulin.TabIndex = 2;
            this.bt_CalculateInsulin.Text = "A1c and Insulin Calculator\r\n";
            this.bt_CalculateInsulin.UseVisualStyleBackColor = true;
            this.bt_CalculateInsulin.Click += new System.EventHandler(this.bt_CalculateInsulin_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exit.Location = new System.Drawing.Point(211, 126);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(167, 53);
            this.bt_Exit.TabIndex = 3;
            this.bt_Exit.Text = "Exit";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(398, 206);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_CalculateInsulin);
            this.Controls.Add(this.bt_SearchMeasurement);
            this.Controls.Add(this.bt_NewMeasurement);
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_NewMeasurement;
        private System.Windows.Forms.Button bt_SearchMeasurement;
        private System.Windows.Forms.Button bt_CalculateInsulin;
        private System.Windows.Forms.Button bt_Exit;
    }
}

