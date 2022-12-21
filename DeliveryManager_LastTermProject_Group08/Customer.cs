using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryManager_LastTermProject_Group08
{
    public class Customer : ISearch
    {
        public string sIDCustomer;
        public string sCustomerName;
        public string sCustomerAddress;
        public string sCustomerPhoneNumber;
        public int demten = 0;
        public string IDCustomer
        {
            get { return this.sIDCustomer; }
            set { this.sIDCustomer = value; }
        }
        public string CustomerName
        {
            get { return this.sCustomerName; }
            set { this.sCustomerName = value; }
        }
        public string CustomerAddress
        {
            get { return this.sCustomerAddress; }
            set { this.sCustomerAddress = value; }
        }
        public string CustomerPhoneNumber
        {
            get { return this.sCustomerPhoneNumber; }
            set { this.sCustomerPhoneNumber = value; }
        }

        public Customer()
        {

        }

        public Customer(string idCustomer, string customerName, string customerAddress, string customerPhoneNumber)
        {
            this.sIDCustomer = idCustomer;
            this.sCustomerName = customerName;
            this.sCustomerAddress = customerAddress;
            this.sCustomerPhoneNumber = customerPhoneNumber;
        }
        ~Customer()
        {

        }

        //edit form
        public override string ToString()
        => $"{string.Join(",", sIDCustomer)}{string.Join(",", sCustomerName),20}{string.Join(",", sCustomerAddress),20}{string.Join(",", sCustomerPhoneNumber),20}";


        //interface
        public void Search(string customerN)
        {

            if (customerN == CustomerName)
            {
                demten++;
                Console.WriteLine("ID Customer:         " + this.sIDCustomer);
                Console.WriteLine("Customer name:       " + this.sCustomerName);
                Console.WriteLine("Customer Address:    " + this.sCustomerAddress);
                Console.WriteLine("Customer PhoneNumber:" + this.sCustomerPhoneNumber);
                Console.WriteLine();
            }
        }
    }
}
