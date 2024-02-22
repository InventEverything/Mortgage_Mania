namespace Engle_Mortgage
{
    partial class frmMortgageCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMortgageCalculator));
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.rad15Year = new System.Windows.Forms.RadioButton();
            this.rad30Year = new System.Windows.Forms.RadioButton();
            this.radOtherYear = new System.Windows.Forms.RadioButton();
            this.cboInterest = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.lblTermInYears = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblInterestPercent = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrincipal.Location = new System.Drawing.Point(144, 20);
            this.txtPrincipal.Margin = new System.Windows.Forms.Padding(6);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(196, 31);
            this.txtPrincipal.TabIndex = 0;
            this.txtPrincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrincipal_KeyDown);
            // 
            // rad15Year
            // 
            this.rad15Year.AutoSize = true;
            this.rad15Year.Location = new System.Drawing.Point(29, 88);
            this.rad15Year.Name = "rad15Year";
            this.rad15Year.Size = new System.Drawing.Size(106, 29);
            this.rad15Year.TabIndex = 1;
            this.rad15Year.Text = "15 Year";
            this.rad15Year.UseVisualStyleBackColor = true;
            this.rad15Year.CheckedChanged += new System.EventHandler(this.rad15Year_CheckedChanged);
            // 
            // rad30Year
            // 
            this.rad30Year.AutoSize = true;
            this.rad30Year.Location = new System.Drawing.Point(29, 123);
            this.rad30Year.Name = "rad30Year";
            this.rad30Year.Size = new System.Drawing.Size(106, 29);
            this.rad30Year.TabIndex = 2;
            this.rad30Year.Text = "30 Year";
            this.rad30Year.UseVisualStyleBackColor = true;
            this.rad30Year.CheckedChanged += new System.EventHandler(this.rad30Year_CheckedChanged);
            // 
            // radOtherYear
            // 
            this.radOtherYear.AutoSize = true;
            this.radOtherYear.Location = new System.Drawing.Point(29, 158);
            this.radOtherYear.Name = "radOtherYear";
            this.radOtherYear.Size = new System.Drawing.Size(101, 29);
            this.radOtherYear.TabIndex = 3;
            this.radOtherYear.Text = "Other...";
            this.radOtherYear.UseVisualStyleBackColor = true;
            this.radOtherYear.CheckedChanged += new System.EventHandler(this.radOtherYear_CheckedChanged);
            // 
            // cboInterest
            // 
            this.cboInterest.FormattingEnabled = true;
            this.cboInterest.Items.AddRange(new object[] {
            "3.0",
            "3.1",
            "3.2",
            "3.3",
            "3.4",
            "3.5",
            "3.6",
            "3.7",
            "3.8",
            "3.9",
            "4.0",
            "4.1",
            "4.2",
            "4.3",
            "4.4",
            "4.5"});
            this.cboInterest.Location = new System.Drawing.Point(136, 200);
            this.cboInterest.Name = "cboInterest";
            this.cboInterest.Size = new System.Drawing.Size(91, 33);
            this.cboInterest.TabIndex = 5;
            this.cboInterest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboInterest_KeyDown);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculate.Location = new System.Drawing.Point(29, 239);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(311, 45);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate Payment";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnReset.Enabled = false;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Location = new System.Drawing.Point(29, 290);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(152, 45);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(239, 290);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 45);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtOther
            // 
            this.txtOther.Enabled = false;
            this.txtOther.Location = new System.Drawing.Point(136, 158);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(171, 31);
            this.txtOther.TabIndex = 4;
            this.txtOther.Visible = false;
            this.txtOther.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOther_KeyDown);
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Location = new System.Drawing.Point(24, 23);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(119, 25);
            this.lblPrincipal.TabIndex = 9;
            this.lblPrincipal.Text = "Principal: $";
            // 
            // lblTermInYears
            // 
            this.lblTermInYears.AutoSize = true;
            this.lblTermInYears.Location = new System.Drawing.Point(24, 60);
            this.lblTermInYears.Name = "lblTermInYears";
            this.lblTermInYears.Size = new System.Drawing.Size(147, 25);
            this.lblTermInYears.TabIndex = 10;
            this.lblTermInYears.Text = "Term In Years";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(24, 203);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(83, 25);
            this.lblInterest.TabIndex = 11;
            this.lblInterest.Text = "Interest";
            // 
            // lblInterestPercent
            // 
            this.lblInterestPercent.AutoSize = true;
            this.lblInterestPercent.Location = new System.Drawing.Point(233, 203);
            this.lblInterestPercent.Name = "lblInterestPercent";
            this.lblInterestPercent.Size = new System.Drawing.Size(31, 25);
            this.lblInterestPercent.TabIndex = 12;
            this.lblInterestPercent.Text = "%";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(29, 342);
            this.lblOutput.MaximumSize = new System.Drawing.Size(311, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 25);
            this.lblOutput.TabIndex = 13;
            this.lblOutput.Resize += new System.EventHandler(this.lblOutput_Resize);
            // 
            // frmMortgageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 394);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInterestPercent);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.lblTermInYears);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cboInterest);
            this.Controls.Add(this.radOtherYear);
            this.Controls.Add(this.rad30Year);
            this.Controls.Add(this.rad15Year);
            this.Controls.Add(this.txtPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMortgageCalculator";
            this.Text = "Mortgage Calculator";
            this.Load += new System.EventHandler(this.frmMortgageCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.RadioButton rad15Year;
        private System.Windows.Forms.RadioButton rad30Year;
        private System.Windows.Forms.RadioButton radOtherYear;
        private System.Windows.Forms.ComboBox cboInterest;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Label lblTermInYears;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblInterestPercent;
        private System.Windows.Forms.Label lblOutput;
    }
}

