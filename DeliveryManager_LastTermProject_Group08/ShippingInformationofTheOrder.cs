using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryManager_LastTermProject_Group08
{
    public class ShippingInformationofTheOrder
    {
        public string sOrderStatus;
        public Order oOrder;
        public Shipper sShipper;

        public string OrderStatus
        {
            get { return this.sOrderStatus; }
            set { this.sOrderStatus = value; }
        }
        public Order Order
        {
            get { return this.oOrder; }
            set { this.oOrder = value; }
        }
        public Shipper Shipper
        {
            get { return this.sShipper; }
            set { this.sShipper = value; }
        }

        public ShippingInformationofTheOrder()
        {

        }
        public ShippingInformationofTheOrder(string orderStatus, Order order, Shipper shipper)
        {
            this.sOrderStatus = orderStatus;
            this.oOrder = order;
            this.sShipper = shipper;
        }
        ~ShippingInformationofTheOrder()
        {

        }

        public void xuly()
        {
            if (this.sOrderStatus == "delivered")
            {
                this.sShipper.congDonhang();
            }

        }
        public void PrintInform()
        {
            Console.WriteLine("Order Status: " + this.sOrderStatus);
            this.oOrder.PrintInformOrder();
            this.sShipper.PrintInformEmployee();
        }
    }
}
