using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryManager_LastTermProject_Group08
{
    public class Product
    {
        //fields
        public string sIDProduct;
        public string sProductName;
        public string sOrigin;
        public double dPrice;
        public double dMass;
        public string sIDStore;

        //properties
        public string IDProduct
        {
            get { return this.sIDProduct; }
            set { this.sIDProduct = value; }
        }

        public string ProductName
        {
            get { return this.sProductName; }
            set { this.sProductName = value; }
        }

        public string Origin
        {
            get { return this.sOrigin; }
            set { this.sOrigin = value; }
        }
        public double Price
        {
            get { return this.dPrice; }
            set { this.dPrice = value; }
        }

        public double Mass
        {
            get { return this.dMass; }
            set { this.dMass = value; }
        }
        public string IDStore
        {
            get { return this.sIDStore; }
            set { this.sIDStore = value; }
        }
        //constructors
        public Product()
        {

        }


        public Product(string idProduct, string productName, string origin, double price, double mass, string idStore)
        {
            this.IDProduct = idProduct;
            this.ProductName = productName;
            this.Origin = origin;
            this.Price = price;
            this.Mass = mass;
            this.IDStore = idStore;
        }

        ~Product()
        {

        }


        //method
        //class Product
        public virtual void ShowCharacteristics()
        {
            Console.WriteLine("Charactertistics of order: ");
        }

        //edit form
        public override string ToString()
        => $"{string.Join(",", sIDProduct)}{string.Join(",", sProductName),20}{string.Join(",", sOrigin),20}{dPrice,20}{dMass,20}{string.Join(",", sIDStore),15}";
    }
}
