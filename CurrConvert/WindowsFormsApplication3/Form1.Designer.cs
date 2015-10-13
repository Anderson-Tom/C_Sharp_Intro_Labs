namespace WindowsFormsApplication3
{
    partial class CurConverter
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.gboxInput = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.gboxFrom = new System.Windows.Forms.GroupBox();
            this.combFrom = new System.Windows.Forms.ComboBox();
            this.grpbTo = new System.Windows.Forms.GroupBox();
            this.combTo = new System.Windows.Forms.ComboBox();
            this.btnReuse = new System.Windows.Forms.Button();
            this.gboxInput.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gboxFrom.SuspendLayout();
            this.grpbTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(6, 19);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(273, 38);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // gboxInput
            // 
            this.gboxInput.Controls.Add(this.txtInput);
            this.gboxInput.Location = new System.Drawing.Point(12, 12);
            this.gboxInput.Name = "gboxInput";
            this.gboxInput.Size = new System.Drawing.Size(285, 68);
            this.gboxInput.TabIndex = 2;
            this.gboxInput.TabStop = false;
            this.gboxInput.Text = "Input";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Location = new System.Drawing.Point(12, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 65);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.SystemColors.Window;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(6, 16);
            this.lblResult.MaximumSize = new System.Drawing.Size(273, 38);
            this.lblResult.MinimumSize = new System.Drawing.Size(273, 38);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(273, 38);
            this.lblResult.TabIndex = 0;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gboxFrom
            // 
            this.gboxFrom.Controls.Add(this.combFrom);
            this.gboxFrom.Location = new System.Drawing.Point(12, 207);
            this.gboxFrom.Name = "gboxFrom";
            this.gboxFrom.Size = new System.Drawing.Size(289, 71);
            this.gboxFrom.TabIndex = 4;
            this.gboxFrom.TabStop = false;
            this.gboxFrom.Text = "From";
            // 
            // combFrom
            // 
            this.combFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combFrom.FormattingEnabled = true;
            this.combFrom.Items.AddRange(new object[] {
            "",
            "American Dollar",
            "Bitcoin",
            "British Pound",
            "Canadian Dollar",
            "Euro"});
            this.combFrom.Location = new System.Drawing.Point(6, 19);
            this.combFrom.Name = "combFrom";
            this.combFrom.Size = new System.Drawing.Size(273, 39);
            this.combFrom.TabIndex = 0;
            this.combFrom.SelectedIndexChanged += new System.EventHandler(this.combFrom_SelectedIndexChanged);
            // 
            // grpbTo
            // 
            this.grpbTo.Controls.Add(this.combTo);
            this.grpbTo.Location = new System.Drawing.Point(12, 298);
            this.grpbTo.Name = "grpbTo";
            this.grpbTo.Size = new System.Drawing.Size(288, 68);
            this.grpbTo.TabIndex = 5;
            this.grpbTo.TabStop = false;
            this.grpbTo.Text = "To";
            // 
            // combTo
            // 
            this.combTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combTo.FormattingEnabled = true;
            this.combTo.Items.AddRange(new object[] {
            "",
            "American Dollar",
            "Bitcoin",
            "British Pound",
            "Canadian Dollar",
            "Euro"});
            this.combTo.Location = new System.Drawing.Point(10, 16);
            this.combTo.Name = "combTo";
            this.combTo.Size = new System.Drawing.Size(268, 39);
            this.combTo.TabIndex = 0;
            this.combTo.SelectedIndexChanged += new System.EventHandler(this.comboTo_SelectedIndexChanged);
            // 
            // btnReuse
            // 
            this.btnReuse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReuse.Location = new System.Drawing.Point(176, 86);
            this.btnReuse.Name = "btnReuse";
            this.btnReuse.Size = new System.Drawing.Size(113, 34);
            this.btnReuse.TabIndex = 6;
            this.btnReuse.Text = "Use Result ⬆";
            this.btnReuse.UseVisualStyleBackColor = true;
            this.btnReuse.Click += new System.EventHandler(this.btnReuse_Click);
            // 
            // CurConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(309, 409);
            this.Controls.Add(this.btnReuse);
            this.Controls.Add(this.grpbTo);
            this.Controls.Add(this.gboxFrom);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxInput);
            this.Name = "CurConverter";
            this.Text = "Currency Converter";
            this.gboxInput.ResumeLayout(false);
            this.gboxInput.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboxFrom.ResumeLayout(false);
            this.grpbTo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox gboxInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox gboxFrom;
        private System.Windows.Forms.ComboBox combFrom;
        private System.Windows.Forms.GroupBox grpbTo;
        private System.Windows.Forms.ComboBox combTo;
        private System.Windows.Forms.Button btnReuse;
    }
}

