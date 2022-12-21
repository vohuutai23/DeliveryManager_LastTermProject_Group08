using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryManager_LastTermProject_Group08
{
    public class OrderDetails
    {
        //fields
        public double dOrderPrice;
        public Order oOrder;
        public Product pProduct;
        public string sIDWarehouse;

        //properties
        public double OrderPrice
        {
            get { return this.dOrderPrice; }
            set { this.dOrderPrice = value; }
        }
        public Order Order
        {
            get { return this.oOrder; }
            set { this.oOrder = value; }
        }
        public Product Product
        {
            get { return this.pProduct; }
            set { this.pProduct = value; }
        }
        public string IDWarehouse
        {
            get { return this.sIDWarehouse; }
            set { this.sIDWarehouse = value; }
        }
        //constructors
        public OrderDetails()
        {

        }
        public OrderDetails(double orderPrice, Order order, Product product, string idWarehouse)
        {
            this.dOrderPrice = orderPrice;
            this.oOrder = order;
            this.pProduct = product;
            this.sIDWarehouse = idWarehouse;
        }
        public OrderDetails(OrderDetails a)
        {
            this.dOrderPrice = a.dOrderPrice;
            this.oOrder = a.oOrder;
            this.pProduct = a.pProduct;
            this.sIDWarehouse = a.sIDWarehouse;
        }
        //destructors
        ~OrderDetails()
        {

        }
    }
}
