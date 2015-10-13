namespace MultiConvert
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.grpConversions = new System.Windows.Forms.GroupBox();
            this.rdbInchesToFeet = new System.Windows.Forms.RadioButton();
            this.rdbFeetToInches = new System.Windows.Forms.RadioButton();
            this.rdbPoundsToEuro = new System.Windows.Forms.RadioButton();
            this.rdbEuroToPounds = new System.Windows.Forms.RadioButton();
            this.rdbCelToFahr = new System.Windows.Forms.RadioButton();
            this.rdbFahrToCel = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblOutput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grpConversions.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(17, 19);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(337, 38);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // grpConversions
            // 
            this.grpConversions.Controls.Add(this.rdbFahrToCel);
            this.grpConversions.Controls.Add(this.rdbCelToFahr);
            this.grpConversions.Controls.Add(this.rdbEuroToPounds);
            this.grpConversions.Controls.Add(this.rdbPoundsToEuro);
            this.grpConversions.Controls.Add(this.rdbFeetToInches);
            this.grpConversions.Controls.Add(this.rdbInchesToFeet);
            this.grpConversions.Location = new System.Drawing.Point(16, 102);
            this.grpConversions.Name = "grpConversions";
            this.grpConversions.Size = new System.Drawing.Size(373, 195);
            this.grpConversions.TabIndex = 1;
            this.grpConversions.TabStop = false;
            this.grpConversions.Text = "Conversions ";
            // 
            // rdbInchesToFeet
            // 
            this.rdbInchesToFeet.AutoSize = true;
            this.rdbInchesToFeet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInchesToFeet.Location = new System.Drawing.Point(17, 34);
            this.rdbInchesToFeet.Name = "rdbInchesToFeet";
            this.rdbInchesToFeet.Size = new System.Drawing.Size(109, 20);
            this.rdbInchesToFeet.TabIndex = 0;
            this.rdbInchesToFeet.TabStop = true;
            this.rdbInchesToFeet.Text = "Inches to Feet";
            this.rdbInchesToFeet.UseVisualStyleBackColor = true;
            this.rdbInchesToFeet.CheckedChanged += new System.EventHandler(this.rdbInchesToFeet_CheckedChanged);
            // 
            // rdbFeetToInches
            // 
            this.rdbFeetToInches.AutoSize = true;
            this.rdbFeetToInches.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFeetToInches.Location = new System.Drawing.Point(210, 34);
            this.rdbFeetToInches.Name = "rdbFeetToInches";
            this.rdbFeetToInches.Size = new System.Drawing.Size(109, 20);
            this.rdbFeetToInches.TabIndex = 1;
            this.rdbFeetToInches.TabStop = true;
            this.rdbFeetToInches.Text = "Feet to Inches";
            this.rdbFeetToInches.UseVisualStyleBackColor = true;
            this.rdbFeetToInches.CheckedChanged += new System.EventHandler(this.rdbFeetToInches_CheckedChanged);
            // 
            // rdbPoundsToEuro
            // 
            this.rdbPoundsToEuro.AutoSize = true;
            this.rdbPoundsToEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPoundsToEuro.Location = new System.Drawing.Point(17, 88);
            this.rdbPoundsToEuro.Name = "rdbPoundsToEuro";
            this.rdbPoundsToEuro.Size = new System.Drawing.Size(117, 20);
            this.rdbPoundsToEuro.TabIndex = 2;
            this.rdbPoundsToEuro.TabStop = true;
            this.rdbPoundsToEuro.Text = "Pounds to Euro";
            this.rdbPoundsToEuro.UseVisualStyleBackColor = true;
            this.rdbPoundsToEuro.CheckedChanged += new System.EventHandler(this.rdbPoundsToEuro_CheckedChanged);
            // 
            // rdbEuroToPounds
            // 
            this.rdbEuroToPounds.AutoSize = true;
            this.rdbEuroToPounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEuroToPounds.Location = new System.Drawing.Point(210, 88);
            this.rdbEuroToPounds.Name = "rdbEuroToPounds";
            this.rdbEuroToPounds.Size = new System.Drawing.Size(117, 20);
            this.rdbEuroToPounds.TabIndex = 3;
            this.rdbEuroToPounds.TabStop = true;
            this.rdbEuroToPounds.Text = "Euro to Pounds";
            this.rdbEuroToPounds.UseVisualStyleBackColor = true;
            this.rdbEuroToPounds.CheckedChanged += new System.EventHandler(this.rdbEuroToPounds_CheckedChanged);
            // 
            // rdbCelToFahr
            // 
            this.rdbCelToFahr.AutoSize = true;
            this.rdbCelToFahr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCelToFahr.Location = new System.Drawing.Point(17, 140);
            this.rdbCelToFahr.Name = "rdbCelToFahr";
            this.rdbCelToFahr.Size = new System.Drawing.Size(158, 20);
            this.rdbCelToFahr.TabIndex = 4;
            this.rdbCelToFahr.TabStop = true;
            this.rdbCelToFahr.Text = "Celsius to Faherenheit";
            this.rdbCelToFahr.UseVisualStyleBackColor = true;
            this.rdbCelToFahr.CheckedChanged += new System.EventHandler(this.rdbCelToFahr_CheckedChanged);
            // 
            // rdbFahrToCel
            // 
            this.rdbFahrToCel.AutoSize = true;
            this.rdbFahrToCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFahrToCel.Location = new System.Drawing.Point(210, 140);
            this.rdbFahrToCel.Name = "rdbFahrToCel";
            this.rdbFahrToCel.Size = new System.Drawing.Size(158, 20);
            this.rdbFahrToCel.TabIndex = 5;
            this.rdbFahrToCel.TabStop = true;
            this.rdbFahrToCel.Text = "Faherenheit to Celsius";
            this.rdbFahrToCel.UseVisualStyleBackColor = true;
            this.rdbFahrToCel.CheckedChanged += new System.EventHandler(this.rdbFahrToCel_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblOutput);
            this.groupBox3.Location = new System.Drawing.Point(16, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 71);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // lblOutput
            // 
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(17, 18);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(337, 38);
            this.lblOutput.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(407, 396);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpConversions);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Multi-convetrer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpConversions.ResumeLayout(false);
            this.grpConversions.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox grpConversions;
        private System.Windows.Forms.RadioButton rdbFahrToCel;
        private System.Windows.Forms.RadioButton rdbCelToFahr;
        private System.Windows.Forms.RadioButton rdbEuroToPounds;
        private System.Windows.Forms.RadioButton rdbPoundsToEuro;
        private System.Windows.Forms.RadioButton rdbFeetToInches;
        private System.Windows.Forms.RadioButton rdbInchesToFeet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox lblOutput;
    }
}

