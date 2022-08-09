using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace disturbo_tax
{
    public partial class frmInfo : Form
    {
        public frmInfo()
        {
            InitializeComponent();
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
            this.cboState.Items.AddRange(new object[] {
            "Alabama ",
            "Alaska ",
            "Arizona ",
            "Arkansas ",
            "California ",
            "Colorado ",
            "Connecticut ",
            "Delaware ",
            "Florida ",
            "Georgia ",
            "Hawaii ",
            "Idaho ",
            "Illinois ",
            "Indiana ",
            "Iowa ",
            "Kansas ",
            "Kentucky ",
            "Louisiana ",
            "Maine ",
            "Maryland ",
            "Massachusetts ",
            "Michigan ",
            "Minnesota ",
            "Mississippi ",
            "Missouri ",
            "Montana ",
            "Nebraska ",
            "Nevada ",
            "New Hampshire ",
            "New Jersey ",
            "New Mexico ",
            "New York ",
            "North Carolina ",
            "North Dakota ",
            "Ohio ",
            "Oklahoma ",
            "Oregon ",
            "Pennsylvania ",
            "Rhode Island ",
            "South Carolina ",
            "South Dakota ",
            "Tennessee ",
            "Texas ",
            "Utah ",
            "Vermont ",
            "Virginia ",
            "Washington ",
            "West Virginia ",
            "Wisconsin ",
            "Wyoming"});
        }

        public static decimal adjustedGross, amountOfTax, taxWithheld, penalty;
        public static int isSaveData;
        public static string ssn, name;

        private void btbSumbit_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValid())
                {
                    ssn = txtSSN.Text;
                    name = txtTaxpayerName.Text;


                    decimal grossEarning = Convert.ToDecimal(txtGrossEarnings.Text);
                    decimal numExcemption = Convert.ToInt32(txtNumExcemptios.Text);
                    decimal realEstate = Convert.ToDecimal(txtRealEstate.Text);
                    decimal exciseTax = Convert.ToDecimal(txtExcise.Text);
                    decimal medicalExpense = Convert.ToDecimal(txtMedicalExpenses.Text);
                    decimal capitol = Convert.ToDecimal(txtCapitol.Text);


                    adjustedGross =Calculate.CalculateAdjustGross(grossEarning, numExcemption, realEstate,
                                    exciseTax, medicalExpense, capitol);
                    amountOfTax = Convert.ToDecimal(Calculate.calculateAmountOfTax(Convert.ToDouble(adjustedGross)));
                    taxWithheld = Convert.ToDecimal(txtFederalTax.Text);
                    penalty = Convert.ToDecimal(Calculate.calculatedPenalty(Convert.ToDouble(amountOfTax),
                              Convert.ToDouble(taxWithheld)));


                    this.Hide();
                    new frmResult().ShowDialog();
                    this.Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid numeric format. Please check all entries.", "Entry Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Overflow error. Please enter smaller values.", "Entry Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void btbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //------------------------------- VALIDATION METHODS -------------------------------------- //

        private bool isValid()
        {
            return
               // Validate empty field TextBoxes.
               isEmpty(txtTaxpayerName, "Name") && isEmpty(txtAddress, "Address")
                && isEmpty(txtCity, "City") && isEmpty(txtZipCode, "Zip Code")
                && isEmpty(txtSSN, "Social Security Number") && isEmpty(txtNumExcemptios, "Number Of Exemptions")
                && isEmpty(txtGrossEarnings, "Gross Earning") && isEmpty(txtFederalTax, "Tax Withheld")
                && isEmpty(txtCapitol, "Capital Lossess/Gain") && isEmpty(txtRealEstate, "Real Estate Tax")
                && isEmpty(txtExcise, "Excise Tax") && isEmpty(txtMedicalExpenses, "Medical Expenses")


                //Validate integer number.
                && isInt32(txtNumExcemptios, "Number of Exemption") && isInt32(txtSSN, "Social Security Number")
                && isInt32(txtZipCode, "Zip Code")

                //Validate length.
                && isLongEnough(txtSSN, 9) && isLongEnough(txtZipCode, 5);

        }

        private bool isLongEnough(TextBox textBox, int length)
        {
            if (textBox.Text.Length < length)
            {
                MessageBox.Show("Please enter a valid " + length + " digit number.", "Entry Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }
            return true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                isSaveData = 1;
            }
        }

        public bool isEmpty(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool isInt32(TextBox textBox, string name)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be an integer.", "Entry Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }
        }

        public bool isWithRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);

            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between" + min + " and" + max + ".", "Entry Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }
            return true;
        }


    }
}
