namespace WindowsFormsApplication5
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.conversionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lengthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchesToFeetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feetToInchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poundsToEuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.euroToPoundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tempertureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.celsiusToFahernheitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conversionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(340, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // conversionsToolStripMenuItem
            // 
            this.conversionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lengthToolStripMenuItem,
            this.weightToolStripMenuItem,
            this.tempertureToolStripMenuItem});
            this.conversionsToolStripMenuItem.Name = "conversionsToolStripMenuItem";
            this.conversionsToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.conversionsToolStripMenuItem.Text = "Conversion Type";
            // 
            // lengthToolStripMenuItem
            // 
            this.lengthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inchesToFeetToolStripMenuItem,
            this.feetToInchesToolStripMenuItem});
            this.lengthToolStripMenuItem.Name = "lengthToolStripMenuItem";
            this.lengthToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.lengthToolStripMenuItem.Text = "Length";
            // 
            // inchesToFeetToolStripMenuItem
            // 
            this.inchesToFeetToolStripMenuItem.Name = "inchesToFeetToolStripMenuItem";
            this.inchesToFeetToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.inchesToFeetToolStripMenuItem.Text = "Inches to Feet";
            this.inchesToFeetToolStripMenuItem.Click += new System.EventHandler(this.inchesToFeetToolStripMenuItem_Click);
            // 
            // feetToInchesToolStripMenuItem
            // 
            this.feetToInchesToolStripMenuItem.Name = "feetToInchesToolStripMenuItem";
            this.feetToInchesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.feetToInchesToolStripMenuItem.Text = "Feet to Inches";
            this.feetToInchesToolStripMenuItem.Click += new System.EventHandler(this.feetToInchesToolStripMenuItem_Click);
            // 
            // weightToolStripMenuItem
            // 
            this.weightToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poundsToEuroToolStripMenuItem,
            this.euroToPoundsToolStripMenuItem});
            this.weightToolStripMenuItem.Name = "weightToolStripMenuItem";
            this.weightToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.weightToolStripMenuItem.Text = "Currency";
            // 
            // poundsToEuroToolStripMenuItem
            // 
            this.poundsToEuroToolStripMenuItem.Name = "poundsToEuroToolStripMenuItem";
            this.poundsToEuroToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.poundsToEuroToolStripMenuItem.Text = "Pounds to Euro";
            this.poundsToEuroToolStripMenuItem.Click += new System.EventHandler(this.poundsToEuroToolStripMenuItem_Click);
            // 
            // euroToPoundsToolStripMenuItem
            // 
            this.euroToPoundsToolStripMenuItem.Name = "euroToPoundsToolStripMenuItem";
            this.euroToPoundsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.euroToPoundsToolStripMenuItem.Text = "Euro to Pounds";
            this.euroToPoundsToolStripMenuItem.Click += new System.EventHandler(this.euroToPoundsToolStripMenuItem_Click);
            // 
            // tempertureToolStripMenuItem
            // 
            this.tempertureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.celsiusToFahernheitToolStripMenuItem,
            this.faherToolStripMenuItem});
            this.tempertureToolStripMenuItem.Name = "tempertureToolStripMenuItem";
            this.tempertureToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.tempertureToolStripMenuItem.Text = "Temperature";
            // 
            // celsiusToFahernheitToolStripMenuItem
            // 
            this.celsiusToFahernheitToolStripMenuItem.Name = "celsiusToFahernheitToolStripMenuItem";
            this.celsiusToFahernheitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.celsiusToFahernheitToolStripMenuItem.Text = "Celsius to Fahrenheit";
            this.celsiusToFahernheitToolStripMenuItem.Click += new System.EventHandler(this.celsiusToFahernheitToolStripMenuItem_Click);
            // 
            // faherToolStripMenuItem
            // 
            this.faherToolStripMenuItem.Name = "faherToolStripMenuItem";
            this.faherToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.faherToolStripMenuItem.Text = "Fahrenheit to Celsius";
            this.faherToolStripMenuItem.Click += new System.EventHandler(this.faherToolStripMenuItem_Click);
            // 
            // tbxInput
            // 
            this.tbxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInput.Location = new System.Drawing.Point(6, 19);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(296, 38);
            this.tbxInput.TabIndex = 1;
            this.tbxInput.Text = "0";
            this.tbxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxInput.TextChanged += new System.EventHandler(this.tbxInput_TextChanged);
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.tbxInput);
            this.grpInput.Location = new System.Drawing.Point(12, 27);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(312, 67);
            this.grpInput.TabIndex = 2;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.lblOutput);
            this.grpOutput.Location = new System.Drawing.Point(12, 115);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(312, 63);
            this.grpOutput.TabIndex = 3;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.SystemColors.Window;
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(6, 16);
            this.lblOutput.MaximumSize = new System.Drawing.Size(296, 38);
            this.lblOutput.MinimumSize = new System.Drawing.Size(296, 38);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(296, 38);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "0";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 213);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Multi Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem conversionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lengthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchesToFeetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feetToInchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poundsToEuroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem euroToPoundsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tempertureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem celsiusToFahernheitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faherToolStripMenuItem;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Label lblOutput;
    }
}

