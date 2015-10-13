namespace WindowsFormsApplication2
{
    partial class CalcForm
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
            this.lblInput = new System.Windows.Forms.Label();
            this.lblCalculation = new System.Windows.Forms.Label();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnCAll = new System.Windows.Forms.Button();
            this.btnCError = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInput.BackColor = System.Drawing.SystemColors.Window;
            this.lblInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInput.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(7, 15);
            this.lblInput.Name = "lblInput";
            this.lblInput.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.lblInput.Size = new System.Drawing.Size(284, 74);
            this.lblInput.TabIndex = 0;
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblInput.Click += new System.EventHandler(this.lblInput_Click);
            // 
            // lblCalculation
            // 
            this.lblCalculation.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculation.Location = new System.Drawing.Point(26, 19);
            this.lblCalculation.Name = "lblCalculation";
            this.lblCalculation.Size = new System.Drawing.Size(261, 30);
            this.lblCalculation.TabIndex = 1;
            this.lblCalculation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBackspace
            // 
            this.btnBackspace.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackspace.Location = new System.Drawing.Point(18, 111);
            this.btnBackspace.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(53, 49);
            this.btnBackspace.TabIndex = 2;
            this.btnBackspace.Text = "<--";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnCAll
            // 
            this.btnCAll.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAll.Location = new System.Drawing.Point(90, 111);
            this.btnCAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnCAll.Name = "btnCAll";
            this.btnCAll.Size = new System.Drawing.Size(53, 49);
            this.btnCAll.TabIndex = 3;
            this.btnCAll.Text = "CA";
            this.btnCAll.UseVisualStyleBackColor = true;
            this.btnCAll.Click += new System.EventHandler(this.btnCAll_Click);
            // 
            // btnCError
            // 
            this.btnCError.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCError.Location = new System.Drawing.Point(162, 111);
            this.btnCError.Margin = new System.Windows.Forms.Padding(0);
            this.btnCError.Name = "btnCError";
            this.btnCError.Size = new System.Drawing.Size(53, 49);
            this.btnCError.TabIndex = 4;
            this.btnCError.Text = "CE";
            this.btnCError.UseVisualStyleBackColor = true;
            this.btnCError.Click += new System.EventHandler(this.btnCError_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(241, 111);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(53, 49);
            this.btnPlus.TabIndex = 6;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnOne
            // 
            this.btnOne.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(18, 173);
            this.btnOne.Margin = new System.Windows.Forms.Padding(0);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(53, 49);
            this.btnOne.TabIndex = 7;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(90, 173);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(0);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(53, 49);
            this.btnTwo.TabIndex = 8;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(162, 173);
            this.btnThree.Margin = new System.Windows.Forms.Padding(0);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(53, 49);
            this.btnThree.TabIndex = 9;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(241, 173);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(53, 49);
            this.btnMinus.TabIndex = 10;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnFour
            // 
            this.btnFour.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(18, 235);
            this.btnFour.Margin = new System.Windows.Forms.Padding(0);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(53, 49);
            this.btnFour.TabIndex = 11;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnFive
            // 
            this.btnFive.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(90, 235);
            this.btnFive.Margin = new System.Windows.Forms.Padding(0);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(53, 49);
            this.btnFive.TabIndex = 12;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnSix
            // 
            this.btnSix.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(162, 235);
            this.btnSix.Margin = new System.Windows.Forms.Padding(0);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(53, 49);
            this.btnSix.TabIndex = 13;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(241, 235);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(0);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(53, 49);
            this.btnMultiply.TabIndex = 14;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(18, 297);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(0);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(53, 49);
            this.btnSeven.TabIndex = 15;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnEight
            // 
            this.btnEight.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(90, 297);
            this.btnEight.Margin = new System.Windows.Forms.Padding(0);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(53, 49);
            this.btnEight.TabIndex = 16;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnNine
            // 
            this.btnNine.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(162, 297);
            this.btnNine.Margin = new System.Windows.Forms.Padding(0);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(53, 49);
            this.btnNine.TabIndex = 17;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(241, 297);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(0);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(53, 49);
            this.btnDivide.TabIndex = 18;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(90, 359);
            this.btnZero.Margin = new System.Windows.Forms.Padding(0);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(53, 49);
            this.btnZero.TabIndex = 19;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoint.Location = new System.Drawing.Point(18, 359);
            this.btnPoint.Margin = new System.Windows.Forms.Padding(0);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(53, 49);
            this.btnPoint.TabIndex = 20;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(162, 359);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(0);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(132, 49);
            this.btnEquals.TabIndex = 21;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(304, 430);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnCError);
            this.Controls.Add(this.btnCAll);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.lblCalculation);
            this.Controls.Add(this.lblInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(324, 469);
            this.MinimumSize = new System.Drawing.Size(324, 469);
            this.Name = "CalcForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalcForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblCalculation;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnCAll;
        private System.Windows.Forms.Button btnCError;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnEquals;
    }
}

