using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disturbo_tax
{
   public class Data
    {
        public List<Customer> taxPayerList = null;

        public Data()
        {
            taxPayerList = new List<Customer>();
            createData();
        }

        public List<Customer> getList()
        {
            return taxPayerList;
        }

        private void createData()
        {
            Customer customer1 = new Customer("Alex", "134534765", "$0.00", "$4,898.84");
            Customer customer2 = new Customer("Bob", "367123654", "$0.00", "$3,798.96");
            Customer customer3 = new Customer("John", "233456678", "$9,298.74", "$0.00");
            Customer customer4 = new Customer("Emmy", "132448980", "$0.00", "$1,876.20");
            Customer customer5 = new Customer("Ann", "011231345", "579.43", "$0.00");
            Customer customer6 = new Customer("Rachel", "110098123", "$0.00", "$3,224.84");
            Customer customer7 = new Customer("James", "435231578", "$0.00", "$2,987.96");
            Customer customer8 = new Customer("Tess", "125673241", "$4,900.12", "$0.00");
            Customer customer9 = new Customer("Ruby", "897123214", "$0.00", "$632.56");
            Customer customer10 = new Customer("Vincent", "091232890", "343.12", "$0.00");


            taxPayerList.Add(customer1);
            taxPayerList.Add(customer2);
            taxPayerList.Add(customer3);
            taxPayerList.Add(customer4);
            taxPayerList.Add(customer5);
            taxPayerList.Add(customer6);
            taxPayerList.Add(customer7);
            taxPayerList.Add(customer8);
            taxPayerList.Add(customer9);
            taxPayerList.Add(customer10);

        }
    }
}
