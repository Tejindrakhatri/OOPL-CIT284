using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace disturbo_tax
{
    public partial class frmResult : Form
    {
        public frmResult()
        {
            InitializeComponent();
        }

      

        private void frmResult_Load(object sender, EventArgs e)
        { 
            txtAdjustedGross.Text = String.Format("{0:c}", frmInfo.adjustedGross);
            txtAmountOfTax.Text = String.Format("{0:c}", frmInfo.amountOfTax);
            txtW2Withheld.Text = String.Format("{0:c}", frmInfo.taxWithheld);
            txtPenalty.Text = String.Format("{0:c}", frmInfo.penalty);

            decimal amountTax = Decimal.Parse(txtAmountOfTax.Text, NumberStyles.Currency);
            decimal w2 = Decimal.Parse(txtW2Withheld.Text, NumberStyles.Currency);

            decimal refund = w2 - amountTax;

            if (refund > 0)
            {
                txtRefund.Text = txtRefund.Text = String.Format("{0:c}", refund);
                txtTaxOwnedGovernment.Text = "$0.00";
            }
            else
            {
                txtRefund.Text = "$0.00";
                txtTaxOwnedGovernment.Text = String.Format("{0:c}",
                    (Math.Abs(refund) + Decimal.Parse(txtPenalty.Text, NumberStyles.Currency)));
            }

            if(frmInfo.isSaveData == 1)
            {
                saveData();
            }
        }

        private void btbOk_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmReport().ShowDialog();
            this.Close();
        }

        private void saveData()
        {
            Customer customer = new Customer(frmInfo.name,
                frmInfo.ssn,
                txtTaxOwnedGovernment.Text,
                txtRefund.Text);

            frmReport.data.getList().Add(customer);
        }
    }
}
