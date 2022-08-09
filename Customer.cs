using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disturbo_tax
{
    public class Customer
    {
        private string name;
        private string ssn;
        private string amountOwed;
        private string amountRefund;

        public Customer()
        {
            this.name = this.ssn = this.amountOwed = this.amountRefund = "";
        }

        public Customer(string name, string ssn, string amountOwed, string amountRefund)
        {
            this.name = name;
            this.ssn = ssn;
            this.amountOwed = amountOwed;
            this.amountRefund = amountRefund;
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string SSN
        {
            set { ssn = value; }
            get { return ssn; }
        }

        public string AmountOwed
        {
            set { amountOwed = value; }
            get { return amountOwed; }
        }

        public string AmountRefund
        {
            set { AmountRefund = value; }
            get { return amountRefund; }
        }
    }
}
