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
            //anytime the radiobutton selection changes the output message is cleared
            lblOutput.Text = "";
        }
        //anytime the radiobutton selection changes the output message is cleared
        private void rad15Year_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Text = "";
        }
        //anytime the radiobutton selection changes the output message is cleared
        private void rad30Year_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Text = "";
        }
        //close application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ValidPrincipal = decimal.TryParse(txtPrincipal.Text, out Principle);
            ValidOther = decimal.TryParse(txtOther.Text, out NumPayments);
            ValidInterest = decimal.TryParse(cboInterest.Text, out InterestAnnual);
            //calculates the number of payments based off of the selected radio button
            if (rad15Year.Checked)
                NumPayments = 15 * 12;
            else if (rad30Year.Checked)
                NumPayments = 30 * 12;
            else if (radOtherYear.Checked)
                NumPayments = NumPayments * 12;
            //clears all error messages prevent error messages appearing that have already been corrected
            string InvalidPrincipal = "";
            string InvalidOther = "";
            string InvalidInterest = "";
            //validates each text/combo box for parsable input
            if (!ValidInterest)
            {
                InvalidInterest = "Please select a valid interest rate";
                cboInterest.Focus();
            }
            if (!ValidOther && txtOther.Enabled)
            {
                txtOther.Clear();
                InvalidOther = "Please Enter a valid term in years \n";
                txtOther.Focus();
            }
            if (!ValidPrincipal)
            {
                txtPrincipal.Clear();
                InvalidPrincipal = "Please enter a valid dollar amount as your principal \n";
                txtPrincipal.Focus();
            }
            //message box containing all error messages associated with invalid input
            if (!ValidPrincipal || (!ValidOther && txtOther.Enabled) || !ValidInterest)
            {
                lblOutput.Text = "";
                MessageBox.Show(InvalidPrincipal + InvalidOther + InvalidInterest);
            }
            //calculates as long as all required fields are correctly input
            if (ValidPrincipal && ValidInterest && ValidOther && txtOther.Enabled || ValidPrincipal && ValidInterest && !txtOther.Enabled)
            {
                //convert annual to monthly by multiplying by 12 and divide by 100 to make it into a percent
                InterestMonthly = (InterestAnnual / 12)/100;
                MonthlyPayment = (Principle * (InterestMonthly * (decimal)Math.Pow((1 + (double)InterestMonthly), (double)NumPayments) / ((decimal)Math.Pow((1 + (double)InterestMonthly), (double)NumPayments) - 1))).ToString("C");
                lblOutput.Text = "Monthly payment is "+MonthlyPayment;
                
            }
        }
        //validates that the interest amount entered is contained within the combobox collection
        private void cboInterest_Leave(object sender, EventArgs e)
        {
            ValidInterest = decimal.TryParse(cboInterest.Text, out InterestAnnual);
            if (cboInterest.Items.Contains(InterestAnnual.ToString("0.0")))
                cboInterest.Text = InterestAnnual.ToString("0.0");
            else
                cboInterest.Text = "";
        }
        //reset all content and give focus to the principal textbox
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = string.Empty;
            txtOther.Text = string.Empty;
            rad30Year.Checked = true;
            cboInterest.Text = "";
            lblOutput.Text = "";
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
                cboInterest_Leave(sender, e);
                btnCalculate_Click(sender, e);
            }
        }
    }
}
