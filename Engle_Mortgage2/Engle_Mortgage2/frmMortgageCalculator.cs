using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engle_Mortgage
{
    public partial class frmMortgageCalculator : Form
    {
        decimal Principle;
        decimal NumPayments;
        decimal InterestAnnual;
        decimal InterestMonthly;
        bool ValidInterest;
        bool ValidPrincipal;
        bool ValidOther;
        string MonthlyPayment;
        bool ValidTerm;
        //I added my own logo as the form icon even though it was not required
        public frmMortgageCalculator()
        {
            InitializeComponent();
        }
        //you requested within the assignment that the name of the form be changed in code at startup
        private void frmMortgageCalculator_Load(object sender, EventArgs e)
        {
            this.Text = "Ian Engle : Mortgage Calculator";
        }
        //toggle visability of other textbox if radio button is checked
        private void radOtherYear_CheckedChanged(object sender, EventArgs e)
        {
            if (radOtherYear.Checked) 
            {
                txtOther.Visible = true;
                txtOther.Enabled = true;
            }
            else if (!radOtherYear.Checked)
            {
                txtOther.Visible = false;
                txtOther.Enabled = false;
            }
            //anytime the radiobutton selection changes the output messag eand txtother are cleared
            lblOutput.Text = string.Empty;
            txtOther.Text = string.Empty;
        }
        //anytime the radiobutton selection changes the output message is cleared
        private void rad15Year_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Text = string.Empty;
        }
        //anytime the radiobutton selection changes the output message is cleared
        private void rad30Year_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Text = string.Empty;
        }
        //close application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblOutput.Text = string.Empty;
            ValidPrincipal = decimal.TryParse(txtPrincipal.Text, out Principle);
            ValidOther = decimal.TryParse(txtOther.Text, out NumPayments);
            ValidInterest = decimal.TryParse(cboInterest.Text, out InterestAnnual);
            //calculates the number of payments based off of the selected radio button
            if (rad15Year.Checked)
            {
                ValidTerm = true;
                NumPayments = 15 * 12;
            }
            else if (rad30Year.Checked)
            {
                ValidTerm = true;
                NumPayments = 30 * 12;
            }
            else if (radOtherYear.Checked)
            {
                ValidTerm = true;
                NumPayments = NumPayments * 12;
            }
            else
            {
                ValidTerm = false;
            }
            //clears all error messages prevent error messages appearing that have already been corrected
            string InvalidPrincipal = string.Empty;
            string InvalidOther = string.Empty;
            string InvalidInterest = string.Empty;
            string InvalidTerm = string.Empty;
            //validates each text/combo box for parsable input
            if (!ValidInterest || !cboInterest.Items.Contains(InterestAnnual.ToString("0.0")) || InterestAnnual.ToString().Length > 3)
            {
                //string length was needed to prevent numbers like 3.99 or 4.01 from qualifying as valid interest amounts
                InvalidInterest = "Please select a valid interest rate";
                cboInterest.Focus();
            }
            if ((ValidOther && (NumPayments / 12) > 40) || (ValidOther && (NumPayments / 12) < 5))
            {
                InvalidOther = "Other term is required to be between 5 and 40 years. \n";
                txtOther.Focus();
            }
            if (!ValidOther && txtOther.Enabled)
            {
                InvalidOther = "Please enter a valid term in years. \n";
                txtOther.Focus();
            }
            if (!ValidTerm)
            {
                InvalidTerm = "Please select the appropriate term. \n";
            }
            if (!ValidPrincipal)
            {
                InvalidPrincipal = "Please enter a valid dollar amount as your principal. \n";
                txtPrincipal.Focus();
            }
            //message containing all error messages associated with invalid input
            if (!ValidPrincipal || InvalidOther != string.Empty || InvalidInterest != string.Empty || !ValidTerm)
            {
                lblOutput.Text = InvalidPrincipal + InvalidOther + InvalidTerm + InvalidInterest;
                this.Height = lblOutput.Location.Y + lblOutput.Size.Height + 45;
            }
            //calculates as long as all required fields are correctly input
            if (ValidPrincipal && InvalidInterest == string.Empty && InvalidOther == string.Empty && ValidTerm && txtOther.Enabled || ValidPrincipal && InvalidInterest == string.Empty && ValidTerm && !txtOther.Enabled)
            {
                //convert annual to monthly by multiplying by 12 and divide by 100 to make it into a percent
                InterestMonthly = (InterestAnnual / 12)/100;
                MonthlyPayment = (Principle * (InterestMonthly * (decimal)Math.Pow((1 + (double)InterestMonthly), (double)NumPayments) / ((decimal)Math.Pow((1 + (double)InterestMonthly), (double)NumPayments) - 1))).ToString("C");
                lblOutput.Text = "Monthly payment is " + MonthlyPayment;
                btnReset.Enabled = true;
                
            }
        }
        //reset all content and give focus to the principal textbox
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = string.Empty;
            txtOther.Text = string.Empty;
            cboInterest.Text = string.Empty;
            lblOutput.Text = string.Empty;
            txtOther.Text = string.Empty;
            rad30Year.Checked = false;
            rad15Year.Checked = false;
            radOtherYear.Checked = false;
            btnReset.Enabled = false;
            txtPrincipal.Focus();
        }
        //enter will calculate if principle textbox is selected
        private void txtPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalculate_Click(sender, e);
            }
        }
        //enter will calculate if other textbox is selected
        private void txtOther_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalculate_Click(sender, e);
            }
        }
        //enter will calculate if interest combobox is selected
        private void cboInterest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalculate_Click(sender, e);
            }
        }
        //form height will always be large enough to fit the message displayed by the output label
        private void lblOutput_Resize(object sender, EventArgs e)
        {
            this.Height = lblOutput.Location.Y + lblOutput.Size.Height + 45;
        }
    }
}
