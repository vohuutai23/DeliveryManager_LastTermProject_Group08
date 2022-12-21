using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryManager_LastTermProject_Group08
{
    public class ReceiptDetails
    {
        public OrderDetails oOrderDetails;
        public Customer cCustomer;
        public Receipt rReceipt;

        public OrderDetails OrderDetails
        {
            get { return this.oOrderDetails; }
            set { this.oOrderDetails = value; }
        }
        public Customer Customer
        {
            get { return this.cCustomer; }
            set { this.cCustomer = value; }
        }
        public Receipt Receipt
        {
            get { return this.rReceipt; }
            set { this.rReceipt = value; }
        }

        public ReceiptDetails()
        {

        }
        public ReceiptDetails(OrderDetails orderDetails, Customer customer, Receipt receipt)
        {
            this.oOrderDetails = orderDetails;
            this.cCustomer = customer;
            this.rReceipt = receipt;
        }
        ~ReceiptDetails()
        {

        }

        //edit form
        public override string ToString()
          => $"{oOrderDetails}{cCustomer,20}{rReceipt,20}";

    }
}
