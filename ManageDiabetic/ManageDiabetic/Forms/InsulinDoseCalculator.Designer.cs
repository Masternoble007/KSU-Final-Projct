
namespace ManageDiabetic.Forms
{
    partial class InsulinDoseCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsulinDoseCalculator));
            this.lbl_Carbs = new System.Windows.Forms.Label();
            this.lbl_BG = new System.Windows.Forms.Label();
            this.lbl_InsulinResistance = new System.Windows.Forms.Label();
            this.lbl_A1C = new System.Windows.Forms.Label();
            this.ep_InsulinDoseCalc = new System.Windows.Forms.ErrorProvider(this.components);
            this.gb_Calculation = new System.Windows.Forms.GroupBox();
            this.num_bg = new System.Windows.Forms.NumericUpDown();
            this.num_ratio = new System.Windows.Forms.NumericUpDown();
            this.num_carbs = new System.Windows.Forms.NumericUpDown();
            this.tb_Explaination = new System.Windows.Forms.TextBox();
            this.lb_A1c = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_Dosage = new System.Windows.Forms.Label();
            this.label_numDosage = new System.Windows.Forms.Label();
            this.tb_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ep_InsulinDoseCalc)).BeginInit();
            this.gb_Calculation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_bg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ratio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_carbs)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Carbs
            // 
            this.lbl_Carbs.AutoSize = true;
            this.lbl_Carbs.Location = new System.Drawing.Point(21, 32);
            this.lbl_Carbs.Name = "lbl_Carbs";
            this.lbl_Carbs.Size = new System.Drawing.Size(81, 13);
            this.lbl_Carbs.TabIndex = 0;
            this.lbl_Carbs.Text = "Carbohydrates: ";
            // 
            // lbl_BG
            // 
            this.lbl_BG.AutoSize = true;
            this.lbl_BG.Location = new System.Drawing.Point(21, 152);
            this.lbl_BG.Name = "lbl_BG";
            this.lbl_BG.Size = new System.Drawing.Size(71, 13);
            this.lbl_BG.TabIndex = 1;
            this.lbl_BG.Text = "Blood Sugar: ";
            // 
            // lbl_InsulinResistance
            // 
            this.lbl_InsulinResistance.AutoSize = true;
            this.lbl_InsulinResistance.Location = new System.Drawing.Point(21, 72);
            this.lbl_InsulinResistance.Name = "lbl_InsulinResistance";
            this.lbl_InsulinResistance.Size = new System.Drawing.Size(71, 13);
            this.lbl_InsulinResistance.TabIndex = 2;
            this.lbl_InsulinResistance.Text = "Insulin Ratio: ";
            // 
            // lbl_A1C
            // 
            this.lbl_A1C.AutoSize = true;
            this.lbl_A1C.Location = new System.Drawing.Point(380, 35);
            this.lbl_A1C.Name = "lbl_A1C";
            this.lbl_A1C.Size = new System.Drawing.Size(32, 13);
            this.lbl_A1C.TabIndex = 3;
            this.lbl_A1C.Text = "A1c: ";
            // 
            // ep_InsulinDoseCalc
            // 
            this.ep_InsulinDoseCalc.ContainerControl = this;
            // 
            // gb_Calculation
            // 
            this.gb_Calculation.Controls.Add(this.label_numDosage);
            this.gb_Calculation.Controls.Add(this.lb_Dosage);
            this.gb_Calculation.Controls.Add(this.button1);
            this.gb_Calculation.Controls.Add(this.num_bg);
            this.gb_Calculation.Controls.Add(this.tb_Explaination);
            this.gb_Calculation.Controls.Add(this.num_ratio);
            this.gb_Calculation.Controls.Add(this.num_carbs);
            this.gb_Calculation.Controls.Add(this.lbl_Carbs);
            this.gb_Calculation.Controls.Add(this.lbl_InsulinResistance);
            this.gb_Calculation.Controls.Add(this.lbl_BG);
            this.gb_Calculation.Location = new System.Drawing.Point(12, 19);
            this.gb_Calculation.Name = "gb_Calculation";
            this.gb_Calculation.Size = new System.Drawing.Size(267, 303);
            this.gb_Calculation.TabIndex = 5;
            this.gb_Calculation.TabStop = false;
            this.gb_Calculation.Text = "Insulin Caclulator";
            // 
            // num_bg
            // 
            this.num_bg.Location = new System.Drawing.Point(109, 152);
            this.num_bg.Name = "num_bg";
            this.num_bg.Size = new System.Drawing.Size(120, 20);
            this.num_bg.TabIndex = 5;
            // 
            // num_ratio
            // 
            this.num_ratio.DecimalPlaces = 1;
            this.num_ratio.Location = new System.Drawing.Point(109, 72);
            this.num_ratio.Name = "num_ratio";
            this.num_ratio.Size = new System.Drawing.Size(120, 20);
            this.num_ratio.TabIndex = 4;
            // 
            // num_carbs
            // 
            this.num_carbs.DecimalPlaces = 1;
            this.num_carbs.Location = new System.Drawing.Point(109, 24);
            this.num_carbs.Name = "num_carbs";
            this.num_carbs.Size = new System.Drawing.Size(120, 20);
            this.num_carbs.TabIndex = 3;
            // 
            // tb_Explaination
            // 
            this.tb_Explaination.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tb_Explaination.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Explaination.Location = new System.Drawing.Point(6, 98);
            this.tb_Explaination.Multiline = true;
            this.tb_Explaination.Name = "tb_Explaination";
            this.tb_Explaination.Size = new System.Drawing.Size(100, 30);
            this.tb_Explaination.TabIndex = 6;
            this.tb_Explaination.Text = "(How many units for 10 grams of carbs)";
            // 
            // lb_A1c
            // 
            this.lb_A1c.AutoSize = true;
            this.lb_A1c.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_A1c.Location = new System.Drawing.Point(376, 69);
            this.lb_A1c.Name = "lb_A1c";
            this.lb_A1c.Size = new System.Drawing.Size(47, 37);
            this.lb_A1c.TabIndex = 7;
            this.lb_A1c.Text = "...";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(8, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Caclulate Insulin Dosage";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_Dosage
            // 
            this.lb_Dosage.AutoSize = true;
            this.lb_Dosage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Dosage.Location = new System.Drawing.Point(7, 257);
            this.lb_Dosage.Name = "lb_Dosage";
            this.lb_Dosage.Size = new System.Drawing.Size(126, 16);
            this.lb_Dosage.TabIndex = 8;
            this.lb_Dosage.Text = "Estimated Dosage: ";
            // 
            // label_numDosage
            // 
            this.label_numDosage.AutoSize = true;
            this.label_numDosage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numDosage.Location = new System.Drawing.Point(139, 257);
            this.label_numDosage.Name = "label_numDosage";
            this.label_numDosage.Size = new System.Drawing.Size(17, 16);
            this.label_numDosage.TabIndex = 9;
            this.label_numDosage.Text = "...";
            // 
            // tb_textBox
            // 
            this.tb_textBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tb_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_textBox.Location = new System.Drawing.Point(310, 222);
            this.tb_textBox.Multiline = true;
            this.tb_textBox.Name = "tb_textBox";
            this.tb_textBox.Size = new System.Drawing.Size(227, 99);
            this.tb_textBox.TabIndex = 8;
            this.tb_textBox.Text = resources.GetString("tb_textBox.Text");
            // 
            // InsulinDoseCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 351);
            this.Controls.Add(this.tb_textBox);
            this.Controls.Add(this.lb_A1c);
            this.Controls.Add(this.gb_Calculation);
            this.Controls.Add(this.lbl_A1C);
            this.Name = "InsulinDoseCalculator";
            this.Text = "Insulin Dose Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.ep_InsulinDoseCalc)).EndInit();
            this.gb_Calculation.ResumeLayout(false);
            this.gb_Calculation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_bg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ratio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_carbs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Carbs;
        private System.Windows.Forms.Label lbl_BG;
        private System.Windows.Forms.Label lbl_InsulinResistance;
        private System.Windows.Forms.Label lbl_A1C;
        private System.Windows.Forms.ErrorProvider ep_InsulinDoseCalc;
        private System.Windows.Forms.GroupBox gb_Calculation;
        private System.Windows.Forms.TextBox tb_Explaination;
        private System.Windows.Forms.NumericUpDown num_bg;
        private System.Windows.Forms.NumericUpDown num_ratio;
        private System.Windows.Forms.NumericUpDown num_carbs;
        private System.Windows.Forms.Label lb_A1c;
        private System.Windows.Forms.Label label_numDosage;
        private System.Windows.Forms.Label lb_Dosage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_textBox;
    }
}