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
    public partial class frmReport : Form
    {
      
        public frmReport()
        {
            InitializeComponent();
          
           
        }

        private DataTable dt = new DataTable();
        public static Data data = new Data();

        private void frmReport_Load(object sender, EventArgs e)
        {

            addColumn();
            addRows();
            tbReports.DataSource = dt;

            // sort the data in ascending order by social security number
            tbReports.Sort(tbReports.Columns[1], ListSortDirection.Ascending); 
         
        }

        private void addColumn()
        {
            
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Social Security Number", typeof(string));
            dt.Columns.Add("Amount Owed", typeof(string));
            dt.Columns.Add("Refunded Amount", typeof(string));
        }

        private void addRows()
        {
            foreach (Customer customer in data.getList())
            {
               dt.Rows.Add(customer.Name, customer.SSN, customer.AmountOwed, customer.AmountRefund);
            }
        }

        
    }
}
