using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryManager_LastTermProject_Group08
{
    public class Order
    {
        //fields
        public string sIDOrder;
        public string sDeliveryAddress;
        public int iAmountofOrder;
        public string sPayment;
        public string sDeliveries;
        public string sOrderDate;

        //properties
        public string IDOrder
        {
            get { return this.sIDOrder; }
            set { this.sIDOrder = value; }
        }

        public string DeliveryAddress
        {
            get { return this.sDeliveryAddress; }
            set { this.sDeliveryAddress = value; }
        }

        public int AmountofOrder
        {
            get { return this.iAmountofOrder; }
            set { this.iAmountofOrder = value; }
        }
        public string Payments
        {
            get { return this.sPayment; }
            set { this.sPayment = value; }
        }
        public string Deliveries
        {
            get { return this.sDeliveries; }
            set { this.sDeliveries = value; }
        }
        public string OrderDate
        {
            get { return this.sOrderDate; }
            set { this.sOrderDate = value; }
        }

        //constructors
        public Order()
        {

        }

        public Order(string idOrder, string deliveryAddress, int amountofOrder, string payments, string deliveries, string orderDate)
        {
            this.sIDOrder = idOrder;
            this.sDeliveryAddress = deliveryAddress;
            this.iAmountofOrder = amountofOrder;
            this.sPayment = payments;
            this.sDeliveries = deliveries;
            this.sOrderDate = orderDate;
        }

        //destructors
        ~Order()
        {

        }

        public void PrintInformOrder()
        {
            Console.WriteLine("The information of Order: ");
            Console.WriteLine("ID of Order: " + this.sIDOrder);
            Console.WriteLine("Delivery Address: " + this.sDeliveryAddress);
            Console.WriteLine("Amount of Order: " + this.iAmountofOrder);
            Console.WriteLine("Paymets: " + this.sPayment);
            Console.WriteLine("Deliveries: " + this.sDeliveries);
            Console.WriteLine("Order Date: " + this.sOrderDate);
        }

        //edit form
        public override string ToString()
        => $"{string.Join(",", sIDOrder)}{string.Join(",", sDeliveryAddress),20}{iAmountofOrder,15}{string.Join(",", sPayment),15}{string.Join(",", sDeliveries),15}{string.Join(",", sOrderDate),15}";
    }
}
